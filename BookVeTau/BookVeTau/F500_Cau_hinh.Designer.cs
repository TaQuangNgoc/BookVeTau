namespace BookVeTau
{
    partial class F500_Cau_hinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.m_txt_thu_muc_hn_lc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.m_cmd_hn_lc = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.m_txt_thu_muc_lc_hn = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.m_cmd_lc_hn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialRaisedButton3);
            this.panel1.Controls.Add(this.m_cmd_lc_hn);
            this.panel1.Controls.Add(this.m_cmd_hn_lc);
            this.panel1.Controls.Add(this.m_txt_thu_muc_lc_hn);
            this.panel1.Controls.Add(this.m_txt_thu_muc_hn_lc);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 393);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(62, 58);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(124, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Thư mục HN - LC";
            // 
            // m_txt_thu_muc_hn_lc
            // 
            this.m_txt_thu_muc_hn_lc.Depth = 0;
            this.m_txt_thu_muc_hn_lc.Hint = "";
            this.m_txt_thu_muc_hn_lc.Location = new System.Drawing.Point(205, 54);
            this.m_txt_thu_muc_hn_lc.MaxLength = 32767;
            this.m_txt_thu_muc_hn_lc.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_txt_thu_muc_hn_lc.Name = "m_txt_thu_muc_hn_lc";
            this.m_txt_thu_muc_hn_lc.PasswordChar = '\0';
            this.m_txt_thu_muc_hn_lc.SelectedText = "";
            this.m_txt_thu_muc_hn_lc.SelectionLength = 0;
            this.m_txt_thu_muc_hn_lc.SelectionStart = 0;
            this.m_txt_thu_muc_hn_lc.Size = new System.Drawing.Size(305, 23);
            this.m_txt_thu_muc_hn_lc.TabIndex = 1;
            this.m_txt_thu_muc_hn_lc.TabStop = false;
            this.m_txt_thu_muc_hn_lc.UseSystemPasswordChar = false;
            // 
            // m_cmd_hn_lc
            // 
            this.m_cmd_hn_lc.Depth = 0;
            this.m_cmd_hn_lc.Location = new System.Drawing.Point(529, 54);
            this.m_cmd_hn_lc.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_cmd_hn_lc.Name = "m_cmd_hn_lc";
            this.m_cmd_hn_lc.Primary = true;
            this.m_cmd_hn_lc.Size = new System.Drawing.Size(130, 23);
            this.m_cmd_hn_lc.TabIndex = 2;
            this.m_cmd_hn_lc.Text = "Chọn thư mục";
            this.m_cmd_hn_lc.UseVisualStyleBackColor = true;
            this.m_cmd_hn_lc.Click += new System.EventHandler(this.m_cmd_hn_lc_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(62, 101);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(124, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Thư mục LC - HN";
            // 
            // m_txt_thu_muc_lc_hn
            // 
            this.m_txt_thu_muc_lc_hn.Depth = 0;
            this.m_txt_thu_muc_lc_hn.Hint = "";
            this.m_txt_thu_muc_lc_hn.Location = new System.Drawing.Point(205, 97);
            this.m_txt_thu_muc_lc_hn.MaxLength = 32767;
            this.m_txt_thu_muc_lc_hn.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_txt_thu_muc_lc_hn.Name = "m_txt_thu_muc_lc_hn";
            this.m_txt_thu_muc_lc_hn.PasswordChar = '\0';
            this.m_txt_thu_muc_lc_hn.SelectedText = "";
            this.m_txt_thu_muc_lc_hn.SelectionLength = 0;
            this.m_txt_thu_muc_lc_hn.SelectionStart = 0;
            this.m_txt_thu_muc_lc_hn.Size = new System.Drawing.Size(305, 23);
            this.m_txt_thu_muc_lc_hn.TabIndex = 1;
            this.m_txt_thu_muc_lc_hn.TabStop = false;
            this.m_txt_thu_muc_lc_hn.UseSystemPasswordChar = false;
            // 
            // m_cmd_lc_hn
            // 
            this.m_cmd_lc_hn.Depth = 0;
            this.m_cmd_lc_hn.Location = new System.Drawing.Point(529, 97);
            this.m_cmd_lc_hn.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_cmd_lc_hn.Name = "m_cmd_lc_hn";
            this.m_cmd_lc_hn.Primary = true;
            this.m_cmd_lc_hn.Size = new System.Drawing.Size(130, 23);
            this.m_cmd_lc_hn.TabIndex = 2;
            this.m_cmd_lc_hn.Text = "Chọn thư mục";
            this.m_cmd_lc_hn.UseVisualStyleBackColor = true;
            this.m_cmd_lc_hn.Click += new System.EventHandler(this.m_cmd_lc_hn_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(21, 19);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(340, 18);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Cấu hình thư mục báo cáo thống kê booking";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(466, 145);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(193, 43);
            this.materialRaisedButton3.TabIndex = 2;
            this.materialRaisedButton3.Text = "Lưu cấu hình thư mục";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // F500_Cau_hinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 393);
            this.Controls.Add(this.panel1);
            this.Name = "F500_Cau_hinh";
            this.Text = "F500_Cau_hinh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton m_cmd_lc_hn;
        private MaterialSkin.Controls.MaterialRaisedButton m_cmd_hn_lc;
        private MaterialSkin.Controls.MaterialSingleLineTextField m_txt_thu_muc_lc_hn;
        private MaterialSkin.Controls.MaterialSingleLineTextField m_txt_thu_muc_hn_lc;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}