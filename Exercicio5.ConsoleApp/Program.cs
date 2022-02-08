using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C = 0;

            Console.Write("Digite o valor A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            B = int.Parse(Console.ReadLine());

            if (A == B)
                C = A + B;
            else
                C = A * B;

            Console.WriteLine("\nO valor C é: " + C);
        }
    }
}
