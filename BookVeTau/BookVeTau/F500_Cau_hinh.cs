using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookVeTau
{
    public partial class F500_Cau_hinh : MaterialSkin.Controls.MaterialForm
    {
        public F500_Cau_hinh()
        {
            InitializeComponent();
            load_thu_muc_hien_tai();
        }

        private void load_thu_muc_hien_tai()
        {
            BookVeEntities v_ett = new BookVeEntities();
            m_txt_thu_muc_hn_lc.Text = v_ett.CM_DM_TU_DIEN.Where(x => x.ID == 10).First().TEN_TU_DIEN;
            m_txt_thu_muc_lc_hn.Text = v_ett.CM_DM_TU_DIEN.Where(x => x.ID == 11).First().TEN_TU_DIEN;
        }

        private void m_cmd_hn_lc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.Description = "Select a folder in which to save your workspace...";
            if (m_txt_thu_muc_hn_lc.Text.Trim() == "")
            {
                diag.SelectedPath = Application.StartupPath;
            }
            else
            {
                diag.SelectedPath = m_txt_thu_muc_hn_lc.Text.Trim();
            }
            

            if (DialogResult.OK == diag.ShowDialog())
            {
                m_txt_thu_muc_hn_lc.Text = diag.SelectedPath;
            }
        }

        private void m_cmd_lc_hn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.Description = "Select a folder in which to save your workspace...";
            if (m_txt_thu_muc_lc_hn.Text.Trim() == "")
            {
                diag.SelectedPath = Application.StartupPath;
            }
            else
            {
                diag.SelectedPath = m_txt_thu_muc_lc_hn.Text.Trim();
            }

            if (DialogResult.OK == diag.ShowDialog())
            {
                m_txt_thu_muc_lc_hn.Text = diag.SelectedPath;
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            try
            {
                BookVeEntities v_ett = new BookVeEntities();
                var hn_lc = v_ett.CM_DM_TU_DIEN.Where(x => x.ID == 10).First();
                hn_lc.TEN_TU_DIEN = m_txt_thu_muc_hn_lc.Text;
                v_ett.Entry(hn_lc).State = System.Data.EntityState.Modified;
                v_ett.SaveChanges();

                var lc_hn = v_ett.CM_DM_TU_DIEN.Where(x => x.ID == 11).First();
                lc_hn.TEN_TU_DIEN = m_txt_thu_muc_lc_hn.Text;
                v_ett.Entry(lc_hn).State = System.Data.EntityState.Modified;
                v_ett.SaveChanges();
            }
            catch (Exception v_e)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(v_e.Message);
            }
        }
    }
}
