using System;

namespace DivingLicense
{
	class Program
	{
		static void Main(string[] args)
		{
			// Programm küsib kasutaja sünnaaastat;
			// Programm aruvtab kasutaja vanust;
			// Kui kasutaja on noorem kui 18, siis programm kuvab konsoolis 
			// "Oled liiga noor, et juhilube saada";
			// Kui kasutaja on vanem kui 18, siis porgramm kuvab konsoolis
			// "oled piisaval vana, et juhilube saada";
			// Kui kasutaja on 18, siis programm kuvab konsoolis
			// "Palju õnne! Nüüd sa saad ka juhilube taotleda";


			Console.WriteLine("Palun sisesta oma sünniaasta:");
			int yearOfBirth = Convert.ToInt32(Console.ReadLine());
			
			int userAge = 2022 - yearOfBirth;

			if (userAge > 18)

			{
				Console.WriteLine("Oled piisaval vana, et juhilube saada!");

			}

			else if (userAge < 18)

			{
				Console.WriteLine("Oled liiga noor, et juhilube saada!");
			}

			else

			{
				Console.WriteLine("Palju õnne! Nüüd sa saad ka juhilube taotleda!");

			}


		}
	}
}
