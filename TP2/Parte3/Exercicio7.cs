namespace TP2.Parte3;

public class Exercicio7
{
    public void VerificarParImpar()
    {
        Console.WriteLine("Digite um número inteiro: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        if(valor % 2 == 0){
            Console.WriteLine($"O valor é PAR ({valor})");
        }else{
            Console.WriteLine($"O valor é ÍMPAR ({valor})");
        }
    }
}