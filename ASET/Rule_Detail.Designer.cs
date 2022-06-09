namespace ASET
{
    partial class Rule_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rule_Detail));
            this.risk_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.back_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fix_lvw = new MaterialSkin.Controls.MaterialListView();
            this.fix_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fix_sql = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fix_query_execute_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.check_lvw = new MaterialSkin.Controls.MaterialListView();
            this.check_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.check_sql = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.check_query_execute_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.save_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.check_result_lvw = new MaterialSkin.Controls.MaterialListView();
            this.check_result_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.check_result_stae = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.check_result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fix_result_lvw = new MaterialSkin.Controls.MaterialListView();
            this.fix_result_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fix_result_state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fix_result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.check_result_delete_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fix_result_delete_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.status_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.fix_method_tbx = new System.Windows.Forms.TextBox();
            this.fix_query_edit_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.check_query_edit_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.check_result_edit_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.check_result_upload_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.check_result_lbl = new System.Windows.Forms.Label();
            this.check_lbl = new System.Windows.Forms.Label();
            this.check_knowhow_lbl = new System.Windows.Forms.Label();
            this.check_method_tbx = new System.Windows.Forms.TextBox();
            this.fix_result_edit_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fix_result_upload_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fix_result_lbl = new System.Windows.Forms.Label();
            this.fix_lbl = new System.Windows.Forms.Label();
            this.fix_knowhow_lbl = new System.Windows.Forms.Label();
            this.title_contents_tbx = new MaterialSkin.Controls.MaterialLabel();
            this.title_seperator_line = new System.Windows.Forms.Label();
            this.risk_pbx = new System.Windows.Forms.PictureBox();
            this.ready_status_lbl = new System.Windows.Forms.Label();
            this.checked_status_lbl = new System.Windows.Forms.Label();
            this.fixed_status_lbl = new System.Windows.Forms.Label();
            this.na_status_lbl = new System.Windows.Forms.Label();
            this.id_tbx = new System.Windows.Forms.Label();
            this.next_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.checkTab = new System.Windows.Forms.TabPage();
            this.fixTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.risk_pbx)).BeginInit();
            this.tabControl.SuspendLayout();
            this.checkTab.SuspendLayout();
            this.fixTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // risk_lbl
            // 
            this.risk_lbl.AutoSize = true;
            this.risk_lbl.Depth = 0;
            this.risk_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.risk_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.risk_lbl.Location = new System.Drawing.Point(30, 140);
            this.risk_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.risk_lbl.Name = "risk_lbl";
            this.risk_lbl.Size = new System.Drawing.Size(37, 18);
            this.risk_lbl.TabIndex = 16;
            this.risk_lbl.Text = "Risk";
            // 
            // back_btn
            // 
            this.back_btn.AutoSize = true;
            this.back_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_btn.Depth = 0;
            this.back_btn.Icon = null;
            this.back_btn.Location = new System.Drawing.Point(37, 641);
            this.back_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.back_btn.Name = "back_btn";
            this.back_btn.Primary = true;
            this.back_btn.Size = new System.Drawing.Size(56, 36);
            this.back_btn.TabIndex = 19;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // fix_lvw
            // 
            this.fix_lvw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fix_lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fix_number,
            this.fix_sql});
            this.fix_lvw.Depth = 0;
            this.fix_lvw.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.fix_lvw.FullRowSelect = true;
            this.fix_lvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.fix_lvw.HideSelection = false;
            this.fix_lvw.Location = new System.Drawing.Point(21, 233);
            this.fix_lvw.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fix_lvw.MouseState = MaterialSkin.MouseState.OUT;
            this.fix_lvw.MultiSelect = false;
            this.fix_lvw.Name = "fix_lvw";
            this.fix_lvw.OwnerDraw = true;
            this.fix_lvw.Size = new System.Drawing.Size(590, 123);
            this.fix_lvw.TabIndex = 23;
            this.fix_lvw.UseCompatibleStateImageBehavior = false;
            this.fix_lvw.View = System.Windows.Forms.View.Details;
            this.fix_lvw.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fix_lvw_MouseDoubleClick);
            // 
            // fix_number
            // 
            this.fix_number.Text = "number";
            // 
            // fix_sql
            // 
            this.fix_sql.Text = "query";
            this.fix_sql.Width = 5000;
            // 
            // fix_query_execute_btn
            // 
            this.fix_query_execute_btn.AutoSize = true;
            this.fix_query_execute_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fix_query_execute_btn.Depth = 0;
            this.fix_query_execute_btn.Icon = null;
            this.fix_query_execute_btn.Location = new System.Drawing.Point(516, 181);
            this.fix_query_execute_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.fix_query_execute_btn.Name = "fix_query_execute_btn";
            this.fix_query_execute_btn.Primary = true;
            this.fix_query_execute_btn.Size = new System.Drawing.Size(79, 36);
            this.fix_query_execute_btn.TabIndex = 30;
            this.fix_query_execute_btn.Text = "Execute";
            this.fix_query_execute_btn.UseVisualStyleBackColor = true;
            this.fix_query_execute_btn.Click += new System.EventHandler(this.fix_query_execute_btn_Click);
            // 
            // check_lvw
            // 
            this.check_lvw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.check_number,
            this.check_sql});
            this.check_lvw.Depth = 0;
            this.check_lvw.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_lvw.FullRowSelect = true;
            this.check_lvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.check_lvw.HideSelection = false;
            this.check_lvw.Location = new System.Drawing.Point(21, 233);
            this.check_lvw.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_lvw.MouseState = MaterialSkin.MouseState.OUT;
            this.check_lvw.MultiSelect = false;
            this.check_lvw.Name = "check_lvw";
            this.check_lvw.OwnerDraw = true;
            this.check_lvw.Size = new System.Drawing.Size(590, 123);
            this.check_lvw.TabIndex = 23;
            this.check_lvw.UseCompatibleStateImageBehavior = false;
            this.check_lvw.View = System.Windows.Forms.View.Details;
            this.check_lvw.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.check_lvw_MouseDoubleClick);
            // 
            // check_number
            // 
            this.check_number.Text = "number";
            // 
            // check_sql
            // 
            this.check_sql.Text = "query";
            this.check_sql.Width = 3000;
            // 
            // check_query_execute_btn
            // 
            this.check_query_execute_btn.AutoSize = true;
            this.check_query_execute_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.check_query_execute_btn.Depth = 0;
            this.check_query_execute_btn.Icon = null;
            this.check_query_execute_btn.Location = new System.Drawing.Point(516, 181);
            this.check_query_execute_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_query_execute_btn.Name = "check_query_execute_btn";
            this.check_query_execute_btn.Primary = true;
            this.check_query_execute_btn.Size = new System.Drawing.Size(79, 36);
            this.check_query_execute_btn.TabIndex = 28;
            this.check_query_execute_btn.Text = "Execute";
            this.check_query_execute_btn.UseVisualStyleBackColor = true;
            this.check_query_execute_btn.Click += new System.EventHandler(this.check_query_execute_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.AutoSize = true;
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.Depth = 0;
            this.save_btn.Icon = null;
            this.save_btn.Location = new System.Drawing.Point(1172, 641);
            this.save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_btn.Name = "save_btn";
            this.save_btn.Primary = true;
            this.save_btn.Size = new System.Drawing.Size(55, 36);
            this.save_btn.TabIndex = 31;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // check_result_lvw
            // 
            this.check_result_lvw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_result_lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.check_result_number,
            this.check_result_stae,
            this.check_result});
            this.check_result_lvw.Depth = 0;
            this.check_result_lvw.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_result_lvw.FullRowSelect = true;
            this.check_result_lvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.check_result_lvw.HideSelection = false;
            this.check_result_lvw.Location = new System.Drawing.Point(655, 233);
            this.check_result_lvw.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_result_lvw.MouseState = MaterialSkin.MouseState.OUT;
            this.check_result_lvw.MultiSelect = false;
            this.check_result_lvw.Name = "check_result_lvw";
            this.check_result_lvw.OwnerDraw = true;
            this.check_result_lvw.Size = new System.Drawing.Size(590, 123);
            this.check_result_lvw.TabIndex = 34;
            this.check_result_lvw.UseCompatibleStateImageBehavior = false;
            this.check_result_lvw.View = System.Windows.Forms.View.Details;
            this.check_result_lvw.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.check_result_lvw_MouseDoubleClick);
            // 
            // check_result_number
            // 
            this.check_result_number.Text = "number";
            this.check_result_number.Width = 51;
            // 
            // check_result_stae
            // 
            this.check_result_stae.Text = "state";
            this.check_result_stae.Width = 180;
            // 
            // check_result
            // 
            this.check_result.Text = "result";
            this.check_result.Width = 3000;
            // 
            // fix_result_lvw
            // 
            this.fix_result_lvw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fix_result_lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fix_result_number,
            this.fix_result_state,
            this.fix_result});
            this.fix_result_lvw.Depth = 0;
            this.fix_result_lvw.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.fix_result_lvw.FullRowSelect = true;
            this.fix_result_lvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.fix_result_lvw.HideSelection = false;
            this.fix_result_lvw.Location = new System.Drawing.Point(655, 233);
            this.fix_result_lvw.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fix_result_lvw.MouseState = MaterialSkin.MouseState.OUT;
            this.fix_result_lvw.MultiSelect = false;
            this.fix_result_lvw.Name = "fix_result_lvw";
            this.fix_result_lvw.OwnerDraw = true;
            this.fix_result_lvw.Size = new System.Drawing.Size(590, 123);
            this.fix_result_lvw.TabIndex = 35;
            this.fix_result_lvw.UseCompatibleStateImageBehavior = false;
            this.fix_result_lvw.View = System.Windows.Forms.View.Details;
            this.fix_result_lvw.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fix_result_lvw_MouseDoubleClick);
            // 
            // fix_result_number
            // 
            this.fix_result_number.Text = "number";
            // 
            // fix_result_state
            // 
            this.fix_result_state.Text = "state";
            this.fix_result_state.Width = 180;
            // 
            // fix_result
            // 
            this.fix_result.Text = "result";
            this.fix_result.Width = 5000;
            // 
            // check_result_delete_btn
            // 
            this.check_result_delete_btn.AutoSize = true;
            this.check_result_delete_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.check_result_delete_btn.Depth = 0;
            this.check_result_delete_btn.Icon = null;
            this.check_result_delete_btn.Location = new System.Drawing.Point(1176, 181);
            this.check_result_delete_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_result_delete_btn.Name = "check_result_delete_btn";
            this.check_result_delete_btn.Primary = true;
            this.check_result_delete_btn.Size = new System.Drawing.Size(69, 36);
            this.check_result_delete_btn.TabIndex = 38;
            this.check_result_delete_btn.Text = "delete";
            this.check_result_delete_btn.UseVisualStyleBackColor = true;
            this.check_result_delete_btn.Click += new System.EventHandler(this.check_result_delete_btn_Click);
            // 
            // fix_result_delete_btn
            // 
            this.fix_result_delete_btn.AutoSize = true;
            this.fix_result_delete_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fix_result_delete_btn.Depth = 0;
            this.fix_result_delete_btn.Icon = null;
            this.fix_result_delete_btn.Location = new System.Drawing.Point(1176, 181);
            this.fix_result_delete_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.fix_result_delete_btn.Name = "fix_result_delete_btn";
            this.fix_result_delete_btn.Primary = true;
            this.fix_result_delete_btn.Size = new System.Drawing.Size(69, 36);
            this.fix_result_delete_btn.TabIndex = 39;
            this.fix_result_delete_btn.Text = "delete";
            this.fix_result_delete_btn.UseVisualStyleBackColor = true;
            this.fix_result_delete_btn.Click += new System.EventHandler(this.fix_result_delete_btn_Click);
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Depth = 0;
            this.status_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.status_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.status_lbl.Location = new System.Drawing.Point(218, 140);
            this.status_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(51, 18);
            this.status_lbl.TabIndex = 40;
            this.status_lbl.Text = "Status";
            // 
            // fix_method_tbx
            // 
            this.fix_method_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fix_method_tbx.Font = new System.Drawing.Font("Roboto", 12F);
            this.fix_method_tbx.Location = new System.Drawing.Point(21, 50);
            this.fix_method_tbx.Multiline = true;
            this.fix_method_tbx.Name = "fix_method_tbx";
            this.fix_method_tbx.ReadOnly = true;
            this.fix_method_tbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fix_method_tbx.Size = new System.Drawing.Size(1224, 115);
            this.fix_method_tbx.TabIndex = 49;
            // 
            // fix_query_edit_btn
            // 
            this.fix_query_edit_btn.AutoSize = true;
            this.fix_query_edit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fix_query_edit_btn.Depth = 0;
            this.fix_query_edit_btn.Icon = null;
            this.fix_query_edit_btn.Location = new System.Drawing.Point(452, 181);
            this.fix_query_edit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.fix_query_edit_btn.Name = "fix_query_edit_btn";
            this.fix_query_edit_btn.Primary = true;
            this.fix_query_edit_btn.Size = new System.Drawing.Size(50, 36);
            this.fix_query_edit_btn.TabIndex = 51;
            this.fix_query_edit_btn.Text = "Edit";
            this.fix_query_edit_btn.UseVisualStyleBackColor = true;
            this.fix_query_edit_btn.Click += new System.EventHandler(this.fix_query_edit_btn_Click);
            // 
            // check_query_edit_btn
            // 
            this.check_query_edit_btn.AutoSize = true;
            this.check_query_edit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.check_query_edit_btn.Depth = 0;
            this.check_query_edit_btn.Icon = null;
            this.check_query_edit_btn.Location = new System.Drawing.Point(452, 181);
            this.check_query_edit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_query_edit_btn.Name = "check_query_edit_btn";
            this.check_query_edit_btn.Primary = true;
            this.check_query_edit_btn.Size = new System.Drawing.Size(50, 36);
            this.check_query_edit_btn.TabIndex = 52;
            this.check_query_edit_btn.Text = "edit";
            this.check_query_edit_btn.UseVisualStyleBackColor = true;
            this.check_query_edit_btn.Click += new System.EventHandler(this.check_query_edit_btn_Click);
            // 
            // check_result_edit_btn
            // 
            this.check_result_edit_btn.AutoSize = true;
            this.check_result_edit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.check_result_edit_btn.Depth = 0;
            this.check_result_edit_btn.Icon = null;
            this.check_result_edit_btn.Location = new System.Drawing.Point(1111, 181);
            this.check_result_edit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_result_edit_btn.Name = "check_result_edit_btn";
            this.check_result_edit_btn.Primary = true;
            this.check_result_edit_btn.Size = new System.Drawing.Size(50, 36);
            this.check_result_edit_btn.TabIndex = 61;
            this.check_result_edit_btn.Text = "edit";
            this.check_result_edit_btn.UseVisualStyleBackColor = true;
            this.check_result_edit_btn.Click += new System.EventHandler(this.check_result_edit_btn_Click);
            // 
            // check_result_upload_btn
            // 
            this.check_result_upload_btn.AutoSize = true;
            this.check_result_upload_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.check_result_upload_btn.Depth = 0;
            this.check_result_upload_btn.Icon = null;
            this.check_result_upload_btn.Location = new System.Drawing.Point(992, 181);
            this.check_result_upload_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_result_upload_btn.Name = "check_result_upload_btn";
            this.check_result_upload_btn.Primary = true;
            this.check_result_upload_btn.Size = new System.Drawing.Size(104, 36);
            this.check_result_upload_btn.TabIndex = 60;
            this.check_result_upload_btn.Text = "File UPLOAD";
            this.check_result_upload_btn.UseVisualStyleBackColor = true;
            this.check_result_upload_btn.Click += new System.EventHandler(this.check_result_upload_btn_Click);
            // 
            // check_result_lbl
            // 
            this.check_result_lbl.AutoSize = true;
            this.check_result_lbl.BackColor = System.Drawing.Color.Transparent;
            this.check_result_lbl.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_result_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.check_result_lbl.Location = new System.Drawing.Point(650, 188);
            this.check_result_lbl.Name = "check_result_lbl";
            this.check_result_lbl.Size = new System.Drawing.Size(80, 29);
            this.check_result_lbl.TabIndex = 60;
            this.check_result_lbl.Text = "Result";
            // 
            // check_lbl
            // 
            this.check_lbl.AutoSize = true;
            this.check_lbl.BackColor = System.Drawing.Color.Transparent;
            this.check_lbl.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.check_lbl.Location = new System.Drawing.Point(16, 188);
            this.check_lbl.Name = "check_lbl";
            this.check_lbl.Size = new System.Drawing.Size(199, 29);
            this.check_lbl.TabIndex = 59;
            this.check_lbl.Text = "Automatic Check";
            // 
            // check_knowhow_lbl
            // 
            this.check_knowhow_lbl.AutoSize = true;
            this.check_knowhow_lbl.BackColor = System.Drawing.Color.Transparent;
            this.check_knowhow_lbl.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_knowhow_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.check_knowhow_lbl.Location = new System.Drawing.Point(16, 11);
            this.check_knowhow_lbl.Name = "check_knowhow_lbl";
            this.check_knowhow_lbl.Size = new System.Drawing.Size(127, 29);
            this.check_knowhow_lbl.TabIndex = 58;
            this.check_knowhow_lbl.Text = "Know-how";
            // 
            // check_method_tbx
            // 
            this.check_method_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.check_method_tbx.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_method_tbx.Location = new System.Drawing.Point(21, 50);
            this.check_method_tbx.Multiline = true;
            this.check_method_tbx.Name = "check_method_tbx";
            this.check_method_tbx.ReadOnly = true;
            this.check_method_tbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.check_method_tbx.Size = new System.Drawing.Size(1224, 115);
            this.check_method_tbx.TabIndex = 54;
            // 
            // fix_result_edit_btn
            // 
            this.fix_result_edit_btn.AutoSize = true;
            this.fix_result_edit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fix_result_edit_btn.Depth = 0;
            this.fix_result_edit_btn.Icon = null;
            this.fix_result_edit_btn.Location = new System.Drawing.Point(1111, 181);
            this.fix_result_edit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.fix_result_edit_btn.Name = "fix_result_edit_btn";
            this.fix_result_edit_btn.Primary = true;
            this.fix_result_edit_btn.Size = new System.Drawing.Size(50, 36);
            this.fix_result_edit_btn.TabIndex = 63;
            this.fix_result_edit_btn.Text = "edit";
            this.fix_result_edit_btn.UseVisualStyleBackColor = true;
            this.fix_result_edit_btn.Click += new System.EventHandler(this.fix_result_edit_btn_Click);
            // 
            // fix_result_upload_btn
            // 
            this.fix_result_upload_btn.AutoSize = true;
            this.fix_result_upload_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fix_result_upload_btn.Depth = 0;
            this.fix_result_upload_btn.Icon = null;
            this.fix_result_upload_btn.Location = new System.Drawing.Point(992, 181);
            this.fix_result_upload_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.fix_result_upload_btn.Name = "fix_result_upload_btn";
            this.fix_result_upload_btn.Primary = true;
            this.fix_result_upload_btn.Size = new System.Drawing.Size(104, 36);
            this.fix_result_upload_btn.TabIndex = 62;
            this.fix_result_upload_btn.Text = "File UPLOAD";
            this.fix_result_upload_btn.UseVisualStyleBackColor = true;
            this.fix_result_upload_btn.Click += new System.EventHandler(this.fix_result_upload_btn_Click);
            // 
            // fix_result_lbl
            // 
            this.fix_result_lbl.AutoSize = true;
            this.fix_result_lbl.BackColor = System.Drawing.Color.Transparent;
            this.fix_result_lbl.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.fix_result_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fix_result_lbl.Location = new System.Drawing.Point(650, 188);
            this.fix_result_lbl.Name = "fix_result_lbl";
            this.fix_result_lbl.Size = new System.Drawing.Size(80, 29);
            this.fix_result_lbl.TabIndex = 61;
            this.fix_result_lbl.Text = "Result";
            // 
            // fix_lbl
            // 
            this.fix_lbl.AutoSize = true;
            this.fix_lbl.BackColor = System.Drawing.Color.Transparent;
            this.fix_lbl.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.fix_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fix_lbl.Location = new System.Drawing.Point(16, 188);
            this.fix_lbl.Name = "fix_lbl";
            this.fix_lbl.Size = new System.Drawing.Size(162, 29);
            this.fix_lbl.TabIndex = 60;
            this.fix_lbl.Text = "Automatic Fix";
            // 
            // fix_knowhow_lbl
            // 
            this.fix_knowhow_lbl.AutoSize = true;
            this.fix_knowhow_lbl.BackColor = System.Drawing.Color.Transparent;
            this.fix_knowhow_lbl.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.fix_knowhow_lbl.Location = new System.Drawing.Point(16, 11);
            this.fix_knowhow_lbl.Name = "fix_knowhow_lbl";
            this.fix_knowhow_lbl.Size = new System.Drawing.Size(127, 29);
            this.fix_knowhow_lbl.TabIndex = 59;
            this.fix_knowhow_lbl.Text = "Know-how";
            // 
            // title_contents_tbx
            // 
            this.title_contents_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_contents_tbx.Depth = 0;
            this.title_contents_tbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.title_contents_tbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.title_contents_tbx.Location = new System.Drawing.Point(30, 174);
            this.title_contents_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.title_contents_tbx.Name = "title_contents_tbx";
            this.title_contents_tbx.Size = new System.Drawing.Size(1267, 21);
            this.title_contents_tbx.TabIndex = 52;
            this.title_contents_tbx.Text = "none";
            // 
            // title_seperator_line
            // 
            this.title_seperator_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title_seperator_line.Location = new System.Drawing.Point(32, 118);
            this.title_seperator_line.Name = "title_seperator_line";
            this.title_seperator_line.Size = new System.Drawing.Size(180, 2);
            this.title_seperator_line.TabIndex = 55;
            // 
            // risk_pbx
            // 
            this.risk_pbx.Image = global::ASET.Properties.Resources.three_star;
            this.risk_pbx.Location = new System.Drawing.Point(102, 132);
            this.risk_pbx.Name = "risk_pbx";
            this.risk_pbx.Size = new System.Drawing.Size(85, 31);
            this.risk_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.risk_pbx.TabIndex = 56;
            this.risk_pbx.TabStop = false;
            // 
            // ready_status_lbl
            // 
            this.ready_status_lbl.AutoSize = true;
            this.ready_status_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ready_status_lbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ready_status_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.ready_status_lbl.Location = new System.Drawing.Point(286, 140);
            this.ready_status_lbl.Name = "ready_status_lbl";
            this.ready_status_lbl.Size = new System.Drawing.Size(53, 20);
            this.ready_status_lbl.TabIndex = 62;
            this.ready_status_lbl.Text = "Ready";
            // 
            // checked_status_lbl
            // 
            this.checked_status_lbl.AutoSize = true;
            this.checked_status_lbl.BackColor = System.Drawing.Color.Transparent;
            this.checked_status_lbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checked_status_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.checked_status_lbl.Location = new System.Drawing.Point(379, 140);
            this.checked_status_lbl.Name = "checked_status_lbl";
            this.checked_status_lbl.Size = new System.Drawing.Size(69, 20);
            this.checked_status_lbl.TabIndex = 63;
            this.checked_status_lbl.Text = "Checked";
            // 
            // fixed_status_lbl
            // 
            this.fixed_status_lbl.AutoSize = true;
            this.fixed_status_lbl.BackColor = System.Drawing.Color.Transparent;
            this.fixed_status_lbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixed_status_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.fixed_status_lbl.Location = new System.Drawing.Point(488, 140);
            this.fixed_status_lbl.Name = "fixed_status_lbl";
            this.fixed_status_lbl.Size = new System.Drawing.Size(47, 20);
            this.fixed_status_lbl.TabIndex = 64;
            this.fixed_status_lbl.Text = "Fixed";
            // 
            // na_status_lbl
            // 
            this.na_status_lbl.AutoSize = true;
            this.na_status_lbl.BackColor = System.Drawing.Color.Transparent;
            this.na_status_lbl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.na_status_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.na_status_lbl.Location = new System.Drawing.Point(575, 140);
            this.na_status_lbl.Name = "na_status_lbl";
            this.na_status_lbl.Size = new System.Drawing.Size(37, 20);
            this.na_status_lbl.TabIndex = 65;
            this.na_status_lbl.Text = "N/A";
            // 
            // id_tbx
            // 
            this.id_tbx.AutoSize = true;
            this.id_tbx.BackColor = System.Drawing.Color.Transparent;
            this.id_tbx.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tbx.ForeColor = System.Drawing.SystemColors.WindowText;
            this.id_tbx.Location = new System.Drawing.Point(24, 76);
            this.id_tbx.Name = "id_tbx";
            this.id_tbx.Size = new System.Drawing.Size(167, 38);
            this.id_tbx.TabIndex = 66;
            this.id_tbx.Text = "Inspection";
            // 
            // next_btn
            // 
            this.next_btn.AutoSize = true;
            this.next_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.next_btn.Depth = 0;
            this.next_btn.Icon = null;
            this.next_btn.Location = new System.Drawing.Point(1246, 641);
            this.next_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.next_btn.Name = "next_btn";
            this.next_btn.Primary = true;
            this.next_btn.Size = new System.Drawing.Size(55, 36);
            this.next_btn.TabIndex = 67;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.checkTab);
            this.tabControl.Controls.Add(this.fixTab);
            this.tabControl.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl.Location = new System.Drawing.Point(31, 210);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1270, 416);
            this.tabControl.TabIndex = 68;
            // 
            // checkTab
            // 
            this.checkTab.Controls.Add(this.check_result_edit_btn);
            this.checkTab.Controls.Add(this.check_result_upload_btn);
            this.checkTab.Controls.Add(this.check_method_tbx);
            this.checkTab.Controls.Add(this.check_query_edit_btn);
            this.checkTab.Controls.Add(this.check_knowhow_lbl);
            this.checkTab.Controls.Add(this.check_lvw);
            this.checkTab.Controls.Add(this.check_lbl);
            this.checkTab.Controls.Add(this.check_result_lvw);
            this.checkTab.Controls.Add(this.check_result_lbl);
            this.checkTab.Controls.Add(this.check_result_delete_btn);
            this.checkTab.Controls.Add(this.check_query_execute_btn);
            this.checkTab.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkTab.Location = new System.Drawing.Point(4, 30);
            this.checkTab.Name = "checkTab";
            this.checkTab.Padding = new System.Windows.Forms.Padding(3);
            this.checkTab.Size = new System.Drawing.Size(1262, 382);
            this.checkTab.TabIndex = 0;
            this.checkTab.Text = "Check";
            this.checkTab.UseVisualStyleBackColor = true;
            // 
            // fixTab
            // 
            this.fixTab.Controls.Add(this.fix_method_tbx);
            this.fixTab.Controls.Add(this.fix_result_lvw);
            this.fixTab.Controls.Add(this.fix_result_delete_btn);
            this.fixTab.Controls.Add(this.fix_result_edit_btn);
            this.fixTab.Controls.Add(this.fix_query_execute_btn);
            this.fixTab.Controls.Add(this.fix_knowhow_lbl);
            this.fixTab.Controls.Add(this.fix_result_lbl);
            this.fixTab.Controls.Add(this.fix_lvw);
            this.fixTab.Controls.Add(this.fix_lbl);
            this.fixTab.Controls.Add(this.fix_result_upload_btn);
            this.fixTab.Controls.Add(this.fix_query_edit_btn);
            this.fixTab.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fixTab.Location = new System.Drawing.Point(4, 30);
            this.fixTab.Name = "fixTab";
            this.fixTab.Padding = new System.Windows.Forms.Padding(3);
            this.fixTab.Size = new System.Drawing.Size(1262, 382);
            this.fixTab.TabIndex = 1;
            this.fixTab.Text = "Fix";
            this.fixTab.UseVisualStyleBackColor = true;
            // 
            // Rule_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1344, 700);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.id_tbx);
            this.Controls.Add(this.na_status_lbl);
            this.Controls.Add(this.fixed_status_lbl);
            this.Controls.Add(this.checked_status_lbl);
            this.Controls.Add(this.ready_status_lbl);
            this.Controls.Add(this.risk_pbx);
            this.Controls.Add(this.title_seperator_line);
            this.Controls.Add(this.title_contents_tbx);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.risk_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Rule_Detail";
            this.Sizable = false;
            this.Text = "ASET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rule_Detail_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.risk_pbx)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.checkTab.ResumeLayout(false);
            this.checkTab.PerformLayout();
            this.fixTab.ResumeLayout(false);
            this.fixTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel risk_lbl;
        private MaterialSkin.Controls.MaterialRaisedButton back_btn;
        private MaterialSkin.Controls.MaterialListView fix_lvw;
        private MaterialSkin.Controls.MaterialRaisedButton fix_query_execute_btn;
        private MaterialSkin.Controls.MaterialListView check_lvw;
        private MaterialSkin.Controls.MaterialRaisedButton check_query_execute_btn;
        private System.Windows.Forms.ColumnHeader check_sql;
        private System.Windows.Forms.ColumnHeader fix_sql;
        private MaterialSkin.Controls.MaterialRaisedButton save_btn;
        private MaterialSkin.Controls.MaterialListView check_result_lvw;
        private System.Windows.Forms.ColumnHeader check_result;
        private MaterialSkin.Controls.MaterialListView fix_result_lvw;
        private System.Windows.Forms.ColumnHeader fix_result;
        private MaterialSkin.Controls.MaterialRaisedButton check_result_delete_btn;
        private MaterialSkin.Controls.MaterialRaisedButton fix_result_delete_btn;
        private MaterialSkin.Controls.MaterialLabel status_lbl;
        private System.Windows.Forms.TextBox fix_method_tbx;
        private MaterialSkin.Controls.MaterialRaisedButton fix_query_edit_btn;
        private MaterialSkin.Controls.MaterialRaisedButton check_query_edit_btn;
        private MaterialSkin.Controls.MaterialLabel title_contents_tbx;
        private System.Windows.Forms.TextBox check_method_tbx;
        private System.Windows.Forms.Label title_seperator_line;
        private System.Windows.Forms.PictureBox risk_pbx;
        private System.Windows.Forms.Label check_knowhow_lbl;
        private System.Windows.Forms.Label fix_knowhow_lbl;
        private System.Windows.Forms.Label check_result_lbl;
        private System.Windows.Forms.Label check_lbl;
        private System.Windows.Forms.Label fix_result_lbl;
        private System.Windows.Forms.Label fix_lbl;
        private MaterialSkin.Controls.MaterialRaisedButton check_result_upload_btn;
        private MaterialSkin.Controls.MaterialRaisedButton check_result_edit_btn;
        private MaterialSkin.Controls.MaterialRaisedButton fix_result_edit_btn;
        private MaterialSkin.Controls.MaterialRaisedButton fix_result_upload_btn;
        private System.Windows.Forms.ColumnHeader check_number;
        private System.Windows.Forms.ColumnHeader check_result_number;
        private System.Windows.Forms.ColumnHeader fix_result_number;
        private System.Windows.Forms.ColumnHeader fix_number;
        private System.Windows.Forms.ColumnHeader check_result_stae;
        private System.Windows.Forms.ColumnHeader fix_result_state;
        private System.Windows.Forms.Label ready_status_lbl;
        private System.Windows.Forms.Label checked_status_lbl;
        private System.Windows.Forms.Label fixed_status_lbl;
        private System.Windows.Forms.Label na_status_lbl;
        private System.Windows.Forms.Label id_tbx;
        private MaterialSkin.Controls.MaterialRaisedButton next_btn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage checkTab;
        private System.Windows.Forms.TabPage fixTab;
    }
}