using System;
using System.Collections;
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
            Console.WriteLine("2. show users");


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

                case 2:
                    ShowUsers();
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
                Console.Clear();
                Console.WriteLine("invalid email");
                AddUser();
            }

            Console.Write("Enter age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("invalid, try again.");
                AddUser();
            }

            
            User newUser = new User(name, phoneNumber, email, age);

            
            _userManager.AddUser(newUser);

            Console.WriteLine("User added successfully!");
            Console.WriteLine("type something to go back");
            string goBack = Console.ReadLine();
            if(goBack == "1")
            {
                Console.Clear();
                mainMenu();
            } else
            {
                Console.Clear();
                mainMenu();
            }
        }
        private void ShowUsers()
        {

            List<User> allUsers = _userManager.GetUsers();


            if (allUsers.Count == 0)
            {
                Console.WriteLine("The list is currently empty.");
            }
            else
            {
                foreach (User user in allUsers)
                {
                    Console.WriteLine($"Name: {user.Name} Age: {user.Age} Phone: {user.PhoneNumber}");
                }
            }
                        Console.WriteLine("type 1 to go back");
            string goBack = Console.ReadLine();
            if(goBack == "1")
            {
                Console.Clear();
                mainMenu();
            }
        }


    }
}


