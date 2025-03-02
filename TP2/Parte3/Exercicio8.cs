namespace TP2.Parte3;

public class Exercicio8
{
    public void ClassificacaoNotaEscolar()
    {
        Console.WriteLine("Digite sua nota: (0-10)");
        double nota = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Sua nota está {VerificarNota(nota)}");
    }
    private String VerificarNota(double nota)
    {
        switch (nota)
        {
            case < 7:
                return "Insuficiente";
            case < 8:
                return "Regular";
            case < 9:
                return "Bom";
            case < 10:
                return "Excelente";
            default:
                return "Valor inválido";
        }
    }
}