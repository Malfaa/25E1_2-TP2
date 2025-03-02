namespace TP2.Parte4;

public class Exercicio12
{
    public void JogoAdivinhacao()
    {
        Console.WriteLine("Tente adivinhar o número: (1 - 100)");
        int palpite;
        Random rnd = new Random();
        int numAleatorio = rnd.Next(100);
        do{
            palpite = Convert.ToInt32(Console.ReadLine());
            
            if(palpite == numAleatorio){
                Console.WriteLine("Boa! Você acertou!");

            }else if(palpite < numAleatorio){
                Console.WriteLine("O número que você digitou é MENOR que o número para ser adivinhado!");
            }
            else
            {
                Console.WriteLine("O número que você digitou é MAIOR que o número para ser adivinhado!");
            }
        }while(palpite != numAleatorio);



    }
}