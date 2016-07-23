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

namespace BookVeTau
{
    public partial class MainForm : MaterialForm
    {
        MaterialSkin.MaterialSkinManager materialSkinManager;
        F200_Book_ve m_f_book_ve;
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
                    break;
                default:
                    break;
            }
        }
    }
}
