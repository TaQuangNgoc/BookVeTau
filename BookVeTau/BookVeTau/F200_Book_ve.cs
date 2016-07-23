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
    public partial class F200_Book_ve : MaterialSkin.Controls.MaterialForm
    {
        FORM_CHIEU_DETAIL v_form_chieu;
        public F200_Book_ve()
        {
            InitializeComponent();
           
        }

        private void load_giao_dien_form_chieu()
        {
            if (v_form_chieu != null)
            {
                return;
            }
            else
            {
                v_form_chieu = new FORM_CHIEU_DETAIL();
                v_form_chieu.TopLevel = false;
                m_group_HN_LC.Controls.Add(v_form_chieu);
                v_form_chieu.WindowState = FormWindowState.Maximized;
                v_form_chieu.Show();
            }
        }

        private void F200_Book_ve_Load(object sender, EventArgs e)
        {
            load_giao_dien_form_chieu();
        }
    }
}
