using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class AddExperience : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLHAKKIMDA t = new TBLHAKKIMDA();
            t.ISDENEYIMLERI = TextBox1.Text;
            db.TBLHAKKIMDA.Add(t);
            db.SaveChanges();
            Response.Redirect("Experience.Aspx");
        }
    }
}