using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace ASET
{
    public partial class History : MaterialForm
    {
        public static string log_keyword;
        public static string history_title;
        public History(string p_log_keyword, string p_title)
        {
            InitializeComponent();

            // [1] 매터리얼 디자인 적용
            if (Main.theme_state == "Dark")
            {
                // * 매터리얼 다크 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Dark_Material_Skin(this, this.history_grv);

                this.report_lbl.BackColor = Color.FromArgb(51, 51, 51);
                this.report_lbl.ForeColor = Color.Snow;

                this.title_tbx.BackColor = Color.FromArgb(51, 51, 51);
                this.title_tbx.ForeColor = Color.Snow;
            }
            else
            {
                // * 매터리얼 밝은 테마 적용
                Materia_Theme theme = new Materia_Theme();
                theme.Apply_Light_Material_Skin(this, this.history_grv);
            }

            // [1.5] 한국어 적용
            if (Main.isKoreanMode)
            {
                this.report_lbl.Text = "보고서";
                title_tbx.Location = new Point(120, 103);

                this.id.HeaderText = "점검번호";
                this.risk.HeaderText = "위험도";
                this.title.HeaderText = "제목";
                this.status.HeaderText = "상태";

                this.back_btn.Text = "뒤로";


                this.save_figure_csv_btn.Text = "보고서 출력(CSV)";
                this.save_figure_csv_btn.Location = new Point(536, 642);

                this.save_rowdata_csv_btn.Text = "로우 데이터 출력(CSV)";
                this.save_rowdata_csv_btn.Location = new Point(708, 642);

                this.save_figure_btn.Text = "보고서 출력(엑셀)";
                this.save_figure_btn.Location = new Point(944, 642);

                this.save_rowdata_btn.Text = "로우 데이터 출력(엑셀)";
                this.save_rowdata_btn.Location = new Point(1120, 642);
            }

            // [2] 이전폼으로부터 데이터를 받아옴
            log_keyword = p_log_keyword;
            history_title = p_title;

            // [3] 데이터를 화면에 표시
            this.title_tbx.Text = "(" + history_title + ")";
        }

        public bool Read_JSON()
        {
            CheckForIllegalCrossThreadCalls = false; // 크로스 쓰레드 문제점 해결을 위한 예외처리

            string myDocument_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // 내문서 주소를 가져옴
            string log_path = myDocument_path + @"\OMOP_CDM\Query\" + log_keyword;

            DirectoryInfo di = new DirectoryInfo(log_path);

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
                    string check_sql = (rule.Check_sql == null ? null : string.Join("\n\n", rule.Check_sql));
                    string fix = rule.Fix;
                    string fix_sql = (rule.Fix_sql == null ? null : string.Join("\n\n", rule.Fix_sql));
                    string check_result = (rule.Check_result == null ? null : string.Join("\n\n", rule.Check_result));
                    string fix_result = (rule.Fix_result == null ? null : string.Join("\n\n", rule.Fix_result));

                    // 그리드뷰에 표시하기 위한 객체 생성
                    DataGridViewRow row = (DataGridViewRow)this.history_grv.Rows[0].Clone();

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

                    this.history_grv.Rows.Add(row); // 그리드뷰에 적용

                }
            }
            return true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Main main_form = new Main();

            main_form.StartPosition = FormStartPosition.Manual;
            main_form.Location = new Point(this.Location.X, this.Location.Y);
            main_form.Show();
            this.Hide();
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void History_Load(object sender, EventArgs e)
        {
            Read_JSON(); // 제이슨 정보를 불러옴

            // 통계를 만듬
            int total_count = this.history_grv.RowCount;
            int ready_count = 0;
            int checked_count = 0;
            int fixed_count = 0;
            int na_count = 0;


            // 위협별 통계를 내기위한 변수
            int high_risk_ready_count = 0;
            int high_risk_check_count = 0;
            int high_risk_fix_count = 0;
            int high_risk_na_count = 0;

            int middle_risk_ready_count = 0;
            int middle_risk_check_count = 0;
            int middle_risk_fix_count = 0;
            int middle_risk_na_count = 0;

            int low_risk_ready_count = 0;
            int low_risk_check_count = 0;
            int low_risk_fix_count = 0;
            int low_risk_na_count = 0;

            // 순차적으로 점검
            for (int index = 0; index < this.history_grv.Rows.Count - 1; index++)
            {
                string id = this.history_grv.Rows[index].Cells[0].FormattedValue.ToString();
                string risk = this.history_grv.Rows[index].Cells[1].FormattedValue.ToString();
                string title = this.history_grv.Rows[index].Cells[2].FormattedValue.ToString();
                string status = this.history_grv.Rows[index].Cells[3].FormattedValue.ToString();
                string check = this.history_grv.Rows[index].Cells[4].FormattedValue.ToString();
                string check_sql = this.history_grv.Rows[index].Cells[5].FormattedValue.ToString();
                string fix = this.history_grv.Rows[index].Cells[6].FormattedValue.ToString();
                string fix_sql = this.history_grv.Rows[index].Cells[7].FormattedValue.ToString();
                string check_result = this.history_grv.Rows[index].Cells[8].FormattedValue.ToString();
                string fix_result = this.history_grv.Rows[index].Cells[9].FormattedValue.ToString();

                switch (status)
                {
                    case "Ready":
                        ready_count += 1;
                        break;
                    case "Checked":
                        checked_count += 1;
                        break;
                    case "Fixed":
                        fixed_count += 1;
                        break;
                    case "N/A":
                        na_count += 1;
                        break;
                }

                switch (risk)
                {
                    case "H":
                        switch (status)
                        {
                            case "Ready":
                                high_risk_ready_count += 1;
                                break;
                            case "Checked":
                                high_risk_check_count += 1;
                                break;
                            case "Fixed":
                                high_risk_fix_count += 1;
                                break;
                            case "N/A":
                                high_risk_na_count += 1;
                                break;
                        }
                        break;
                    case "M":
                        switch (status)
                        {
                            case "Ready":
                                middle_risk_ready_count += 1;
                                break;
                            case "Checked":
                                middle_risk_check_count += 1;
                                break;
                            case "Fixed":
                                middle_risk_fix_count += 1;
                                break;
                            case "N/A":
                                middle_risk_na_count += 1;
                                break;
                        }
                        break;
                    case "L":
                        switch (status)
                        {
                            case "Ready":
                                low_risk_ready_count += 1;
                                break;
                            case "Checked":
                                low_risk_check_count += 1;
                                break;
                            case "Fixed":
                                low_risk_fix_count += 1;
                                break;
                            case "N/A":
                                low_risk_na_count += 1;
                                break;
                        }
                        break;
                }
            }

            // 통계를 화면에 표시함

            this.total_rule_tbx.Text = total_count.ToString();
            this.ready_rule_tbx.Text = ready_count.ToString();
            this.checked_rule_tbx.Text = checked_count.ToString();
            this.fixed_rule_tbx.Text = fixed_count.ToString();
            this.na_rule_tbx.Text = na_count.ToString();

            // 1) 고위험군
            this.high_risk_ready_count_tbx.Text = high_risk_ready_count.ToString();
            this.high_risk_checked_count_tbx.Text = high_risk_check_count.ToString();
            this.high_risk_fixed_count_tbx.Text = high_risk_fix_count.ToString();
            this.high_risk_na_count_tbx.Text = high_risk_na_count.ToString();

            // 2) 중위험군
            this.middle_risk_ready_count_tbx.Text = middle_risk_ready_count.ToString();
            this.middle_risk_checked_count_tbx.Text = middle_risk_check_count.ToString();
            this.middle_risk_fixed_count_tbx.Text = middle_risk_fix_count.ToString();
            this.middle_risk_na_count_tbx.Text = middle_risk_na_count.ToString();


            // 3) 저위험군
            this.low_risk_ready_count_tbx.Text = low_risk_ready_count.ToString();
            this.low_risk_checked_count_tbx.Text = low_risk_check_count.ToString();
            this.low_risk_fixed_count_tbx.Text = low_risk_fix_count.ToString();
            this.low_risk_na_count_tbx.Text = low_risk_na_count.ToString();


            // 결과 활용
            int complete_count = checked_count + fixed_count + na_count;
            this.progress_pgb.Maximum = total_count;
            this.progress_pgb.Value = complete_count;

            float percent = ((float)complete_count / (float)total_count * 100);
            string percentage = string.Format("{0:0.00}", double.Parse(percent.ToString()));

            this.progress_lbl.Text = "Total Rule: " + total_count.ToString() +
                " / Complete Rule: " + complete_count.ToString() +
                "(" + percentage + "%)";

        }

        private DataGridView createTempDataGridView()
        {
            DataGridView dgv = new System.Windows.Forms.DataGridView();

            //열 추가 (Name & Value)
            dgv.Columns.Add("Name", "Name");
            dgv.Columns.Add("Value", "Value");

            dgv.Columns.Add("", "");
            dgv.Columns.Add("Name", "Name");
            dgv.Columns.Add("Value", "Value");

            dgv.Columns.Add("", "");
            dgv.Columns.Add("Name", "Name");
            dgv.Columns.Add("Value", "Value");

            dgv.Columns.Add("", "");
            dgv.Columns.Add("Name", "Name");
            dgv.Columns.Add("Value", "Value");

            //행 추가
            dgv.Rows.Add(this.total_rule_lbl.Text, this.total_rule_tbx.Text);

            dgv.Rows.Add(this.ready_rule_lbl.Text, this.ready_rule_tbx.Text, "",
                this.high_risk_ready_count_lbl.Text, this.high_risk_ready_count_tbx.Text, "",
                this.middle_risk_ready_count_lbl.Text, this.middle_risk_ready_count_tbx.Text, "",
                this.low_risk_ready_count_lbl.Text, this.low_risk_ready_count_tbx.Text);

            dgv.Rows.Add(this.checked_rule_lbl.Text, this.checked_rule_tbx.Text, "",
                this.high_risk_checked_count_lbl.Text, this.high_risk_checked_count_tbx.Text, "",
                this.middle_risk_checked_count_lbl.Text, this.middle_risk_checked_count_tbx.Text, "",
                this.low_risk_checked_count_lbl.Text, this.low_risk_checked_count_tbx.Text);

            dgv.Rows.Add(this.fixed_rule_lbl.Text, this.fixed_rule_tbx.Text, "",
                this.high_risk_fixed_count_lbl.Text, this.high_risk_fixed_count_tbx.Text, "",
                this.middle_risk_fixed_count_lbl.Text, this.middle_risk_fixed_count_tbx.Text, "",
                this.low_risk_fixed_count_lbl.Text, this.low_risk_fixed_count_tbx.Text);

            dgv.Rows.Add(this.na_rule_lbl.Text, this.na_rule_tbx.Text, "",
                this.high_risk_na_count_lbl.Text, this.high_risk_na_count_tbx.Text, "",
                this.middle_risk_na_count_lbl.Text, this.middle_risk_na_count_tbx.Text, "",
                this.low_risk_na_count_lbl.Text, this.low_risk_na_count_tbx.Text);

            return dgv;
        }

        private void DrawFractionChart(Excel._Worksheet activeSheet, Excel.ChartObjects xlCharts,
            int left, int top, int width, int height, string xRangeStart, string xRangeEnd, string yRangeStart, string yRangeEnd)
        {
            // Chart Section X, Y 위치 & 높이, 넓이 지정
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(left, top, width, height);
            Excel.Chart chartPage = myChart.Chart;

            Excel.SeriesCollection seriesCollection = chartPage.SeriesCollection();
            Excel.Series series1 = seriesCollection.NewSeries();
            series1.XValues = activeSheet.Range[xRangeStart, xRangeEnd];
            series1.Values = activeSheet.Range[yRangeStart, yRangeEnd];

            chartPage.ChartType = Excel.XlChartType.xlPieExploded;

            Excel.Axis axis = chartPage.Axes(Excel.XlAxisType.xlValue, Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary) as Excel.Axis;

            series1.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowPercent, false, true, false, false, false, true, true);

        }


        private bool dataGridView_ExportToExcel(string fileName, DataGridView dgv, string ext, bool chart)
        {
            CheckForIllegalCrossThreadCalls = false; // 크로스 쓰레드 문제점 해결을 위한 예외처리

            Excel.Application excelApp = new Excel.Application();

            if (excelApp == null)
            {
                MessageBox.Show("엑셀이 설치되지 않았습니다");
                return false;
            }
            Excel.Workbook wb = excelApp.Workbooks.Add(true);
            Excel._Worksheet workSheet = wb.Worksheets.get_Item(1) as Excel._Worksheet;
            workSheet.Name = "C#";

            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("출력할 데이터가 없습니다");
                return false;
            }

            // 헤더 출력
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                workSheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }

            //내용 출력
            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    workSheet.Cells[r + 2, i + 1] = dgv.Rows[r].Cells[i].Value;
                }
            }


            if (chart)
            {
                Excel.ChartObjects myCharts = (Excel.ChartObjects)workSheet.ChartObjects(Type.Missing);
                DrawFractionChart(workSheet, myCharts, 0, 140, 150, 200, "A3", "A6", "B3", "B6");

                Excel.ChartObjects myChartsTwo = (Excel.ChartObjects)workSheet.ChartObjects(Type.Missing);
                DrawFractionChart(workSheet, myChartsTwo, 160, 140, 150, 200, "D3", "D6", "E3", "E6");

                Excel.ChartObjects myChartsThree = (Excel.ChartObjects)workSheet.ChartObjects(Type.Missing);
                DrawFractionChart(workSheet, myChartsThree, 320, 140, 150, 200, "G3", "G6", "H3", "H6");

                Excel.ChartObjects myChartsFour = (Excel.ChartObjects)workSheet.ChartObjects(Type.Missing);
                DrawFractionChart(workSheet, myChartsFour, 480, 140, 150, 200, "J3", "J6", "K3", "K6");
            }

            // 글자 크기에 맞게 셀 크기를 자동으로 조절
            workSheet.Columns.AutoFit();


            //엑셀 2003 저장
            if (ext.Equals("xls"))
            {
                wb.SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            //엑셀 2007 저장
            if (ext.Equals("xlsx"))
            {
                wb.SaveAs(fileName, Excel.XlFileFormat.xlOpenXMLWorkbook, Type.Missing, Type.Missing, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
                    Excel.XlSaveConflictResolution.xlUserResolution, true, Type.Missing, Type.Missing, Type.Missing);
            }

            if (ext.Equals("csv"))
            {
                wb.SaveAs(fileName, Excel.XlFileFormat.xlOpenXMLWorkbook, Type.Missing, Type.Missing, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
                    Excel.XlSaveConflictResolution.xlUserResolution, true, Type.Missing, Type.Missing, Type.Missing);
            }

            wb.Close(Type.Missing, Type.Missing, Type.Missing);
            excelApp.Quit();
            releaseObject(excelApp);
            releaseObject(workSheet);
            releaseObject(wb);

            return true;
        }

        #region 메모리해제
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch 
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion

        private async void save_rowdata_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Title = "Save as Excel File";
            dialog.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";
            dialog.FileName = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.loading_pbx.Visible = true;
                this.loading_side_pbx.Visible = true;

                //만약 excel 2003을 골랐다면 xls로 저장
                if (Path.GetExtension(dialog.FileName).Equals(".xls"))
                {
                    var save_task = Task.Run(() => dataGridView_ExportToExcel(dialog.FileName, this.history_grv, "xls", false));
                    if (await save_task) // 비동기식 처리가 완료되면,
                    {
                        save_task.Dispose();
                    }
                    else
                    {
                        save_task.Dispose();
                    }
                }

                //만약 excel 2007을 골랐다면 xlsx로 저장
                else if (Path.GetExtension(dialog.FileName).Equals(".xlsx"))
                {
                    var save_task = Task.Run(() => dataGridView_ExportToExcel(dialog.FileName, this.history_grv, "xlsx", false));
                    if (await save_task) // 비동기식 처리가 완료되면,
                    {
                        save_task.Dispose();
                    }
                    else
                    {
                        save_task.Dispose();
                    }
                }

                this.loading_pbx.Visible = false;
                this.loading_side_pbx.Visible = false;

                MessageBox.Show("파일이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void save_figure_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Title = "Save as Excel File";
            dialog.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";
            dialog.FileName = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.loading_pbx.Visible = true;
                this.loading_side_pbx.Visible = true;

                //만약 excel 2003을 골랐다면 xls로 저장
                if (Path.GetExtension(dialog.FileName).Equals(".xls"))
                {
                    var save_task = Task.Run(() => dataGridView_ExportToExcel(dialog.FileName, this.createTempDataGridView(), "xls", true));
                    if (await save_task) // 비동기식 처리가 완료되면,
                    {
                        save_task.Dispose();
                    }
                    else
                    {
                        save_task.Dispose();
                    }
                }

                //만약 excel 2007을 골랐다면 xlsx로 저장
                else if (Path.GetExtension(dialog.FileName).Equals(".xlsx"))
                {
                    var save_task = Task.Run(() => dataGridView_ExportToExcel(dialog.FileName, this.createTempDataGridView(), "xlsx", true));
                    if (await save_task) // 비동기식 처리가 완료되면,
                    {
                        save_task.Dispose();
                    }
                    else
                    {
                        save_task.Dispose();
                    }
                }

                this.loading_pbx.Visible = false;
                this.loading_side_pbx.Visible = false;

                MessageBox.Show("파일이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void save_figure_csv_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Title = "Save as csv File";
            dialog.Filter = "csv (*.csv) | *.csv";
            dialog.FileName = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.loading_pbx.Visible = true;
                this.loading_side_pbx.Visible = true;

                if (Path.GetExtension(dialog.FileName).Equals(".csv"))
                {
                    var save_task = Task.Run(() => dataGridView_ExportToExcel(dialog.FileName, this.createTempDataGridView(), "csv", true));
                    if (await save_task) // 비동기식 처리가 완료되면,
                    {
                        save_task.Dispose();
                    }
                    else
                    {
                        save_task.Dispose();
                    }
                }

                this.loading_pbx.Visible = false;
                this.loading_side_pbx.Visible = false;

                MessageBox.Show("파일이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void save_rowdata_csv_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Title = "Save as csv File";
            dialog.Filter = "csv (*.csv) | *.csv";
            dialog.FileName = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.loading_pbx.Visible = true;
                this.loading_side_pbx.Visible = true;

                if (Path.GetExtension(dialog.FileName).Equals(".csv"))
                {
                    var save_task = Task.Run(() => dataGridView_ExportToExcel(dialog.FileName, this.history_grv, "csv", false));
                    if (await save_task) // 비동기식 처리가 완료되면,
                    {
                        save_task.Dispose();
                    }
                    else
                    {
                        save_task.Dispose();
                    }
                }

                this.loading_pbx.Visible = false;
                this.loading_side_pbx.Visible = false;

                MessageBox.Show("파일이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
