using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(EmployeeWCF.Service1)))
            {
                host.Open();
                Console.WriteLine("Service Hosted : " + DateTime.Now.ToString());
                Console.ReadLine
                    ();
            }
        }
    }
}
