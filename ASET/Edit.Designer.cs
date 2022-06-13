namespace ASET
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.save_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.back_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.editor_tbx = new System.Windows.Forms.TextBox();
            this.recommendation_lvw = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recommend_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.AutoSize = true;
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.Depth = 0;
            this.save_btn.Icon = null;
            this.save_btn.Location = new System.Drawing.Point(827, 448);
            this.save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_btn.Name = "save_btn";
            this.save_btn.Primary = true;
            this.save_btn.Size = new System.Drawing.Size(55, 36);
            this.save_btn.TabIndex = 33;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.AutoSize = true;
            this.back_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_btn.Depth = 0;
            this.back_btn.Icon = null;
            this.back_btn.Location = new System.Drawing.Point(26, 448);
            this.back_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.back_btn.Name = "back_btn";
            this.back_btn.Primary = true;
            this.back_btn.Size = new System.Drawing.Size(56, 36);
            this.back_btn.TabIndex = 32;
            this.back_btn.Text = "back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // editor_tbx
            // 
            this.editor_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.editor_tbx.Location = new System.Drawing.Point(26, 87);
            this.editor_tbx.Multiline = true;
            this.editor_tbx.Name = "editor_tbx";
            this.editor_tbx.Size = new System.Drawing.Size(679, 340);
            this.editor_tbx.TabIndex = 34;
            // 
            // recommendation_lvw
            // 
            this.recommendation_lvw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recommendation_lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.recommendation_lvw.Depth = 0;
            this.recommendation_lvw.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.recommendation_lvw.FullRowSelect = true;
            this.recommendation_lvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.recommendation_lvw.HideSelection = false;
            this.recommendation_lvw.Location = new System.Drawing.Point(722, 119);
            this.recommendation_lvw.MouseLocation = new System.Drawing.Point(-1, -1);
            this.recommendation_lvw.MouseState = MaterialSkin.MouseState.OUT;
            this.recommendation_lvw.Name = "recommendation_lvw";
            this.recommendation_lvw.OwnerDraw = true;
            this.recommendation_lvw.Size = new System.Drawing.Size(192, 308);
            this.recommendation_lvw.TabIndex = 38;
            this.recommendation_lvw.UseCompatibleStateImageBehavior = false;
            this.recommendation_lvw.View = System.Windows.Forms.View.Details;
            this.recommendation_lvw.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.recommendation_lvw_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SQL Query";
            this.columnHeader1.Width = 450;
            // 
            // recommend_lbl
            // 
            this.recommend_lbl.AutoSize = true;
            this.recommend_lbl.Depth = 0;
            this.recommend_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.recommend_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.recommend_lbl.Location = new System.Drawing.Point(740, 87);
            this.recommend_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.recommend_lbl.Name = "recommend_lbl";
            this.recommend_lbl.Size = new System.Drawing.Size(145, 18);
            this.recommend_lbl.TabIndex = 39;
            this.recommend_lbl.Text = "Recommended word";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 504);
            this.Controls.Add(this.recommend_lbl);
            this.Controls.Add(this.recommendation_lvw);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.editor_tbx);
            this.Controls.Add(this.back_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Edit";
            this.Sizable = false;
            this.Text = "Query Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
            
        private MaterialSkin.Controls.MaterialRaisedButton save_btn;
        private MaterialSkin.Controls.MaterialRaisedButton back_btn;
        private System.Windows.Forms.TextBox editor_tbx;
        private MaterialSkin.Controls.MaterialListView recommendation_lvw;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialLabel recommend_lbl;
    }
}
