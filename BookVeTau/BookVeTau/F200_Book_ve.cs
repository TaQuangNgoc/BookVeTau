using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BookVeTau
{
    public partial class F200_Book_ve : MaterialSkin.Controls.MaterialForm
    {
        FORM_CHIEU_DETAIL v_form_chieu= new FORM_CHIEU_DETAIL();
        public ImageList m_imageList = new ImageList();
       
        decimal m_id_gd_book_ve=0;
        public F200_Book_ve()
        {
            InitializeComponent();
           
        }

        private void text_box_format_numeric_not_contain_point(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_box_key_up_format_currency(object sender, KeyEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double valueBefore = Double.Parse(textbox.Text, System.Globalization.NumberStyles.AllowThousands);
                textbox.Text = String.Format(culture, "{0:N0}", valueBefore);
                textbox.Select(textbox.Text.Length, 0);

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Nhập chẵn số tiền!");
                textbox.Text = "";
            }

        }

      

        private void F200_Book_ve_Load(object sender, EventArgs e)
        {
           
            load_data_to_combobox_chieu();
            load_data_to_combobox_tai_khoan();
            m_rd_chuyen_khoan.Checked = true;
            
        }

        private void load_data_to_combobox_tai_khoan()
        {
            BookVeEntities book_ve = new BookVeEntities();
            m_cbo_ten_tai_khoan.DataSource = book_ve.CM_DM_TU_DIEN.Where(x => x.ID_LOAI_TU_DIEN == 3).ToList();
            m_cbo_ten_tai_khoan.DisplayMember = "TEN_TU_DIEN";
            m_cbo_ten_tai_khoan.ValueMember = "ID";
        }

        private void load_data_to_combobox_chieu()
        {
            BookVeEntities book_ve = new BookVeEntities();
            m_cbo_chieu.DataSource = book_ve.CM_DM_TU_DIEN.Where(x => x.ID_LOAI_TU_DIEN == 2).ToList();
            m_cbo_chieu.DisplayMember = "TEN_TU_DIEN";
            m_cbo_chieu.ValueMember = "ID";
        }

        private void m_btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_thong_tin_is_ok())
                {
                    luu_thong_tin();
                    XtraMessageBox.Show("Lưu thành công!");
                   
                }
            }
            catch (Exception v_e)
            {

                throw v_e;
            }
            
        }

        private void luu_thong_tin()
        {
            BookVeEntities book_ve = new BookVeEntities();
            GD_BOOK_VE gd_book_ve = new GD_BOOK_VE();
            gd_book_ve.ID_CHIEU = decimal.Parse(m_cbo_chieu.SelectedValue.ToString());
            gd_book_ve.TEN_CONG_TY = m_txt_ten_cong_ty.Text;
            gd_book_ve.SO_VE = decimal.Parse(m_txt_so_ve.Text);
            gd_book_ve.GIA_VE = decimal.Parse(m_txt_gia_ve.Text);
            if (m_cb_cap_cho.Checked == true)
                gd_book_ve.CAP_CHO_YN = "Y";
            else gd_book_ve.CAP_CHO_YN = "N";
            if (m_cb_vip.Checked == true)
                gd_book_ve.VIP_YN = "Y";
            else gd_book_ve.VIP_YN = "N";
            gd_book_ve.NGAY_DI = (DateTime)m_dtp_ngay_di.EditValue;
            gd_book_ve.NGAY_VE = (DateTime)m_dtp_ngay_ve.EditValue;
            gd_book_ve.NGAY_DAT = DateTime.Now;
            if (m_rd_chuyen_khoan.Checked == true)
                gd_book_ve.ID_TAI_KHOAN = decimal.Parse(m_cbo_ten_tai_khoan.SelectedValue.ToString());
            if (m_rd_tien_mat.Checked == true)
                gd_book_ve.MA_PHIEU_THU = m_txt_ma_phieu_thu.Text;
            book_ve.GD_BOOK_VE.Add(gd_book_ve);
            book_ve.SaveChanges();
            // luu_thong_tin_detail
            var last_id = gd_book_ve.ID;
            var list_control = GetAll(m_group_HN_LC, typeof(DevExpress.XtraEditors.SimpleButton));
            luu_thong_tin_detail(last_id, list_control);

        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

     
        private void luu_thong_tin_detail(decimal last_id, IEnumerable<Control> list_control_button)
        {
          
            foreach (var item in list_control_button)
            {
                if (((DevExpress.XtraEditors.SimpleButton)item).Text=="X" )
                {
                    var button_text = item.Name.Split('_').ToArray();
                    var id_toa = 0;
                    if (button_text[0] == "A")
                        id_toa = 1;
                    else if (button_text[0] == "B")
                        id_toa = 2;
                    else id_toa = 9;
                    decimal ghe_so = decimal.Parse(button_text[1].ToString());
                    BookVeEntities book_ve = new BookVeEntities();
                    GD_BOOK_VE_DETAIL gd_book_ve_detail = new GD_BOOK_VE_DETAIL();
                    gd_book_ve_detail.ID_GD_BOOK_VE = last_id;
                    gd_book_ve_detail.GHE_SO = ghe_so;
                    gd_book_ve_detail.ID_TOA = id_toa;
                    book_ve.GD_BOOK_VE_DETAIL.Add(gd_book_ve_detail);
                    book_ve.SaveChanges();
                }
            }
        }

        private bool check_thong_tin_is_ok()
        {
            return true;
        }

        private void m_rd_chuyen_khoan_CheckedChanged(object sender, EventArgs e)
        {
            change_status_cua_combobox_ten_tai_khoan();
        }

        private void change_status_cua_combobox_ten_tai_khoan()
        {
            if (m_rd_chuyen_khoan.Checked == true)
            {
                m_cbo_ten_tai_khoan.Enabled = true;
            }
            else
            {
                m_cbo_ten_tai_khoan.Enabled = false;
            }
        }

        private void m_rd_tien_mat_CheckedChanged(object sender, EventArgs e)
        {
            if (m_rd_tien_mat.Checked == true)
            {
                m_txt_ma_phieu_thu.Enabled = true;
            }
            else
            {
                m_txt_ma_phieu_thu.Enabled = false;
            }
        }

        private  void m_btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_dtp_ngay_di.EditValue == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn chiều đi, và ngày đi để load thông tin của chuyến đi!");
                }
                else
                {
                    load_form_chieu_detail();
                    load_form_chieu_ve_detail();
                   
                }
                
            }
            catch (Exception v_e)
            {
                throw v_e;
              
            }
           
            
        }

        private void load_form_chieu_ve_detail()
        {
            v_form_chieu = new FORM_CHIEU_DETAIL();
            v_form_chieu.Display((DateTime)m_dtp_ngay_di.EditValue, decimal.Parse(m_cbo_chieu.SelectedValue.ToString()));
            v_form_chieu.TopLevel = false;
            m_group_LC_HN.Controls.Add(v_form_chieu);
            v_form_chieu.WindowState = FormWindowState.Maximized;
            v_form_chieu.Show();
        }

        private void load_form_chieu_detail()
        {
            v_form_chieu = new FORM_CHIEU_DETAIL();
            v_form_chieu.Display((DateTime)m_dtp_ngay_di.EditValue, decimal.Parse(m_cbo_chieu.SelectedValue.ToString()));
            v_form_chieu.TopLevel = false;
            if (int.Parse(m_cbo_chieu.SelectedValue.ToString()) == 3)
            {
                m_group_HN_LC.Controls.Add(v_form_chieu);
            }
            else
            {
                m_group_LC_HN.Controls.Add(v_form_chieu);
            }
            v_form_chieu.WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.Visible = true;
            v_form_chieu.Show();
        }

        private void m_sua_thong_tin_Click(object sender, EventArgs e)
        {
            SUA_THONG_TIN_DAT_VE v_f = new SUA_THONG_TIN_DAT_VE();
            v_f.Display(out m_id_gd_book_ve);
            if( m_id_gd_book_ve!=0)
            hien_thi_thong_tin_detail(m_id_gd_book_ve);
        }

        private void hien_thi_thong_tin_detail(decimal m_id_gd_book_ve)
        {
            BookVeEntities book_ve = new BookVeEntities();
            var gd_book_ve = book_ve.GD_BOOK_VE.Where(x => x.ID == m_id_gd_book_ve).FirstOrDefault();
            m_cbo_chieu.SelectedValue = gd_book_ve.ID_CHIEU;
           m_txt_ten_cong_ty.Text=  gd_book_ve.TEN_CONG_TY ;
           m_txt_so_ve.Text=  gd_book_ve.SO_VE.ToString() ;
           m_txt_gia_ve.Text = gd_book_ve.GIA_VE.ToString();
           if (gd_book_ve.CAP_CHO_YN == "N")
               m_cb_cap_cho.Checked = true;
           else m_cb_cap_cho.Checked = false;
           if (gd_book_ve.VIP_YN == "Y")
               m_cb_vip.Checked = true;
           else m_cb_vip.Checked = false;
           m_dtp_ngay_di.EditValue= gd_book_ve.NGAY_DI ;
           m_dtp_ngay_ve.EditValue= gd_book_ve.NGAY_VE ;

           if (gd_book_ve.ID_TAI_KHOAN.ToString()!=null)
               m_cbo_ten_tai_khoan.SelectedValue = gd_book_ve.ID_TAI_KHOAN;
            if ( gd_book_ve.MA_PHIEU_THU!=null)
                m_txt_ma_phieu_thu.Text = gd_book_ve.MA_PHIEU_THU.ToString();
          
        }
    }
}
