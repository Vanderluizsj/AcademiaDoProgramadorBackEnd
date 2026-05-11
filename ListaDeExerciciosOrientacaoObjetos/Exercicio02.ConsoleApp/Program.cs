using Exercicio02.ConsoleApp;

System.Console.Write("Digite a temperatura em Fahrenheit: ");
decimal fahrenheit = Convert.ToDecimal(Console.ReadLine());


TemperaturaFahrenheit temperaturaFahrenheit = new TemperaturaFahrenheit(fahrenheit);

TemperaturaCelsius celsius = temperaturaFahrenheit.ConverterParaCelcius();

Console.WriteLine($"\nA conversão de {temperaturaFahrenheit.Graus:F1} ºF resultou em: {celsius.Graus:F1} ºC");