class Program
{
    public static void Main()
    {
        //Tipo nomeDaVariavel

        double num1, num2;

        Console.WriteLine("Informe um número:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe outro número:");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(" ");

        double soma =(double) num1 + (double)num2;
        double subt = (double) num1 - (double)num2;
        double div = num1 / num2;
        double multi = (double) num1 * (double)num2;

        Console.WriteLine($"A soma dos valores é: \n {soma} \n");
        Console.WriteLine($"A subtração dos valores é: \n {subt} \n");
        Console.WriteLine($"A divisão dos valores é: \n {div} \n");
        Console.WriteLine($"A multiplicação dos valores é: \n {multi} \n");


        Console.WriteLine("\n Digite um nome");
        string nome = Console.ReadLine();

        Console.WriteLine("{0} fez a soma de {1} + {2} e deu {3}", nome, num1, num2, soma);
    }
}
