using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace ASET
{
    public partial class Rule_Detail : MaterialForm
    {
        public static string last_status;
        public static int index;
        public static DataGridView dgrv;
        public Rule_Detail(string id, string risk, string title, string status, string check, string[] check_sql, string fix, 
            string[] fix_sql, string[] check_result, string[] fix_result, int p_index, DataGridView p_dgrv)
        {
            InitializeComponent();

            // [1] 매터리얼 디자인 적용
            if (Main.theme_state == "Dark")
            {
                // * 매터리얼 다크 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Dark_Material_Skin(this, null);

                this.title_contents_tbx.BackColor = Color.FromArgb(51, 51, 51);
                this.title_contents_tbx.ForeColor = Color.Snow;

                this.check_method_tbx.BackColor = Color.FromArgb(51, 51, 51);
                this.check_method_tbx.ForeColor = Color.Snow;

                this.fix_method_tbx.BackColor = Color.FromArgb(51, 51, 51);
                this.fix_method_tbx.ForeColor = Color.Snow;

                // 테마 외 아이템에 대한 색상 적용
                this.id_tbx.ForeColor = Color.Snow;
                this.check_knowhow_lbl.ForeColor = Color.Snow;
                this.fix_knowhow_lbl.ForeColor = Color.Snow;
                this.check_lbl.ForeColor = Color.Snow;
                this.check_result_lbl.ForeColor = Color.Snow;
                this.fix_lbl.ForeColor = Color.Snow;
                this.fix_result_lbl.ForeColor = Color.Snow;

            }
            else
            {
                // * 매터리얼 밝은 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Light_Material_Skin(this, null);

                this.title_contents_tbx.BackColor = Color.White;
                this.title_contents_tbx.ForeColor = Color.Black;


                this.check_method_tbx.BackColor = Color.White;
                this.check_method_tbx.ForeColor = Color.Black;

                this.fix_method_tbx.BackColor = Color.White;
                this.fix_method_tbx.ForeColor = Color.Black;
            }

            // [1.5] 한글버전 적용
            if (Main.isKoreanMode)
            {
                this.risk_lbl.Text = "위험도";
                this.status_lbl.Text = "상태";
                this.ready_status_lbl.Text = "미검";
                this.checked_status_lbl.Text = "점검";
                this.fixed_status_lbl.Text = "조치";
                this.na_status_lbl.Text = "예외";

                this.check_knowhow_lbl.Text = "점검방안";
                this.fix_knowhow_lbl.Text = "점검방안";

                this.check_lbl.Text = "자동점검";
                this.check_result_lbl.Text = "점검결과";
                this.fix_lbl.Text = "자동조치";
                this.fix_result_lbl.Text = "조치결과";

                this.back_btn.Text = "뒤로";
                this.save_btn.Text = "저장";
                this.next_btn.Text = "다음";

                this.check_query_edit_btn.Text = "수정";
                this.check_query_execute_btn.Text = "실행";

                this.check_result_upload_btn.Text = "파일첨부";
                this.check_result_upload_btn.Location = new Point(1018, 181);

                this.check_result_edit_btn.Text = "수정";
                this.check_result_delete_btn.Text = "삭제";


                this.fix_query_edit_btn.Text = "수정";
                this.fix_query_execute_btn.Text = "실행";

                this.fix_result_upload_btn.Text = "파일첨부";
                this.fix_result_upload_btn.Location = new Point(1018, 181);

                this.fix_result_edit_btn.Text = "수정";
                this.fix_result_delete_btn.Text = "삭제";


                this.check_knowhow_lbl.Font = new Font("맑은 고딕", 18, FontStyle.Bold);
                this.fix_knowhow_lbl.Font = new Font("맑은 고딕", 18, FontStyle.Bold);

                this.check_lbl.Font = new Font("맑은 고딕", 18, FontStyle.Bold);
                this.check_result_lbl.Font = new Font("맑은 고딕", 18, FontStyle.Bold);

                this.fix_lbl.Font = new Font("맑은 고딕", 18, FontStyle.Bold);
                this.fix_result_lbl.Font = new Font("맑은 고딕", 18, FontStyle.Bold);

                this.checkTab.Font = new Font("맑은 고딕", 18, FontStyle.Bold);
                this.checkTab.Text = "점검";
                this.fixTab.Text = "조치";

            }
            else
            {
                this.check_result_upload_btn.Location = new Point(979, 181);
                this.fix_result_upload_btn.Location = new Point(979, 181);
            }


            // [2] 칼럼 디자인

            this.check_lvw.View = View.Details;
            this.check_lvw.HideSelection = true;
            this.check_lvw.HeaderStyle = ColumnHeaderStyle.None;
            ColumnHeader h = new ColumnHeader();
            h.Width = this.check_lvw.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;
            this.check_lvw.Columns.Add(h);

            this.check_result_lvw.View = View.Details;
            this.check_result_lvw.HideSelection = true;
            this.check_result_lvw.HeaderStyle = ColumnHeaderStyle.None;
            ColumnHeader h2 = new ColumnHeader();
            h2.Width = this.check_result_lvw.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;
            this.check_result_lvw.Columns.Add(h2);

            this.fix_lvw.View = View.Details;
            this.fix_lvw.HideSelection = true;
            this.fix_lvw.HeaderStyle = ColumnHeaderStyle.None;
            ColumnHeader h3 = new ColumnHeader();
            h3.Width = this.fix_lvw.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;
            this.fix_lvw.Columns.Add(h3);

            this.fix_result_lvw.View = View.Details;
            this.fix_result_lvw.HideSelection = true;
            this.fix_result_lvw.HeaderStyle = ColumnHeaderStyle.None;
            ColumnHeader h4 = new ColumnHeader();
            h4.Width = this.fix_result_lvw.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;
            this.fix_result_lvw.Columns.Add(h4);



            // [3] 폼에 데이터를 넣음
            this.id_tbx.Text = id;

            // 위험도 영역
            switch (risk)
            {
                case "H":
                    this.risk_pbx.Image = Properties.Resources.three_star;
                    break;
                case "M":
                    this.risk_pbx.Image = Properties.Resources.two_star;
                    break;
                case "L":
                    this.risk_pbx.Image = Properties.Resources.one_star;
                    break;
            }


            last_status = status;
            this.title_contents_tbx.Text = title;
            this.title_contents_tbx.Font = new Font("Roboto", 12, FontStyle.Bold);
            index = p_index;

            dgrv = p_dgrv; // 데이터 그리드뷰


            this.check_method_tbx.Text = check;
            this.check_method_tbx.Font = new Font("Roboto", 11, FontStyle.Regular);

            this.fix_method_tbx.Text = fix;
            this.fix_method_tbx.Font = new Font("Roboto", 11, FontStyle.Regular);

            int index_counter = 0;
            List<Control> ltControl = new List<Control>();

            // 점검 항목에 데이터를 넣음
            if (check_sql != null)
            {
                index_counter = 0;
                foreach (string sql_query in check_sql)
                {
                    string[] contents = sql_query.Split(new String[] { "///" }, StringSplitOptions.None);

                    if (contents.Length >= 2)
                    {
                        ListViewItem items = new ListViewItem();
                        items.Text = contents[0];
                        items.SubItems.Add(contents[1]);
                        this.check_lvw.Items.Add(items);
                    }
                    else
                    {
                        ListViewItem items = new ListViewItem();
                        items.Text = index_counter.ToString();
                        items.SubItems.Add(sql_query);
                        this.check_lvw.Items.Add(items);
                    }



                    index_counter += 1;
                }
            }

            if (fix_sql != null)
            {
                index_counter = 0;
                foreach (string sql_query in fix_sql)
                {
                    string[] contents = sql_query.Split(new String[] { "///" }, StringSplitOptions.None);

                    if (contents.Length >= 2)
                    {
                        ListViewItem items = new ListViewItem();
                        items.Text = contents[0];
                        items.SubItems.Add(contents[1]);

                        this.fix_lvw.Items.Add(items);
                    }
                    else
                    {
                        ListViewItem items = new ListViewItem();
                        items.Text = index_counter.ToString();
                        items.SubItems.Add(sql_query);

                        this.fix_lvw.Items.Add(items);
                    }

                    index_counter += 1;
                }
            }

            if (check_result != null)
            {
                index_counter = 0;
                foreach (string sql_query in check_result)
                {
                    string[] contents = sql_query.Split(new String[] { "///" }, StringSplitOptions.None);

                    ListViewItem items = new ListViewItem();
                    items.Text = contents[0];
                    items.SubItems.Add(contents[1]);
                    items.SubItems.Add(contents[2]);

                    this.check_result_lvw.Items.Add(items);

                    index_counter += 1;
                }
            }

            if (fix_result != null)
            {
                index_counter = 0;
                foreach (string sql_query in fix_result)
                {
                    string[] contents = sql_query.Split(new String[] { "///" }, StringSplitOptions.None);
                    ListViewItem items = new ListViewItem();
                    items.Text = contents[0];
                    items.SubItems.Add(contents[1]);
                    items.SubItems.Add(contents[2]);

                    this.fix_result_lvw.Items.Add(items);
                    index_counter += 1;
                }
            }

            Status_Check();

        }
        public void Status_Check()
        {
            this.ready_status_lbl.ForeColor = Color.White; ;
            this.checked_status_lbl.ForeColor = Color.DarkGray;
            this.fixed_status_lbl.ForeColor = Color.DarkGray;
            this.na_status_lbl.ForeColor = Color.DarkGray;

            this.ready_status_lbl.BackColor = Color.FromArgb(59, 161, 248);
            this.checked_status_lbl.BackColor = Color.White;
            this.fixed_status_lbl.BackColor = Color.White;
            this.na_status_lbl.BackColor = Color.White;

            if (Main.isKoreanMode)
            {
                this.ready_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                this.checked_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                this.fixed_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                this.na_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
            }
            else
            {
                this.ready_status_lbl.Font = new Font("Roboto", 12, FontStyle.Bold);
                this.checked_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);
                this.fixed_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);
                this.na_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);
            }

            last_status = "Ready";

            if (this.check_lvw.Items.Count == 0 && this.fix_lvw.Items.Count == 0)
            {
                this.ready_status_lbl.ForeColor = Color.DarkGray;
                this.checked_status_lbl.ForeColor = Color.DarkGray;
                this.fixed_status_lbl.ForeColor = Color.DarkGray;
                this.na_status_lbl.ForeColor = Color.White;

                this.ready_status_lbl.BackColor = Color.White;
                this.checked_status_lbl.BackColor = Color.White;
                this.fixed_status_lbl.BackColor = Color.White;
                this.na_status_lbl.BackColor = Color.FromArgb(59, 161, 248);


                if (Main.isKoreanMode)
                {
                    this.ready_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                    this.checked_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                    this.fixed_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                    this.na_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                }
                else
                {
                    this.ready_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);
                    this.checked_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);
                    this.fixed_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);
                    this.na_status_lbl.Font = new Font("Roboto", 12, FontStyle.Bold);
                }

                last_status = "N/A";
            }

            if (this.check_result_lvw.Items.Count > 0)
            {
                this.ready_status_lbl.ForeColor = Color.DarkGray;
                this.checked_status_lbl.ForeColor = Color.White;
                this.fixed_status_lbl.ForeColor = Color.DarkGray;
                this.na_status_lbl.ForeColor = Color.DarkGray;

                this.ready_status_lbl.BackColor = Color.White;
                this.checked_status_lbl.BackColor = Color.FromArgb(59, 161, 248);
                this.fixed_status_lbl.BackColor = Color.White;
                this.na_status_lbl.BackColor = Color.White;

                if (Main.isKoreanMode)
                {
                    this.ready_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                    this.checked_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                    this.fixed_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                    this.na_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                }
                else
                {
                    this.ready_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);
                    this.checked_status_lbl.Font = new Font("Roboto", 12, FontStyle.Bold);
                    this.fixed_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);
                    this.na_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);

                }

                last_status = "Checked";
            }


            if (this.fix_result_lvw.Items.Count > 0)
            {
                this.ready_status_lbl.ForeColor = Color.DarkGray;
                this.checked_status_lbl.ForeColor = Color.DarkGray;
                this.fixed_status_lbl.ForeColor = Color.White;
                this.na_status_lbl.ForeColor = Color.DarkGray;


                this.ready_status_lbl.BackColor = Color.White;
                this.checked_status_lbl.BackColor = Color.White;
                this.fixed_status_lbl.BackColor = Color.FromArgb(59, 161, 248);
                this.na_status_lbl.BackColor = Color.White;

                if (Main.isKoreanMode)
                {
                    this.ready_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                    this.checked_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                    this.fixed_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                    this.na_status_lbl.Font = new Font("Roboto", 13, FontStyle.Bold);
                }
                else
                {
                    this.ready_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);
                    this.checked_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);
                    this.fixed_status_lbl.Font = new Font("Roboto", 12, FontStyle.Bold);
                    this.na_status_lbl.Font = new Font("Roboto", 12, FontStyle.Regular);
                }
                last_status = "Fixed";
            }

        }
        

        private void back_btn_Click(object sender, EventArgs e)
        {
            // 저장하지 않고 나가는 경우의 이벤트
            Inspection parent = (Inspection)this.Owner;
            parent.Opacity = 100.0;

            this.Close();
        }

        public void Call_Edit_Form(ListView lvw, bool need_recommendation)
        {
            if (lvw.FocusedItem == null)
            {
                MessageBox.Show("수정하고자 하는 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string query;
            string state;

            int index = lvw.FocusedItem.Index;

            if (lvw == this.check_lvw || lvw == this.fix_lvw)
            {
                state = null;
                query = lvw.FocusedItem.SubItems[1].Text;
            }
            else
            {
                // result 영역의 조건문

                state = lvw.FocusedItem.SubItems[1].Text;
                query = lvw.FocusedItem.SubItems[2].Text;
            }

            if (state == "File Attached")
            {
                string myDocument_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 내문서 주소를 가져옴
                string file_attached_path = myDocument_path + @"\OMOP_CDM\Attached\" + Inspection.inspection_title + "(" + Inspection.inspection_date.Replace(":", "-") + ")" + @"\";

                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Title = "File Upload";
                dialog.FileName = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // 이전 파일 및 로그 삭제
                    try
                    {
                        if (File.Exists(query))
                        {
                            File.Delete(query);
                        }
                    }
                    catch { }


                    // 리스트뷰에서 제거
                    lvw.Items.RemoveAt(index);


                    // 유저가 파일을 선택한 경우의 이벤트
                    if (File.Exists(dialog.FileName))
                    {
                        string file_name = Path.GetFileName(dialog.FileName);
                        string attached_file_path = file_attached_path + file_name;

                        ListViewItem items = new ListViewItem();
                        items.Text = "+";
                        items.SubItems.Add("File Attached");
                        items.SubItems.Add(attached_file_path);
                        lvw.Items.Add(items);

                        try
                        {
                            File.Copy(dialog.FileName, attached_file_path);
                        }
                        catch { }
                    }
                }
                Status_Check();
                return;
            }

            Edit edit_form = new Edit(query, lvw, index, false, check_result_lvw, need_recommendation);
            edit_form.Owner = this;
            edit_form.ShowDialog(this);
        }

        public void Edit_Query(string query, ListView lvw, int index, bool IsAdd)
        {
            if (IsAdd == true)
            {
                if (!String.IsNullOrEmpty(query))
                {
                    ListViewItem items = new ListViewItem();
                    items.Text = query;
                    lvw.Items.Add(items);
                }
            }
            else
            {
                // result는 세번째 칼럼으로 적용하도록 하는 코드
                if (lvw == this.check_lvw || lvw == this.fix_lvw)
                    lvw.Items[index].SubItems[1].Text = query;
                else
                    lvw.Items[index].SubItems[2].Text = query;
            }
        }

        private void check_query_execute_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 쿼리를 수행할까요?", "Question", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (check_lvw.FocusedItem == null)
            {
                MessageBox.Show("실행하고자 하는 쿼리를 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string rule_id = this.id_tbx.Text;
            string index = check_lvw.FocusedItem.SubItems[0].Text;
            string query = check_lvw.FocusedItem.SubItems[1].Text;
            
            var query_response = Data_IO.Query_Request(query);

            // 돌아온 응답에 대한 처리
            string[] responses = query_response.ToArray();
            Data_IO.Response_Interpret(rule_id, responses, index, this.check_result_lvw, null, true);

            Status_Check();
        }

        private void fix_query_execute_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 쿼리를 수행할까요?", "Question", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (fix_lvw.FocusedItem == null)
            {
                MessageBox.Show("실행하고자 하는 쿼리를 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string rule_id = this.id_tbx.Text;
            string index = fix_lvw.FocusedItem.SubItems[0].Text;
            string query = fix_lvw.FocusedItem.SubItems[1].Text;

            var query_response = Data_IO.Query_Request(query);

            // 돌아온 응답에 대한 처리
            string[] responses = query_response.ToArray();
            Data_IO.Response_Interpret(rule_id, responses, index, this.fix_result_lvw, null, false);

            /*
            string[] responses = query_response.ToArray();

            foreach (string response in responses)
            {
                ListViewItem items = new ListViewItem();

                if (String.IsNullOrEmpty(response))
                {
                    items.Text = "null";
                }
                else
                {
                    items.Text = index;
                    items.SubItems.Add("Fix Complete");
                    items.SubItems.Add(response);
                }
                this.fix_result_lvw.Items.Add(items);
            }
            */
            Status_Check();
        }


        private void check_lvw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Call_Edit_Form(this.check_lvw, false);
        }

        private void fix_lvw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Call_Edit_Form(this.fix_lvw, true);
        }

        private void check_result_lvw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Call_Edit_Form(this.check_result_lvw, false);
        }

        private void fix_result_lvw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Call_Edit_Form(this.fix_result_lvw, false);
        }



        private void save_btn_Click(object sender, EventArgs e)
        {
            string status = last_status;

            List<String> check_qeuries = new List<String>();
            for (int i = 0; i <= this.check_lvw.Items.Count - 1; i++)
            {
                string c_index = this.check_lvw.Items[i].SubItems[0].Text;
                string contents = this.check_lvw.Items[i].SubItems[1].Text;
                check_qeuries.Add(c_index + "///" + contents);

            }
            string[] check_sql = check_qeuries.ToArray();

            List<String> fix_qeuries = new List<String>();
            for (int i = 0; i <= this.fix_lvw.Items.Count - 1; i++)
            {
                string f_index = this.fix_lvw.Items[i].SubItems[0].Text;
                string contents = this.fix_lvw.Items[i].SubItems[1].Text;
                fix_qeuries.Add(f_index + "///" + contents);
            }
            string[] fix_sql = fix_qeuries.ToArray();


            List<String> check_result_qeuries = new List<String>();
            for (int i = 0; i <= this.check_result_lvw.Items.Count - 1; i++)
            {
                string c_index = this.check_result_lvw.Items[i].SubItems[0].Text;
                string state = this.check_result_lvw.Items[i].SubItems[1].Text;
                string contents = this.check_result_lvw.Items[i].SubItems[2].Text;

                check_result_qeuries.Add(c_index + "///" + state + "///" + contents);
            }
            string[] check_result = check_result_qeuries.ToArray();


            List<String> fix_result_qeuries = new List<String>();
            for (int i = 0; i <= this.fix_result_lvw.Items.Count - 1; i++)
            {
                string f_index = this.fix_result_lvw.Items[i].SubItems[0].Text;
                string state = this.fix_result_lvw.Items[i].SubItems[1].Text;
                string contents = this.fix_result_lvw.Items[i].SubItems[2].Text;
                fix_result_qeuries.Add(f_index + "///" + state + "///" + contents);
            }
            string[] fix_result = fix_result_qeuries.ToArray();



            Inspection parent = (Inspection)this.Owner;
            parent.Save_Event(status, index, check_sql, fix_sql, check_result, fix_result);
            parent.Opacity = 100.0;

            this.Close();
        }


        private void Rule_Detail_FormClosing(object sender, FormClosingEventArgs e)
        {
            Inspection parent = (Inspection)this.Owner;
            parent.Opacity = 100.0;

        }


        private void fix_query_edit_btn_Click(object sender, EventArgs e)
        {
            Call_Edit_Form(this.fix_lvw, true);
        }

        private void check_query_edit_btn_Click(object sender, EventArgs e)
        {
            Call_Edit_Form(this.check_lvw, false);
        }

        private void check_result_delete_btn_Click(object sender, EventArgs e)
        {
            if (check_result_lvw.FocusedItem == null)
            {
                MessageBox.Show("삭제하고자 하는 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("정말로 해당 항목을 삭제할까요?", "Question", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (check_result_lvw.SelectedItems.Count > 0)
            {
                int index = check_result_lvw.FocusedItem.Index;

                string fix_query = check_result_lvw.Items[index].SubItems[2].Text;
                try
                {
                    if (File.Exists(fix_query))
                    {
                        File.Delete(fix_query);
                    }
                }
                catch { }

                // 리스트뷰에서 제거
                check_result_lvw.Items.RemoveAt(index);
            }

            Status_Check();
        }

        private void fix_result_delete_btn_Click(object sender, EventArgs e)
        {
            if (fix_result_lvw.FocusedItem == null)
            {
                MessageBox.Show("삭제하고자 하는 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("정말로 해당 항목을 삭제할까요?", "Question", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (fix_result_lvw.SelectedItems.Count > 0)
            {

                int index = fix_result_lvw.FocusedItem.Index;


                string fix_query = fix_result_lvw.Items[index].SubItems[0].Text;
                try
                {
                    if (File.Exists(fix_query))
                    {
                        File.Delete(fix_query);
                    }
                }
                catch { }


                // 리스트뷰에서 제거
                fix_result_lvw.Items.RemoveAt(index);
            }

            Status_Check();
        }

        private void check_result_edit_btn_Click(object sender, EventArgs e)
        {
            Call_Edit_Form(this.check_result_lvw, false);
        }

        private void fix_result_edit_btn_Click(object sender, EventArgs e)
        {
            Call_Edit_Form(this.fix_result_lvw, false);
        }

        public void File_Upload(ListView lvw)
        {
            string myDocument_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 내문서 주소를 가져옴
            string file_attached_path = myDocument_path + @"\OMOP_CDM\Attached\" + Inspection.inspection_title + "(" + Inspection.inspection_date.Replace(":", "-") + ")" + @"\";

            if (!Directory.Exists(Path.GetDirectoryName(file_attached_path))) // 디렉토리가 존재하지 않으면,
            {
                try { Directory.CreateDirectory(Path.GetDirectoryName(file_attached_path)); }
                catch { }
            }


            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "File Upload";
            dialog.FileName = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 유저가 파일을 선택한 경우의 이벤트
                if (File.Exists(dialog.FileName))
                {
                    string file_name = Path.GetFileName(dialog.FileName);
                    string attached_file_path = file_attached_path + file_name;

                    ListViewItem items = new ListViewItem();
                    items.Text = "+";
                    items.SubItems.Add("File Attached");
                    items.SubItems.Add(attached_file_path);
                    lvw.Items.Add(items);

                    try
                    {
                        File.Copy(dialog.FileName, attached_file_path);
                    }
                    catch { }
                }
            }

            Status_Check();
        }

        private void check_result_upload_btn_Click(object sender, EventArgs e)
        {
            File_Upload(check_result_lvw);
        }

        private void fix_result_upload_btn_Click(object sender, EventArgs e)
        {
            File_Upload(fix_result_lvw);
        }

        private void next_btn_Click(object sender, EventArgs e)
        {

            // 인덱스를 하나 넘김
            int next_index = 0;
            next_index += index + 1;

            if (next_index >= dgrv.RowCount)
            {
                MessageBox.Show("마지막 점검 항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 데이터 파싱
            string next_id = dgrv.Rows[next_index].Cells[0].FormattedValue.ToString();
            string next_risk = dgrv.Rows[next_index].Cells[1].FormattedValue.ToString();
            string next_title = dgrv.Rows[next_index].Cells[2].FormattedValue.ToString();
            string next_status = dgrv.Rows[next_index].Cells[3].FormattedValue.ToString();
            string next_check = dgrv.Rows[next_index].Cells[4].FormattedValue.ToString();
            string[] next_check_sql = (string[])dgrv.Rows[next_index].Cells[5].Value;
            string next_fix = dgrv.Rows[next_index].Cells[6].FormattedValue.ToString();
            string[] next_fix_sql = (string[])dgrv.Rows[next_index].Cells[7].Value;
            string[] next_check_result = (string[])dgrv.Rows[next_index].Cells[8].Value;
            string[] next_fix_result = (string[])dgrv.Rows[next_index].Cells[9].Value;


            // [2] 저장하고 종료

            string status = last_status;

            List<String> check_qeuries = new List<String>();
            for (int i = 0; i <= this.check_lvw.Items.Count - 1; i++)
            {
                string c_index = this.check_lvw.Items[i].SubItems[0].Text;
                string contents = this.check_lvw.Items[i].SubItems[1].Text;
                check_qeuries.Add(c_index + "///" + contents);

            }
            string[] check_sql = check_qeuries.ToArray();

            List<String> fix_qeuries = new List<String>();
            for (int i = 0; i <= this.fix_lvw.Items.Count - 1; i++)
            {
                string f_index = this.fix_lvw.Items[i].SubItems[0].Text;
                string contents = this.fix_lvw.Items[i].SubItems[1].Text;
                fix_qeuries.Add(f_index + "///" + contents);
            }
            string[] fix_sql = fix_qeuries.ToArray();


            List<String> check_result_qeuries = new List<String>();
            for (int i = 0; i <= this.check_result_lvw.Items.Count - 1; i++)
            {
                string c_index = this.check_result_lvw.Items[i].SubItems[0].Text;
                string state = this.check_result_lvw.Items[i].SubItems[1].Text;
                string contents = this.check_result_lvw.Items[i].SubItems[2].Text;

                check_result_qeuries.Add(c_index + "///" + state + "///" + contents);
            }
            string[] check_result = check_result_qeuries.ToArray();


            List<String> fix_result_qeuries = new List<String>();
            for (int i = 0; i <= this.fix_result_lvw.Items.Count - 1; i++)
            {
                string f_index = this.fix_result_lvw.Items[i].SubItems[0].Text;
                string state = this.fix_result_lvw.Items[i].SubItems[1].Text;
                string contents = this.fix_result_lvw.Items[i].SubItems[2].Text;
                fix_result_qeuries.Add(f_index + "///" + state + "///" + contents);
            }
            string[] fix_result = fix_result_qeuries.ToArray();


            Inspection parent = (Inspection)this.Owner;
            parent.Save_Event(status, index, check_sql, fix_sql, check_result, fix_result);

            this.Close();

            parent.Next_Event(next_id, next_risk, next_title, next_status, next_check, next_check_sql, next_fix, next_fix_sql, next_check_result, next_fix_result, next_index, dgrv);


        }
    }
}
