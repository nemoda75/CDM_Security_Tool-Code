using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASET
{
    public partial class Setting : MaterialForm
    {
        public Setting()
        {
            InitializeComponent();

            // [1] 매터리얼 디자인 적용
            if (Main.theme_state == "Dark")
            {
                // * 매터리얼 다크 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Dark_Material_Skin(this, null);
            }
            else
            {
                // * 매터리얼 밝은 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Light_Material_Skin(this, null);
            }

            // [2] 폼에 자동으로 데이터를 채움
            this.inspection_title_tbx.Text = "INS_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            try { this.inspector_tbx.Text = SystemInformation.ComputerName; }
            catch { this.inspector_tbx.Enabled = true; }
            this.inspection_date_tbx.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            // [3] 한국어 선택 시 적용
            if (Main.isKoreanMode)
            {
                this.inspection_step_lbl.Text = "점검 설정";
                this.inspection_title_lbl.Text = "점검명";
                this.inspector_lbl.Text = "점검자";
                this.inspection_date_lbl.Text = "점검일자";
                this.db_address_lbl.Text = "DB주소";
                this.db_name_lbl.Text = "포트번호";
                this.db_id_lbl.Text = "유저ID";
                this.db_password_lbl.Text = "비밀번호";
                this.back_btn.Text = "뒤로";
                this.next_btn.Text = "다음";
            }


        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Main main_form = new Main();

            main_form.StartPosition = FormStartPosition.Manual;
            main_form.Location = new Point(this.Location.X, this.Location.Y);
            main_form.Show();
            this.Hide();
        }

        public bool Connection_Check(string database_info)
        {
            CheckForIllegalCrossThreadCalls = false; // 크로스 쓰레드 문제점 해결을 위한 예외처리
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    // DB 커넥션
                    conn.ConnectionString = database_info;
                    conn.Open();

                    // DB 커넥션 종료
                    conn.Close();

                    return true;
                }
            }
            catch { return false; }
        }


        private async void next_btn_Click(object sender, EventArgs e)
        {
            this.loading_pbx.Visible = true;
            this.loading_side_pbx.Visible = true;

            // 다음 폼으로 전달할 정보들
            string database_info = "Data Source=" + db_address_tbx.Text + "," + db_port_tbx.Text +
                ";User Id=" + db_id_tbx.Text + ";Password=" + db_password_tbx.Text;
            string inspection_title = inspection_title_tbx.Text;
            string inspector = inspector_tbx.Text;
            string inspection_date = inspection_date_tbx.Text;


            // 비동기식 처리를 통해 데이터 베이스 연결가능 여부를 점검함
            var connection_check_task = Task.Run(() => Connection_Check(database_info));
            if (!await connection_check_task) // 비동기식 처리가 완료되면
            {
                this.loading_pbx.Visible = false;
                this.loading_pbx.BackColor = Color.Transparent;

                this.loading_side_pbx.Visible = false;

                MessageBox.Show("데이터베이스 정보를 다시 확인하여 주십시오.", "ASET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                connection_check_task.Dispose(); // task를 Dispose하여 메모리를 관리함
                return;
            }
            else
            {
                connection_check_task.Dispose(); // task를 Dispose하여 메모리를 관리함
            }

            this.loading_pbx.Visible = false;
            this.loading_side_pbx.Visible = false;

            // 폼을 띄움
            Inspection inspection_form = new Inspection(inspection_title, inspector, inspection_date, database_info, false, null);
            inspection_form.StartPosition = FormStartPosition.Manual;
            inspection_form.Location = new Point(this.Location.X, this.Location.Y);
            inspection_form.Show();
            this.Hide();
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
