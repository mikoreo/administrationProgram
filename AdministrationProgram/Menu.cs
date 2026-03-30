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
            switch (userInput)
            {
                case 1:
                    AddUser();
                    break;
            }
        }



        private UserManager _userManager = new UserManager();

        private void AddUser()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            if (!email.Contains("@") && !email.Contains("."))
            {
                Console.WriteLine("invalid email");
                return;
            }

            Console.Write("Enter age: ");
            
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("invalid, try again.");
                return;
            }

            
            User newUser = new User(name, phoneNumber, email, age);

            
            _userManager.AddUser(newUser);

            Console.WriteLine("User added successfully!");
        }
    }
    }

