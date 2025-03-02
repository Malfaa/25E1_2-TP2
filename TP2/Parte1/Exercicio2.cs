using System.Globalization;

namespace TP2.Parte1;

public class Exercicio2
{
    public void ProximoAniversario()
    {
        Console.WriteLine("Digite sua data de nascimento: ");
        String dataNascimentoString = Console.ReadLine()!;

        var atual = DateTime.Now;
        if (DateTime.TryParseExact(dataNascimentoString, "dd/MM/yyyy", null, DateTimeStyles.None,
                out DateTime resultado))
        {
            int diasParaAniversario;
            
            if (resultado.DayOfYear - atual.DayOfYear < 0)
            {
                diasParaAniversario = DateTime.IsLeapYear(atual.Year) ? 366 : 365 + (resultado.DayOfYear - atual.DayOfYear);
            }
            else
            {
                diasParaAniversario = resultado.DayOfYear - atual.DayOfYear;
            }
            Console.WriteLine($"Faltam {diasParaAniversario} dias para o seu aniversário!");

        }
        else
        {
            Console.WriteLine("Valor colocado inválido");
        }

        
    }
}