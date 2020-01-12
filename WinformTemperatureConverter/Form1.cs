using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TemperatureConverter;

namespace WinformTemperatureConverter
{
    public partial class Form1 : Form
    {
        Converter converter;
        public Form1()
        {
            InitializeComponent();
            converter = new Converter();
        }

        private void btnCelciusToFahrenheit_Click(object sender, EventArgs e)
        {
            double result;
            bool isDouble = Double.TryParse(inputTemp.Text, out result);
            if(isDouble)
                listBoxConversions.Items.Add(converter.ConvertCToF( result));
        }

        private void btnFahrenheitToCelcius_Click(object sender, EventArgs e)
        {
            double result;
            bool isDouble = Double.TryParse(inputTemp.Text, out result);
            if (isDouble)
                listBoxConversions.Items.Add(converter.ConvertFToC(result));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XElement element = new XElement("Temperatures");

            foreach (var item in listBoxConversions.Items)
            {
                element.Add(new XElement("Temp", item));
            }

            XDocument document = new XDocument();
            document.Add(element);

            // Added a bit extra for funs.
            saveAsXML.DefaultExt = "xml";
            saveAsXML.Filter = "Data Files (*.xml)|*.xml";
            saveAsXML.AddExtension = true;
            saveAsXML.ShowDialog();
            
            if(saveAsXML.FileName != "")
            {
                document.Save(saveAsXML.FileName, SaveOptions.DisableFormatting);
                lblSaveStatus.Text += "(Saved)";
            }
        
        }
    }
}
