using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("ingrese una calificación numérica (0-5):");
		double calificacion = Convert.ToDouble(Console.ReadLine());
             if (calificacion >=4 && calificacion<= 5 )  {
			 	Console.WriteLine("Su calificacion es A");
			 }else if (calificacion >= 3 && calificacion < 4){
				 Console.WriteLine("Su calificacion es B");
			 }else if(calificacion >= 2 && calificacion < 3){
				 Console.WriteLine("Su calificacion es C");
			 }else if (calificacion >= 1 && calificacion < 2){
				 Console.WriteLine("Su calificacion es D");
			 }else if (calificacion >= 0 && calificacion < 1){
			 Console.WriteLine("Su calificacion es F");
			 }else {
				 Console.WriteLine("El numero ingresado no está dentro del rando de notas.");
			 }
            }
 
		
	}
