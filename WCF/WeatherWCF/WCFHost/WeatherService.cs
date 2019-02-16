using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;

namespace WCFHost
{
    public partial class WeatherService : ServiceBase
    {
        public ServiceHost serviceHost = null;
        public WeatherService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }
             
            //Create a URI to serve as the base address
            //Uri httpUrl = new Uri("http://localhost:8090/MyService/WeatherService");

            serviceHost = new ServiceHost(typeof(WeatherWCF.Service1));
            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
