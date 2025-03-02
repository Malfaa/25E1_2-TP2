using System.Collections;

namespace TP2.Parte4;

public class Exercicio10
{
    public void ContagemRegressiva()
    {
        Console.WriteLine("Contagem Regressiva! Digite um valor para iniciar: ");
        int contagem = Convert.ToInt32(Console.ReadLine());

        List<int> lista = new List<int>();

        for(int i = contagem; i >= 0; i--){
            lista.Add(i);
        }
        Console.WriteLine($"Contagem: {string.Join(", ", lista)}");
    }
}