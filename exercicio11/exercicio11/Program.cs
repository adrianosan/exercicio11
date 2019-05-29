using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            double resultado = 0;
            Console.Write("digite um número: ");
            n = double.Parse(Console.ReadLine());
            resultado = n / 3;
            Console.WriteLine("A terça parte deste número é: {0:#.00}", resultado);

        }
    }
}
