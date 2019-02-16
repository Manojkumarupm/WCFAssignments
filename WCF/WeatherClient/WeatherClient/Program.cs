using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherClient
{
    class Program
    {
        static void Main(string[] args)
        { 
            //creating the object of WCF service client       
            ServiceReference1.Service1Client weather = new ServiceReference1.Service1Client();
            Double Celcius,Ferenhit;
            //assigning the input values to the variables    
            Console.WriteLine("Enter Celcius Value");
            Double.TryParse(Console.ReadLine(),out Celcius);
            Console.WriteLine("Farenhit Value for {0} is {1}",Celcius,weather.Farenhit(Celcius));
            Console.WriteLine("Enter Ferenhit Value");
            Double.TryParse(Console.ReadLine(), out Ferenhit);
            Console.WriteLine("Celcius Value for {0} is {1}", Ferenhit, weather.Celcius(Ferenhit));


            Console.ReadLine();  
        }
    }
}
