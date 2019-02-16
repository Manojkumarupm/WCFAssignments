using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            Label2.Text = sc.SayHello(TextBox1.Text);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client("NetHttpBinding_IService1");
            Label2.Text = sc.TodayProgram(TextBox1.Text);
        }
    }
}