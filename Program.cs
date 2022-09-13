using System;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			bool opcion = true;

while (opcion)
{
    Console.WriteLine("Ingrese un numero del mes del 1 al 12 Aguate el millo:");
    int num = int.Parse(Console.ReadLine());

    if (num > 0 & num < 13) {

        switch (num)
        {
            case 1:
                Console.WriteLine("Enero");
                //Console.ReadKey(true);
                opcion = false;
                Console.ReadKey(true);
                break;
            case 2:
                Console.WriteLine("Febrero");
                Console.ReadKey(true);
                opcion = false;
                break;
            case 3:
                Console.WriteLine("Marzo");
                Console.ReadKey(true);
                opcion = false;
                break;
            case 4:
                Console.WriteLine("Abril");
                Console.ReadKey(true);
                opcion = false;
                break;
            case 5:
                Console.WriteLine("Mayo");
                Console.ReadKey(true);
                opcion = false;
                break;
            case 6:
                Console.WriteLine("Junio");
                Console.ReadKey(true);
                opcion = false;
                break;
            case 7:
                Console.WriteLine("Julio");
                Console.ReadKey(true);
                opcion = false;
                break;
            case 8:
                Console.WriteLine("Agosto");
                Console.ReadKey(true);
                opcion = false;
                break;
            case 9:
                Console.WriteLine("Septiembre");
                Console.ReadKey(true);
                opcion = false;
                break;
            case 10:
                Console.WriteLine("Octubre");
                Console.ReadKey(true);
                opcion = false;
                break;
            case 11:
                Console.WriteLine("Noviembre");
                Console.ReadKey(true);
                opcion = false;
                break;
            case 12:
                Console.WriteLine("Diciembre");
                Console.ReadKey(true);
                opcion = false;
                break;
        }
    }
    else
        Console.WriteLine("Ingreso un numero invalido");
}

		}
	}
}