using System;
using System.Linq;

namespace Ejercicio_80
{
	public static class Program
	{
		public static void Main()
		{
			byte lineas = 0;
			double capacidad = 0;
			double suma = 0;


			Console.WriteLine();
			Console.Write("Cuantas líneas tendra la tabla: ");
			lineas = Convert.ToByte(Console.ReadLine());
			Console.WriteLine();



			double[][] numeros = new double[lineas][];

			Console.WriteLine("Cuantos datos habrá en ");
			for (int i = 0; i < lineas; i++)
			{
				Console.Write("la línea: {0}: ", i + 1);
				capacidad = Convert.ToDouble(Console.ReadLine());
				numeros[i] = new double[(int)(capacidad)];
			}

			Console.WriteLine();

			for (int i = 0; i < numeros.Length; i++)
			{
				for (int j = 0; j < numeros[i].Length; j++)
				{

					Console.Write("Añadiendo valores en la línea {0}: ", i + 1);
					double n = Convert.ToDouble(Console.ReadLine());

					numeros[i][j] = n;
				}
				Console.WriteLine();
			}



			for (int i = 0; i < numeros.Length; i++)
			{
				for (int j = 0; j < numeros[i].Length; j++)
				{

					Console.Write("{0} ", numeros[i][j]);
				}
				Console.WriteLine();
			}

			Console.WriteLine();



			int k = 0;
			for (int i = 0; i < numeros.Length; i++)
			{

				for (int j = 0; j <= numeros.Length; j++)
				{

					if (i == k)
						suma += numeros.Length;
					numeros[i][j] = suma;

				}
				suma = 0;
				k++;
				Console.WriteLine();
			}


		
			for (int i = 0; i < numeros.Length; i++)
			{
				for (int j = 0; j <= numeros.Length; j++)
				{

					if (i == i)
						Console.Write(" El valor es {0} ", numeros[i][j]);

				}

				
				Console.WriteLine();
			}






		}
	}
}