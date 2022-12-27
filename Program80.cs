/*80. Crea una variante del programa anterior, que pregunte al usuario cuántos 
datos guardará en un primer bloque de números reales de doble precisión, 
luego cuántos datos guardará en un segundo bloque, y finalmente pida todos esos datos. 
Los debe guardar en un array de arrays. Después mostrará el promedio de los valores que 
hay guardados en el primer subarray, luego el promedio de los valores en el segundo subarray 
y finalmente el promedio global.*/
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
			double valor = 0;
			double sumaglobal = 0;
			double promedio = 0;
            double promedioglobal=0;

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



			for (int i = 0; i < lineas; i++)
			{
				for (int j = 0; j < capacidad; j++)
				{

					Console.Write("{0} ", numeros[i][j]);
				}
				Console.WriteLine();
			}

			Console.WriteLine();



			// suma de cada línea		

			for (int i = 0; i < lineas; i++)
			{

				for (int j = 0; j < capacidad; j++)
				{


					suma += numeros[i][j];
					numeros[i][j] = suma;


				}
				suma = 0;
				Console.WriteLine();
			}





			for (int i = 0; i < lineas; i++)
			{

				for (int j = 0; j < capacidad; j++)
				{

					suma = numeros[i][j];

				}
				Console.WriteLine("La suma de la línea{0} es {1}", i + 1, suma);
			}
			Console.WriteLine();



			//promedio de cada línea

			for (int i = 0; i < lineas; i++)
			{

				for (int j = 0; j < capacidad; j++)
				{

					suma = numeros[i][j];
					promedio = suma / capacidad;

				}
				Console.WriteLine("El promedio de la línea {0} es {1}", i + 1, promedio);
			}



			// suma y promedio global

			for (int i = 0; i < lineas; i++)
			{

				for (int j = 0; j < lineas; j++)
				{

					valor = numeros[i][j];
					sumaglobal = sumaglobal + valor;
					promedioglobal=sumaglobal/lineas;

				}
				Console.WriteLine();
			}


			Console.WriteLine("La suma global es {0}", sumaglobal);
			Console.WriteLine("El promedio global es {0}", promedioglobal);

		}
	}
}
