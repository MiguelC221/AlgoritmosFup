using System;
					
public class Program
{
	public static void Main()
	{
		int anio;
		Console.WriteLine("Escriba un año para saber si es Biciesto...");
		anio = Convert.ToInt32(Console.ReadLine());
		
		if (anio % 4 == 0 ){
			if (anio % 100 == 0){
				if (anio % 400 == 0){
				 	Console.WriteLine("El año es biciesto");
				}else{
			Console.WriteLine("El año no es biciesto");
		}
			}else{
			Console.WriteLine("El año no es biciesto");
		}
		}else{
			Console.WriteLine("El año no es biciesto");
		}
		Console.WriteLine("fin");
	}
}
