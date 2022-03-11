using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.collections.Generic;

namespace AplicacionBase
{
    class Program
    {
          static void Main(string[] args)
        {  

        int Numero >= 0;

        System.Console.WriteLine("Regalame un número");
        System.Console.WriteLine("Regalame un número");
        System.Console.WriteLine("Regalame un número");
        System.Console.WriteLine("Regalame un número");
        System.Console.WriteLine("Regalame un número");
        System.Console.WriteLine("Regalame un número");
        System.Console.WriteLine("Regalame un número");
        System.Console.WriteLine("Regalame un número");
        System.Console.WriteLine("Regalame un número");
        System.Console.WriteLine("Regalame un número");
        
            Numero = int.Parse(System.Console.ReadLine());

            if (Numero >= 0)
         {
            Console.WriteLine("");
            Console.WriteLine("el número {0} es positivo", Numero);
            }else
            Console.WriteLine("El número {0} es negativo", Numero);


            double[] Numero = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
		
		double sumatoria = 0;
		
		foreach(double Numero in Numeros){
			
			sumatoria += Numeros;
		}
		
		double promedio = sumatoria / Numeros.Length;
    Console.WriteLine("Promedio: " + promedio);

        var results = from p in MyList
               group p by p.CodeColor into grupo
               select new {

                  Color = grupo.positivo,
                    Color = grupo.negativo,
                  Total = grupo.Sum(x=> x.QuantityxSize)

               };
    }
  }
}
