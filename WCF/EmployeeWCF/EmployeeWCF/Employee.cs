using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeWCF
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string EmployeeId { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public float Salary { get; set; }
        [DataMember]
        public bool Gender { get; set; }
        [DataMember]
        public string Phone { get; set; }
    }
}