namespace TemperatureConverter
{
    public class Converter
    {
        public string ConvertCToF(double celcius)
        {
            var fahrenheit = celcius * 9 / 5 + 32;
            return $"Converted {celcius}C to {fahrenheit}F";
        }

        public double CToFAsDouble(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        public string ConvertFToC(double fahrenheit)
        {
            var celsius = (fahrenheit - 32) * 5 / 9;
            return $"Converted {fahrenheit}F to {celsius}C";
        }

        public double FToCAsDouble(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
