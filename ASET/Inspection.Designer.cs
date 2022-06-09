namespace ASET
{
    partial class Inspection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inspection));
            this.inspection_pgb = new MaterialSkin.Controls.MaterialProgressBar();
            this.total_rule_grv = new System.Windows.Forms.DataGridView();
            this.fin_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.auto_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.back_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.inspection_step_lbl = new System.Windows.Forms.Label();
            this.loading_pbx = new System.Windows.Forms.PictureBox();
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
            this.Ready = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fixed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.total_rule_grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // inspection_pgb
            // 
            this.inspection_pgb.Depth = 0;
            this.inspection_pgb.Location = new System.Drawing.Point(42, 164);
            this.inspection_pgb.Maximum = 3;
            this.inspection_pgb.MouseState = MaterialSkin.MouseState.HOVER;
            this.inspection_pgb.Name = "inspection_pgb";
            this.inspection_pgb.Size = new System.Drawing.Size(1253, 5);
            this.inspection_pgb.TabIndex = 10;
            // 
            // total_rule_grv
            // 
            this.total_rule_grv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.total_rule_grv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.risk,
            this.title,
            this.status,
            this.check,
            this.check_sql,
            this.fix,
            this.fix_sql,
            this.check_result,
            this.fix_result,
            this.Ready,
            this.Checked,
            this.Fixed,
            this.NA,
            this.Edit});
            this.total_rule_grv.Location = new System.Drawing.Point(41, 187);
            this.total_rule_grv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.total_rule_grv.MultiSelect = false;
            this.total_rule_grv.Name = "total_rule_grv";
            this.total_rule_grv.ReadOnly = true;
            this.total_rule_grv.RowTemplate.Height = 23;
            this.total_rule_grv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.total_rule_grv.Size = new System.Drawing.Size(1261, 428);
            this.total_rule_grv.TabIndex = 12;
            this.total_rule_grv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.total_rule_grv_CellContentClick);
            this.total_rule_grv.SelectionChanged += new System.EventHandler(this.total_rule_grv_SelectionChanged);
            // 
            // fin_btn
            // 
            this.fin_btn.AutoSize = true;
            this.fin_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fin_btn.Depth = 0;
            this.fin_btn.Icon = null;
            this.fin_btn.Location = new System.Drawing.Point(1217, 642);
            this.fin_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.fin_btn.Name = "fin_btn";
            this.fin_btn.Primary = true;
            this.fin_btn.Size = new System.Drawing.Size(55, 36);
            this.fin_btn.TabIndex = 13;
            this.fin_btn.Text = "NEXT";
            this.fin_btn.UseVisualStyleBackColor = true;
            this.fin_btn.Click += new System.EventHandler(this.fin_btn_Click);
            // 
            // auto_btn
            // 
            this.auto_btn.AutoSize = true;
            this.auto_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.auto_btn.Depth = 0;
            this.auto_btn.Icon = null;
            this.auto_btn.Location = new System.Drawing.Point(1215, 113);
            this.auto_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.auto_btn.Name = "auto_btn";
            this.auto_btn.Primary = true;
            this.auto_btn.Size = new System.Drawing.Size(57, 36);
            this.auto_btn.TabIndex = 15;
            this.auto_btn.Text = "auto";
            this.auto_btn.UseVisualStyleBackColor = true;
            this.auto_btn.Click += new System.EventHandler(this.auto_btn_Click);
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
            this.back_btn.TabIndex = 16;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // inspection_step_lbl
            // 
            this.inspection_step_lbl.AutoSize = true;
            this.inspection_step_lbl.BackColor = System.Drawing.Color.Transparent;
            this.inspection_step_lbl.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspection_step_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inspection_step_lbl.Location = new System.Drawing.Point(35, 113);
            this.inspection_step_lbl.Name = "inspection_step_lbl";
            this.inspection_step_lbl.Size = new System.Drawing.Size(167, 38);
            this.inspection_step_lbl.TabIndex = 21;
            this.inspection_step_lbl.Text = "Inspection";
            // 
            // loading_pbx
            // 
            this.loading_pbx.BackColor = System.Drawing.Color.Transparent;
            this.loading_pbx.Image = global::ASET.Properties.Resources.loading;
            this.loading_pbx.Location = new System.Drawing.Point(537, 287);
            this.loading_pbx.Name = "loading_pbx";
            this.loading_pbx.Size = new System.Drawing.Size(308, 224);
            this.loading_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading_pbx.TabIndex = 22;
            this.loading_pbx.TabStop = false;
            this.loading_pbx.Visible = false;
            // 
            // id
            // 
            this.id.FillWeight = 150F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 120;
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
            this.title.Width = 570;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Visible = false;
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
            // 
            // check_result
            // 
            this.check_result.HeaderText = "check_result";
            this.check_result.Name = "check_result";
            this.check_result.ReadOnly = true;
            this.check_result.Visible = false;
            // 
            // fix_result
            // 
            this.fix_result.HeaderText = "fix_result";
            this.fix_result.Name = "fix_result";
            this.fix_result.ReadOnly = true;
            this.fix_result.Visible = false;
            // 
            // Ready
            // 
            this.Ready.HeaderText = "Ready";
            this.Ready.Name = "Ready";
            this.Ready.ReadOnly = true;
            this.Ready.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ready.Width = 80;
            // 
            // Checked
            // 
            this.Checked.HeaderText = "Checked";
            this.Checked.Name = "Checked";
            this.Checked.ReadOnly = true;
            this.Checked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Checked.Width = 80;
            // 
            // Fixed
            // 
            this.Fixed.HeaderText = "Fixed";
            this.Fixed.Name = "Fixed";
            this.Fixed.ReadOnly = true;
            this.Fixed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fixed.Width = 80;
            // 
            // NA
            // 
            this.NA.HeaderText = "N/A";
            this.NA.Name = "NA";
            this.NA.ReadOnly = true;
            this.NA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NA.Width = 80;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::ASET.Properties.Resources.run;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Inspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 700);
            this.Controls.Add(this.loading_pbx);
            this.Controls.Add(this.inspection_step_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.auto_btn);
            this.Controls.Add(this.fin_btn);
            this.Controls.Add(this.total_rule_grv);
            this.Controls.Add(this.inspection_pgb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inspection";
            this.Sizable = false;
            this.Text = "ASET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inspection_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.total_rule_grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading_pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialProgressBar inspection_pgb;
        private System.Windows.Forms.DataGridView total_rule_grv;
        private MaterialSkin.Controls.MaterialRaisedButton fin_btn;
        private MaterialSkin.Controls.MaterialRaisedButton auto_btn;
        private MaterialSkin.Controls.MaterialRaisedButton back_btn;
        private System.Windows.Forms.Label inspection_step_lbl;
        private System.Windows.Forms.PictureBox loading_pbx;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Ready;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fixed;
        private System.Windows.Forms.DataGridViewTextBoxColumn NA;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}