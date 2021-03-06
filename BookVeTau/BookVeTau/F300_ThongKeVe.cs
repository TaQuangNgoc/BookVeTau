﻿using DevExpress.XtraEditors;
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
    public partial class F300_ThongKeVe : MaterialSkin.Controls.MaterialForm
    {
        public F300_ThongKeVe()
        {
            InitializeComponent();
            m_txt_thang.Text = DateTime.Now.Month.ToString();
            m_txt_nam.Text = DateTime.Now.Year.ToString();
            m_txt_thang.Focus();
        }

        private void m_cmd_xem_ket_qua_Click(object sender, EventArgs e)
        {
            try
            {
                BookVeEntities v_ett = new BookVeEntities();
                var v_lst_hn_lc = v_ett.GET_THONG_KE_VE(m_txt_thang.Text.Trim(), m_txt_nam.Text.Trim(), 3).ToList();
                var v_lst_lc_hn = v_ett.GET_THONG_KE_VE(m_txt_thang.Text.Trim(), m_txt_nam.Text.Trim(), 4).ToList();

                m_grc_hn_lc.DataSource = v_lst_hn_lc;
                m_grc_lc_hn.DataSource = v_lst_lc_hn;
            }
            catch (Exception v_e)
            {
                XtraMessageBox.Show(v_e.Message);
            }
        }

        private void m_cmd_export_Click(object sender, EventArgs e)
        {
            try
            {
                BookVeEntities v_ett = new BookVeEntities();
                var v_path_hn_lc = v_ett.CM_DM_TU_DIEN.Where(x => x.ID == 10).First().TEN_TU_DIEN;
                var v_path_lc_hn = v_ett.CM_DM_TU_DIEN.Where(x => x.ID == 11).First().TEN_TU_DIEN;
                gridView1.ExportToXls(v_path_hn_lc + "\\HN-LC thang " + m_txt_thang.Text + " nam " + m_txt_nam.Text + ".xls");
                gridView2.ExportToXls(v_path_lc_hn + "\\LC-HN thang " + m_txt_thang.Text + " nam " + m_txt_nam.Text + ".xls");
                DevExpress.XtraEditors.XtraMessageBox.Show("Trích xuất dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception v_e)
            {
                XtraMessageBox.Show(v_e.Message);
            }
        }
    }
}
