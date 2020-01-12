using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverter;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new Converter();
            Console.WriteLine("B:\r\n");
            Console.WriteLine(converter.ConvertCToF(20));

            Console.WriteLine("C:\r\n");
            double[] TemperaturesFahrenheit = { 60.0, 68.4, 72.2, 80.1, 20.8, 12.2 };

            foreach(var tempF in TemperaturesFahrenheit)
            {
                Console.WriteLine(converter.ConvertFToC(tempF));
            }
        }


    }
}
