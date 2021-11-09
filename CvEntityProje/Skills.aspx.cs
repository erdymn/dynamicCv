using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities dBCVENTITY = new DBCVENTITYEntities();
            Repeater1.DataSource = dBCVENTITY.TBLYETENEKLER.ToList();
            Repeater1.DataBind();

        }
    }
}