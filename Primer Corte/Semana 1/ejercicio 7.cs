using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace VariablesEnteras
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
             int B;
             int C;

            int A=500;
            int B=200;
            int C=300;

          Console.WriteLine("Hola Mundo");

            int VALOR1=500;
            int VALOR2=200;
            int VALOR3=300;
            int Resultado=1000;

            Resultado = VALOR1 + VALOR2 + VALOR3;
            Console.WriteLine("");
            Console.WriteLine("La suma de ({0} * {1} + {2} = {3}", VALOR1, VALOR2, VALOR3, Resultado);
        }
    }
}