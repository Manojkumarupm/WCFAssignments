using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{

    [ServiceContract]
    public interface IOpeningJob
    {
        [OperationContract]
        List<JobList> OpeningJobs();
        [OperationContract]
        List<JobList> OpeningJobsByRole(string Role);
    }
}
