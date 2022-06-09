namespace ASET
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.new_Inspection_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Inspection_history_grv = new System.Windows.Forms.DataGridView();
            this.inspection_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.high_risk_fix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middle_risk_fix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.low_risk_fix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database_Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Report = new System.Windows.Forms.DataGridViewImageColumn();
            this.light_theme_radio_btn = new MaterialSkin.Controls.MaterialRadioButton();
            this.dark_theme_radio_btn = new MaterialSkin.Controls.MaterialRadioButton();
            this.close_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.inspection_step_lbl = new System.Windows.Forms.Label();
            this.language_toggle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Inspection_history_grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.language_toggle)).BeginInit();
            this.SuspendLayout();
            // 
            // new_Inspection_btn
            // 
            this.new_Inspection_btn.AutoSize = true;
            this.new_Inspection_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.new_Inspection_btn.Depth = 0;
            this.new_Inspection_btn.Font = new System.Drawing.Font("굴림", 12F);
            this.new_Inspection_btn.Icon = null;
            this.new_Inspection_btn.Location = new System.Drawing.Point(31, 92);
            this.new_Inspection_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.new_Inspection_btn.Name = "new_Inspection_btn";
            this.new_Inspection_btn.Primary = true;
            this.new_Inspection_btn.Size = new System.Drawing.Size(133, 36);
            this.new_Inspection_btn.TabIndex = 0;
            this.new_Inspection_btn.Text = "New Inspection";
            this.new_Inspection_btn.UseVisualStyleBackColor = true;
            this.new_Inspection_btn.Click += new System.EventHandler(this.new_Inspection_btn_Click);
            // 
            // Inspection_history_grv
            // 
            this.Inspection_history_grv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Inspection_history_grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inspection_history_grv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inspection_title,
            this.start_date,
            this.change_date,
            this.inspector,
            this.high_risk_fix,
            this.middle_risk_fix,
            this.low_risk_fix,
            this.log_keyword,
            this.database_Info,
            this.Edit,
            this.Delete,
            this.Report});
            this.Inspection_history_grv.Location = new System.Drawing.Point(31, 222);
            this.Inspection_history_grv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Inspection_history_grv.Name = "Inspection_history_grv";
            this.Inspection_history_grv.ReadOnly = true;
            this.Inspection_history_grv.RowHeadersVisible = false;
            this.Inspection_history_grv.RowTemplate.Height = 23;
            this.Inspection_history_grv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Inspection_history_grv.Size = new System.Drawing.Size(1279, 404);
            this.Inspection_history_grv.TabIndex = 1;
            this.Inspection_history_grv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Inspection_history_grv_CellContentClick);
            // 
            // inspection_title
            // 
            this.inspection_title.HeaderText = "Title";
            this.inspection_title.Name = "inspection_title";
            this.inspection_title.ReadOnly = true;
            this.inspection_title.Width = 180;
            // 
            // start_date
            // 
            this.start_date.HeaderText = "Start Date";
            this.start_date.Name = "start_date";
            this.start_date.ReadOnly = true;
            this.start_date.Width = 180;
            // 
            // change_date
            // 
            this.change_date.HeaderText = "Change Date";
            this.change_date.Name = "change_date";
            this.change_date.ReadOnly = true;
            this.change_date.Width = 180;
            // 
            // inspector
            // 
            this.inspector.HeaderText = "Inspector";
            this.inspector.Name = "inspector";
            this.inspector.ReadOnly = true;
            this.inspector.Width = 130;
            // 
            // high_risk_fix
            // 
            this.high_risk_fix.HeaderText = "High Risk";
            this.high_risk_fix.Name = "high_risk_fix";
            this.high_risk_fix.ReadOnly = true;
            this.high_risk_fix.Width = 120;
            // 
            // middle_risk_fix
            // 
            this.middle_risk_fix.HeaderText = "Middle Risk";
            this.middle_risk_fix.Name = "middle_risk_fix";
            this.middle_risk_fix.ReadOnly = true;
            this.middle_risk_fix.Width = 120;
            // 
            // low_risk_fix
            // 
            this.low_risk_fix.HeaderText = "Low Risk";
            this.low_risk_fix.Name = "low_risk_fix";
            this.low_risk_fix.ReadOnly = true;
            this.low_risk_fix.Width = 120;
            // 
            // log_keyword
            // 
            this.log_keyword.HeaderText = "Log_keyword";
            this.log_keyword.Name = "log_keyword";
            this.log_keyword.ReadOnly = true;
            this.log_keyword.Visible = false;
            this.log_keyword.Width = 150;
            // 
            // database_Info
            // 
            this.database_Info.HeaderText = "Database Info";
            this.database_Info.Name = "database_Info";
            this.database_Info.ReadOnly = true;
            this.database_Info.Visible = false;
            // 
            // Edit
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle7;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::ASET.Properties.Resources.run;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.ToolTipText = "edit";
            this.Edit.Width = 80;
            // 
            // Delete
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle8;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::ASET.Properties.Resources.delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.ToolTipText = "delete";
            this.Delete.Width = 80;
            // 
            // Report
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            this.Report.DefaultCellStyle = dataGridViewCellStyle9;
            this.Report.HeaderText = "Report";
            this.Report.Image = global::ASET.Properties.Resources.report;
            this.Report.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Report.Name = "Report";
            this.Report.ReadOnly = true;
            this.Report.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Report.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Report.ToolTipText = "report";
            this.Report.Width = 80;
            // 
            // light_theme_radio_btn
            // 
            this.light_theme_radio_btn.AutoSize = true;
            this.light_theme_radio_btn.Checked = true;
            this.light_theme_radio_btn.Depth = 0;
            this.light_theme_radio_btn.Font = new System.Drawing.Font("Roboto", 10F);
            this.light_theme_radio_btn.Location = new System.Drawing.Point(637, 317);
            this.light_theme_radio_btn.Margin = new System.Windows.Forms.Padding(0);
            this.light_theme_radio_btn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.light_theme_radio_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.light_theme_radio_btn.Name = "light_theme_radio_btn";
            this.light_theme_radio_btn.Ripple = true;
            this.light_theme_radio_btn.Size = new System.Drawing.Size(106, 30);
            this.light_theme_radio_btn.TabIndex = 7;
            this.light_theme_radio_btn.TabStop = true;
            this.light_theme_radio_btn.Text = "Light Theme";
            this.light_theme_radio_btn.UseVisualStyleBackColor = true;
            this.light_theme_radio_btn.Visible = false;
            this.light_theme_radio_btn.CheckedChanged += new System.EventHandler(this.light_theme_radio_btn_CheckedChanged);
            // 
            // dark_theme_radio_btn
            // 
            this.dark_theme_radio_btn.AutoSize = true;
            this.dark_theme_radio_btn.Depth = 0;
            this.dark_theme_radio_btn.Font = new System.Drawing.Font("Roboto", 10F);
            this.dark_theme_radio_btn.Location = new System.Drawing.Point(517, 317);
            this.dark_theme_radio_btn.Margin = new System.Windows.Forms.Padding(0);
            this.dark_theme_radio_btn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dark_theme_radio_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dark_theme_radio_btn.Name = "dark_theme_radio_btn";
            this.dark_theme_radio_btn.Ripple = true;
            this.dark_theme_radio_btn.Size = new System.Drawing.Size(103, 30);
            this.dark_theme_radio_btn.TabIndex = 6;
            this.dark_theme_radio_btn.Text = "Dark Theme";
            this.dark_theme_radio_btn.UseVisualStyleBackColor = true;
            this.dark_theme_radio_btn.Visible = false;
            this.dark_theme_radio_btn.CheckedChanged += new System.EventHandler(this.dark_theme_radio_btn_CheckedChanged);
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close_btn.Depth = 0;
            this.close_btn.Font = new System.Drawing.Font("굴림", 12F);
            this.close_btn.Icon = null;
            this.close_btn.Location = new System.Drawing.Point(1240, 642);
            this.close_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.close_btn.Name = "close_btn";
            this.close_btn.Primary = true;
            this.close_btn.Size = new System.Drawing.Size(63, 36);
            this.close_btn.TabIndex = 9;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // inspection_step_lbl
            // 
            this.inspection_step_lbl.AutoSize = true;
            this.inspection_step_lbl.BackColor = System.Drawing.Color.Transparent;
            this.inspection_step_lbl.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspection_step_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inspection_step_lbl.Location = new System.Drawing.Point(24, 165);
            this.inspection_step_lbl.Name = "inspection_step_lbl";
            this.inspection_step_lbl.Size = new System.Drawing.Size(279, 38);
            this.inspection_step_lbl.TabIndex = 10;
            this.inspection_step_lbl.Text = "Inspection History";
            // 
            // language_toggle
            // 
            this.language_toggle.Image = global::ASET.Properties.Resources.switch_off;
            this.language_toggle.Location = new System.Drawing.Point(1174, 167);
            this.language_toggle.Name = "language_toggle";
            this.language_toggle.Size = new System.Drawing.Size(129, 36);
            this.language_toggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.language_toggle.TabIndex = 11;
            this.language_toggle.TabStop = false;
            this.language_toggle.Click += new System.EventHandler(this.language_toggle_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 700);
            this.Controls.Add(this.language_toggle);
            this.Controls.Add(this.inspection_step_lbl);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.Inspection_history_grv);
            this.Controls.Add(this.new_Inspection_btn);
            this.Controls.Add(this.dark_theme_radio_btn);
            this.Controls.Add(this.light_theme_radio_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Sizable = false;
            this.Text = "ASET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inspection_history_grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.language_toggle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton new_Inspection_btn;
        private System.Windows.Forms.DataGridView Inspection_history_grv;
        private MaterialSkin.Controls.MaterialRadioButton light_theme_radio_btn;
        private MaterialSkin.Controls.MaterialRadioButton dark_theme_radio_btn;
        private MaterialSkin.Controls.MaterialRaisedButton close_btn;
        private System.Windows.Forms.Label inspection_step_lbl;
        private System.Windows.Forms.PictureBox language_toggle;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspection_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn change_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn high_risk_fix;
        private System.Windows.Forms.DataGridViewTextBoxColumn middle_risk_fix;
        private System.Windows.Forms.DataGridViewTextBoxColumn low_risk_fix;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn database_Info;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Report;
    }
}

