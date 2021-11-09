using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace CvEntityProje
{
    public partial class UpdateSkill : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var value = db.TBLYETENEKLER.Find(x);
                TextBox1.Text = value.YETENEK;
            }
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var value = db.TBLYETENEKLER.Find(x);
            value.YETENEK = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Skills.Aspx");
        }
    }
}