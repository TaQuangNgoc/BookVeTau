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

        private void Button_Click(object sender, EventArgs e)
        {
            if (((DevExpress.XtraEditors.SimpleButton)sender).Image !=null)
                ((DevExpress.XtraEditors.SimpleButton)sender).Image = null;
            else
            {
                ((DevExpress.XtraEditors.SimpleButton)sender).Image = global::BookVeTau.Properties.Resources._checked;
            } 
           
        }

      
    }
}
