using System.Globalization;

namespace TP2.Parte1;

public class Exercicio1
{

    public static void IdadePrecisa()
    {
        Console.WriteLine("Digite sua data de nascimento: (dia/mês/ano)");
        var input = Console.ReadLine();
        
        
        if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dataNascimento))
        {
            // var hoje = DateTime.Now;
            var calculo = (DateTime.Now - dataNascimento).TotalDays;
            var idadeAnos = Math.Truncate(calculo / 365);
            var idadeMeses = Math.Truncate((calculo % 365) / 30);
            var idadeDias = Math.Truncate((calculo % 365) % 30);

            Console.WriteLine($"Sua idade é: {idadeAnos} anos, {idadeMeses} meses e {idadeDias} dias");
        }
        else
        {
            Console.WriteLine("Entrada fornecida é inválida.");
        }
    }
    /*
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua data de nascimento: (dia/mês/ano)");
        var input = Console.ReadLine();
        
        
        if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dataNascimento))
        {
            var hoje = DateTime.Now;
            var calculo = (DateTime.Now - dataNascimento).TotalDays;
            var idadeAnos = Math.Truncate(calculo / 365);
            var idadeMeses = Math.Truncate((calculo % 365) / 30);
            var idadeDias = Math.Truncate((calculo % 365) % 30);

            Console.WriteLine($"Sua idade é: {idadeAnos} anos, {idadeMeses} meses e {idadeDias} dias");
        }
        else
        {
            Console.WriteLine("Entrada fornecida é inválida.");
        }
    }*/
}

/*
solicitar data de nascimento   X

calcular idade exata em anos meses e dias

considerar ano bissexto

:C para formatação
*/