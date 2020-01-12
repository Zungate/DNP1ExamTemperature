namespace TemperatureConverter
{
    public class Converter
    {
        public string ConvertCToF(double celcius)
        {
            var fahrenheit = celcius * 9 / 5 + 32;
            return $"Converted {celcius}C to {fahrenheit}F";
        }

        public string ConvertFToC(double fahrenheit)
        {
            var celcius = (fahrenheit - 32) * 5 / 9;
            return $"Converted {fahrenheit}F to {celcius}C";
        }
    }
}
