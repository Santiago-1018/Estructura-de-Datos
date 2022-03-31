using System;

namespace NotasExamen 
{
    class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Digite el numero de estudiantes: ");
            estudiantes = int.Parse(System.Console.ReadLine());
            int estudiantes = 0;
            {
                 double[,] matriz1 = new double[estudiantes, 3];
                 int i = 0;
            }

            
            while 
            
            i < estudiantes

            {

                Console.WriteLine("Nota Numero 1:");
            
                Console.WriteLine("Nota Numero 2:");

                Console.WriteLine("Nota Numero 3:");


                double N1 = double.Parse(System.Console.ReadLine());

                double N2 = double.Parse(System.Console.ReadLine());

                double N3 = double.Parse(System.Console.ReadLine());

            }
            

            {
                matriz

                [i, 0] = N1;
                
                [i, 1] = N2;
                
                [i, 2] = N3;

                (i++);
            }

           

            while 
            
            a < estudiantes

            {
                double estudianteprom = (matriz[a, 0] + [a, 1] + [a, 2] / 3);
                Console.WriteLine("El promedio del estudiante " + a + " es: " + estudianteprom) (suma = suma + estudianteprom);
                (a++);
            }
        }
    }
}