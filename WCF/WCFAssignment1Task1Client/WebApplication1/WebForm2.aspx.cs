using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.OpeningJobClient OJ = new ServiceReference2.OpeningJobClient();
            List<ServiceReference2.JobList> list = OJ.OpeningJobs().ToList();
            StringBuilder sb = new StringBuilder();
            foreach (ServiceReference2.JobList jl in list)
            {
                sb.Append("Job Name : ").Append(jl.JobName).Append(" Orgnizantion : ").Append(jl.Organization).Append(" Role : ").Append(jl.Roles).Append("\n");
            }

            Alldata.InnerHtml = sb.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference2.OpeningJobClient OJ = new ServiceReference2.OpeningJobClient();
            List<ServiceReference2.JobList> list = OJ.OpeningJobsByRole(TextBox1.Text).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (ServiceReference2.JobList jl in list)
            {
                sb.Append("Job Name : ").Append(jl.JobName).Append(" Orgnizantion : ").Append(jl.Organization).Append(" Role : ").Append(jl.Roles).Append("\n");
            }

            Alldata.InnerHtml = sb.ToString();
        }
    }
}