namespace TP2.Parte2;

public class Exercicio4
{
    public void FormCadastroSimples()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        string idade= Console.ReadLine();
        Console.WriteLine("Digite seu telefone : ");
        string telefone = Console.ReadLine();
        Console.WriteLine("Digite seu e-mail: ");
        string email= Console.ReadLine();

        Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nTelefone: {telefone}\nE-mail: {email}");
    }
}