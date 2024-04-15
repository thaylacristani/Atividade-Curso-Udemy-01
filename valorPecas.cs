using System;
using System.Reflection.Metadata;

namespace Pecas;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o código, a quantidade e o valor da primeira peça: ");
        string[] entrada1 = Console.ReadLine().Split(' ');

        string codigoPeca1 = entrada1[0];
        int numPeca1 = int.Parse(entrada1[1]);
        double valorPeca1 = double.Parse(entrada1[2]);

        Console.WriteLine("\nInforme o código, a quantidade e o valor da segunda peça: ");
        string[] entrada2 = Console.ReadLine().Split(' ');

        string codigoPeca2 = entrada2[0];
        int numPeca2 = int.Parse(entrada2[1]);
        double valorPeca2 = double.Parse(entrada2[2]);

        double totalPeca1 = numPeca1 * valorPeca1;
        double totalPeca2 = numPeca2 * valorPeca2;

        double valorTotal = totalPeca1 + totalPeca2;

        Console.WriteLine("\nO valor total das peças é: R$ "+ valorTotal);
    }
}
