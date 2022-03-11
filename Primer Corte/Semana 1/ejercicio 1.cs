using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;

namespace programaValorAbsoluto
{
    class Program
    {
        static void valorAbsoluto(int a)
        {
            Console.Write( Math,Abs(a) );
        }
        static void Main(string[] args)
        {
            int numero;
            for(int x = 0; x < 10; x++)
            {

                Console.Write("\nIngrese un Numero: ");
                numero = int.Parse(Console.ReadLine());
                valorAbsoluto(numero);
            }

            Console.ReadKey();

        }
    }
}