namespace TP2.Parte4;

public class Exercicio11
{
    public void TabuadaInterativa()
    {
        Console.WriteLine("Tabuada! Digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        List<String>tabuada = new List<String>();

        for(int i = 1; i <= 10; i++){
            tabuada.Add($"{num} x {i} = {num * i}");
        }

        Console.WriteLine($"Tabuada do {num}: \n{string.Join("\n", tabuada)}");
    }
}