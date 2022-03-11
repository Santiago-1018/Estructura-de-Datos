using System;
public class ascedesc
{

	public static void Main(string[] args)
	{
		int num1;
		int num2;
		int num3;
		int num4;
		int num5;
		int num6;
		int num7;
		int num8;
		int num9;
		int num10;
		int resp;
		int mayor;
		int menor;
		int medio;
		Console.WriteLine("Bienvenidos al primer programa de Programacio" +
            "n ");
		Console.Write(" Escriba primer nuemro entero \t ");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write(" Escriba segundo nuemro entero \t ");
		num2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Escriba tercer numero entero \t ");
		num3 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Escriba cuarto numero entero \t ");
		num4 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Escriba quinto numero entero \t ");
		num5 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Escriba sexto numero entero \t ");
		num6 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Escriba septimo numero entero \t ");
		num7 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Escriba octavo numero entero \t ");
		num8 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Escriba noveno numero entero \t ");
		num9 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Escriba decimo numero entero \t ");
		num10 = Convert.ToInt32(Console.ReadLine());
		if (num1 > num2)
			mayor = num1;
		else mayor = num2;
		if (num3 > num4)
			mayor = num3;
		else mayor = num4;
		if (num5 > num6)
			mayor = num5;
		else mayor = num6;
		if (num7 > num8) 
			mayor = num7;
		else mayor = num8;
		if (num8 > num9)
			mayor = num9;
		else mayor = num10;
		if (num1 < num2)
			menor = num1;
		else menor = num2;
		if (num3 < num4)
			menor = num3;
		else menor = num4;
		if (num5 < num6)
			menor = num5;
		else menor = num6;
		if (num7 < num8)
			menor = num7;
		else menor = num8;
		if (num9 < num10)
			menor = num9;
		else menor = num10;
		if ((num1 != mayor) & (num1 != menor))
		{
			medio = num1;
		}
		else
		{
			if ((num3 != mayor) & (num3 != menor))
			{
				medio = num3;
			}
			else
			if ((num4 != mayor) & (num4 != menor))
			{
				medio = num4;
			}
			else
		   if ((num5 != mayor) & (num5 != menor))
			{
				medio = num5;
			}
			else
		    if ((num6 != mayor) & (num6 != menor))
			{
				medio = num6;
			}
			else
			if ((num7 != mayor) & (num7 != menor))
			{
				medio = num7;
			}
			else
			if ((num8 != mayor) & (num8 != menor))
			{
				medio = num8;
			}
			else
		      if ((num9 != mayor) & (num9 != menor))
			{
				medio = num9;
			}
		    else
			if ((num10 != mayor) & (num10 != menor))
			{
				medio = num10;
			}
		}
		Console.WriteLine("¿como desea ordenarlos ?");
		Console.WriteLine("ascendentemente....1");
		Console.WriteLine("Descendentemente...2");
		resp = Convert.ToInt32(Console.ReadLine());
		if (resp == 1)
		{
			Console.WriteLine("eligio el modo ascendente");
			Console.WriteLine("el menor es: {0}", menor);
			Console.WriteLine("el medio es: {0}", medio);
			Console.WriteLine("el mayor es: {0}", mayor);
		}
		if (resp == 2)
		{
			Console.WriteLine("eligio el modo descendente");
			Console.WriteLine("el mayor es: {0}", mayor);
			Console.WriteLine("el medio es: {0}", medio);
			Console.WriteLine("el menor es: {0}", menor);
		}
	}
}
