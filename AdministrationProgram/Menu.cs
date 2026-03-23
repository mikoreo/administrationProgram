using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgram
{
    internal class Menu
    {
        public void mainMenu()
        {
            Console.WriteLine("Welcome, Please choose one of the options below:");
            Console.WriteLine("1. Add user.");


            int userInput;
            while (true)
            {
                Console.Write("Your choice: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userInput) && userInput >= 1 && userInput <= 3)
                    break;

                Console.WriteLine("Invalid input. Please choose 1, 2, or 3.");
            }
        } 
    }
}
