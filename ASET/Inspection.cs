using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASET
{
    public partial class Inspection : MaterialForm
    {
        // 전역변수 선언
        public static string inspection_title;
        public static string inspector;
        public static string inspection_date;
        public static string database_info;
        public static bool is_edit;
        public static bool is_AutoRunning;

        public Inspection(string p_inspection_title, string p_inspector, string p_inspection_date, string p_database_info, bool p_is_edit, string log_keyword)
        {
            InitializeComponent();

            // [1] 매터리얼 디자인 적용
            if (Main.theme_state == "Dark")
            {
                // * 매터리얼 다크 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Dark_Material_Skin(this, total_rule_grv);
            }
            else
            {
                // * 매터리얼 밝은 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Light_Material_Skin(this, total_rule_grv);
            }

            // [1.5] 한국어 모드 적용

            if (Main.isKoreanMode)
            {
                this.inspection_step_lbl.Text = "점검항목";
                this.id.HeaderText = "점검번호";
                this.risk.HeaderText = "위험도";
                this.title.HeaderText = "제목";
                this.Ready.HeaderText = "미검";
                this.Checked.HeaderText = "점검";
                this.Fixed.HeaderText = "조치";
                this.NA.HeaderText = "제외";
                this.Edit.HeaderText = "편집";
                this.auto_btn.Text = "자동점검";
                this.fin_btn.Text = "다음";
                this.back_btn.Text = "뒤로";
            }




            // [2] 데이터 그리드 뷰에 데이터를 불러옴
            string myDocument_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 내문서 주소를 가져옴
            string rule_file = myDocument_path + @"\OMOP_CDM\Rule\rule.json";
            string privacy_file = myDocument_path + @"\OMOP_CDM\Rule\privacy.json";
            is_edit = p_is_edit;

            if (!is_edit) // 초기 점검시에는 기본룰 json을 불러옴
            {
                Read_JSON(rule_file);
                Read_JSON(privacy_file);
                this.total_rule_grv.AllowUserToAddRows = false;
            }
            else
            {
                string Query_log_path = myDocument_path + @"\OMOP_CDM\Query\" + log_keyword; // 로그 파일을 만듬

                if (Directory.Exists(Query_log_path))
                {
                    DirectoryInfo di = new DirectoryInfo(Query_log_path);

                    foreach (FileInfo fi in di.GetFiles())
                    {
                        if (File.Exists(fi.FullName) && fi.Extension == ".json") // 파일이 존재하는지 확인
                        {
                            var json = File.ReadAllText(fi.FullName);
                            Rule rule = JsonConvert.DeserializeObject<Rule>(json);

                            // JSON 파싱
                            string id = rule.Id;
                            string risk = rule.Risk;
                            string subject = rule.Subject;
                            string status = rule.Status;
                            string check = rule.Check;
                            string[] check_sql = rule.Check_sql;
                            string fix = rule.Fix;
                            string[] fix_sql = rule.Fix_sql;
                            string[] check_result = rule.Check_result;
                            string[] fix_result = rule.Fix_result;

                            // 그리드뷰에 표시하기 위한 객체 생성
                            DataGridViewRow row = (DataGridViewRow)this.total_rule_grv.Rows[0].Clone();

                            row.Cells[0].Value = id;
                            row.Cells[1].Value = risk;
                            row.Cells[2].Value = subject;
                            row.Cells[3].Value = status;
                            row.Cells[4].Value = check;
                            row.Cells[5].Value = check_sql;
                            row.Cells[6].Value = fix;
                            row.Cells[7].Value = fix_sql;
                            row.Cells[8].Value = check_result;
                            row.Cells[9].Value = fix_result;

                            if (status == "Ready")
                            {
                                if (Main.theme_state == "Dark")
                                {
                                    row.Cells[10].Style.BackColor = Color.LightGray;
                                    row.Cells[11].Style.BackColor = Color.White;
                                    row.Cells[12].Style.BackColor = Color.White;
                                    row.Cells[13].Style.BackColor = Color.White;

                                }
                                else
                                {
                                    row.Cells[10].Style.BackColor = Color.FromArgb(189, 226, 255);
                                    row.Cells[11].Style.BackColor = Color.White;
                                    row.Cells[12].Style.BackColor = Color.White;
                                    row.Cells[13].Style.BackColor = Color.White;
                                }
                            }
                            else if (status == "Checked")
                            {
                                if (Main.theme_state == "Dark")
                                {
                                    row.Cells[10].Style.BackColor = Color.White;
                                    row.Cells[11].Style.BackColor = Color.LightGray;
                                    row.Cells[12].Style.BackColor = Color.White;
                                    row.Cells[13].Style.BackColor = Color.White;
                                }
                                else
                                {
                                    row.Cells[10].Style.BackColor = Color.White;
                                    row.Cells[11].Style.BackColor = Color.FromArgb(189, 226, 255);
                                    row.Cells[12].Style.BackColor = Color.White;
                                    row.Cells[13].Style.BackColor = Color.White;
                                }
                            }
                            else if (status == "Fixed")
                            {
                                if (Main.theme_state == "Dark")
                                {
                                    row.Cells[10].Style.BackColor = Color.White;
                                    row.Cells[11].Style.BackColor = Color.White;
                                    row.Cells[12].Style.BackColor = Color.LightGray;
                                    row.Cells[13].Style.BackColor = Color.White;
                                }
                                else
                                {
                                    row.Cells[10].Style.BackColor = Color.White;
                                    row.Cells[11].Style.BackColor = Color.White;
                                    row.Cells[12].Style.BackColor = Color.FromArgb(189, 226, 255);
                                    row.Cells[13].Style.BackColor = Color.White;
                                }
                            }
                            else if (status == "N/A")
                            {
                                if (Main.theme_state == "Dark")
                                {
                                    row.Cells[10].Style.BackColor = Color.White;
                                    row.Cells[11].Style.BackColor = Color.White;
                                    row.Cells[12].Style.BackColor = Color.White;
                                    row.Cells[13].Style.BackColor = Color.LightGray;
                                }
                                else
                                {
                                    row.Cells[10].Style.BackColor = Color.White;
                                    row.Cells[11].Style.BackColor = Color.White;
                                    row.Cells[12].Style.BackColor = Color.White;
                                    row.Cells[13].Style.BackColor = Color.FromArgb(189, 226, 255);
                                }
                            }
                            this.total_rule_grv.Rows.Add(row); // 그리드뷰에 적용
                        }
                    }
                    this.total_rule_grv.AllowUserToAddRows = false;
                }
            }
                       
            // [3] 이전 폼으로부터 전달된 데이터를 사용함
            inspection_title = p_inspection_title;
            inspector = p_inspector;
            inspection_date = p_inspection_date;
            database_info = p_database_info;
            this.inspection_pgb.Maximum = this.total_rule_grv.Rows.Count - 1;
        }

        public void Read_JSON(string json_file)
        {
            Rule[] rules;

            string json_string = File.ReadAllText(json_file);

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json_string)))
            {
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(Rule[]));
                rules = (Rule[])deserializer.ReadObject(ms);
            }

            foreach (Rule rule in rules)
            {
                // JSON 파싱
                string id = rule.Id;
                string risk = rule.Risk;
                string subject = rule.Subject;
                string check = rule.Check;
                string[] check_sql = rule.Check_sql;
                string fix = rule.Fix;
                string[] fix_sql = rule.Fix_sql;

                // 그리드뷰에 표시하기 위한 객체 생성
                DataGridViewRow row = (DataGridViewRow)this.total_rule_grv.Rows[0].Clone();

                row.Cells[0].Value = id;
                row.Cells[1].Value = risk;
                row.Cells[2].Value = subject;
                row.Cells[3].Value = "Ready";
                row.Cells[4].Value = check;
                row.Cells[5].Value = check_sql;
                row.Cells[6].Value = fix;
                row.Cells[7].Value = fix_sql;
                if (Main.theme_state == "Dark")
                {
                    row.Cells[10].Style.BackColor = Color.LightGray;
                }
                else
                {
                    row.Cells[10].Style.BackColor = Color.FromArgb(189, 226, 255);
                }

                this.total_rule_grv.Rows.Add(row); // 그리드뷰에 적용
            }
        }

        public void Auto_Save()
        {
            int index;
            for (index = 0; index < this.total_rule_grv.Rows.Count; index++)
            {
                try
                {
                    // 자동저장 기능을 위해 데이터 파싱
                    string id = this.total_rule_grv.Rows[index].Cells[0].FormattedValue.ToString();
                    string risk = this.total_rule_grv.Rows[index].Cells[1].FormattedValue.ToString();
                    string title = this.total_rule_grv.Rows[index].Cells[2].FormattedValue.ToString();
                    string status = this.total_rule_grv.Rows[index].Cells[3].FormattedValue.ToString();
                    string check = this.total_rule_grv.Rows[index].Cells[4].FormattedValue.ToString();
                    var check_sql = (string[])this.total_rule_grv.Rows[index].Cells[5].Value;
                    string fix = this.total_rule_grv.Rows[index].Cells[6].FormattedValue.ToString();
                    var fix_sql = (string[])this.total_rule_grv.Rows[index].Cells[7].Value;
                    var check_result = (string[])this.total_rule_grv.Rows[index].Cells[8].Value;
                    var fix_result = (string[])this.total_rule_grv.Rows[index].Cells[9].Value;

                    Data_IO.Query_Logging(id, risk, title, status, check, check_sql, fix, fix_sql, check_result, fix_result); // 쿼리 진행사항 자동저장
                }
                catch { continue; }
            }
            Save_Inspection_Profile(); // 점검 프로필 자동저장
        }


        public bool Auto_Inspection()
        {
            CheckForIllegalCrossThreadCalls = false; // 크로스 쓰레드 문제점 해결을 위한 예외처리


            // 데이터 그리드뷰 정렬기능 끄기
            foreach (DataGridViewColumn i in this.total_rule_grv.Columns)
            {
                i.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            int index; // 순차적으로 점검하기 위한 인덱스 변수

            int counter = 0;
            for (index = 0; index < this.total_rule_grv.Rows.Count; index++)
            {
                if (this.total_rule_grv.Rows[index].Cells[3].Value.ToString() == "Ready")
                {
                    if (this.total_rule_grv.Rows[index].Cells[5].Value != null)
                    {
                        var sql_object = this.total_rule_grv.Rows[index].Cells[5].Value;
                        string[] queries = (string[])sql_object;
                        string rule_id = this.total_rule_grv.Rows[index].Cells[0].FormattedValue.ToString();

                        List<String> check_qeuries = new List<String>();

                        counter = 0;
                        foreach (string query in queries)
                        {
                            var query_response = Data_IO.Query_Request(query);

                            string[] responses = query_response.ToArray();
                            Data_IO.Response_Interpret(rule_id, responses, counter.ToString(), null, check_qeuries, true);

                            counter += 1;
                        }

                        string[] check_sql_array = check_qeuries.ToArray();

                        if (check_sql_array.Length != 0) // null이 아닌 응답만 자동 점검으로 표시
                        {
                            this.total_rule_grv.Rows[index].Cells[3].Value = "Checked";
                            this.total_rule_grv.Rows[index].Cells[8].Value = check_sql_array;

                            if (Main.theme_state == "Dark")
                            {
                                this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.White;
                                this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.LightGray;
                                this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.White;
                                this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.White;
                            }
                            else
                            {
                                this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.White;
                                this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.FromArgb(189, 226, 255);
                                this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.White;
                                this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.White;
                            }
                        }
                    }
                    else
                    {
                        if (this.total_rule_grv.Rows[index].Cells[7].Value == null)
                        {
                            this.total_rule_grv.Rows[index].Cells[3].Value = "N/A";

                            if (Main.theme_state == "Dark")
                            {
                                this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.White;
                                this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.White;
                                this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.White;
                                this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.LightGray;
                            }
                            else
                            {
                                this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.White;
                                this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.White;
                                this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.White;
                                this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.FromArgb(189, 226, 255);
                            }
                        }
                    }
                }

                // 자동저장 기능

                string id = this.total_rule_grv.Rows[index].Cells[0].FormattedValue.ToString();
                string risk = this.total_rule_grv.Rows[index].Cells[1].FormattedValue.ToString();
                string title = this.total_rule_grv.Rows[index].Cells[2].FormattedValue.ToString();
                string status = this.total_rule_grv.Rows[index].Cells[3].FormattedValue.ToString();
                string check = this.total_rule_grv.Rows[index].Cells[4].FormattedValue.ToString();
                var check_sql = (string[])this.total_rule_grv.Rows[index].Cells[5].Value;
                string fix = this.total_rule_grv.Rows[index].Cells[6].FormattedValue.ToString();
                var fix_sql = (string[])this.total_rule_grv.Rows[index].Cells[7].Value;
                var check_result = (string[])this.total_rule_grv.Rows[index].Cells[8].Value;
                var fix_result = (string[])this.total_rule_grv.Rows[index].Cells[9].Value;

                Data_IO.Query_Logging(id, risk, title, status, check, check_sql, fix, fix_sql, check_result, fix_result); // 쿼리 진행사항 자동저장
                Save_Inspection_Profile(); // 점검 프로필 자동저장

                // 진행사항 진행
                this.inspection_pgb.Increment(1);

            }

            MessageBox.Show("점검이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fin_btn.Enabled = true; // 점검완료에 따른 완료 버튼 활성화
            return true;

        }

        private async void auto_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("정말로 자동점검을 수행할까요?", "Question", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // 버튼 비활성화
            this.loading_pbx.Visible = true;
            this.auto_btn.Enabled = false;
            this.fin_btn.Enabled = false;
            this.back_btn.Enabled = false;
            this.fin_btn.Enabled = false;
            is_AutoRunning = true;

            var auto_task = Task.Run(() => Auto_Inspection());
            if (await auto_task)
            {
                auto_task.Dispose();

                // 버튼 활성화
                this.loading_pbx.Visible = false;
                this.fin_btn.Enabled = true;
                this.auto_btn.Enabled = true;
                this.back_btn.Enabled = true;
                this.fin_btn.Enabled = true;
                is_AutoRunning = false;

                // 데이터그리드뷰 정렬기능 켜기
                foreach (DataGridViewColumn i in this.total_rule_grv.Columns)
                {
                    i.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
        }
        public void Next_Event(string next_id, string next_risk, string next_title, string next_status, string next_check, string[] next_check_sql, 
            string next_fix, string[] next_fix_sql, string[] next_check_result, string[] next_fix_result, int next_index, DataGridView dgrv)
        {
            if (String.IsNullOrEmpty(next_id)) { return; }

            // 룰 관련 폼 호출
            Rule_Detail rule_form = new Rule_Detail(next_id, next_risk, next_title, next_status, next_check, next_check_sql, next_fix, next_fix_sql, next_check_result, next_fix_result, next_index, total_rule_grv);
            rule_form.StartPosition = FormStartPosition.Manual;
            rule_form.Location = new Point(this.Location.X, this.Location.Y);
            rule_form.Owner = this;

            this.Opacity = 0.0;
            rule_form.Show();
        }

        public void Save_Event(string status, int index, string[] check_sql, string[] fix_sql, string[] check_result, string[] fix_result)
        {
            // status 갱선
            this.total_rule_grv.Rows[index].Cells[3].Value = status;
            this.total_rule_grv.Rows[index].Cells[5].Value = check_sql;
            this.total_rule_grv.Rows[index].Cells[7].Value = fix_sql;
            this.total_rule_grv.Rows[index].Cells[8].Value = check_result;
            this.total_rule_grv.Rows[index].Cells[9].Value = fix_result;

            if (status == "Ready")
            {
                if (Main.theme_state == "Dark")
                {
                    this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.LightGray;
                    this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.White;

                }
                else
                {
                    this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.FromArgb(189, 226, 255);
                    this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.White;
                }
            }
            else if (status == "Checked")
            {
                if (Main.theme_state == "Dark")
                {
                    this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.LightGray;
                    this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.White;
                }
                else
                {
                    this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.FromArgb(189, 226, 255);
                    this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.White;
                }
            }
            else if (status == "Fixed")
            {
                if (Main.theme_state == "Dark")
                {
                    this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.LightGray;
                    this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.White;
                }
                else
                {
                    this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.FromArgb(189, 226, 255);
                    this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.White;
                }
            }
            else if (status == "N/A")
            {
                if (Main.theme_state == "Dark")
                {
                    this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.LightGray;
                }
                else
                {
                    this.total_rule_grv.Rows[index].Cells[10].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[11].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[12].Style.BackColor = Color.White;
                    this.total_rule_grv.Rows[index].Cells[13].Style.BackColor = Color.FromArgb(189, 226, 255);
                }
            }

            string id = this.total_rule_grv.Rows[index].Cells[0].FormattedValue.ToString();
            string risk = this.total_rule_grv.Rows[index].Cells[1].FormattedValue.ToString();
            string title = this.total_rule_grv.Rows[index].Cells[2].FormattedValue.ToString();
            string check = this.total_rule_grv.Rows[index].Cells[4].FormattedValue.ToString();
            string fix = this.total_rule_grv.Rows[index].Cells[6].FormattedValue.ToString();


            Data_IO.Query_Logging(id, risk, title, status, check, check_sql, fix, fix_sql, check_result, fix_result); // 쿼리 진행사항 자동저장
            Save_Inspection_Profile(); // 점검 프로필 자동저장
        }

        public void Save_Inspection_Profile()
        {
            // 통계를 내기위한 변수
            int high_risk_check_count = 0;
            int high_risk_fix_count = 0;

            int middle_risk_check_count = 0;
            int middle_risk_fix_count = 0;

            int low_risk_check_count = 0;
            int low_risk_fix_count = 0;

            // 순차적으로 점검
            for (int index = 0; index < this.total_rule_grv.Rows.Count; index++)
            {
                string id = this.total_rule_grv.Rows[index].Cells[0].FormattedValue.ToString();
                string risk = this.total_rule_grv.Rows[index].Cells[1].FormattedValue.ToString();
                string title = this.total_rule_grv.Rows[index].Cells[2].FormattedValue.ToString();
                string status = this.total_rule_grv.Rows[index].Cells[3].FormattedValue.ToString();
                string check = this.total_rule_grv.Rows[index].Cells[4].FormattedValue.ToString();
                string[] check_sql = (string[])this.total_rule_grv.Rows[index].Cells[5].Value;
                string fix = this.total_rule_grv.Rows[index].Cells[6].FormattedValue.ToString();
                string[] fix_sql = (string[])this.total_rule_grv.Rows[index].Cells[7].Value;
                string[] check_result = (string[])this.total_rule_grv.Rows[index].Cells[8].Value;
                string[] fix_result = (string[])this.total_rule_grv.Rows[index].Cells[9].Value;

                switch (risk)
                {
                    case "H":
                        switch (status)
                        {
                            case "Checked":
                                high_risk_check_count += 1;
                                break;
                            case "Fixed":
                                high_risk_fix_count += 1;
                                break;
                        }
                        break;
                    case "M":
                        switch (status)
                        {
                            case "Checked":
                                middle_risk_check_count += 1;
                                break;
                            case "Fixed":
                                middle_risk_fix_count += 1;
                                break;
                        }
                        break;
                    case "L":
                        switch (status)
                        {
                            case "Checked":
                                low_risk_check_count += 1;
                                break;
                            case "Fixed":
                                low_risk_fix_count += 1;
                                break;
                        }
                        break;
                }
            }
            Data_IO.Statistics_Logging(high_risk_check_count, high_risk_fix_count, middle_risk_check_count, middle_risk_fix_count, low_risk_check_count, low_risk_fix_count, database_info);
        }

        private void fin_btn_Click(object sender, EventArgs e)
        {
            Auto_Save(); // 자동저장 진행

            int firstIndex = 0;
            // 데이터를 가져옴
            string id = this.total_rule_grv.Rows[firstIndex].Cells[0].FormattedValue.ToString();
            string risk = this.total_rule_grv.Rows[firstIndex].Cells[1].FormattedValue.ToString();
            string title = this.total_rule_grv.Rows[firstIndex].Cells[2].FormattedValue.ToString();
            string status = this.total_rule_grv.Rows[firstIndex].Cells[3].FormattedValue.ToString();
            string check = this.total_rule_grv.Rows[firstIndex].Cells[4].FormattedValue.ToString();
            string[] check_sql = (string[])this.total_rule_grv.Rows[firstIndex].Cells[5].Value;
            string fix = this.total_rule_grv.Rows[firstIndex].Cells[6].FormattedValue.ToString();
            string[] fix_sql = (string[])this.total_rule_grv.Rows[firstIndex].Cells[7].Value;
            string[] check_result = (string[])this.total_rule_grv.Rows[firstIndex].Cells[8].Value;
            string[] fix_result = (string[])this.total_rule_grv.Rows[firstIndex].Cells[9].Value;

            if (String.IsNullOrEmpty(id)) { return; }

            // 룰 관련 폼 호출
            Rule_Detail rule_form = new Rule_Detail(id, risk, title, status, check, check_sql, fix, fix_sql, check_result, fix_result, firstIndex, total_rule_grv);
            rule_form.StartPosition = FormStartPosition.Manual;
            rule_form.Location = new Point(this.Location.X, this.Location.Y);
            rule_form.Owner = this;
            this.Opacity = 0.0;
            rule_form.Show();
        }

        private void Inspection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Auto_Save(); // 자동저장 진행
            Application.Exit();
        }

        private void total_rule_grv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.Edit.Index)
                {
                    if (is_AutoRunning)
                    {
                        MessageBox.Show("자동점검이 진행중이므로 잠시만 기다려주시기 바랍니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // edit
                    string id = this.total_rule_grv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    string risk = this.total_rule_grv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    string title = this.total_rule_grv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    string status = this.total_rule_grv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    string check = this.total_rule_grv.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    string[] check_sql = (string[])this.total_rule_grv.Rows[e.RowIndex].Cells[5].Value;
                    string fix = this.total_rule_grv.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    string[] fix_sql = (string[])this.total_rule_grv.Rows[e.RowIndex].Cells[7].Value;
                    string[] check_result = (string[])this.total_rule_grv.Rows[e.RowIndex].Cells[8].Value;
                    string[] fix_result = (string[])this.total_rule_grv.Rows[e.RowIndex].Cells[9].Value;
                    int index = e.RowIndex;

                    if (String.IsNullOrEmpty(id)) { return; }

                    // 룰 관련 폼 호출
                    Rule_Detail rule_form = new Rule_Detail(id, risk, title, status, check, check_sql, fix, fix_sql, check_result, fix_result, index, total_rule_grv);
                    rule_form.StartPosition = FormStartPosition.Manual;
                    rule_form.Location = new Point(this.Location.X, this.Location.Y);
                    rule_form.Owner = this;
                    this.Opacity = 0.0;
                    rule_form.Show();
                }
                else
                {
                    total_rule_grv.ClearSelection();
                }
            }
        }

        private void total_rule_grv_SelectionChanged(object sender, EventArgs e)
        {
            this.total_rule_grv.ClearSelection();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (is_edit)
            {
                Main main_form = new Main();

                main_form.StartPosition = FormStartPosition.Manual;
                main_form.Location = new Point(this.Location.X, this.Location.Y);
                main_form.Show();
                this.Hide();
            }
            else
            {
                Setting setting_form = new Setting();
                setting_form.StartPosition = FormStartPosition.Manual;
                setting_form.Location = new Point(this.Location.X, this.Location.Y);
                setting_form.Show();
                this.Hide();
            }
        }
    }


    public class Rule
    {
        public string Id { get; set; }
        public string Risk { get; set; }
        public string Subject { get; set; }
        public string Status { get; set; }
        public string Check { get; set; }
        public string[] Check_sql { get; set; }
        public string Fix { get; set; }
        public string[] Fix_sql { get; set; }
        public string[] Check_result { get; set; }
        public string[] Fix_result { get; set; }
    }
}
