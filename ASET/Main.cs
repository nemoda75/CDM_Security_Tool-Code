using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ASET
{
    public partial class Main : MaterialForm
    {
        public static string theme_state = "Light";
        public static bool isKoreanMode = true;
        public Main()
        {
            InitializeComponent();

            // [1] 매터리얼 디자인 적용
            if (Main.theme_state == "Dark")
            {
                // * 매터리얼 다크 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Dark_Material_Skin(this, Inspection_history_grv);
                this.dark_theme_radio_btn.Checked = true;
            }
            else
            {
                // * 매터리얼 밝은 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Light_Material_Skin(this, Inspection_history_grv);
                this.light_theme_radio_btn.Checked = true;
            }

            // [1.5] 한글버전 적용
            if (Main.isKoreanMode)
            {
                this.inspection_title.HeaderText = "점검명";
                this.start_date.HeaderText = "시작일";
                this.change_date.HeaderText = "변경일";
                this.inspector.HeaderText = "점검자";
                this.high_risk_fix.HeaderText = "고위험 완료";
                this.middle_risk_fix.HeaderText = "중위험 완료";
                this.low_risk_fix.HeaderText = "저위험 완료";
                this.Edit.HeaderText = "편집";
                this.Delete.HeaderText = "삭제";
                this.Report.HeaderText = "보고서";

                // 외부 아이템
                this.inspection_step_lbl.Text = "점검내역";
                this.dark_theme_radio_btn.Text = "다크 테마";
                this.light_theme_radio_btn.Text = "라이트 테마";
                this.new_Inspection_btn.Text = "신규점검";
                this.close_btn.Text = "종료";

                this.Inspection_history_grv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 13, FontStyle.Bold);
                this.language_toggle.Image = Properties.Resources.switch_on;
            }
            else
            {
                this.inspection_title.HeaderText = "Title";
                this.start_date.HeaderText = "Start Date";
                this.change_date.HeaderText = "Change Date";
                this.inspector.HeaderText = "Inspector";
                this.high_risk_fix.HeaderText = "High Risk";
                this.middle_risk_fix.HeaderText = "Middle Risk";
                this.low_risk_fix.HeaderText = "Low Risk";
                this.Edit.HeaderText = "Edit";
                this.Delete.HeaderText = "Delete";
                this.Report.HeaderText = "Report";

                // 외부 아이템
                this.inspection_step_lbl.Text = "Inspection History";
                this.dark_theme_radio_btn.Text = "Dark Theme";
                this.light_theme_radio_btn.Text = "Light Theme";
                this.new_Inspection_btn.Text = "New Inspection";
                this.close_btn.Text = "Close";

                this.Inspection_history_grv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12, FontStyle.Bold);
                this.language_toggle.Image = Properties.Resources.switch_off;
            }

            // [2] 리소스에서 주요 파일 꺼내기
            string myDocument_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 내문서 주소를 가져옴
            string rule_path = myDocument_path + @"\OMOP_CDM\Rule\";

            if (!Directory.Exists(Path.GetDirectoryName(rule_path))) // 디렉토리가 존재하지 않으면,
            {
                try { Directory.CreateDirectory(Path.GetDirectoryName(rule_path)); }
                catch {}
            }

            string rule_file = rule_path + "rule.json";
            string privacy_file = rule_path + "privacy.json";

            try
            {
                File.WriteAllBytes(rule_file, Properties.Resources.rule);
                File.WriteAllBytes(privacy_file, Properties.Resources.privacy);
            }
            catch { }

        }

        private void new_Inspection_btn_Click(object sender, EventArgs e)
        {
            Setting setting_form = new Setting();
            setting_form.StartPosition = FormStartPosition.Manual;
            setting_form.Location = new Point(this.Location.X, this.Location.Y);
            setting_form.Show();
            this.Hide();
        }


        public bool Read_JSON()
        {
            CheckForIllegalCrossThreadCalls = false; // 크로스 쓰레드 문제점 해결을 위한 예외처리

            string myDocument_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 내문서 주소를 가져옴
            string log_path = myDocument_path + @"\OMOP_CDM\Log\";

            if (!Directory.Exists(Path.GetDirectoryName(log_path))) // 디렉토리가 존재하지 않으면,
            {
                try { Directory.CreateDirectory(Path.GetDirectoryName(log_path)); }
                catch { return true; }
            }

            try
            {
                DirectoryInfo di = new DirectoryInfo(log_path);
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (File.Exists(fi.FullName) && fi.Extension == ".json") // 파일이 존재하는지 확인
                    {
                        var log_byte = File.ReadAllBytes(fi.FullName);
                        string log_string = Encoding.UTF8.GetString(log_byte);

                        var jArray = JArray.Parse(log_string);
                        foreach (JObject item in jArray)
                        {
                            string inspection_title = item.GetValue("inspection_title").ToString();
                            string inspector = item.GetValue("inspector").ToString();
                            string inspection_date = item.GetValue("inspection_date").ToString();
                            string inspection_edit_date = item.GetValue("change_date").ToString();
                            string high_risk_fix_count = item.GetValue("high_risk_fix_count").ToString();
                            string middle_risk_fix_count = item.GetValue("middle_risk_fix_count").ToString();
                            string low_risk_fix_count = item.GetValue("low_risk_fix_count").ToString();
                            string log_keyword = inspection_title + "(" + inspection_date.Replace(":", "-") + ")";
                            string database_info = item.GetValue("database_info").ToString();

                            // 그리드뷰에 표시하기 위한 객체 생성
                            DataGridViewRow row = (DataGridViewRow)this.Inspection_history_grv.Rows[0].Clone();

                            row.Cells[0].Value = inspection_title;
                            row.Cells[1].Value = inspection_date;
                            row.Cells[2].Value = inspection_edit_date;
                            row.Cells[3].Value = inspector;
                            row.Cells[4].Value = high_risk_fix_count;
                            row.Cells[5].Value = middle_risk_fix_count;
                            row.Cells[6].Value = low_risk_fix_count;
                            row.Cells[7].Value = log_keyword;
                            row.Cells[8].Value = database_info;

                            this.Inspection_history_grv.Rows.Add(row); // 그리드뷰에 적용
                        }
                    }
                }
                // 데이터 정렬
                this.Inspection_history_grv.Sort(start_date, ListSortDirection.Descending);

                return true;
            }
            catch { return true; }
        }
        private async void Main_Load(object sender, EventArgs e)
        {
            // 비동기식 처리를 통해 JSON형식으로 저장된 history를 불러옴
            var history_read_task = Task.Run(() => Read_JSON()); 
            if (await history_read_task) // 비동기식 처리가 완료되면,
            {
                history_read_task.Dispose(); // task를 Dispose하여 메모리를 관리함
                this.Inspection_history_grv.AllowUserToAddRows = false;
            }
        }

        private void dark_theme_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            // * 매터리얼 다크 테마 적용
            Materia_Theme theme = new Materia_Theme();
            theme.Apply_Dark_Material_Skin(this, Inspection_history_grv);
            theme_state = "Dark";
    }

        private void light_theme_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            // * 매터리얼 밝은 테마 적용
            Materia_Theme theme = new Materia_Theme();
            theme.Apply_Light_Material_Skin(this, Inspection_history_grv);
            theme_state = "Light";

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string myDocument_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 내문서 주소를 가져옴
            string log_path = myDocument_path + @"\OMOP_CDM\Log\";

            if (MessageBox.Show("정말로 기록을 삭제하시겠습니까?", "Question", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                // [1] 데이터 그리드 뷰에서의 삭제

                Int32 selectedRowCount = this.Inspection_history_grv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        int index = this.Inspection_history_grv.SelectedRows[0].Index;
                        string inspection_title = this.Inspection_history_grv.Rows[index].Cells[0].FormattedValue.ToString();
                        string log_keyword = this.Inspection_history_grv.Rows[index].Cells[6].FormattedValue.ToString();

                        this.Inspection_history_grv.Rows.RemoveAt(index);

                        // 로그 파일 삭제
                        File.Delete(log_path + log_keyword + ".json");

                    }
                }
            } catch { }
        }

        private void Inspection_history_grv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Inspection_history_grv.ClearSelection(); 
                Inspection_history_grv.Rows[e.RowIndex].Selected = true;
            }
        }

        private void Inspection_history_grv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.Edit.Index)
                {
                    // edit
                    Int32 selectedRowCount = this.Inspection_history_grv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount == 1)
                    {
                        int index = this.Inspection_history_grv.SelectedRows[0].Index;

                        string log_keyword = this.Inspection_history_grv.Rows[index].Cells[7].FormattedValue.ToString();
                        string title = this.Inspection_history_grv.Rows[index].Cells[0].FormattedValue.ToString();
                        string inspector = this.Inspection_history_grv.Rows[index].Cells[3].FormattedValue.ToString();
                        string inspection_date = this.Inspection_history_grv.Rows[index].Cells[1].FormattedValue.ToString();
                        string database_info = this.Inspection_history_grv.Rows[index].Cells[8].FormattedValue.ToString();

                        if (String.IsNullOrEmpty(log_keyword)) { return; }

                        Inspection inspection_form = new Inspection(title, inspector, inspection_date, database_info, true, log_keyword);
                        inspection_form.StartPosition = FormStartPosition.Manual;
                        inspection_form.Location = new Point(this.Location.X, this.Location.Y);
                        inspection_form.Show();
                        this.Hide();
                    }

                }
                else if (e.ColumnIndex == this.Delete.Index)
                {
                    // delete
                    string myDocument_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 내문서 주소를 가져옴
                    string log_path = myDocument_path + @"\OMOP_CDM\Log\";

                    try
                    {
                        // [1] 데이터 그리드 뷰에서의 삭제
                        Int32 selectedRowCount = this.Inspection_history_grv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                        if (selectedRowCount > 0)
                        {
                            if (MessageBox.Show("정말로 제거하시겠습니까?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                for (int i = 0; i < selectedRowCount; i++)
                                {
                                    int index = this.Inspection_history_grv.SelectedRows[0].Index;
                                    string inspection_title = this.Inspection_history_grv.Rows[index].Cells[0].FormattedValue.ToString();
                                    string log_keyword = this.Inspection_history_grv.Rows[index].Cells[7].FormattedValue.ToString();

                                    this.Inspection_history_grv.Rows.RemoveAt(index);

                                    // 로그 파일 삭제
                                    File.Delete(log_path + log_keyword + ".json");

                                }
                            }
                        }
                    }
                    catch { }
                }
                else if (e.ColumnIndex == this.Report.Index)
                {
                    // report
                    Int32 selectedRowCount = this.Inspection_history_grv.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount == 1)
                    {
                        int index = this.Inspection_history_grv.SelectedRows[0].Index;

                        string log_keyword = this.Inspection_history_grv.Rows[index].Cells[7].FormattedValue.ToString();
                        string title = this.Inspection_history_grv.Rows[index].Cells[0].FormattedValue.ToString();
                        if (String.IsNullOrEmpty(log_keyword)) { return; }

                        // 룰 관련 폼 호출
                        History history_form = new History(log_keyword, title);
                        history_form.StartPosition = FormStartPosition.Manual;
                        history_form.Location = new Point(this.Location.X, this.Location.Y);
                        history_form.Owner = this;
                        history_form.Show();

                        this.Hide();
                    }
                    else { MessageBox.Show("1개의 항목만 선택하여 주십시오", "ASET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                }
            }
        }


        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 프로그램을 종료하시겠습니까?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void language_toggle_Click(object sender, EventArgs e)
        {
            if (Main.isKoreanMode)
            {
                // 영어 모드
                // 데이터 그리드 뷰 내부
                this.inspection_title.HeaderText = "Title";
                this.start_date.HeaderText = "Start Date";
                this.change_date.HeaderText = "Change Date";
                this.inspector.HeaderText = "Inspector";
                this.high_risk_fix.HeaderText = "High Risk";
                this.middle_risk_fix.HeaderText = "Middle Risk";
                this.low_risk_fix.HeaderText = "Low Risk";
                this.Edit.HeaderText = "Edit";
                this.Delete.HeaderText = "Delete";
                this.Report.HeaderText = "Report";

                // 외부 아이템
                this.inspection_step_lbl.Text = "Inspection History";
                this.dark_theme_radio_btn.Text = "Dark Theme";
                this.light_theme_radio_btn.Text = "Light Theme";
                this.new_Inspection_btn.Text = "New Inspection";
                this.close_btn.Text = "Close";

                this.Inspection_history_grv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 12, FontStyle.Bold);
                this.language_toggle.Image = Properties.Resources.switch_off;
                Main.isKoreanMode = false;
            }
            else
            {
                // 한국어 모드
                // 데이터 그리드 뷰 내부
                this.inspection_title.HeaderText = "점검명";
                this.start_date.HeaderText = "시작일";
                this.change_date.HeaderText = "변경일";
                this.inspector.HeaderText = "점검자";
                this.high_risk_fix.HeaderText = "고위험 완료";
                this.middle_risk_fix.HeaderText = "중위험 완료";
                this.low_risk_fix.HeaderText = "저위험 완료";
                this.Edit.HeaderText = "편집";
                this.Delete.HeaderText = "삭제";
                this.Report.HeaderText = "보고서";

                // 외부 아이템
                this.inspection_step_lbl.Text = "점검내역";
                this.dark_theme_radio_btn.Text = "다크 테마";
                this.light_theme_radio_btn.Text = "라이트 테마";
                this.new_Inspection_btn.Text = "신규점검";
                this.close_btn.Text = "종료";

                this.Inspection_history_grv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 13, FontStyle.Bold);
                this.language_toggle.Image = Properties.Resources.switch_on;
                Main.isKoreanMode = true;
            }
        }
    }
}
