using Exercicio06.ConsoleApp;

System.Console.Write("Digite a temperatura em Celsius: ");
decimal celsius = Convert.ToDecimal(Console.ReadLine());


TemperaturaCelsius temperaturaCelsius = new TemperaturaCelsius(celsius);

TemperaturaFahrenheit fahrenheit = temperaturaCelsius.ConverterParaFahrenheit();

Console.
    WriteLine($"\nA conversão de {temperaturaCelsius.Graus:F1} ºC resultou em: {fahrenheit.Graus:F1} ºF");