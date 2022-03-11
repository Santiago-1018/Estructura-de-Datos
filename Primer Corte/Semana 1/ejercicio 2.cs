using System;
					
namespace ProgramaPeliculas
{
public class Program
{
	public static void Main()
	{
		
            double Precio1;
            double Precio2;
            double Precio3;
            double Resultado;

            Console.Write("Ingrese el valor de la primera pelicula ");
            Precio1 =
                double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de la segunda pelicula ");
            Precio2 =
                double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de la tercera pelicula ");
            Precio3 =
                double.Parse(Console.ReadLine());
            
            if (Precio1 > Precio2 && Precio1 > Precio3)
            {
                Resultado = Precio2 + Precio3;
                Console.WriteLine("El valor a pagar es: " + Resultado);
            }
            
            else if (Precio2 > Precio1 && Precio2 > Precio3)
            {
                Resultado = Precio1 + Precio3;
                Console.WriteLine("El valor a pagar es: " + Resultado);
            }
            else
            {
                Resultado = Precio2 + Precio1;
                Console.WriteLine("El valor a pagar es: " + Resultado);
            }
            Console.ReadLine();
            Console.WriteLine("Gracias por la compra");
            Console.ReadLine();


        }
	}
}