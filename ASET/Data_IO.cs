using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ASET
{
    class Data_IO
    {
        public static void Query_Logging(string id, string risk, string title, string status, string check, string[] check_sql, string fix, string[] fix_sql, string[] check_result, string[] fix_result)
        {
            string myDocument_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 내문서 주소를 가져옴
            string Query_log_file = myDocument_path + @"\OMOP_CDM\Query\" + Inspection.inspection_title + "(" + Inspection.inspection_date.Replace(":", "-") + ")" + @"\" + id + ".json"; // 로그 파일을 만듬


            if (!Directory.Exists(Path.GetDirectoryName(Query_log_file)))
            {
                try { Directory.CreateDirectory(Path.GetDirectoryName(Query_log_file)); }
                catch { return; }
            }

            // 재사용을 위한 파일 삭제
            if (File.Exists(Query_log_file))
            {
                try { File.Delete(Query_log_file); }
                catch { }
            }

            try
            {
                var rules = new Rule()
                {
                    Id = id,
                    Risk = risk,
                    Subject = title,
                    Status = status,
                    Check = check,
                    Check_sql = check_sql,
                    Fix = fix,
                    Fix_sql = fix_sql,
                    Check_result = check_result,
                    Fix_result = fix_result
                };

                var json_format = JsonConvert.SerializeObject(rules);

                File.AppendAllText(Query_log_file, json_format);
            }
            catch { }

        }

        public static void Statistics_Logging(int high_risk_check_count, int high_risk_fix_count, int middle_risk_check_count, int middle_risk_fix_count, int low_risk_check_count, int low_risk_fix_count, string database_info)
        {
            string myDocument_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 내문서 주소를 가져옴
            string log_file = myDocument_path + @"\OMOP_CDM\Log\" + Inspection.inspection_title + "(" + Inspection.inspection_date.Replace(":","-") + ")" +".json"; // 로그 파일을 만듬

            if (!Directory.Exists(Path.GetDirectoryName(log_file)))
            {
                try { Directory.CreateDirectory(Path.GetDirectoryName(log_file)); }
                catch { return; }
            }

            // 재사용을 위한 파일 삭제
            if (File.Exists(log_file))
            {
                try { File.Delete(log_file); }
                catch { }
            }


            // [1] json 파일로 데이터를 저장하는 부분
            var json = new JArray();

            JObject log = new JObject(
                new JProperty("inspection_title", Inspection.inspection_title),
                new JProperty("inspector", Inspection.inspector),
                new JProperty("inspection_date", Inspection.inspection_date),
                new JProperty("change_date", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")),
                new JProperty("high_risk_check_count", high_risk_check_count),
                new JProperty("high_risk_fix_count", high_risk_fix_count),
                new JProperty("middle_risk_check_count", middle_risk_check_count),
                new JProperty("middle_risk_fix_count", middle_risk_fix_count),
                new JProperty("low_risk_check_count", low_risk_check_count),
                new JProperty("low_risk_fix_count", low_risk_fix_count),
                new JProperty("database_info", database_info));

            json.Add(log);
            var json_format = JsonConvert.SerializeObject(json);

            File.AppendAllText(log_file, json_format);
        }

        public static List<String> Query_Request(string query)
        {

            List<String> resposes = new List<String>();

            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    // DB 커넥션
                    conn.ConnectionString = Inspection.database_info;
                    conn.Open();

                    // SQL 쿼리전송

                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int affectedCount = cmd.ExecuteNonQuery();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dtSchemaTable = reader.GetSchemaTable();
                    DataColumn dcData = null;
                    DataRow drData = null;
                    DataTable dtData = new DataTable();

                    if (dtSchemaTable != null)
                    {
                        foreach (DataRow drColumn in dtSchemaTable.Rows)
                        {
                            dcData = new DataColumn(drColumn["ColumnName"].ToString(), (Type)drColumn["DataType"]);
                            dtData.Columns.Add(dcData);
                        }

                        while (reader.Read())
                        {
                            drData = dtData.NewRow();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                drData[i] = reader.GetValue(i);
                            }
                            dtData.Rows.Add(drData);
                        }

                        string response_message = "";
                        for (int i = 0; i < dtData.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtData.Columns.Count; j++)
                            {
                                string key = dtData.Columns[j].ColumnName; 
                                string val = dtData.Rows[i][j].ToString(); 
                                response_message += key + ":" + val + Environment.NewLine;
                            }
                        }

                        resposes.Add(response_message);
                        return resposes;
                    }
                    else
                    {
                        resposes.Add(null);
                        return resposes;
                    }

                }
                catch (Exception ex)
                {
                    string error_message = ex.ToString();
                    resposes.Add(error_message);

                    return resposes;
                }
            }
        }


        public static void Response_Interpret(string id, string[] responses, string index, ListView lvw, List<String> check_qeuries, bool isCheck)
        {
            // [1] 자동 점검에서 실행하였을때의 코드
            if (lvw == null) 
            {
                if (responses == null || responses.Length < 1)
                {
                    string result = index + "///" + "Fix Required" + "///" + "null";
                    check_qeuries.Add(result);
                }
                else
                {
                    foreach (string response in responses)
                    {
                        /* 쿼리별 컨디션 적용
                        string state = "No Fix Required";
                        if (Query_Interpret.Check_Fix_Required(id, Int32.Parse(index), response))
                        {
                            state = "Fix Required";
                        }
                        */
                        string result = index + "///" + "Fix Required" + "///" + response;
                        check_qeuries.Add(result);
                    }
                }
                return;

            }
            // [2] 유저가 개별 룰단위로 실행하는 경우의 코드
            else
            {
                // 이미 처리한 결과(중복)는 제거
                for (int i = 0; i < lvw.Items.Count; i++)
                {
                    ListViewItem item = lvw.Items[i];
                    if (item.SubItems[0].Text.Contains(index))
                    {
                        item.Remove();
                    }
                }

                // 실제 응답을 받아서 화면에 입력
                if (responses == null || responses.Length < 1)
                {
                    if (isCheck)
                    {
                        ListViewItem items = new ListViewItem();
                        items.Text = index;
                        items.SubItems.Add("Fix Required");
                        items.SubItems.Add("null");

                        lvw.Items.Add(items);
                    }
                    else
                    {
                        ListViewItem items = new ListViewItem();
                        items.Text = index;
                        items.SubItems.Add("Fix Complete");
                        items.SubItems.Add("null");

                        lvw.Items.Add(items);
                    }
                }
                else
                {
                    // 데이터가 여러개 리턴되는 경우에 대한 처리
                    foreach (string response in responses)
                    {
                        /* 쿼리별 컨디션 적용
                        string state = "No Fix Required";
                        if (Query_Interpret.Check_Fix_Required(id, Int32.Parse(index), response))
                        {
                            state = "Fix Required";
                        }
                        */
                        if (isCheck)
                        {
                            ListViewItem items = new ListViewItem();
                            items.Text = index;
                            items.SubItems.Add("Fix Required");
                            items.SubItems.Add(response);
                            lvw.Items.Add(items);
                        }
                        else
                        {
                            ListViewItem items = new ListViewItem();
                            items.Text = index;
                            items.SubItems.Add("Fix Complete");
                            items.SubItems.Add(response);
                            lvw.Items.Add(items);
                        }
                    }
                }

                lvw.Sorting = System.Windows.Forms.SortOrder.Ascending; // 리스트뷰 정렬
            }
        }
    }


}
