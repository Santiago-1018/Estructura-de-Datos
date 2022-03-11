using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace RaizCuadrada
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        
            double numero = 25;
            double raizCuadrada = Math.Sqrt(numero);
            Console.WriteLine("La raíz cuadrada de {0} es {1}", numero, raizCuadrada);
        }
    }
}