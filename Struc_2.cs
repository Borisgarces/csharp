/*
81. Crea un "struct" para almacenar algunos datos de personas, de momento sólo:
nombre (cadena de texto), edad (byte) y estatura en metros (real de simple
precisión). Pide al usuario datos de 2 personas (sin usar todavía ningún array)
y luego muéstralos.
*/
using System;
using System.Linq;

namespace Struc_2
{
	public static class Program
	{

		struct datosPersonales
		{
			public string nombre;
			public byte edad;
			public float estatura;
		}


		public static void Main()
		{


			char a;




			do
			{

				Console.WriteLine("Marque");
				Console.WriteLine("1 . Si quiere introducir datos.");
				Console.WriteLine("0 . Si quiere salir");
				a = Convert.ToChar(Console.ReadLine());

				if (a != '0')
				{


					datosPersonales persona;

					Console.Write("Nombre: ");
					persona.nombre = Console.ReadLine();

					Console.Write("Edad: ");
					persona.edad = Convert.ToByte(Console.ReadLine());

					Console.Write("Estatura: ");
					persona.estatura = Convert.ToSingle(Console.ReadLine());


		            Console.WriteLine();
					Console.WriteLine(persona.nombre);
					Console.WriteLine(persona.edad);
				    Console.WriteLine(persona.estatura);
				    Console.WriteLine();

				}


			} while (a != '0');





			if (a == '0')
				Console.WriteLine("Hasta pronto");





		}
	}
}
