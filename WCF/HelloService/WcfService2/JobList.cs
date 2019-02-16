using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService2
{
    [DataContract] 
    public class JobList
    {
        [DataMember]
        public string JobName { get; set; }
        [DataMember]
        public string Organization { get; set; }
        [DataMember]
        public string Roles { get; set; }

        public JobList()
        {

        }
        public JobList(string JobName, string Org, string Roles)
        {
            this.JobName = JobName;
            this.Organization = Org;
            this.Roles = Roles;
        }
      
        
    }
}