using System;
					
public class Program
{
	public static void Main()
	{
		            string FirstName;
            string LastName;
            int Age;
            Console.WriteLine("Enter first name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last name : ");
            LastName = Console.ReadLine();
            Console.WriteLine("How old are you? : ");
			Age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Hello " + FirstName + " " + LastName + " you are " + Age + " years old");
	}
}
