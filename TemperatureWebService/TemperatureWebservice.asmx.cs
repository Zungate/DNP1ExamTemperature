using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TemperatureConverter;

namespace TemperatureWebService
{
    /// <summary>
    /// Summary description for TemperatureWebservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TemperatureWebservice : System.Web.Services.WebService
    {
        Converter converter;

        public TemperatureWebservice()
        {
            converter = new Converter();
        }

        [WebMethod]
        public double ConvertToCelsius(double temperatureF)
        {
            return converter.FToCAsDouble(temperatureF);
        }


        [WebMethod]
        public double ConvertToFahrenheit(double temperatureC)
        {
            return converter.CToFAsDouble(temperatureC);
        }
    }
}
