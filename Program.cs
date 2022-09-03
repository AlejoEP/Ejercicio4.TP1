using System;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Ingrese un numero del mes del 1 al 12:");
    		int num = int.Parse(Console.ReadLine());
  

        	switch (num)
        {
            case 1:
                Console.WriteLine("Enero");
                //Console.ReadKey(true);
                Console.ReadKey(true);
                break;
            case 2:
                Console.WriteLine("Febrero");
                Console.ReadKey(true);                
                break;
            case 3:
                Console.WriteLine("Marzo");
                Console.ReadKey(true);                
                break;
            case 4:
                Console.WriteLine("Abril");
                Console.ReadKey(true);                
                break;
            case 5:
                Console.WriteLine("Mayo");
                Console.ReadKey(true);                
                break;
            case 6:
                Console.WriteLine("Junio");
                Console.ReadKey(true);
                
                break;
            case 7:
                Console.WriteLine("Julio");
                Console.ReadKey(true);
                break;
            case 8:
                Console.WriteLine("Agosto");
                Console.ReadKey(true);                
                break;
            case 9:
                Console.WriteLine("Septiembre");
                Console.ReadKey(true);                
                break;
            case 10:
                Console.WriteLine("Octubre");
                Console.ReadKey(true);              
                break;
            case 11:
                Console.WriteLine("Noviembre");
                Console.ReadKey(true);                
                break;
            case 12:
                Console.WriteLine("Diciembre");
                Console.ReadKey(true);                
                break;
        }
	}
	}
		
}

		
	
