using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public string SayHello(string Name)
        {
            string Message = null;

            if (DateTime.Now.Hour < 12)
                Message = "Good Morning";
            else if (DateTime.Now.Hour < 16)
                Message = "Good AfterNoon";
            else if (DateTime.Now.Hour < 18)
                Message = "Good Evening";
            else
                Message = "Good Night";
            return Message + " " + Name;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public string TodayProgram(string Name)
        {
            DayOfWeek dow=DateTime.Now.DayOfWeek;
            string Message = null;
            if (dow == DayOfWeek.Saturday || dow == DayOfWeek.Sunday)
            {
                Message = "Happy WeekEnd";
            }
            else
                Message = "Enjoy Workingday";
            return Message + " " + Name;
        }
    }
}
