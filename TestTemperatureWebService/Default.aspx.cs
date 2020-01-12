using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestTemperatureWebService
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConvertCToF_Click(object sender, EventArgs e)
        {
            var client = new TemperatureWebService.TemperatureWebserviceSoapClient();
            textResult.Text = client.ConvertToFahrenheit(double.Parse(textInput.Text)).ToString();
        }

        protected void ConvertFToC_Click(object sender, EventArgs e)
        {
            var client = new TemperatureWebService.TemperatureWebserviceSoapClient();
            textResult.Text = client.ConvertToCelsius(double.Parse(textInput.Text)).ToString();
        }
    }
}