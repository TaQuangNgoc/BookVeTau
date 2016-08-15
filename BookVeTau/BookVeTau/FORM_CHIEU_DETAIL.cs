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
   
    public partial class FORM_CHIEU_DETAIL : Form
    {
        
        public FORM_CHIEU_DETAIL()
        {
            InitializeComponent();
            format_button();
           
           
        }

        private void format_button()
        {
            var IEButton = GetAll(this, typeof(DevExpress.XtraEditors.SimpleButton));
            foreach (var item in IEButton)
            {
                item.Name = item.Text;
                ((DevExpress.XtraEditors.SimpleButton)item).Appearance.BackColor = Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
                ((DevExpress.XtraEditors.SimpleButton)item).Appearance.ForeColor = Color.White;
            }
        }

       
        private void Click_event()
        {
            var IEButton = GetAll(this, typeof(DevExpress.XtraEditors.SimpleButton));
            foreach (var item in IEButton)
	            {
                  
		            item.Click += Button_Click; 
	            }                       
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (((DevExpress.XtraEditors.SimpleButton)sender).Text == "X")
            {
                ((DevExpress.XtraEditors.SimpleButton)sender).Text = ((DevExpress.XtraEditors.SimpleButton)sender).Name;
                ((DevExpress.XtraEditors.SimpleButton)sender).Appearance.BackColor = Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            }
            else
            {
                ((DevExpress.XtraEditors.SimpleButton)sender).Text = "X";
                ((DevExpress.XtraEditors.SimpleButton)sender).Appearance.BackColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
                ((DevExpress.XtraEditors.SimpleButton)sender).Appearance.ForeColor = Color.White;
            } 
           
        }

        private void FORM_CHIEU_DETAIL_Load(object sender, EventArgs e)
        {
           
            Click_event();
        }

       

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }




        private void add_image_cho_ghe(List<GD_BOOK_VE_DETAIL> list_gd_book_ve_detail)
        {
            var IEButton = GetAll(this, typeof(DevExpress.XtraEditors.SimpleButton));
            for (int i = 0; i < list_gd_book_ve_detail.Count; i++)
            {
                var so_ghe = list_gd_book_ve_detail[i].GHE_SO;
                var toa = list_gd_book_ve_detail[i].ID_TOA;
                if (toa == 1)
                {
                    foreach (var item in IEButton)
                    {
                        if (item.Text == ("A_" + so_ghe))
                        {
                            ((DevExpress.XtraEditors.SimpleButton)item).Text = "Y";

                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.BackColor = Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.ForeColor = Color.White;
                            item.Enabled = false;
                        }
                    }
                }
                else if (toa == 2)
                {
                    foreach (var item in IEButton)
                    {
                        if (item.Text == ("B_" + so_ghe))
                        {
                            ((DevExpress.XtraEditors.SimpleButton)item).Text = "Y";
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.BackColor = Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.ForeColor = Color.White;
                             item.Enabled = false;
                        }
                    }
                }
                else if (toa == 9)
                {
                    foreach (var item in IEButton)
                    {
                        if (item.Text == ("BS_" + so_ghe))
                        {
                            ((DevExpress.XtraEditors.SimpleButton)item).Text = "Y";
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.BackColor = Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.ForeColor = Color.White;
                             item.Enabled = false;
                        }
                    }

                }
            }
        }

        internal void Display(DateTime dateTime, decimal id_chieu)
        {
            BookVeEntities book_ve = new BookVeEntities();
            var list_gd_book_ve = book_ve.GD_BOOK_VE.Where(x => x.NGAY_DI == dateTime).Where(x=>x.ID_CHIEU== id_chieu).ToList();
            if (list_gd_book_ve.Count > 0)
            {
                for (int i = 0; i < list_gd_book_ve.Count; i++)
                {
                    var id_gd_book_ve = list_gd_book_ve[i].ID;
                    var list_gd_book_ve_detail = book_ve.GD_BOOK_VE_DETAIL.Where(x => x.ID_GD_BOOK_VE == id_gd_book_ve).ToList();
                    if (list_gd_book_ve_detail.Count > 0)
                    {
                        add_image_cho_ghe(list_gd_book_ve_detail);
                    }
                }
            }
           
        }

        internal void DisplayForUpdate(decimal m_id_gd_book_ve)
        {
            BookVeEntities book_ve = new BookVeEntities();
            var gd_book_ve = book_ve.GD_BOOK_VE.Where(x => x.ID == m_id_gd_book_ve).FirstOrDefault();
            // format ghế cho những ghế cùng chiều, cùng ngày
            var list_gd_book_ve = book_ve.GD_BOOK_VE.Where(x => x.NGAY_DI == gd_book_ve.NGAY_DI).Where(x => x.ID_CHIEU == gd_book_ve.ID_CHIEU).ToList();
            if (list_gd_book_ve.Count > 0)
            {
                for (int i = 0; i < list_gd_book_ve.Count; i++)
                {
                    var id_gd_book_ve = list_gd_book_ve[i].ID;
                    var list_gd_book_ve_detail = book_ve.GD_BOOK_VE_DETAIL.Where(x => x.ID_GD_BOOK_VE == id_gd_book_ve).ToList();
                    if (list_gd_book_ve_detail.Count > 0)
                    {
                        add_image_cho_ghe(list_gd_book_ve_detail);
                    }
                }
            }

            //format ghế cho riêng gd này

           
          
                   
                    var list_gd_book_ve_cua_id_gd_book_ve = book_ve.GD_BOOK_VE_DETAIL.Where(x => x.ID_GD_BOOK_VE == m_id_gd_book_ve).ToList();
                    if (list_gd_book_ve_cua_id_gd_book_ve.Count > 0)
                    {
                        add_image_cho_ghe_de_sua(list_gd_book_ve_cua_id_gd_book_ve);
                    }
                }

        private void add_image_cho_ghe_de_sua(List<GD_BOOK_VE_DETAIL> list_gd_book_ve_cua_id_gd_book_ve)
        {
 	         var IEButton = GetAll(this, typeof(DevExpress.XtraEditors.SimpleButton));
            for (int i = 0; i < list_gd_book_ve_cua_id_gd_book_ve.Count; i++)
            {
                var so_ghe = list_gd_book_ve_cua_id_gd_book_ve[i].GHE_SO;
                var toa = list_gd_book_ve_cua_id_gd_book_ve[i].ID_TOA;
                if (toa == 1)
                {
                    foreach (var item in IEButton)
                    {
                        if (item.Name == ("A_" + so_ghe))
                        {
                            ((DevExpress.XtraEditors.SimpleButton)item).Text = "X";

                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.BackColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.ForeColor = Color.White;
                            item.Enabled = true;
                        }
                    }
                }
                else if (toa == 2)
                {
                    foreach (var item in IEButton)
                    {
                        if (item.Name == ("B_" + so_ghe))
                        {
                            ((DevExpress.XtraEditors.SimpleButton)item).Text = "X";
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.BackColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.ForeColor = Color.White;
                             item.Enabled = true;
                        }
                    }
                }
                else if (toa == 9)
                {
                    foreach (var item in IEButton)
                    {
                        if (item.Name == ("BS_" + so_ghe))
                        {
                            ((DevExpress.XtraEditors.SimpleButton)item).Text = "X";
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.BackColor = Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.ForeColor = Color.White;
                             item.Enabled = true;
                        }
                    }

                }
            }
        }
             
    }
}
