namespace ASET
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.back_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.history_grv = new System.Windows.Forms.DataGridView();
            this.save_rowdata_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loading_pbx = new System.Windows.Forms.PictureBox();
            this.loading_side_pbx = new System.Windows.Forms.PictureBox();
            this.save_figure_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.title_tbx = new System.Windows.Forms.Label();
            this.title_seperator_line = new System.Windows.Forms.Label();
            this.progress_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.progress_pgb = new MaterialSkin.Controls.MaterialProgressBar();
            this.total_rule_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.low_risk_checked_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.low_risk_ready_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.low_risk_ready_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.low_risk_checked_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.low_risk_fixed_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.low_risk_fixed_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.middle_risk_fixed_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.middle_risk_checked_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.middle_risk_ready_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.middle_risk_ready_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.middle_risk_checked_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.middle_risk_fixed_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.high_risk_fixed_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.high_risk_fixed_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.high_risk_checked_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.high_risk_checked_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.high_risk_ready_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.high_risk_ready_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.fixed_rule_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ready_rule_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checked_rule_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.total_rule_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fixed_rule_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.checked_rule_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.ready_rule_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.report_lbl = new System.Windows.Forms.Label();
            this.na_rule_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.na_rule_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.high_risk_na_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.high_risk_na_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.middle_risk_na_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.middle_risk_na_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.low_risk_na_count_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.low_risk_na_count_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.save_figure_csv_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.save_rowdata_csv_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_sql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fix_sql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fix_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.history_grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading_side_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.AutoSize = true;
            this.back_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_btn.Depth = 0;
            this.back_btn.Icon = null;
            this.back_btn.Location = new System.Drawing.Point(41, 642);
            this.back_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.back_btn.Name = "back_btn";
            this.back_btn.Primary = true;
            this.back_btn.Size = new System.Drawing.Size(56, 36);
            this.back_btn.TabIndex = 9;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // history_grv
            // 
            this.history_grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.history_grv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.risk,
            this.title,
            this.status,
            this.check,
            this.check_sql,
            this.fix,
            this.fix_sql,
            this.check_result,
            this.fix_result});
            this.history_grv.Location = new System.Drawing.Point(41, 204);
            this.history_grv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.history_grv.MultiSelect = false;
            this.history_grv.Name = "history_grv";
            this.history_grv.ReadOnly = true;
            this.history_grv.RowTemplate.Height = 23;
            this.history_grv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.history_grv.Size = new System.Drawing.Size(1264, 411);
            this.history_grv.TabIndex = 13;
            // 
            // save_rowdata_btn
            // 
            this.save_rowdata_btn.AutoSize = true;
            this.save_rowdata_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_rowdata_btn.Depth = 0;
            this.save_rowdata_btn.Icon = null;
            this.save_rowdata_btn.Location = new System.Drawing.Point(1120, 642);
            this.save_rowdata_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_rowdata_btn.Name = "save_rowdata_btn";
            this.save_rowdata_btn.Primary = true;
            this.save_rowdata_btn.Size = new System.Drawing.Size(174, 36);
            this.save_rowdata_btn.TabIndex = 14;
            this.save_rowdata_btn.Text = "save rowdata(excel)";
            this.save_rowdata_btn.UseVisualStyleBackColor = true;
            this.save_rowdata_btn.Click += new System.EventHandler(this.save_rowdata_btn_Click);
            // 
            // loading_pbx
            // 
            this.loading_pbx.BackColor = System.Drawing.Color.Transparent;
            this.loading_pbx.Image = global::ASET.Properties.Resources.loading;
            this.loading_pbx.Location = new System.Drawing.Point(471, 291);
            this.loading_pbx.Name = "loading_pbx";
            this.loading_pbx.Size = new System.Drawing.Size(398, 232);
            this.loading_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading_pbx.TabIndex = 41;
            this.loading_pbx.TabStop = false;
            this.loading_pbx.Visible = false;
            // 
            // loading_side_pbx
            // 
            this.loading_side_pbx.BackColor = System.Drawing.Color.Transparent;
            this.loading_side_pbx.Location = new System.Drawing.Point(41, 204);
            this.loading_side_pbx.Name = "loading_side_pbx";
            this.loading_side_pbx.Size = new System.Drawing.Size(1264, 411);
            this.loading_side_pbx.TabIndex = 42;
            this.loading_side_pbx.TabStop = false;
            this.loading_side_pbx.Visible = false;
            // 
            // save_figure_btn
            // 
            this.save_figure_btn.AutoSize = true;
            this.save_figure_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_figure_btn.Depth = 0;
            this.save_figure_btn.Icon = null;
            this.save_figure_btn.Location = new System.Drawing.Point(914, 642);
            this.save_figure_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_figure_btn.Name = "save_figure_btn";
            this.save_figure_btn.Primary = true;
            this.save_figure_btn.Size = new System.Drawing.Size(160, 36);
            this.save_figure_btn.TabIndex = 43;
            this.save_figure_btn.Text = "save report(excel)";
            this.save_figure_btn.UseVisualStyleBackColor = true;
            this.save_figure_btn.Click += new System.EventHandler(this.save_figure_btn_Click);
            // 
            // title_tbx
            // 
            this.title_tbx.AutoSize = true;
            this.title_tbx.BackColor = System.Drawing.Color.Transparent;
            this.title_tbx.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tbx.ForeColor = System.Drawing.SystemColors.WindowText;
            this.title_tbx.Location = new System.Drawing.Point(141, 103);
            this.title_tbx.Name = "title_tbx";
            this.title_tbx.Size = new System.Drawing.Size(36, 19);
            this.title_tbx.TabIndex = 55;
            this.title_tbx.Text = "title";
            // 
            // title_seperator_line
            // 
            this.title_seperator_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title_seperator_line.Location = new System.Drawing.Point(37, 133);
            this.title_seperator_line.Name = "title_seperator_line";
            this.title_seperator_line.Size = new System.Drawing.Size(310, 2);
            this.title_seperator_line.TabIndex = 56;
            // 
            // progress_lbl
            // 
            this.progress_lbl.AutoSize = true;
            this.progress_lbl.Depth = 0;
            this.progress_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.progress_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progress_lbl.Location = new System.Drawing.Point(38, 155);
            this.progress_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.progress_lbl.Name = "progress_lbl";
            this.progress_lbl.Size = new System.Drawing.Size(272, 18);
            this.progress_lbl.TabIndex = 58;
            this.progress_lbl.Text = "Total Rule: 0 / Complete Rule: 0 (0.00%)";
            // 
            // progress_pgb
            // 
            this.progress_pgb.Depth = 0;
            this.progress_pgb.Location = new System.Drawing.Point(38, 184);
            this.progress_pgb.Maximum = 3;
            this.progress_pgb.MouseState = MaterialSkin.MouseState.HOVER;
            this.progress_pgb.Name = "progress_pgb";
            this.progress_pgb.Size = new System.Drawing.Size(1251, 5);
            this.progress_pgb.TabIndex = 57;
            // 
            // total_rule_lbl
            // 
            this.total_rule_lbl.AutoSize = true;
            this.total_rule_lbl.Depth = 0;
            this.total_rule_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.total_rule_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.total_rule_lbl.Location = new System.Drawing.Point(1447, 86);
            this.total_rule_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.total_rule_lbl.Name = "total_rule_lbl";
            this.total_rule_lbl.Size = new System.Drawing.Size(119, 18);
            this.total_rule_lbl.TabIndex = 15;
            this.total_rule_lbl.Text = "Total Rule Count";
            this.total_rule_lbl.Visible = false;
            // 
            // low_risk_checked_count_lbl
            // 
            this.low_risk_checked_count_lbl.AutoSize = true;
            this.low_risk_checked_count_lbl.Depth = 0;
            this.low_risk_checked_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.low_risk_checked_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.low_risk_checked_count_lbl.Location = new System.Drawing.Point(1447, 603);
            this.low_risk_checked_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.low_risk_checked_count_lbl.Name = "low_risk_checked_count_lbl";
            this.low_risk_checked_count_lbl.Size = new System.Drawing.Size(175, 18);
            this.low_risk_checked_count_lbl.TabIndex = 37;
            this.low_risk_checked_count_lbl.Text = "Low Risk Checked Count";
            this.low_risk_checked_count_lbl.Visible = false;
            // 
            // low_risk_ready_count_lbl
            // 
            this.low_risk_ready_count_lbl.AutoSize = true;
            this.low_risk_ready_count_lbl.Depth = 0;
            this.low_risk_ready_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.low_risk_ready_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.low_risk_ready_count_lbl.Location = new System.Drawing.Point(1447, 568);
            this.low_risk_ready_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.low_risk_ready_count_lbl.Name = "low_risk_ready_count_lbl";
            this.low_risk_ready_count_lbl.Size = new System.Drawing.Size(157, 18);
            this.low_risk_ready_count_lbl.TabIndex = 35;
            this.low_risk_ready_count_lbl.Text = "Low Risk Ready Count";
            this.low_risk_ready_count_lbl.Visible = false;
            // 
            // low_risk_ready_count_tbx
            // 
            this.low_risk_ready_count_tbx.Depth = 0;
            this.low_risk_ready_count_tbx.Enabled = false;
            this.low_risk_ready_count_tbx.Hint = "none";
            this.low_risk_ready_count_tbx.Location = new System.Drawing.Point(1615, 568);
            this.low_risk_ready_count_tbx.MaxLength = 32767;
            this.low_risk_ready_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.low_risk_ready_count_tbx.Name = "low_risk_ready_count_tbx";
            this.low_risk_ready_count_tbx.PasswordChar = '\0';
            this.low_risk_ready_count_tbx.SelectedText = "";
            this.low_risk_ready_count_tbx.SelectionLength = 0;
            this.low_risk_ready_count_tbx.SelectionStart = 0;
            this.low_risk_ready_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.low_risk_ready_count_tbx.TabIndex = 36;
            this.low_risk_ready_count_tbx.TabStop = false;
            this.low_risk_ready_count_tbx.UseSystemPasswordChar = false;
            this.low_risk_ready_count_tbx.Visible = false;
            // 
            // low_risk_checked_count_tbx
            // 
            this.low_risk_checked_count_tbx.Depth = 0;
            this.low_risk_checked_count_tbx.Enabled = false;
            this.low_risk_checked_count_tbx.Hint = "none";
            this.low_risk_checked_count_tbx.Location = new System.Drawing.Point(1640, 603);
            this.low_risk_checked_count_tbx.MaxLength = 32767;
            this.low_risk_checked_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.low_risk_checked_count_tbx.Name = "low_risk_checked_count_tbx";
            this.low_risk_checked_count_tbx.PasswordChar = '\0';
            this.low_risk_checked_count_tbx.SelectedText = "";
            this.low_risk_checked_count_tbx.SelectionLength = 0;
            this.low_risk_checked_count_tbx.SelectionStart = 0;
            this.low_risk_checked_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.low_risk_checked_count_tbx.TabIndex = 38;
            this.low_risk_checked_count_tbx.TabStop = false;
            this.low_risk_checked_count_tbx.UseSystemPasswordChar = false;
            this.low_risk_checked_count_tbx.Visible = false;
            // 
            // low_risk_fixed_count_tbx
            // 
            this.low_risk_fixed_count_tbx.Depth = 0;
            this.low_risk_fixed_count_tbx.Enabled = false;
            this.low_risk_fixed_count_tbx.Hint = "none";
            this.low_risk_fixed_count_tbx.Location = new System.Drawing.Point(1634, 638);
            this.low_risk_fixed_count_tbx.MaxLength = 32767;
            this.low_risk_fixed_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.low_risk_fixed_count_tbx.Name = "low_risk_fixed_count_tbx";
            this.low_risk_fixed_count_tbx.PasswordChar = '\0';
            this.low_risk_fixed_count_tbx.SelectedText = "";
            this.low_risk_fixed_count_tbx.SelectionLength = 0;
            this.low_risk_fixed_count_tbx.SelectionStart = 0;
            this.low_risk_fixed_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.low_risk_fixed_count_tbx.TabIndex = 40;
            this.low_risk_fixed_count_tbx.TabStop = false;
            this.low_risk_fixed_count_tbx.UseSystemPasswordChar = false;
            this.low_risk_fixed_count_tbx.Visible = false;
            // 
            // low_risk_fixed_count_lbl
            // 
            this.low_risk_fixed_count_lbl.AutoSize = true;
            this.low_risk_fixed_count_lbl.Depth = 0;
            this.low_risk_fixed_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.low_risk_fixed_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.low_risk_fixed_count_lbl.Location = new System.Drawing.Point(1447, 638);
            this.low_risk_fixed_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.low_risk_fixed_count_lbl.Name = "low_risk_fixed_count_lbl";
            this.low_risk_fixed_count_lbl.Size = new System.Drawing.Size(152, 18);
            this.low_risk_fixed_count_lbl.TabIndex = 39;
            this.low_risk_fixed_count_lbl.Text = "Low Risk Fixed Count";
            this.low_risk_fixed_count_lbl.Visible = false;
            // 
            // middle_risk_fixed_count_tbx
            // 
            this.middle_risk_fixed_count_tbx.Depth = 0;
            this.middle_risk_fixed_count_tbx.Enabled = false;
            this.middle_risk_fixed_count_tbx.Hint = "none";
            this.middle_risk_fixed_count_tbx.Location = new System.Drawing.Point(1629, 480);
            this.middle_risk_fixed_count_tbx.MaxLength = 32767;
            this.middle_risk_fixed_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.middle_risk_fixed_count_tbx.Name = "middle_risk_fixed_count_tbx";
            this.middle_risk_fixed_count_tbx.PasswordChar = '\0';
            this.middle_risk_fixed_count_tbx.SelectedText = "";
            this.middle_risk_fixed_count_tbx.SelectionLength = 0;
            this.middle_risk_fixed_count_tbx.SelectionStart = 0;
            this.middle_risk_fixed_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.middle_risk_fixed_count_tbx.TabIndex = 34;
            this.middle_risk_fixed_count_tbx.TabStop = false;
            this.middle_risk_fixed_count_tbx.UseSystemPasswordChar = false;
            this.middle_risk_fixed_count_tbx.Visible = false;
            // 
            // middle_risk_checked_count_tbx
            // 
            this.middle_risk_checked_count_tbx.Depth = 0;
            this.middle_risk_checked_count_tbx.Enabled = false;
            this.middle_risk_checked_count_tbx.Hint = "none";
            this.middle_risk_checked_count_tbx.Location = new System.Drawing.Point(1652, 445);
            this.middle_risk_checked_count_tbx.MaxLength = 32767;
            this.middle_risk_checked_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.middle_risk_checked_count_tbx.Name = "middle_risk_checked_count_tbx";
            this.middle_risk_checked_count_tbx.PasswordChar = '\0';
            this.middle_risk_checked_count_tbx.SelectedText = "";
            this.middle_risk_checked_count_tbx.SelectionLength = 0;
            this.middle_risk_checked_count_tbx.SelectionStart = 0;
            this.middle_risk_checked_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.middle_risk_checked_count_tbx.TabIndex = 32;
            this.middle_risk_checked_count_tbx.TabStop = false;
            this.middle_risk_checked_count_tbx.UseSystemPasswordChar = false;
            this.middle_risk_checked_count_tbx.Visible = false;
            // 
            // middle_risk_ready_count_tbx
            // 
            this.middle_risk_ready_count_tbx.Depth = 0;
            this.middle_risk_ready_count_tbx.Enabled = false;
            this.middle_risk_ready_count_tbx.Hint = "none";
            this.middle_risk_ready_count_tbx.Location = new System.Drawing.Point(1631, 416);
            this.middle_risk_ready_count_tbx.MaxLength = 32767;
            this.middle_risk_ready_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.middle_risk_ready_count_tbx.Name = "middle_risk_ready_count_tbx";
            this.middle_risk_ready_count_tbx.PasswordChar = '\0';
            this.middle_risk_ready_count_tbx.SelectedText = "";
            this.middle_risk_ready_count_tbx.SelectionLength = 0;
            this.middle_risk_ready_count_tbx.SelectionStart = 0;
            this.middle_risk_ready_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.middle_risk_ready_count_tbx.TabIndex = 30;
            this.middle_risk_ready_count_tbx.TabStop = false;
            this.middle_risk_ready_count_tbx.UseSystemPasswordChar = false;
            this.middle_risk_ready_count_tbx.Visible = false;
            // 
            // middle_risk_ready_count_lbl
            // 
            this.middle_risk_ready_count_lbl.AutoSize = true;
            this.middle_risk_ready_count_lbl.Depth = 0;
            this.middle_risk_ready_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.middle_risk_ready_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.middle_risk_ready_count_lbl.Location = new System.Drawing.Point(1447, 416);
            this.middle_risk_ready_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.middle_risk_ready_count_lbl.Name = "middle_risk_ready_count_lbl";
            this.middle_risk_ready_count_lbl.Size = new System.Drawing.Size(174, 18);
            this.middle_risk_ready_count_lbl.TabIndex = 29;
            this.middle_risk_ready_count_lbl.Text = "Middle Risk Ready Count";
            this.middle_risk_ready_count_lbl.Visible = false;
            // 
            // middle_risk_checked_count_lbl
            // 
            this.middle_risk_checked_count_lbl.AutoSize = true;
            this.middle_risk_checked_count_lbl.Depth = 0;
            this.middle_risk_checked_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.middle_risk_checked_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.middle_risk_checked_count_lbl.Location = new System.Drawing.Point(1447, 445);
            this.middle_risk_checked_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.middle_risk_checked_count_lbl.Name = "middle_risk_checked_count_lbl";
            this.middle_risk_checked_count_lbl.Size = new System.Drawing.Size(192, 18);
            this.middle_risk_checked_count_lbl.TabIndex = 31;
            this.middle_risk_checked_count_lbl.Text = "Middle Risk Checked Count";
            this.middle_risk_checked_count_lbl.Visible = false;
            // 
            // middle_risk_fixed_count_lbl
            // 
            this.middle_risk_fixed_count_lbl.AutoSize = true;
            this.middle_risk_fixed_count_lbl.Depth = 0;
            this.middle_risk_fixed_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.middle_risk_fixed_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.middle_risk_fixed_count_lbl.Location = new System.Drawing.Point(1447, 480);
            this.middle_risk_fixed_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.middle_risk_fixed_count_lbl.Name = "middle_risk_fixed_count_lbl";
            this.middle_risk_fixed_count_lbl.Size = new System.Drawing.Size(169, 18);
            this.middle_risk_fixed_count_lbl.TabIndex = 33;
            this.middle_risk_fixed_count_lbl.Text = "Middle Risk Fixed Count";
            this.middle_risk_fixed_count_lbl.Visible = false;
            // 
            // high_risk_fixed_count_tbx
            // 
            this.high_risk_fixed_count_tbx.Depth = 0;
            this.high_risk_fixed_count_tbx.Enabled = false;
            this.high_risk_fixed_count_tbx.Hint = "none";
            this.high_risk_fixed_count_tbx.Location = new System.Drawing.Point(1628, 334);
            this.high_risk_fixed_count_tbx.MaxLength = 32767;
            this.high_risk_fixed_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.high_risk_fixed_count_tbx.Name = "high_risk_fixed_count_tbx";
            this.high_risk_fixed_count_tbx.PasswordChar = '\0';
            this.high_risk_fixed_count_tbx.SelectedText = "";
            this.high_risk_fixed_count_tbx.SelectionLength = 0;
            this.high_risk_fixed_count_tbx.SelectionStart = 0;
            this.high_risk_fixed_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.high_risk_fixed_count_tbx.TabIndex = 26;
            this.high_risk_fixed_count_tbx.TabStop = false;
            this.high_risk_fixed_count_tbx.UseSystemPasswordChar = false;
            this.high_risk_fixed_count_tbx.Visible = false;
            // 
            // high_risk_fixed_count_lbl
            // 
            this.high_risk_fixed_count_lbl.AutoSize = true;
            this.high_risk_fixed_count_lbl.Depth = 0;
            this.high_risk_fixed_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.high_risk_fixed_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.high_risk_fixed_count_lbl.Location = new System.Drawing.Point(1447, 334);
            this.high_risk_fixed_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.high_risk_fixed_count_lbl.Name = "high_risk_fixed_count_lbl";
            this.high_risk_fixed_count_lbl.Size = new System.Drawing.Size(155, 18);
            this.high_risk_fixed_count_lbl.TabIndex = 25;
            this.high_risk_fixed_count_lbl.Text = "High Risk Fixed Count";
            this.high_risk_fixed_count_lbl.Visible = false;
            // 
            // high_risk_checked_count_tbx
            // 
            this.high_risk_checked_count_tbx.Depth = 0;
            this.high_risk_checked_count_tbx.Enabled = false;
            this.high_risk_checked_count_tbx.Hint = "none";
            this.high_risk_checked_count_tbx.Location = new System.Drawing.Point(1640, 299);
            this.high_risk_checked_count_tbx.MaxLength = 32767;
            this.high_risk_checked_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.high_risk_checked_count_tbx.Name = "high_risk_checked_count_tbx";
            this.high_risk_checked_count_tbx.PasswordChar = '\0';
            this.high_risk_checked_count_tbx.SelectedText = "";
            this.high_risk_checked_count_tbx.SelectionLength = 0;
            this.high_risk_checked_count_tbx.SelectionStart = 0;
            this.high_risk_checked_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.high_risk_checked_count_tbx.TabIndex = 24;
            this.high_risk_checked_count_tbx.TabStop = false;
            this.high_risk_checked_count_tbx.UseSystemPasswordChar = false;
            this.high_risk_checked_count_tbx.Visible = false;
            // 
            // high_risk_checked_count_lbl
            // 
            this.high_risk_checked_count_lbl.AutoSize = true;
            this.high_risk_checked_count_lbl.Depth = 0;
            this.high_risk_checked_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.high_risk_checked_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.high_risk_checked_count_lbl.Location = new System.Drawing.Point(1447, 299);
            this.high_risk_checked_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.high_risk_checked_count_lbl.Name = "high_risk_checked_count_lbl";
            this.high_risk_checked_count_lbl.Size = new System.Drawing.Size(178, 18);
            this.high_risk_checked_count_lbl.TabIndex = 23;
            this.high_risk_checked_count_lbl.Text = "High Risk Checked Count";
            this.high_risk_checked_count_lbl.Visible = false;
            // 
            // high_risk_ready_count_tbx
            // 
            this.high_risk_ready_count_tbx.Depth = 0;
            this.high_risk_ready_count_tbx.Enabled = false;
            this.high_risk_ready_count_tbx.Hint = "none";
            this.high_risk_ready_count_tbx.Location = new System.Drawing.Point(1636, 267);
            this.high_risk_ready_count_tbx.MaxLength = 32767;
            this.high_risk_ready_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.high_risk_ready_count_tbx.Name = "high_risk_ready_count_tbx";
            this.high_risk_ready_count_tbx.PasswordChar = '\0';
            this.high_risk_ready_count_tbx.SelectedText = "";
            this.high_risk_ready_count_tbx.SelectionLength = 0;
            this.high_risk_ready_count_tbx.SelectionStart = 0;
            this.high_risk_ready_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.high_risk_ready_count_tbx.TabIndex = 22;
            this.high_risk_ready_count_tbx.TabStop = false;
            this.high_risk_ready_count_tbx.UseSystemPasswordChar = false;
            this.high_risk_ready_count_tbx.Visible = false;
            // 
            // high_risk_ready_count_lbl
            // 
            this.high_risk_ready_count_lbl.AutoSize = true;
            this.high_risk_ready_count_lbl.Depth = 0;
            this.high_risk_ready_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.high_risk_ready_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.high_risk_ready_count_lbl.Location = new System.Drawing.Point(1447, 267);
            this.high_risk_ready_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.high_risk_ready_count_lbl.Name = "high_risk_ready_count_lbl";
            this.high_risk_ready_count_lbl.Size = new System.Drawing.Size(160, 18);
            this.high_risk_ready_count_lbl.TabIndex = 21;
            this.high_risk_ready_count_lbl.Text = "High Risk Ready Count";
            this.high_risk_ready_count_lbl.Visible = false;
            // 
            // fixed_rule_tbx
            // 
            this.fixed_rule_tbx.Depth = 0;
            this.fixed_rule_tbx.Enabled = false;
            this.fixed_rule_tbx.Hint = "none";
            this.fixed_rule_tbx.Location = new System.Drawing.Point(1612, 191);
            this.fixed_rule_tbx.MaxLength = 32767;
            this.fixed_rule_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.fixed_rule_tbx.Name = "fixed_rule_tbx";
            this.fixed_rule_tbx.PasswordChar = '\0';
            this.fixed_rule_tbx.SelectedText = "";
            this.fixed_rule_tbx.SelectionLength = 0;
            this.fixed_rule_tbx.SelectionStart = 0;
            this.fixed_rule_tbx.Size = new System.Drawing.Size(48, 23);
            this.fixed_rule_tbx.TabIndex = 20;
            this.fixed_rule_tbx.TabStop = false;
            this.fixed_rule_tbx.UseSystemPasswordChar = false;
            this.fixed_rule_tbx.Visible = false;
            // 
            // ready_rule_tbx
            // 
            this.ready_rule_tbx.Depth = 0;
            this.ready_rule_tbx.Enabled = false;
            this.ready_rule_tbx.Hint = "none";
            this.ready_rule_tbx.Location = new System.Drawing.Point(1592, 121);
            this.ready_rule_tbx.MaxLength = 32767;
            this.ready_rule_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.ready_rule_tbx.Name = "ready_rule_tbx";
            this.ready_rule_tbx.PasswordChar = '\0';
            this.ready_rule_tbx.SelectedText = "";
            this.ready_rule_tbx.SelectionLength = 0;
            this.ready_rule_tbx.SelectionStart = 0;
            this.ready_rule_tbx.Size = new System.Drawing.Size(48, 23);
            this.ready_rule_tbx.TabIndex = 28;
            this.ready_rule_tbx.TabStop = false;
            this.ready_rule_tbx.UseSystemPasswordChar = false;
            this.ready_rule_tbx.Visible = false;
            // 
            // checked_rule_tbx
            // 
            this.checked_rule_tbx.Depth = 0;
            this.checked_rule_tbx.Enabled = false;
            this.checked_rule_tbx.Hint = "none";
            this.checked_rule_tbx.Location = new System.Drawing.Point(1612, 156);
            this.checked_rule_tbx.MaxLength = 32767;
            this.checked_rule_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.checked_rule_tbx.Name = "checked_rule_tbx";
            this.checked_rule_tbx.PasswordChar = '\0';
            this.checked_rule_tbx.SelectedText = "";
            this.checked_rule_tbx.SelectionLength = 0;
            this.checked_rule_tbx.SelectionStart = 0;
            this.checked_rule_tbx.Size = new System.Drawing.Size(48, 23);
            this.checked_rule_tbx.TabIndex = 18;
            this.checked_rule_tbx.TabStop = false;
            this.checked_rule_tbx.UseSystemPasswordChar = false;
            this.checked_rule_tbx.Visible = false;
            // 
            // total_rule_tbx
            // 
            this.total_rule_tbx.Depth = 0;
            this.total_rule_tbx.Enabled = false;
            this.total_rule_tbx.Hint = "none";
            this.total_rule_tbx.Location = new System.Drawing.Point(1584, 86);
            this.total_rule_tbx.MaxLength = 32767;
            this.total_rule_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.total_rule_tbx.Name = "total_rule_tbx";
            this.total_rule_tbx.PasswordChar = '\0';
            this.total_rule_tbx.SelectedText = "";
            this.total_rule_tbx.SelectionLength = 0;
            this.total_rule_tbx.SelectionStart = 0;
            this.total_rule_tbx.Size = new System.Drawing.Size(48, 23);
            this.total_rule_tbx.TabIndex = 16;
            this.total_rule_tbx.TabStop = false;
            this.total_rule_tbx.UseSystemPasswordChar = false;
            this.total_rule_tbx.Visible = false;
            // 
            // fixed_rule_lbl
            // 
            this.fixed_rule_lbl.AutoSize = true;
            this.fixed_rule_lbl.Depth = 0;
            this.fixed_rule_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.fixed_rule_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fixed_rule_lbl.Location = new System.Drawing.Point(1447, 191);
            this.fixed_rule_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.fixed_rule_lbl.Name = "fixed_rule_lbl";
            this.fixed_rule_lbl.Size = new System.Drawing.Size(120, 18);
            this.fixed_rule_lbl.TabIndex = 19;
            this.fixed_rule_lbl.Text = "Fixed Rule Count";
            this.fixed_rule_lbl.Visible = false;
            // 
            // checked_rule_lbl
            // 
            this.checked_rule_lbl.AutoSize = true;
            this.checked_rule_lbl.Depth = 0;
            this.checked_rule_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.checked_rule_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checked_rule_lbl.Location = new System.Drawing.Point(1447, 156);
            this.checked_rule_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.checked_rule_lbl.Name = "checked_rule_lbl";
            this.checked_rule_lbl.Size = new System.Drawing.Size(143, 18);
            this.checked_rule_lbl.TabIndex = 17;
            this.checked_rule_lbl.Text = "Checked Rule Count";
            this.checked_rule_lbl.Visible = false;
            // 
            // ready_rule_lbl
            // 
            this.ready_rule_lbl.AutoSize = true;
            this.ready_rule_lbl.Depth = 0;
            this.ready_rule_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.ready_rule_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ready_rule_lbl.Location = new System.Drawing.Point(1447, 121);
            this.ready_rule_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ready_rule_lbl.Name = "ready_rule_lbl";
            this.ready_rule_lbl.Size = new System.Drawing.Size(125, 18);
            this.ready_rule_lbl.TabIndex = 27;
            this.ready_rule_lbl.Text = "Ready Rule Count";
            this.ready_rule_lbl.Visible = false;
            // 
            // report_lbl
            // 
            this.report_lbl.AutoSize = true;
            this.report_lbl.BackColor = System.Drawing.Color.Transparent;
            this.report_lbl.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.report_lbl.Location = new System.Drawing.Point(29, 90);
            this.report_lbl.Name = "report_lbl";
            this.report_lbl.Size = new System.Drawing.Size(114, 38);
            this.report_lbl.TabIndex = 59;
            this.report_lbl.Text = "Report";
            // 
            // na_rule_lbl
            // 
            this.na_rule_lbl.AutoSize = true;
            this.na_rule_lbl.Depth = 0;
            this.na_rule_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.na_rule_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.na_rule_lbl.Location = new System.Drawing.Point(1447, 223);
            this.na_rule_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.na_rule_lbl.Name = "na_rule_lbl";
            this.na_rule_lbl.Size = new System.Drawing.Size(112, 18);
            this.na_rule_lbl.TabIndex = 60;
            this.na_rule_lbl.Text = "N/A Rule Count";
            this.na_rule_lbl.Visible = false;
            // 
            // na_rule_tbx
            // 
            this.na_rule_tbx.Depth = 0;
            this.na_rule_tbx.Enabled = false;
            this.na_rule_tbx.Hint = "none";
            this.na_rule_tbx.Location = new System.Drawing.Point(1612, 223);
            this.na_rule_tbx.MaxLength = 32767;
            this.na_rule_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.na_rule_tbx.Name = "na_rule_tbx";
            this.na_rule_tbx.PasswordChar = '\0';
            this.na_rule_tbx.SelectedText = "";
            this.na_rule_tbx.SelectionLength = 0;
            this.na_rule_tbx.SelectionStart = 0;
            this.na_rule_tbx.Size = new System.Drawing.Size(48, 23);
            this.na_rule_tbx.TabIndex = 61;
            this.na_rule_tbx.TabStop = false;
            this.na_rule_tbx.UseSystemPasswordChar = false;
            this.na_rule_tbx.Visible = false;
            // 
            // high_risk_na_count_lbl
            // 
            this.high_risk_na_count_lbl.AutoSize = true;
            this.high_risk_na_count_lbl.Depth = 0;
            this.high_risk_na_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.high_risk_na_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.high_risk_na_count_lbl.Location = new System.Drawing.Point(1447, 366);
            this.high_risk_na_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.high_risk_na_count_lbl.Name = "high_risk_na_count_lbl";
            this.high_risk_na_count_lbl.Size = new System.Drawing.Size(147, 18);
            this.high_risk_na_count_lbl.TabIndex = 62;
            this.high_risk_na_count_lbl.Text = "High Risk N/A Count";
            this.high_risk_na_count_lbl.Visible = false;
            // 
            // high_risk_na_count_tbx
            // 
            this.high_risk_na_count_tbx.Depth = 0;
            this.high_risk_na_count_tbx.Enabled = false;
            this.high_risk_na_count_tbx.Hint = "none";
            this.high_risk_na_count_tbx.Location = new System.Drawing.Point(1628, 363);
            this.high_risk_na_count_tbx.MaxLength = 32767;
            this.high_risk_na_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.high_risk_na_count_tbx.Name = "high_risk_na_count_tbx";
            this.high_risk_na_count_tbx.PasswordChar = '\0';
            this.high_risk_na_count_tbx.SelectedText = "";
            this.high_risk_na_count_tbx.SelectionLength = 0;
            this.high_risk_na_count_tbx.SelectionStart = 0;
            this.high_risk_na_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.high_risk_na_count_tbx.TabIndex = 63;
            this.high_risk_na_count_tbx.TabStop = false;
            this.high_risk_na_count_tbx.UseSystemPasswordChar = false;
            this.high_risk_na_count_tbx.Visible = false;
            // 
            // middle_risk_na_count_tbx
            // 
            this.middle_risk_na_count_tbx.Depth = 0;
            this.middle_risk_na_count_tbx.Enabled = false;
            this.middle_risk_na_count_tbx.Hint = "none";
            this.middle_risk_na_count_tbx.Location = new System.Drawing.Point(1628, 511);
            this.middle_risk_na_count_tbx.MaxLength = 32767;
            this.middle_risk_na_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.middle_risk_na_count_tbx.Name = "middle_risk_na_count_tbx";
            this.middle_risk_na_count_tbx.PasswordChar = '\0';
            this.middle_risk_na_count_tbx.SelectedText = "";
            this.middle_risk_na_count_tbx.SelectionLength = 0;
            this.middle_risk_na_count_tbx.SelectionStart = 0;
            this.middle_risk_na_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.middle_risk_na_count_tbx.TabIndex = 65;
            this.middle_risk_na_count_tbx.TabStop = false;
            this.middle_risk_na_count_tbx.UseSystemPasswordChar = false;
            this.middle_risk_na_count_tbx.Visible = false;
            // 
            // middle_risk_na_count_lbl
            // 
            this.middle_risk_na_count_lbl.AutoSize = true;
            this.middle_risk_na_count_lbl.Depth = 0;
            this.middle_risk_na_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.middle_risk_na_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.middle_risk_na_count_lbl.Location = new System.Drawing.Point(1447, 514);
            this.middle_risk_na_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.middle_risk_na_count_lbl.Name = "middle_risk_na_count_lbl";
            this.middle_risk_na_count_lbl.Size = new System.Drawing.Size(161, 18);
            this.middle_risk_na_count_lbl.TabIndex = 64;
            this.middle_risk_na_count_lbl.Text = "Middle Risk N/A Count";
            this.middle_risk_na_count_lbl.Visible = false;
            // 
            // low_risk_na_count_lbl
            // 
            this.low_risk_na_count_lbl.AutoSize = true;
            this.low_risk_na_count_lbl.Depth = 0;
            this.low_risk_na_count_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.low_risk_na_count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.low_risk_na_count_lbl.Location = new System.Drawing.Point(1447, 671);
            this.low_risk_na_count_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.low_risk_na_count_lbl.Name = "low_risk_na_count_lbl";
            this.low_risk_na_count_lbl.Size = new System.Drawing.Size(144, 18);
            this.low_risk_na_count_lbl.TabIndex = 66;
            this.low_risk_na_count_lbl.Text = "Low Risk N/A Count";
            this.low_risk_na_count_lbl.Visible = false;
            // 
            // low_risk_na_count_tbx
            // 
            this.low_risk_na_count_tbx.Depth = 0;
            this.low_risk_na_count_tbx.Enabled = false;
            this.low_risk_na_count_tbx.Hint = "none";
            this.low_risk_na_count_tbx.Location = new System.Drawing.Point(1623, 670);
            this.low_risk_na_count_tbx.MaxLength = 32767;
            this.low_risk_na_count_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.low_risk_na_count_tbx.Name = "low_risk_na_count_tbx";
            this.low_risk_na_count_tbx.PasswordChar = '\0';
            this.low_risk_na_count_tbx.SelectedText = "";
            this.low_risk_na_count_tbx.SelectionLength = 0;
            this.low_risk_na_count_tbx.SelectionStart = 0;
            this.low_risk_na_count_tbx.Size = new System.Drawing.Size(48, 23);
            this.low_risk_na_count_tbx.TabIndex = 67;
            this.low_risk_na_count_tbx.TabStop = false;
            this.low_risk_na_count_tbx.UseSystemPasswordChar = false;
            this.low_risk_na_count_tbx.Visible = false;
            // 
            // save_figure_csv_btn
            // 
            this.save_figure_csv_btn.AutoSize = true;
            this.save_figure_csv_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_figure_csv_btn.Depth = 0;
            this.save_figure_csv_btn.Icon = null;
            this.save_figure_csv_btn.Location = new System.Drawing.Point(516, 642);
            this.save_figure_csv_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_figure_csv_btn.Name = "save_figure_csv_btn";
            this.save_figure_csv_btn.Primary = true;
            this.save_figure_csv_btn.Size = new System.Drawing.Size(146, 36);
            this.save_figure_csv_btn.TabIndex = 69;
            this.save_figure_csv_btn.Text = "save report(csv)";
            this.save_figure_csv_btn.UseVisualStyleBackColor = true;
            this.save_figure_csv_btn.Click += new System.EventHandler(this.save_figure_csv_btn_Click);
            // 
            // save_rowdata_csv_btn
            // 
            this.save_rowdata_csv_btn.AutoSize = true;
            this.save_rowdata_csv_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_rowdata_csv_btn.Depth = 0;
            this.save_rowdata_csv_btn.Icon = null;
            this.save_rowdata_csv_btn.Location = new System.Drawing.Point(708, 642);
            this.save_rowdata_csv_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_rowdata_csv_btn.Name = "save_rowdata_csv_btn";
            this.save_rowdata_csv_btn.Primary = true;
            this.save_rowdata_csv_btn.Size = new System.Drawing.Size(160, 36);
            this.save_rowdata_csv_btn.TabIndex = 68;
            this.save_rowdata_csv_btn.Text = "save rowdata(csv)";
            this.save_rowdata_csv_btn.UseVisualStyleBackColor = true;
            this.save_rowdata_csv_btn.Click += new System.EventHandler(this.save_rowdata_csv_btn_Click);
            // 
            // id
            // 
            this.id.FillWeight = 190F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // risk
            // 
            this.risk.HeaderText = "Risk";
            this.risk.Name = "risk";
            this.risk.ReadOnly = true;
            this.risk.Width = 90;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 890;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // check
            // 
            this.check.HeaderText = "Check";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Visible = false;
            // 
            // check_sql
            // 
            this.check_sql.HeaderText = "check_sql";
            this.check_sql.Name = "check_sql";
            this.check_sql.ReadOnly = true;
            this.check_sql.Visible = false;
            this.check_sql.Width = 300;
            // 
            // fix
            // 
            this.fix.HeaderText = "fix";
            this.fix.Name = "fix";
            this.fix.ReadOnly = true;
            this.fix.Visible = false;
            // 
            // fix_sql
            // 
            this.fix_sql.HeaderText = "fix_sql";
            this.fix_sql.Name = "fix_sql";
            this.fix_sql.ReadOnly = true;
            this.fix_sql.Visible = false;
            this.fix_sql.Width = 300;
            // 
            // check_result
            // 
            this.check_result.HeaderText = "check_result";
            this.check_result.Name = "check_result";
            this.check_result.ReadOnly = true;
            this.check_result.Visible = false;
            this.check_result.Width = 300;
            // 
            // fix_result
            // 
            this.fix_result.HeaderText = "fix_result";
            this.fix_result.Name = "fix_result";
            this.fix_result.ReadOnly = true;
            this.fix_result.Visible = false;
            this.fix_result.Width = 300;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 700);
            this.Controls.Add(this.save_figure_csv_btn);
            this.Controls.Add(this.save_rowdata_csv_btn);
            this.Controls.Add(this.low_risk_na_count_tbx);
            this.Controls.Add(this.low_risk_na_count_lbl);
            this.Controls.Add(this.middle_risk_na_count_tbx);
            this.Controls.Add(this.middle_risk_na_count_lbl);
            this.Controls.Add(this.high_risk_na_count_tbx);
            this.Controls.Add(this.high_risk_na_count_lbl);
            this.Controls.Add(this.na_rule_tbx);
            this.Controls.Add(this.na_rule_lbl);
            this.Controls.Add(this.report_lbl);
            this.Controls.Add(this.progress_lbl);
            this.Controls.Add(this.progress_pgb);
            this.Controls.Add(this.title_seperator_line);
            this.Controls.Add(this.title_tbx);
            this.Controls.Add(this.save_figure_btn);
            this.Controls.Add(this.loading_pbx);
            this.Controls.Add(this.loading_side_pbx);
            this.Controls.Add(this.low_risk_fixed_count_tbx);
            this.Controls.Add(this.low_risk_fixed_count_lbl);
            this.Controls.Add(this.low_risk_checked_count_tbx);
            this.Controls.Add(this.low_risk_checked_count_lbl);
            this.Controls.Add(this.low_risk_ready_count_tbx);
            this.Controls.Add(this.low_risk_ready_count_lbl);
            this.Controls.Add(this.middle_risk_fixed_count_tbx);
            this.Controls.Add(this.middle_risk_fixed_count_lbl);
            this.Controls.Add(this.middle_risk_checked_count_tbx);
            this.Controls.Add(this.middle_risk_checked_count_lbl);
            this.Controls.Add(this.middle_risk_ready_count_tbx);
            this.Controls.Add(this.middle_risk_ready_count_lbl);
            this.Controls.Add(this.ready_rule_tbx);
            this.Controls.Add(this.ready_rule_lbl);
            this.Controls.Add(this.high_risk_fixed_count_tbx);
            this.Controls.Add(this.high_risk_fixed_count_lbl);
            this.Controls.Add(this.high_risk_checked_count_tbx);
            this.Controls.Add(this.high_risk_checked_count_lbl);
            this.Controls.Add(this.high_risk_ready_count_tbx);
            this.Controls.Add(this.high_risk_ready_count_lbl);
            this.Controls.Add(this.fixed_rule_tbx);
            this.Controls.Add(this.fixed_rule_lbl);
            this.Controls.Add(this.checked_rule_tbx);
            this.Controls.Add(this.checked_rule_lbl);
            this.Controls.Add(this.total_rule_tbx);
            this.Controls.Add(this.total_rule_lbl);
            this.Controls.Add(this.save_rowdata_btn);
            this.Controls.Add(this.history_grv);
            this.Controls.Add(this.back_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "History";
            this.Sizable = false;
            this.Text = "ASET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.History_FormClosing);
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.history_grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading_side_pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton back_btn;
        private System.Windows.Forms.DataGridView history_grv;
        private MaterialSkin.Controls.MaterialRaisedButton save_rowdata_btn;
        private System.Windows.Forms.PictureBox loading_pbx;
        private System.Windows.Forms.PictureBox loading_side_pbx;
        private MaterialSkin.Controls.MaterialRaisedButton save_figure_btn;
        private System.Windows.Forms.Label title_tbx;
        private System.Windows.Forms.Label title_seperator_line;
        private MaterialSkin.Controls.MaterialLabel progress_lbl;
        private MaterialSkin.Controls.MaterialProgressBar progress_pgb;
        private MaterialSkin.Controls.MaterialLabel total_rule_lbl;
        private MaterialSkin.Controls.MaterialLabel low_risk_checked_count_lbl;
        private MaterialSkin.Controls.MaterialLabel low_risk_ready_count_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField low_risk_ready_count_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField low_risk_checked_count_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField low_risk_fixed_count_tbx;
        private MaterialSkin.Controls.MaterialLabel low_risk_fixed_count_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField middle_risk_fixed_count_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField middle_risk_checked_count_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField middle_risk_ready_count_tbx;
        private MaterialSkin.Controls.MaterialLabel middle_risk_ready_count_lbl;
        private MaterialSkin.Controls.MaterialLabel middle_risk_checked_count_lbl;
        private MaterialSkin.Controls.MaterialLabel middle_risk_fixed_count_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField high_risk_fixed_count_tbx;
        private MaterialSkin.Controls.MaterialLabel high_risk_fixed_count_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField high_risk_checked_count_tbx;
        private MaterialSkin.Controls.MaterialLabel high_risk_checked_count_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField high_risk_ready_count_tbx;
        private MaterialSkin.Controls.MaterialLabel high_risk_ready_count_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField fixed_rule_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField ready_rule_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField checked_rule_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField total_rule_tbx;
        private MaterialSkin.Controls.MaterialLabel fixed_rule_lbl;
        private MaterialSkin.Controls.MaterialLabel checked_rule_lbl;
        private MaterialSkin.Controls.MaterialLabel ready_rule_lbl;
        private System.Windows.Forms.Label report_lbl;
        private MaterialSkin.Controls.MaterialLabel na_rule_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField na_rule_tbx;
        private MaterialSkin.Controls.MaterialLabel high_risk_na_count_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField high_risk_na_count_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField middle_risk_na_count_tbx;
        private MaterialSkin.Controls.MaterialLabel middle_risk_na_count_lbl;
        private MaterialSkin.Controls.MaterialLabel low_risk_na_count_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField low_risk_na_count_tbx;
        private MaterialSkin.Controls.MaterialRaisedButton save_figure_csv_btn;
        private MaterialSkin.Controls.MaterialRaisedButton save_rowdata_csv_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn risk;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn check_sql;
        private System.Windows.Forms.DataGridViewTextBoxColumn fix;
        private System.Windows.Forms.DataGridViewTextBoxColumn fix_sql;
        private System.Windows.Forms.DataGridViewTextBoxColumn check_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn fix_result;
    }
}