using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WeatherWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public double Celcius(double f)
        {
            double c = 5.0 / 9.0 * (f - 32);

            return c;
        }
         public double Farenhit(double celsius)
        {
            double faren = (celsius * 9) / 5 + 32;

            return faren;
        }
        
    }
}
