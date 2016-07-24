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
                ((DevExpress.XtraEditors.SimpleButton)sender).Appearance.BackColor = Color.Gray;
            }
            else
            {
                ((DevExpress.XtraEditors.SimpleButton)sender).Text = "X";
                ((DevExpress.XtraEditors.SimpleButton)sender).Appearance.BackColor = Color.Green;
            } 
           
        }

        private void FORM_CHIEU_DETAIL_Load(object sender, EventArgs e)
        {
            Rename_button();
            Click_event();
        }

        private void Rename_button()
        {
            var IEButton = GetAll(this, typeof(DevExpress.XtraEditors.SimpleButton));
            foreach (var item in IEButton)
            {
                item.Name = item.Text;
            }
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

                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.BackColor = Color.Red;
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
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.BackColor = Color.Red;
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
                            ((DevExpress.XtraEditors.SimpleButton)item).Appearance.BackColor = Color.Red;
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

        
    }
}
