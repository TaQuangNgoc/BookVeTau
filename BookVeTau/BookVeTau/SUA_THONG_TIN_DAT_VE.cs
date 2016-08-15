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
    public partial class SUA_THONG_TIN_DAT_VE : MaterialSkin.Controls.MaterialForm
    {
        decimal m_id_gd_book_ve;
        public SUA_THONG_TIN_DAT_VE()
        {
            InitializeComponent();
            load_data_to_combobox_chieu();
            m_dtp_ngay_di.EditValue = DateTime.Now;
           
        }

        private void load_data_to_combobox_chieu()
        {
            BookVeEntities book_ve = new BookVeEntities();
            m_cbo_chieu.DataSource = book_ve.CM_DM_TU_DIEN.Where(x => x.ID_LOAI_TU_DIEN == 2).ToList();
            m_cbo_chieu.DisplayMember = "TEN_TU_DIEN";
            m_cbo_chieu.ValueMember = "ID";
            m_cbo_chieu.SelectedValue = 3;
        }

        private void m_cbo_chieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_to_combobox_cong_ty();
        }

        private void load_data_to_combobox_cong_ty()
        {
            int result;
            if (int.TryParse(m_cbo_chieu.SelectedValue.ToString(),out result))
            {
                BookVeEntities book_ve = new BookVeEntities();
                var id_chieu = int.Parse(m_cbo_chieu.SelectedValue.ToString());
                DateTime ngay_di = (DateTime)m_dtp_ngay_di.EditValue;
                var date= new DateTime(ngay_di.Year,ngay_di.Month,ngay_di.Day);
                 m_cbo_ten_cong_ty.DataSource= book_ve.GD_BOOK_VE.Where(x => x.ID_CHIEU == id_chieu).Where(x => x.NGAY_DI == date).ToList();            
                m_cbo_ten_cong_ty.DisplayMember = "MA_GD_BOOK_VE";
                m_cbo_ten_cong_ty.ValueMember = "ID";
            }
        }

        private void SUA_THONG_TIN_DAT_VE_Load(object sender, EventArgs e)
        {         
            m_cbo_chieu.SelectedIndexChanged += m_cbo_chieu_SelectedIndexChanged;
            m_dtp_ngay_di.EditValueChanged += m_dtp_ngay_di_EditValueChanged;
        }

        private void m_btn_tiep_tuc_Click(object sender, EventArgs e)
        {
            if( m_cbo_ten_cong_ty.Text!="")
            {
                m_id_gd_book_ve = int.Parse(m_cbo_ten_cong_ty.SelectedValue.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tên công ty bạn muốn sửa thông tin!");
            }
            
        }


        internal void Display(out decimal m_id_gd_book_ve)
        {
            this.ShowDialog();
            m_id_gd_book_ve = this.m_id_gd_book_ve;
        }

        private void m_dtp_ngay_di_EditValueChanged(object sender, EventArgs e)
        {
            load_data_to_combobox_cong_ty();
        }
    }
}
