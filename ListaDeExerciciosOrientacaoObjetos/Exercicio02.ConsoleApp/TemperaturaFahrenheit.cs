
namespace Exercicio02.ConsoleApp
{
    public class TemperaturaFahrenheit
    {
        public decimal Graus { get; set; }

        public TemperaturaFahrenheit(decimal graus)
        {
            Graus = graus;
        }
        public TemperaturaCelsius ConverterParaCelcius()
        {
            TemperaturaCelsius celsius = new TemperaturaCelsius();
            celsius.Graus = (Graus - 32) * 5 / 9;

            return celsius;
        }
    }
}