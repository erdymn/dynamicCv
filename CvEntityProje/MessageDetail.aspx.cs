using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class MessageDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = int.Parse(Request.QueryString["ID"]);
            var message = db.TBLILETISIM.Find(x);
            TxtAdSoyad.Text = message.ADSOYAD;
            TxtMAil.Text = message.MAIL;
            TxtKonu.Text = message.KONU;
            TxtMessage.Text = message.MESAJ;
        }
    }
}