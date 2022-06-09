namespace ASET
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.inspector_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.inspection_title_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.inspection_date_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.inspection_title_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inspector_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inspection_date_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.next_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.back_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.db_address_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.db_name_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.db_id_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.db_password_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.db_address_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.db_port_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.db_id_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.db_password_tbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loading_pbx = new System.Windows.Forms.PictureBox();
            this.loading_side_pbx = new System.Windows.Forms.PictureBox();
            this.inspection_step_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loading_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading_side_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // inspector_lbl
            // 
            this.inspector_lbl.AutoSize = true;
            this.inspector_lbl.Depth = 0;
            this.inspector_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.inspector_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inspector_lbl.Location = new System.Drawing.Point(183, 364);
            this.inspector_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.inspector_lbl.Name = "inspector_lbl";
            this.inspector_lbl.Size = new System.Drawing.Size(71, 18);
            this.inspector_lbl.TabIndex = 0;
            this.inspector_lbl.Text = "Inspector";
            // 
            // inspection_title_lbl
            // 
            this.inspection_title_lbl.AutoSize = true;
            this.inspection_title_lbl.Depth = 0;
            this.inspection_title_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.inspection_title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inspection_title_lbl.Location = new System.Drawing.Point(183, 237);
            this.inspection_title_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.inspection_title_lbl.Name = "inspection_title_lbl";
            this.inspection_title_lbl.Size = new System.Drawing.Size(108, 18);
            this.inspection_title_lbl.TabIndex = 1;
            this.inspection_title_lbl.Text = "Inspection title";
            // 
            // inspection_date_lbl
            // 
            this.inspection_date_lbl.AutoSize = true;
            this.inspection_date_lbl.Depth = 0;
            this.inspection_date_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.inspection_date_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inspection_date_lbl.Location = new System.Drawing.Point(183, 491);
            this.inspection_date_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.inspection_date_lbl.Name = "inspection_date_lbl";
            this.inspection_date_lbl.Size = new System.Drawing.Size(114, 18);
            this.inspection_date_lbl.TabIndex = 2;
            this.inspection_date_lbl.Text = "Inspection_date";
            // 
            // inspection_title_tbx
            // 
            this.inspection_title_tbx.Depth = 0;
            this.inspection_title_tbx.Enabled = false;
            this.inspection_title_tbx.Hint = "";
            this.inspection_title_tbx.Location = new System.Drawing.Point(325, 237);
            this.inspection_title_tbx.MaxLength = 32767;
            this.inspection_title_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.inspection_title_tbx.Name = "inspection_title_tbx";
            this.inspection_title_tbx.PasswordChar = '\0';
            this.inspection_title_tbx.SelectedText = "";
            this.inspection_title_tbx.SelectionLength = 0;
            this.inspection_title_tbx.SelectionStart = 0;
            this.inspection_title_tbx.Size = new System.Drawing.Size(207, 23);
            this.inspection_title_tbx.TabIndex = 3;
            this.inspection_title_tbx.TabStop = false;
            this.inspection_title_tbx.UseSystemPasswordChar = false;
            // 
            // inspector_tbx
            // 
            this.inspector_tbx.Depth = 0;
            this.inspector_tbx.Enabled = false;
            this.inspector_tbx.Hint = "";
            this.inspector_tbx.Location = new System.Drawing.Point(325, 364);
            this.inspector_tbx.MaxLength = 32767;
            this.inspector_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.inspector_tbx.Name = "inspector_tbx";
            this.inspector_tbx.PasswordChar = '\0';
            this.inspector_tbx.SelectedText = "";
            this.inspector_tbx.SelectionLength = 0;
            this.inspector_tbx.SelectionStart = 0;
            this.inspector_tbx.Size = new System.Drawing.Size(207, 23);
            this.inspector_tbx.TabIndex = 4;
            this.inspector_tbx.TabStop = false;
            this.inspector_tbx.UseSystemPasswordChar = false;
            // 
            // inspection_date_tbx
            // 
            this.inspection_date_tbx.Depth = 0;
            this.inspection_date_tbx.Enabled = false;
            this.inspection_date_tbx.Hint = "";
            this.inspection_date_tbx.Location = new System.Drawing.Point(325, 491);
            this.inspection_date_tbx.MaxLength = 32767;
            this.inspection_date_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.inspection_date_tbx.Name = "inspection_date_tbx";
            this.inspection_date_tbx.PasswordChar = '\0';
            this.inspection_date_tbx.SelectedText = "";
            this.inspection_date_tbx.SelectionLength = 0;
            this.inspection_date_tbx.SelectionStart = 0;
            this.inspection_date_tbx.Size = new System.Drawing.Size(207, 23);
            this.inspection_date_tbx.TabIndex = 5;
            this.inspection_date_tbx.TabStop = false;
            this.inspection_date_tbx.Text = "none";
            this.inspection_date_tbx.UseSystemPasswordChar = false;
            // 
            // next_btn
            // 
            this.next_btn.AutoSize = true;
            this.next_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.next_btn.Depth = 0;
            this.next_btn.Icon = null;
            this.next_btn.Location = new System.Drawing.Point(1240, 642);
            this.next_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.next_btn.Name = "next_btn";
            this.next_btn.Primary = true;
            this.next_btn.Size = new System.Drawing.Size(55, 36);
            this.next_btn.TabIndex = 6;
            this.next_btn.Text = "next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
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
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // db_address_lbl
            // 
            this.db_address_lbl.AutoSize = true;
            this.db_address_lbl.Depth = 0;
            this.db_address_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.db_address_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.db_address_lbl.Location = new System.Drawing.Point(797, 237);
            this.db_address_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.db_address_lbl.Name = "db_address_lbl";
            this.db_address_lbl.Size = new System.Drawing.Size(84, 18);
            this.db_address_lbl.TabIndex = 10;
            this.db_address_lbl.Text = "DB address";
            // 
            // db_name_lbl
            // 
            this.db_name_lbl.AutoSize = true;
            this.db_name_lbl.Depth = 0;
            this.db_name_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.db_name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.db_name_lbl.Location = new System.Drawing.Point(797, 321);
            this.db_name_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.db_name_lbl.Name = "db_name_lbl";
            this.db_name_lbl.Size = new System.Drawing.Size(93, 18);
            this.db_name_lbl.TabIndex = 11;
            this.db_name_lbl.Text = "Port Number";
            // 
            // db_id_lbl
            // 
            this.db_id_lbl.AutoSize = true;
            this.db_id_lbl.Depth = 0;
            this.db_id_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.db_id_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.db_id_lbl.Location = new System.Drawing.Point(797, 405);
            this.db_id_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.db_id_lbl.Name = "db_id_lbl";
            this.db_id_lbl.Size = new System.Drawing.Size(57, 18);
            this.db_id_lbl.TabIndex = 12;
            this.db_id_lbl.Text = "User ID";
            // 
            // db_password_lbl
            // 
            this.db_password_lbl.AutoSize = true;
            this.db_password_lbl.Depth = 0;
            this.db_password_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.db_password_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.db_password_lbl.Location = new System.Drawing.Point(797, 491);
            this.db_password_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.db_password_lbl.Name = "db_password_lbl";
            this.db_password_lbl.Size = new System.Drawing.Size(74, 18);
            this.db_password_lbl.TabIndex = 13;
            this.db_password_lbl.Text = "Password";
            // 
            // db_address_tbx
            // 
            this.db_address_tbx.Depth = 0;
            this.db_address_tbx.Hint = "";
            this.db_address_tbx.Location = new System.Drawing.Point(943, 237);
            this.db_address_tbx.MaxLength = 32767;
            this.db_address_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.db_address_tbx.Name = "db_address_tbx";
            this.db_address_tbx.PasswordChar = '\0';
            this.db_address_tbx.SelectedText = "";
            this.db_address_tbx.SelectionLength = 0;
            this.db_address_tbx.SelectionStart = 0;
            this.db_address_tbx.Size = new System.Drawing.Size(207, 23);
            this.db_address_tbx.TabIndex = 14;
            this.db_address_tbx.TabStop = false;
            this.db_address_tbx.Text = "34.123.223.155";
            this.db_address_tbx.UseSystemPasswordChar = false;
            // 
            // db_port_tbx
            // 
            this.db_port_tbx.Depth = 0;
            this.db_port_tbx.Hint = "";
            this.db_port_tbx.Location = new System.Drawing.Point(943, 321);
            this.db_port_tbx.MaxLength = 32767;
            this.db_port_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.db_port_tbx.Name = "db_port_tbx";
            this.db_port_tbx.PasswordChar = '\0';
            this.db_port_tbx.SelectedText = "";
            this.db_port_tbx.SelectionLength = 0;
            this.db_port_tbx.SelectionStart = 0;
            this.db_port_tbx.Size = new System.Drawing.Size(207, 23);
            this.db_port_tbx.TabIndex = 15;
            this.db_port_tbx.TabStop = false;
            this.db_port_tbx.Text = "1433";
            this.db_port_tbx.UseSystemPasswordChar = false;
            // 
            // db_id_tbx
            // 
            this.db_id_tbx.Depth = 0;
            this.db_id_tbx.Hint = "";
            this.db_id_tbx.Location = new System.Drawing.Point(943, 405);
            this.db_id_tbx.MaxLength = 32767;
            this.db_id_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.db_id_tbx.Name = "db_id_tbx";
            this.db_id_tbx.PasswordChar = '\0';
            this.db_id_tbx.SelectedText = "";
            this.db_id_tbx.SelectionLength = 0;
            this.db_id_tbx.SelectionStart = 0;
            this.db_id_tbx.Size = new System.Drawing.Size(207, 23);
            this.db_id_tbx.TabIndex = 16;
            this.db_id_tbx.TabStop = false;
            this.db_id_tbx.Text = "SA";
            this.db_id_tbx.UseSystemPasswordChar = false;
            // 
            // db_password_tbx
            // 
            this.db_password_tbx.Depth = 0;
            this.db_password_tbx.Hint = "";
            this.db_password_tbx.Location = new System.Drawing.Point(943, 491);
            this.db_password_tbx.MaxLength = 32767;
            this.db_password_tbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.db_password_tbx.Name = "db_password_tbx";
            this.db_password_tbx.PasswordChar = '*';
            this.db_password_tbx.SelectedText = "";
            this.db_password_tbx.SelectionLength = 0;
            this.db_password_tbx.SelectionStart = 0;
            this.db_password_tbx.Size = new System.Drawing.Size(207, 23);
            this.db_password_tbx.TabIndex = 17;
            this.db_password_tbx.TabStop = false;
            this.db_password_tbx.Text = "adminWhdtjd!";
            this.db_password_tbx.UseSystemPasswordChar = false;
            // 
            // loading_pbx
            // 
            this.loading_pbx.BackColor = System.Drawing.Color.Transparent;
            this.loading_pbx.Image = global::ASET.Properties.Resources.loading;
            this.loading_pbx.Location = new System.Drawing.Point(564, 311);
            this.loading_pbx.Name = "loading_pbx";
            this.loading_pbx.Size = new System.Drawing.Size(240, 177);
            this.loading_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading_pbx.TabIndex = 18;
            this.loading_pbx.TabStop = false;
            this.loading_pbx.Visible = false;
            // 
            // loading_side_pbx
            // 
            this.loading_side_pbx.BackColor = System.Drawing.Color.Transparent;
            this.loading_side_pbx.Location = new System.Drawing.Point(102, 190);
            this.loading_side_pbx.Name = "loading_side_pbx";
            this.loading_side_pbx.Size = new System.Drawing.Size(1150, 426);
            this.loading_side_pbx.TabIndex = 19;
            this.loading_side_pbx.TabStop = false;
            this.loading_side_pbx.Visible = false;
            // 
            // inspection_step_lbl
            // 
            this.inspection_step_lbl.AutoSize = true;
            this.inspection_step_lbl.BackColor = System.Drawing.Color.Transparent;
            this.inspection_step_lbl.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspection_step_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inspection_step_lbl.Location = new System.Drawing.Point(24, 116);
            this.inspection_step_lbl.Name = "inspection_step_lbl";
            this.inspection_step_lbl.Size = new System.Drawing.Size(278, 38);
            this.inspection_step_lbl.TabIndex = 20;
            this.inspection_step_lbl.Text = "Inspection Setting";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 700);
            this.Controls.Add(this.inspection_step_lbl);
            this.Controls.Add(this.loading_pbx);
            this.Controls.Add(this.loading_side_pbx);
            this.Controls.Add(this.db_password_tbx);
            this.Controls.Add(this.db_id_tbx);
            this.Controls.Add(this.db_port_tbx);
            this.Controls.Add(this.db_address_tbx);
            this.Controls.Add(this.db_password_lbl);
            this.Controls.Add(this.db_id_lbl);
            this.Controls.Add(this.db_name_lbl);
            this.Controls.Add(this.db_address_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.inspection_date_tbx);
            this.Controls.Add(this.inspector_tbx);
            this.Controls.Add(this.inspection_title_tbx);
            this.Controls.Add(this.inspection_date_lbl);
            this.Controls.Add(this.inspection_title_lbl);
            this.Controls.Add(this.inspector_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Setting";
            this.Sizable = false;
            this.Text = "ASET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.loading_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading_side_pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel inspector_lbl;
        private MaterialSkin.Controls.MaterialLabel inspection_title_lbl;
        private MaterialSkin.Controls.MaterialLabel inspection_date_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField inspection_title_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField inspector_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField inspection_date_tbx;
        private MaterialSkin.Controls.MaterialRaisedButton next_btn;
        private MaterialSkin.Controls.MaterialRaisedButton back_btn;
        private MaterialSkin.Controls.MaterialLabel db_address_lbl;
        private MaterialSkin.Controls.MaterialLabel db_name_lbl;
        private MaterialSkin.Controls.MaterialLabel db_id_lbl;
        private MaterialSkin.Controls.MaterialLabel db_password_lbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField db_address_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField db_port_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField db_id_tbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField db_password_tbx;
        private System.Windows.Forms.PictureBox loading_pbx;
        private System.Windows.Forms.PictureBox loading_side_pbx;
        private System.Windows.Forms.Label inspection_step_lbl;
    }
}