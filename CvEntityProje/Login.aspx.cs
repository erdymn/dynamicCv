using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTITYEntities dB = new DBCVENTITYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var query = from x in dB.TBLADMIN
                        where x.KULLANICIAD == TextBox1.Text && x.SIFRE == TextBox2.Text
                        select x;
            if (query.Any())
            {
                Response.Redirect("Contact.Aspx");
            }
            else
            {
                Response.Write("Wrong username or password!");
            }

        }
    }
}