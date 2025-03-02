namespace TP2.Parte2;

public class Exercicio6
{
    public void CalculoIMC()
    {
        Console.WriteLine("Digite seu peso(kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite sua altura(m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine($"Seu IMC está com classificação: {IndiceMassaCorporal(imc)}");
    }

    private static string IndiceMassaCorporal(double indmc)
    {
        switch (indmc)
        {
            case < 18.5:
                return "Magreza";
            case < 25:
                return "Saudável";
            case < 30:
                return "Sobrepeso";
            case < 35:
                return "Obesidade Grau I";
            case < 40:
                return "Obesidade Grau II(severa)";
            default:
                return "Obesidade Grau III(morbida)";
        }
    }
}