using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace WCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost sv= new ServiceHost(typeof(HelloService.Service1)))
            {
                sv.Open();
                Console.WriteLine("Service Opened "+DateTime.Now);
                Console.ReadKey();
            }
        }
    }
}
