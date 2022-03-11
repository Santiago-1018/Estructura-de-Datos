using System;
public class mes


{
    public static void main(String[] args)
    {
        
        int mes;
        Console.Write("Introduzca número de mes: ");
        if (mes < 1 || mes > 12)                          
            System.out.println("Mes incorrecto");
        else
        {  
            switch (mes)
            {          
                case 1:
                    Console.Write("Enero");
                    break;
                case 2:
                    Console.Write("Febrero");
                    break;
                case 3:
                    Console.Write("Marzo");
                    break;
                case 4:
                    Console.Write("Abril");
                    break;
                case 5:
                    Console.Write("Mayo");
                    break;
                case 6:
                    Console.Write("Junio");
                    break;
                case 7:
                    Console.Write("Julio");
                    break;
                case 8:
                    Console.Write("Agosto");
                    break;
                case 9:
                    Console.Write("Septiembre");
                    break;
                case 10:
                    Console.Write("Octubre");
                    break;
                case 11:
                    Console.Write("Noviembre");
                    break;
                case 12:
                    Console.Write("Diciembre");
                    break;
            }
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                Console.Write(" es un mes de 30 días");
            else if (mes == 2)
                Console.Write(" es un mes de 28 días");
                   else
                Console.Write(" es un mes de 31 días");
        }
    }
}
