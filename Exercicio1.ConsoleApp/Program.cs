using System;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            Console.Write("Digite o valor A: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor C: ");
            C = double.Parse(Console.ReadLine());

            if (A + B < C)
                Console.WriteLine("A + B é menor que C");
            else 
                Console.WriteLine("A + B não é menor que C!");
        }
    }
}
