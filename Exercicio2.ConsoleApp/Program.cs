using System;

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroValor, segundoValor, terceiroValor;

            Console.WriteLine("indique o primeiro valor: ");
            primeiroValor = int.Parse(Console.ReadLine());

            Console.WriteLine("indique o segundo valor: ");
            segundoValor = int.Parse(Console.ReadLine());

            Console.WriteLine("indique o terceiro valor: ");
            terceiroValor = int.Parse(Console.ReadLine());

            if (primeiroValor > segundoValor && segundoValor > terceiroValor)
                Console.WriteLine(" {0} {1} {2} ", primeiroValor, segundoValor, terceiroValor);
            else
                if (primeiroValor > segundoValor && primeiroValor > terceiroValor && terceiroValor > segundoValor)
                Console.WriteLine(" {0} {1} {2} ", primeiroValor, terceiroValor, segundoValor);
            else
                if (segundoValor > primeiroValor && primeiroValor > terceiroValor)
                Console.WriteLine(" {0} {1} {2} ", segundoValor, primeiroValor, terceiroValor);
            else
                if (segundoValor > primeiroValor && segundoValor > terceiroValor && terceiroValor > primeiroValor)
                Console.WriteLine(" {0} {1} {2} ", segundoValor, terceiroValor, primeiroValor);
            else
                if (terceiroValor > segundoValor && segundoValor > primeiroValor)
                Console.WriteLine(" {0} {1} {2} ", terceiroValor, segundoValor, primeiroValor);
            else
                if (terceiroValor > segundoValor && primeiroValor > segundoValor)
                Console.WriteLine(" {0} {1} {2} ", terceiroValor, primeiroValor, segundoValor);

        }
    }
}
