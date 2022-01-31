using System;

namespace InstagramAge
{
	class Program
	{
		static void Main(string[] args)
		{

			// Programm küsib kasutaja vanust
			// Programm kontrollib kas kasutaja on vanem kui 13 või 13 aastat vana
			// Kui kastuaja on 13 aastat vana või vanem, siis ta võib Instagram'i kastutada
			// Kui kasutaja on noorem, kui 13, siis ta on liiga noor. 


			Console.WriteLine("Palun siseta vanus:");
			int userAge = Convert.ToInt32(Console.ReadLine());


			if (userAge > 13)

			{
				Console.WriteLine("Oled piisavalt vana, et Instagram'i kontot luua.");

			}

			else if (userAge < 13)

			{
				Console.WriteLine("Oled liiga noor, et Instagram'i kontot luua.");
			}

			else
				
			{
				Console.WriteLine("Oled piisavalt vana, et Instagram'i kontot luua.");

			}

			Console.WriteLine("Kena päeva!");




		}
	}
}
