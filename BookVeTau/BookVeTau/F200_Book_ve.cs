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
        bool trang_thai_sua = false;
        public F200_Book_ve()
        {
            InitializeComponent();
            load_data_to_combobox_chieu();
            load_data_to_combobox_tai_khoan();
           
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
           
           
            m_rd_chuyen_khoan.Checked = true;
            m_dtp_ngay_di.EditValue = DateTime.Now;
            m_cbo_chieu.SelectedValue = 3;
            
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
                    xoa_trang_trang();
                   
                }
            }
            catch (Exception v_e)
            {

                throw v_e;
            }
            
        }

        private void luu_thong_tin()
        {
            if (m_btn_tao_lai_trang.Visible == false)
            {
                BookVeEntities book_ve = new BookVeEntities();
                GD_BOOK_VE gd_book_ve = new GD_BOOK_VE();
                luu_thong_tin_gd_book_ve(gd_book_ve);
                book_ve.GD_BOOK_VE.Add(gd_book_ve);
                book_ve.SaveChanges();
                // luu_thong_tin_detail
                var last_id = gd_book_ve.ID;
                var list_control = GetAll(m_group_HN_LC, typeof(DevExpress.XtraEditors.SimpleButton));
                luu_thong_tin_detail(last_id, list_control);
            }
            else
            {
                BookVeEntities book_ve = new BookVeEntities();
                GD_BOOK_VE gd_book_ve = book_ve.GD_BOOK_VE.Where(x=>x.ID==m_id_gd_book_ve).FirstOrDefault();
                luu_thong_tin_gd_book_ve(gd_book_ve);
                book_ve.SaveChanges();
                luu_thong_tin_sua_detail(m_id_gd_book_ve);
            }

        }

        private void luu_thong_tin_sua_detail(decimal m_id_gd_book_ve)
        {
            var list_control = GetAll(m_group_HN_LC, typeof(DevExpress.XtraEditors.SimpleButton));
            xoa_ban_ghi_cu(m_id_gd_book_ve);
            luu_thong_tin_detail(m_id_gd_book_ve, list_control);
        }

        private void xoa_ban_ghi_cu(decimal m_id_gd_book_ve)
        {
            BookVeEntities book_ve = new BookVeEntities();
            book_ve.Pr_delete_records_cua_gd_book_ve(m_id_gd_book_ve);
            book_ve.SaveChanges();
        }

            private void luu_thong_tin_gd_book_ve(GD_BOOK_VE gd_book_ve)
            {
                gd_book_ve.ID_CHIEU = decimal.Parse(m_cbo_chieu.SelectedValue.ToString());
                gd_book_ve.MA_GD_BOOK_VE = m_txt_ten_cong_ty.Text+" " + DateTime.Now.Hour + "h " + DateTime.Now.Minute + "p " + DateTime.Now.Second + "s";
                gd_book_ve.TEN_CONG_TY = m_txt_ten_cong_ty.Text;
                gd_book_ve.SO_VE = decimal.Parse(m_txt_so_ve.Text);
                gd_book_ve.GIA_VE = decimal.Parse(m_txt_gia_ve.Text);
                if (m_cb_cap_cho.Checked == true)
                    gd_book_ve.CAP_CHO_YN = "Y";
                else gd_book_ve.CAP_CHO_YN = "N";
                if (m_cb_vip.Checked == true)
                    gd_book_ve.VIP_YN = "Y";
                else gd_book_ve.VIP_YN = "N";
                gd_book_ve.NGAY_DI = ((DateTime)m_dtp_ngay_di.EditValue).Date;

                gd_book_ve.NGAY_DAT = DateTime.Now.Date;
                if (m_rd_chuyen_khoan.Checked == true)
                    gd_book_ve.ID_TAI_KHOAN = decimal.Parse(m_cbo_ten_tai_khoan.SelectedValue.ToString());
                if (m_rd_tien_mat.Checked == true)
                    gd_book_ve.MA_PHIEU_THU = m_txt_ma_phieu_thu.Text;
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
            if (m_txt_ten_cong_ty.Text == "" || m_txt_so_ve.Text == "" || m_txt_gia_ve.Text == ""|| m_cbo_chieu.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }
            //if (check_so_luong_ve_bang_0())
            //    return false;
            return true;
        }

        private bool check_so_luong_ve_bang_0()
        {
            var list_control_button = GetAll(m_group_HN_LC, typeof(DevExpress.XtraEditors.SimpleButton));
            foreach (var item in list_control_button)
            {
                if (((DevExpress.XtraEditors.SimpleButton)item).Text == "X")
                    return false;
            }
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
                }

            }
            catch (Exception v_e)
            {
                XtraMessageBox.Show(v_e.Message);
            }            
        }

        private void load_form_chieu_detail()
        {
            v_form_chieu = new FORM_CHIEU_DETAIL();
            v_form_chieu.Display((DateTime)m_dtp_ngay_di.EditValue, decimal.Parse(m_cbo_chieu.SelectedValue.ToString()));
            v_form_chieu.TopLevel = false;
            m_group_HN_LC.Controls.Add(v_form_chieu);
            v_form_chieu.WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.Visible = true;
            v_form_chieu.Show();
        }

        private void m_sua_thong_tin_Click(object sender, EventArgs e)
        {
            SUA_THONG_TIN_DAT_VE v_f = new SUA_THONG_TIN_DAT_VE();
            v_f.Display(out m_id_gd_book_ve);
            if (m_id_gd_book_ve != 0)
            {
                m_btn_load.Visible = false;
                m_btn_tao_lai_trang.Visible = true;
                m_btn_xoa.Visible = true;
                hien_thi_thong_tin_detail(m_id_gd_book_ve);
                load_form_chieu_detail_for_update(m_id_gd_book_ve);
            }
        }

        private void load_form_chieu_detail_for_update(decimal m_id_gd_book_ve)
        {
            v_form_chieu = new FORM_CHIEU_DETAIL();
            v_form_chieu.DisplayForUpdate(m_id_gd_book_ve);
            v_form_chieu.TopLevel = false;
            m_group_HN_LC.Controls.Add(v_form_chieu);
            v_form_chieu.WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.Visible = true;
            v_form_chieu.Show();
        }

        private void hien_thi_thong_tin_detail(decimal m_id_gd_book_ve)
        {
            BookVeEntities book_ve = new BookVeEntities();
            var gd_book_ve = book_ve.GD_BOOK_VE.Where(x => x.ID == m_id_gd_book_ve).FirstOrDefault();
            m_cbo_chieu.SelectedValue = gd_book_ve.ID_CHIEU;
           m_txt_ten_cong_ty.Text=  gd_book_ve.TEN_CONG_TY ;
           m_txt_so_ve.Text=  gd_book_ve.SO_VE.ToString() ;
            if(gd_book_ve.GIA_VE!=null)
           m_txt_gia_ve.Text = ((decimal)gd_book_ve.GIA_VE).ToString("n0");
           if (gd_book_ve.CAP_CHO_YN == "N")
               m_cb_cap_cho.Checked = true;
           else m_cb_cap_cho.Checked = false;
           if (gd_book_ve.VIP_YN == "Y")
               m_cb_vip.Checked = true;
           else m_cb_vip.Checked = false;
           m_dtp_ngay_di.EditValue= gd_book_ve.NGAY_DI ;
           if (gd_book_ve.ID_TAI_KHOAN != null)
           {
               m_cbo_ten_tai_khoan.SelectedValue = gd_book_ve.ID_TAI_KHOAN;
               m_rd_chuyen_khoan.Checked = true;
           }
           else if (gd_book_ve.MA_PHIEU_THU != null)
           {
               m_txt_ma_phieu_thu.Text = gd_book_ve.MA_PHIEU_THU.ToString();
               m_rd_tien_mat.Checked = true;
           }
           else
           {
               m_rd_cong_no.Checked = true;
           }
            
          
        }

        private void m_btn_tao_lai_trang_Click(object sender, EventArgs e)
        {
            xoa_trang_trang();
           
        }

        private void xoa_trang_trang()
        {
            m_txt_gia_ve.Text = "";
            m_txt_ma_phieu_thu.Text = "";
            m_txt_so_ve.Text = "";
            m_txt_ten_cong_ty.Text = "";
            m_cb_cap_cho.Checked = false;
            m_cb_vip.Checked = false;
            m_rd_chuyen_khoan.Checked = true;
            m_dtp_ngay_di.EditValue = DateTime.Now;
            m_cbo_chieu.SelectedValue = 3;
            m_group_HN_LC.Controls.Clear();
            m_btn_load.Visible = true;
            m_btn_tao_lai_trang.Visible = false;
            m_btn_xoa.Visible = false;
        }

        private void m_btn_xoa_Click(object sender, EventArgs e)
        {

            BookVeEntities book_ve = new BookVeEntities();
            book_ve.Pr_delete_all_gd_book_ve(m_id_gd_book_ve);
            book_ve.SaveChanges();
            MessageBox.Show("Đã xóa thông tin thành công!");
            xoa_trang_trang();
        }

        private void m_cb_vip_CheckedChanged(object sender, EventArgs e)
        {
            change_check_m_cb_vip();
        }

        private void change_check_m_cb_vip()
        {
            if (m_cb_vip.Checked == true)
            {
                m_txt_so_ve.Text = "2";
                m_txt_so_ve.Enabled = false;
            }
            else
            {
                m_txt_so_ve.Enabled = true;
            }
        }
    }
}
