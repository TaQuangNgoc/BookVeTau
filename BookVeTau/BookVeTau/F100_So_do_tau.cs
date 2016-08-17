using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
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
    public partial class F100_So_do_tau : MaterialSkin.Controls.MaterialForm
    {
        public F100_So_do_tau()
        {
            InitializeComponent();
            m_dat_chon_ngay.EditValue = DateTime.Now.Date;
            readWorkbookFromTemplate();
        }

        private void readWorkbookFromTemplate()
        {
            try
            {
                IWorkbook workbook = m_soDoTau.Document;
                workbook.LoadDocument("templateSoDoTau.xlsx", DocumentFormat.OpenXml);
                workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[0];
            }
            catch (Exception v_e)
            {
                XtraMessageBox.Show(v_e.Message);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                IWorkbook workbook = m_soDoTau.Document;
                Worksheet activeSheet = workbook.Worksheets.ActiveWorksheet;
                load_data_2_activeSheet(activeSheet);

            }
            catch (Exception v_e)
            {
                XtraMessageBox.Show(v_e.Message);
            }
        }

        private void load_data_2_activeSheet(Worksheet activeSheet)
        {
            activeSheet.Cells[2, 1].Value = ((DateTime)m_dat_chon_ngay.EditValue).ToString("dd/MM/yyyy");
            BookVeEntities v_ett = new BookVeEntities();
            IWorkbook workbook = m_soDoTau.Document;
            switch (activeSheet.Index)
            {
                case 0:
                    load_data_2_activeSheet(3, 1, (DateTime)m_dat_chon_ngay.EditValue, activeSheet);
                    break;
                case 1:
                    load_data_2_activeSheet(3, 2, (DateTime)m_dat_chon_ngay.EditValue, activeSheet);
                    break;
                case 2:
                    load_data_2_activeSheet(3, 9, (DateTime)m_dat_chon_ngay.EditValue, activeSheet);
                    break;
                case 3:
                    load_data_2_activeSheet(4, 1, (DateTime)m_dat_chon_ngay.EditValue, activeSheet);
                    break;
                case 4:
                    load_data_2_activeSheet(4, 2, (DateTime)m_dat_chon_ngay.EditValue, activeSheet);
                    break;
                case 5:
                    load_data_2_activeSheet(4, 9, (DateTime)m_dat_chon_ngay.EditValue, activeSheet);
                    break;
                default:
                    break;
            }
        }

        private void load_data_2_activeSheet(int ip_int_chieu, int ip_int_toa, DateTime ip_dat_ngay_di, Worksheet activeSheet)
        {
            int v_sl_ghe = 0;
            if (ip_int_toa == 1 || ip_int_toa == 9)
            {
                v_sl_ghe = 24;
            }
            else
            {
                v_sl_ghe = 22;
            }
            BookVeEntities v_ett = new BookVeEntities();
            var v_lst = v_ett.V_SO_DO_TAU.Where(x => 
                x.ID_CHIEU == ip_int_chieu 
                && x.ID_TOA == ip_int_toa 
                && x.NGAY_DI.Value.Day == ip_dat_ngay_di.Day
                && x.NGAY_DI.Value.Month == ip_dat_ngay_di.Month
                && x.NGAY_DI.Value.Year == ip_dat_ngay_di.Year)
                .OrderBy(x=>x.GHE_SO).ToList();
            int row = 5;

            for (int i = 1; i <= v_sl_ghe; i++)
            {
                var item = v_lst.Where(x => x.GHE_SO == i).FirstOrDefault();
                activeSheet.Cells[row, 0].Value = i;
                if (item != null)
                {
                    activeSheet.Cells[row, 1].Value = item.TEN_CONG_TY;
                    activeSheet.Cells[row, 2].Value = item.CAP_CHO;
                }
                else
                {
                    activeSheet.Cells[row, 1].Value = "";
                    activeSheet.Cells[row, 2].Value = "";
                }
                row++;
            }
        }

        private void m_soDoTau_ActiveSheetChanged(object sender, ActiveSheetChangedEventArgs e)
        {
            IWorkbook workbook = m_soDoTau.Document;
            Worksheet activeSheet = workbook.Worksheets.ActiveWorksheet;
            load_data_2_activeSheet(activeSheet);
        }
    }
}
