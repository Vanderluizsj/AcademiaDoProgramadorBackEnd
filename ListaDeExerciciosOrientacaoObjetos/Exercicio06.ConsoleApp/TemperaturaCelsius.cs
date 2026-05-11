
namespace Exercicio06.ConsoleApp
{
    public class TemperaturaCelsius
    {
        public decimal Graus { get; set; }

        public TemperaturaCelsius(decimal graus)
        {
             Graus = graus;
        }
        public TemperaturaFahrenheit ConverterParaFahrenheit()
        {
            TemperaturaFahrenheit fahrenheit = new TemperaturaFahrenheit();

            fahrenheit.Graus = (Graus*Convert.ToDecimal(1.8))+32;

            return fahrenheit;
        }

    }
}