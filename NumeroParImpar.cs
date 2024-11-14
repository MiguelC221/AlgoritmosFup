using System;
					
public class Program
{
	public static void Main()
	{
		int num;
		Console.WriteLine("Escriba un numero");
		num = Convert.ToInt32(Console.ReadLine());
		
		if (num % 2 == 0 ){
			Console.WriteLine("El numero es par");
	}
		else{
		Console.WriteLine("El numero es impar");
		}
		
}
}
