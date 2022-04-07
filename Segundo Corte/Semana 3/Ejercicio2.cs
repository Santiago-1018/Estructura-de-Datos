using System;
using System.Collections;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Lista = new ArrayList();

            Console.WriteLine ("La lista es:");
            
            Lista.Add(2);    Lista.Add(42);
            Lista.Add(8);    Lista.Add(64);
            Lista.Add(16);   Lista.Add(88);
            Lista.Add(26);   Lista.Add(100);
  
            MostrarLista (Lista);

        }
        static void MostrarLista (ArrayList array)
        {
            foreach (int n in array)
                Console.Write ($"{n}");
        }
        
        static void ListaCuadratica (ArrayList array)
        {
            foreach (int n in array)
                Console.Write ($" {n*n} ");

            Console.WriteLine ("El resultado de los  valores elevados al cuadrado es: "); 
                 ListaCuadratica (Lista);

        }

        static void ListaSumatoria (ArrayList array)
        {
            int resultado = 0;
            
            foreach (int n in array)
            resultado + (n*n);
            Console.Write ($" {resultado}");

            Console.WriteLine ("La suma de los numeros elevados al cuadrado es: ");
                 ListaSumatoria (Lista);
        }
    }
}