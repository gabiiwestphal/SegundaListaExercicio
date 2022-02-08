using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, IMC;

            Console.WriteLine("indique o peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("indique a altura: ");
            altura = double.Parse(Console.ReadLine());

            IMC = peso / Math.Pow(altura, 2);

            if (IMC < 18.5)
                Console.WriteLine("abaixo do peso");
            else
                if (IMC > 18.5 && IMC <= 25)
                Console.WriteLine("peso normal");
            else 
                if (IMC > 25 && IMC < 30)
                Console.WriteLine("acima do peso");
            else 
                if (IMC > 30)
                Console.WriteLine("obeso");

        }
    }
}
