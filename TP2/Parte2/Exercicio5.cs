namespace TP2.Parte2;

public class Exercicio5
{
    public void ConversorTemperatura()
    {
        Console.WriteLine("Digite um valor em graus °C para a conversão!");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double kelvin = celsius +  273.15;
        double fahrenheit = celsius * 9/5 + 32;

        Console.WriteLine($"\n{celsius:F2}°C para:\n\nKelvin: {kelvin:0F2}K\nFahrenheit: {fahrenheit:F2}°F");
    }
}