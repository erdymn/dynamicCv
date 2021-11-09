using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities dBCVENTITY = new DBCVENTITYEntities();
            var message = dBCVENTITY.TBLILETISIM.ToList();
            Repeater1.DataSource = message;
            Repeater1.DataBind();

        }
    }
}