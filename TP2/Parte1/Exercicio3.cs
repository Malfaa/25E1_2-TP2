using System.Globalization;

namespace TP2.Parte1;

public class Exercicio3
{
    public void DiferencaEntreDuasDatas()
    {
        Console.WriteLine("Digite uma data!(01/02/2000): ");
        String primeiraData = Console.ReadLine()!;

        Console.WriteLine("Digite uma outra data!(10/09/2000): ");
        String segundaData = Console.ReadLine()!;

        
        DateTime primeira = ParseData(primeiraData);
        DateTime segunda = ParseData(segundaData);

        int dias = segunda.Day - primeira.Day;
        int anos = segunda.Year - primeira.Year;
        int meses = segunda.Month - primeira.Month;

        if (dias < 0)
        {
            meses--;
            dias += 30;
            if (meses < 0)
            {
                anos--;
                meses += 12;
            }
        }

        Console.WriteLine($"A diferença entre a data de {primeira} para {segunda} é de: \nDias: {dias}\n" +
                          $"Meses: {meses}\nAnos: {anos}");
        
    }

    private DateTime ParseData(String data)
    {
        DateTime.TryParseExact(data, "dd/MM/yyyy", null, DateTimeStyles.None,
            out DateTime resultado);
        return resultado;
    }
}