namespace BookVeTau
{
    partial class MainForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.m_tab_so_do_tau = new System.Windows.Forms.TabPage();
            this.m_tab_book_ve = new System.Windows.Forms.TabPage();
            this.m_tab_bao_cao = new System.Windows.Forms.TabPage();
            this.m_tab_cong_no = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.m_tab_cau_hinh = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 523);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.materialTabControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(899, 444);
            this.panel4.TabIndex = 3;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.m_tab_so_do_tau);
            this.materialTabControl1.Controls.Add(this.m_tab_book_ve);
            this.materialTabControl1.Controls.Add(this.m_tab_bao_cao);
            this.materialTabControl1.Controls.Add(this.m_tab_cong_no);
            this.materialTabControl1.Controls.Add(this.m_tab_cau_hinh);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(899, 444);
            this.materialTabControl1.TabIndex = 1;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // m_tab_so_do_tau
            // 
            this.m_tab_so_do_tau.BackColor = System.Drawing.Color.White;
            this.m_tab_so_do_tau.Location = new System.Drawing.Point(4, 22);
            this.m_tab_so_do_tau.Name = "m_tab_so_do_tau";
            this.m_tab_so_do_tau.Padding = new System.Windows.Forms.Padding(3);
            this.m_tab_so_do_tau.Size = new System.Drawing.Size(891, 418);
            this.m_tab_so_do_tau.TabIndex = 0;
            this.m_tab_so_do_tau.Text = "Sơ đồ tàu";
            // 
            // m_tab_book_ve
            // 
            this.m_tab_book_ve.BackColor = System.Drawing.Color.White;
            this.m_tab_book_ve.Location = new System.Drawing.Point(4, 22);
            this.m_tab_book_ve.Name = "m_tab_book_ve";
            this.m_tab_book_ve.Padding = new System.Windows.Forms.Padding(3);
            this.m_tab_book_ve.Size = new System.Drawing.Size(891, 418);
            this.m_tab_book_ve.TabIndex = 1;
            this.m_tab_book_ve.Text = "Book vé";
            // 
            // m_tab_bao_cao
            // 
            this.m_tab_bao_cao.BackColor = System.Drawing.Color.White;
            this.m_tab_bao_cao.Location = new System.Drawing.Point(4, 22);
            this.m_tab_bao_cao.Name = "m_tab_bao_cao";
            this.m_tab_bao_cao.Padding = new System.Windows.Forms.Padding(3);
            this.m_tab_bao_cao.Size = new System.Drawing.Size(891, 418);
            this.m_tab_bao_cao.TabIndex = 2;
            this.m_tab_bao_cao.Text = "Báo cáo";
            // 
            // m_tab_cong_no
            // 
            this.m_tab_cong_no.Location = new System.Drawing.Point(4, 22);
            this.m_tab_cong_no.Name = "m_tab_cong_no";
            this.m_tab_cong_no.Padding = new System.Windows.Forms.Padding(3);
            this.m_tab_cong_no.Size = new System.Drawing.Size(891, 418);
            this.m_tab_cong_no.TabIndex = 3;
            this.m_tab_cong_no.Text = "Công nợ";
            this.m_tab_cong_no.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.materialTabSelector1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 79);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 38);
            this.panel3.TabIndex = 2;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 38);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(899, 41);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // m_tab_cau_hinh
            // 
            this.m_tab_cau_hinh.Location = new System.Drawing.Point(4, 22);
            this.m_tab_cau_hinh.Name = "m_tab_cau_hinh";
            this.m_tab_cau_hinh.Padding = new System.Windows.Forms.Padding(3);
            this.m_tab_cau_hinh.Size = new System.Drawing.Size(891, 418);
            this.m_tab_cau_hinh.TabIndex = 4;
            this.m_tab_cau_hinh.Text = "Cấu hình";
            this.m_tab_cau_hinh.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 523);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Quản lý book vé tàu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage m_tab_so_do_tau;
        private System.Windows.Forms.TabPage m_tab_book_ve;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage m_tab_bao_cao;
        private System.Windows.Forms.TabPage m_tab_cong_no;
        private System.Windows.Forms.TabPage m_tab_cau_hinh;
    }
}