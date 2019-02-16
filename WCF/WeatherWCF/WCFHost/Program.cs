using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WCFHost
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if(!Debug)

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new WeatherService() 
            };
            ServiceBase.Run(ServicesToRun);


#else
            WeatherService ws=new WeatherService();
            ws.OnStart();
#endif
        }
    }
}
