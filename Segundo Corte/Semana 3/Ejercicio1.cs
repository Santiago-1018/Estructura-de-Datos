using System;
using System.Collections;

namespace Aplicacionbase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            int ArraylistTamaño = 0;
            

            ArraylistTamaño = int.Parse(Console.ReadLine());
            Arraylist Lista = new Arraylist();
                Console.WriteLine("La lista numero 1");

            {
                for (int i = 0; i < ArraylistTamaño; i++);    
                n=int.Parse(Console.ReadLine());
                
                {
                    if (n != 0) {
                    Lista.Insert(i, n);
                
                     if(n == 0){
                    i = ArraylistTamaño + 1;
                }

                
                muestra (Lista,
                Console.WriteLine("\n---------"));

            }

            static void muestra (Arraylist array)
            {
                foreach (int n in array)
                array.Sort();

                Console.WriteLine("{0},", n);
            }
            
        }
    }
}