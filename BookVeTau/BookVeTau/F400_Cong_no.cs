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
    public partial class F400_Cong_no : MaterialSkin.Controls.MaterialForm
    {
        public F400_Cong_no()
        {
            InitializeComponent();
            m_dat_tu_ngay.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            m_dat_den_ngay.EditValue = ((DateTime)m_dat_tu_ngay.EditValue).AddMonths(1).AddDays(-1);
            load_data_2_cbo_cong_ty();
        }

        private void load_data_2_cbo_cong_ty()
        {
            BookVeEntities v_ett = new BookVeEntities();
            var v_lst = v_ett.getDsCongTy();

            m_cbo_cong_ty.Properties.DataSource = v_lst;
            m_cbo_cong_ty.Properties.ValueMember = "Row";
            m_cbo_cong_ty.Properties.DisplayMember = "ten_cong_ty";
        }

        private void m_cmd_view_report_Click(object sender, EventArgs e)
        {
            BookVeEntities v_ett = new BookVeEntities();
            var v_dat_tu_ngay = ((DateTime)m_dat_tu_ngay.EditValue).Date;
            var v_dat_den_ngay = ((DateTime)m_dat_den_ngay.EditValue).Date;
            int v_int_row = (int)((long)m_cbo_cong_ty.EditValue);
            var v_lst = v_ett.get_cong_no(
                v_dat_tu_ngay
                , v_dat_den_ngay
                , v_int_row
                , m_cbo_cong_ty.Text).ToList();
            m_grc.DataSource = v_lst;

            gridView1.ExpandAllGroups();
        }
    }
}
