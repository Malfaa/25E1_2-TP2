namespace TP2.Parte3;

public class Exercicio9
{
    public void CalcSalarioLiquido()
    {
        Console.WriteLine("Digite salário bruto: ");
        double salarioBruto = Convert.ToDouble(Console.ReadLine());

        double imposto = 0.09;

        double salarioLiquido = salarioBruto - (salarioBruto * 0.09);

        Console.WriteLine($"Salário Bruto: R${salarioBruto}\nImposto: {imposto*100}%\nSalário Líquido: R${salarioLiquido}");
    }
}