using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {

            // Get the user name and location
            GetUser();

            // Calculate the days until Christmas
            DateTime todayDate = DateTime.Now;
            Console.WriteLine("Today is: " + todayDate.ToString("D"));
            daysUntilChristmas(todayDate);

            // Run the Glazer App
            GlazerApp();


            //Prompt for exit
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            //Console.WriteLine("Thank you. GoodBye!");
            Environment.Exit(0);
        

        }

        private static void consoleMsg(string msg)
        {
            Console.WriteLine(msg);
        }
        private static void GetUser()
        {
            string userName, userLocation;

            Console.WriteLine("What is your name:");
            userName = Console.ReadLine();
            Console.WriteLine("What is your location:");
            userLocation = Console.ReadLine();

            Console.WriteLine($"My name is: {userName}.");
            Console.WriteLine($"I am from: {userLocation}.");

        }
        private static void daysUntilChristmas(DateTime dateNow)
        { //Code modified from dotnetperls.com/datetime-elapsed
            
            string christmasDateString = "12-25-2020";
            DateTime christmasDate = DateTime.Parse(christmasDateString);

            TimeSpan elapsed = christmasDate.Subtract(dateNow);

            double daysUntil = elapsed.TotalDays;
            Console.WriteLine("Chistmas will be in {0} days.", daysUntil.ToString("0"));


        }
        
        private static void GlazerApp()
        {
            //Program example from section 2.1 
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Enter window width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter window height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters");

        }
    }
}
