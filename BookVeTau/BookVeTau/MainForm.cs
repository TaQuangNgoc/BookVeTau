using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using DevExpress.XtraEditors;

namespace BookVeTau
{
    public partial class MainForm : MaterialForm
    {
        MaterialSkin.MaterialSkinManager materialSkinManager;
        F100_So_do_tau m_f_so_do_tau;
        F200_Book_ve m_f_book_ve;
        F300_ThongKeVe m_f_thong_ke_ve;
        F400_Cong_no m_f_cong_no;

        public MainForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red700, Primary.Red200, Accent.Blue100, TextShade.WHITE);
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string v_str_tabname = materialTabControl1.SelectedTab.Name.ToString();
            switch (v_str_tabname)
            {
                case "m_tab_so_do_tau":
                    break;
                case "m_tab_book_ve":
                    if (m_f_book_ve != null)
                    {
                        return;
                    }
                    else
                    {
                        m_f_book_ve = new F200_Book_ve();
                        m_f_book_ve.TopLevel = false;
                        m_tab_book_ve.Controls.Add(m_f_book_ve);
                        m_f_book_ve.WindowState = FormWindowState.Maximized;
                        m_f_book_ve.Show();
                    }
                    break;
                case "m_tab_bao_cao":
                    if (m_f_thong_ke_ve != null)
                    {
                        return;
                    }
                    else
                    {
                        m_f_thong_ke_ve = new F300_ThongKeVe();
                        m_f_thong_ke_ve.TopLevel = false;
                        m_tab_bao_cao.Controls.Add(m_f_thong_ke_ve);
                        m_f_thong_ke_ve.WindowState = FormWindowState.Maximized;
                        m_f_thong_ke_ve.Show();
                    }
                    break;
                case "m_tab_cong_no":
                    if (m_f_cong_no != null)
                    {
                        return;
                    }
                    else
                    {
                        m_f_cong_no = new F400_Cong_no();
                        m_f_cong_no.TopLevel = false;
                        m_tab_cong_no.Controls.Add(m_f_cong_no);
                        m_f_cong_no.WindowState = FormWindowState.Maximized;
                        m_f_cong_no.Show();
                    }
                    break;
                default:
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                m_f_so_do_tau = new F100_So_do_tau();
                m_f_so_do_tau.TopLevel = false;
                m_tab_so_do_tau.Controls.Add(m_f_so_do_tau);
                m_f_so_do_tau.Dock = DockStyle.Fill;
                m_f_so_do_tau.Show();
            }
            catch (Exception v_e)
            {
                XtraMessageBox.Show(v_e.Message);
            }
        }
    }
}
