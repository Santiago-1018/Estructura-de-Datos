using System;
using System.Collections;

namespace Aplicacionbase
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Lista1 = new ArrayList();

            Console.WriteLine ("La lista numero 1 es:");
            Lista1.Add(1);    Lista1.Add(6);
            Lista1.Add(2);    Lista1.Add(7);
            Lista1.Add(3);    Lista1.Add(8);
            Lista1.Add(4);    Lista1.Add(9);
            Lista1.Add(5);    Lista1.Add(10);


            muestra (Lista1);
            ArrayList Lista2 = new ArrayList();
            
            Console.WriteLine ("La lista numero 2 es:");

            Lista2.Add(1);    Lista2.Add(6);
            Lista2.Add(2);    Lista2.Add(7);
            Lista2.Add(3);    Lista2.Add(8);
            Lista2.Add(4);    Lista2.Add(9);
            Lista2.Add(5);    Lista2.Add(10);
            
            muestra (Lista2);
            ArrayList Lista3 = new ArrayList();

            Console.WriteLine ("LA lista numero 3 es:");

            Lista3.Add(1);    Lista3.Add(6);
            Lista3.Add(2);    Lista3.Add(7);
            Lista3.Add(3);    Lista3.Add(8);
            Lista3.Add(4);    Lista3.Add(9);
            Lista3.Add(5);    Lista3.Add(10);

            muestra (Lista3);
            ArrayList Lista4 = new ArrayList();

            Console.WriteLine ("La lista numero 4 es:");

            Lista4.Add(1);    Lista4.Add(6);
            Lista4.Add(2);    Lista4.Add(7);
            Lista4.Add(3);    Lista4.Add(8);
            Lista4.Add(4);    Lista4.Add(9);
            Lista4.Add(5);    Lista4.Add(10);

            muestra (Lista4);

            ArrayList Lista = new ArrayList();

            Lista1.AddRange(Lista2);
            Lista1.AddRange(Lista3);
            Lista1.AddRange(Lista4);

            muestra (Lista1);

                Console.WriteLine("\n---------");

         static void muestra (ArrayList array)
            {
                foreach (int n in array)

                    Console.WriteLine("{0},", n);
            }
        }
    }
}