using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class JobOpening : IOpeningJob
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<JobList> OpeningJobs()
        {
            List<JobList> Jobs = GetJobDetails();
            return Jobs;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Role"></param>
        /// <returns></returns>
        public List<JobList> OpeningJobsByRole(string Role)
        {
            List<JobList> Jobs = GetJobDetails();
            var query = from p in Jobs
                        where
                        p.Roles == Role
                        select p;
            return query.ToList();
        }
        
        private List<JobList> GetJobDetails()
        {
            try
            {
                List<JobList> jobs = new List<JobList>();
                jobs.Add(new JobList("WCF", "Cognizant", "WCF Developer"));
                jobs.Add(new JobList("MVC", "Cognizant", "MVC Developer"));
                jobs.Add(new JobList("ASP", "Cognizant", "ASP Developer"));
                jobs.Add(new JobList(".Net Developer", "Cognizant", ".Net Developer"));
                return jobs;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
