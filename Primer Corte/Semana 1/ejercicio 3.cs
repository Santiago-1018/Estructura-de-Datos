using System;

namespace programaCalificaciones
{
public class Program
{
	public static void Main()
	{
		
            Console.WriteLine("Bienvenido");
            double calificación1, calificación2, calificación3, calificación4;
            Console.WriteLine("Ingresa la primera nota ");
            calificación1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la segunda nota ");
            calificación2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la tercera nota ");
            calificación3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la cuarta nota ");
            calificación4 = int.Parse(Console.ReadLine());

            double promedio;
            promedio = (calificación1 + calificación2 + calificación3 + calificación4) / 4;
            Console.WriteLine("El promedio es " + promedio);
            if(calificación1 < calificación2 && calificación1 < calificación3 && calificación1<calificación4)
            {
                Console.WriteLine("La nota minima es la primera"); 
                Console.ReadLine();
            }
            if(calificación2 < calificación1 && calificación2 < calificación3 && calificación2 < calificación4)
            { 
                Console.WriteLine("La nota minima es la segunda ");
            Console.ReadLine();
            }
            if (calificación3 < calificación1 && calificación3 < calificación2 && calificación3 < calificación4)
            {
                Console.WriteLine("La nota minima es la tercera ");
                Console.ReadLine();
            }
            if (calificación4 < calificación1 && calificación4 < calificación2 && calificación4 < calificación3)
            {
                Console.WriteLine("La nota minima es la cuarta ");
                Console.ReadLine();
            }
            if (calificación1 > calificación2 && calificación1 > calificación3 && calificación1 > calificación4)
            {
                Console.WriteLine("La nota mayor es la primera");
                Console.ReadLine();
            }
            if (calificación2 > calificación1 && calificación2 > calificación3 && calificación2 > calificación4)
            {
                Console.WriteLine("La nota mayor es la segunda ");
                Console.ReadLine();
            }
            if (calificación3 > calificación1 && calificación3 > calificación2 && calificación3 > calificación4)
            {
                Console.WriteLine("La nota mayor es la tercera ");
                Console.ReadLine();
            }
            if (calificación4 > calificación1 && calificación4 > calificación2 && calificación4 > calificación3)
            {
                Console.WriteLine("La nota mayor es la cuarta ");
                Console.ReadLine();
            }

    }
}
}