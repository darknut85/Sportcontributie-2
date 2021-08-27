using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportcontributie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // parameters
            string name;
            string sport = "";

            double contribution;
            double discount = 0;

            DateTime currentDate = DateTime.Now;
            DateTime birthDate;
            DateTime registrationDate;

            List<string> sports = new List<string>();

            // data
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            while (true)
            {
                try
                {
                    Console.WriteLine("What is your birthdate?");
                    birthDate = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid: please try again."); }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("What is your registration date?");
                    registrationDate = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid: please try again."); }
            }
            while (true)
            {
                Console.WriteLine("There are 5 different sports you can select: soccer, volleyball, basketball, handball and atletics. What sport do you practice?");
                sport = Console.ReadLine();
                if (!sports.Contains("volleyball") && sport == "volleyball")
                {
                    sports.Add(sport);
                }
                else if (!sports.Contains("soccer") && sport == "soccer")
                {
                    sports.Add(sport);
                }
                else if (!sports.Contains("basketball") && sport == "basketball")
                {
                    sports.Add(sport);
                }
                else if (!sports.Contains("atletics") && sport == "atletics")
                {
                    sports.Add(sport);
                }
                else if (!sports.Contains("handball") && sport == "handball")
                {
                    sports.Add(sport);
                }
                else
                {
                    Console.WriteLine("The sports you choose is either already registered or not on the list.");
                }
                if (sports.Count >= 5)
                {
                    break;
                }
                Console.WriteLine("Would you like to enter another type of sports?");
                string n = Console.ReadLine();
                if (n == "no" || n == "No" || n == "NO")
                {
                    break;
                }
            }

            // math
            double ageY = currentDate.Year - birthDate.Year;
            double ageM = currentDate.Month - birthDate.Month;
            double ageD = currentDate.Day - birthDate.Day;
            double regY = currentDate.Year - registrationDate.Year;
            double regM = currentDate.Month - registrationDate.Month;
            double regD = currentDate.Day - registrationDate.Day;

            if (ageM > 0 || (ageM == 0 && ageD > 0)) { }
            else { ageY -= 1; }
            if (regM > 0 || (regM == 0 && regD > 0)) { }
            else { regY -= 1; }

            contribution = 40;
            if (sports.Count >= 5) { contribution += 20 * sports.Count; }
            else if (sports.Count >= 3) { contribution += 22 * sports.Count; }
            else if (sports.Count >= 1) { contribution += 25 * sports.Count; }

            if (ageY < 18 || ageY >= 40) { discount += 10; }
            if (regY >= 5) { discount += 5; }

            contribution -= (contribution / 100 * discount);

            // conclusion
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("The current date is: "+ currentDate);
            Console.WriteLine("Your birth date is: " + birthDate);
            Console.WriteLine("Your registration date is: " + registrationDate);
            Console.WriteLine("Your age is: " + ageY);
            Console.WriteLine("You are a club member for this long: " + regY + " years");
            Console.WriteLine("The sports you practice are: ");
            foreach (var sp in sports)
            {
                Console.WriteLine(sp);
            }
            Console.WriteLine("The contribution is: " + contribution);
        }
    }
    // voetbal, volleybal, basketbal, handbal, atletiek
    // basiscontributie: 40 euro
    // extra per sport:
        // 1 of 2 sporten: 25 euro per sport
        // 3 of 4 sporten: 22 euro per sport
        // 5 sporten: 20 euro per sport
    // jonger 18 <= leeftijd <= 40: 10% korting
    // 5 jaar of langer lid: 5% korting

    // bepaal contributie
    // bepaal leeftijd en aantal jaren lid
}
