
class Program
{
    public static void Main()
    {


        Console.WriteLine("Informe seu ano de nascimento: ");

        int anoNasc = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Informe o ano atual: ");

        int anoAtual = Convert.ToInt32(Console.ReadLine());

        int idade = anoAtual - anoNasc;

        Console.WriteLine($"Sua idade ao fim do ano será: {idade}");

    }
}
