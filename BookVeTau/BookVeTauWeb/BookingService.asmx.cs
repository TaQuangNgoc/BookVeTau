using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace BookVeTauWeb
{
    /// <summary>
    /// Summary description for BookingService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class BookingService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<DM_CONG_TY> getDSCty()
        {
            BOOK_VE_TAUEntities v_ett = new BOOK_VE_TAUEntities();
            var v_lst = v_ett.DM_CONG_TY.ToList();
            DM_CONG_TY v_cty = new DM_CONG_TY();
            v_cty.TEN_CONG_TY = "01. Khách lẻ";
            v_cty.ID = 10000;
            v_lst.Add(v_cty);
            return v_lst;
        }

        [WebMethod]
        public bool booking(string chieu_di, string tenCty, string sdt, string so_ve, string so_ve_vip, string ngay_di, string ghi_chu)
        {
            try
            {
                BOOK_VE_TAUEntities v_ett = new BOOK_VE_TAUEntities();
                GD_BOOKING_FROM_WEB v_gd = new GD_BOOKING_FROM_WEB();
                v_gd.GHI_CHU = ghi_chu;
                v_gd.ID_CHIEU = int.Parse(chieu_di);
                v_gd.NGAY_DAT = DateTime.Now.Date;
                v_gd.NGAY_DI = DateTime.ParseExact(ngay_di, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                v_gd.SDT = sdt;
                v_gd.SO_VE = int.Parse(so_ve);
                v_gd.SO_VE_VIP = int.Parse(so_ve_vip);
                v_gd.TEN_CONG_TY = tenCty;
                v_gd.TRANG_THAI = false;
                v_ett.GD_BOOKING_FROM_WEB.Add(v_gd);
                v_ett.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
