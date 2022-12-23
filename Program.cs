using System;
using System.Linq;

namespace ArraysBidimencionales3
{
	public static class Program
	{
		public static void Main()
		{

			double[,] numeros = new double[2, 5];


			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					Console.Write("Ingresa un número {0}: ", i + 1);
					numeros[i,j] = Convert.ToDouble(Console.ReadLine());
				}

			}
			
			for (int i = 0 ; i < numeros.GetLength(0); i++)
			{
				for( int j= 0; j < numeros.GetLength(1) ; j ++)
				{
					Console.Write(numeros[i,j]);
				}
				Console.WriteLine();
			}
			
			





		}
	}
}