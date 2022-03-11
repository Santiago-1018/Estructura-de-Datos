using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.collections.Generic;

namespace
{
 class Program
    {
        static void Main(string[] args)
        {
            int Insufuciente_50<, suficiente_50_60>, Bien_60_79>, Notable_70_89>,sobresaliente_90_100>;
            int estudiante1 = 0;
            int estudiante2 = 0;
            int estudiante3 = 0;
            int estudiante4 = 0;
            int estudiante5 = 0;
            int Resultado = 0;

            Console.WriteLine("1.-  matematicas"); 
            Console.WriteLine("2.-  español"); 
            Console.WriteLine("3.-  ingles"); 
            Console.WriteLine("4.-  fisica");
            Console.WriteLine("");


            Console.WriteLine("Que materia desea mostrar: ");
            Opcion = int.Parse(System.Console.ReadLine()) ;

            Console.WriteLine("Dame el nombre de la materia por favor: ");
            matematicas= int.Parse(System.Console.ReadLine());

            Console.Write("Dame el numero del estudiante: ");
            estudiante1 = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el numero del estudiante: ");
            estudiante2 = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el numero del estudiante: ");
            estudiante3 = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el numero del estudiante: ");
            estudiante4 = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el numero del estudiante: ");
            estudiante5 = int.Parse(System.Console.ReadLine());


             Opcion = int.Parse(System.Console.ReadLine()) ;
            if (Opcion == 1)
                Resultado = sobresaliente_90_100>;
            if (Opcion == 2)
                Resultado = Insufuciente_50<;
            if (Opcion == 3)
                Resultado = suficiente_50_60>;
            if (Opcion == 4)
                Resultado = Bien_60_79>;
            if (Opcion == 5) 
                Resultado = Notable_70_89>;
                 
                 Console.WriteLine("El Resultado  es: {Resultado}");
        
        
        }
    }
}