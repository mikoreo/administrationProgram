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
        private int id = 0;
        public void mainMenu()
        {
            bool Running = true;

            if (Running == true)
            {
                Console.WriteLine("Welcome, Please choose one of the options below:");
                Console.WriteLine("1. Add user.");
                Console.WriteLine("2. show users");
                Console.WriteLine("3. delete users0");
                Console.WriteLine("0. close program");


                int userInput;
                while (true)
                {
                    Console.Write("Your choice: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out userInput))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("not a number. try again");
                    }
                }
                switch (userInput)
                {
                    case 1:
                        id++;
                        AddUser();
                        break;
                    case 2:
                        ShowUsers();
                        break;
                    case 3:
                        deleteUsers();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("type 0 again");
                        Running = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("invalid choice, try again");
                        mainMenu();
                        break;
                }

            }
        }
        

        private UserManager _userManager = new UserManager();

        private void AddUser()
        {
            Console.Clear();

            
            

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            string email;

            while (true)
            {
                Console.Write("Enter email: ");
                email = Console.ReadLine();

                if (email.Contains("@") && email.Contains("."))
                {
                    break; 
                }

                
                Console.WriteLine("Invalid email. Please try again.");
            }
            string ageInput;
            int age;

            while (true)
            {
                Console.Write("Enter age: ");
                ageInput = Console.ReadLine();

               
                if (int.TryParse(ageInput, out age) && age > 0)
                {
                    break;
                }

                Console.WriteLine("Invalid age. Please enter a number higher than 0.");
            }



            User newUser = new User(id, name, phoneNumber, email, age);

            
            _userManager.AddUser(newUser);

            Console.WriteLine("User added successfully!");

            goBack();
        }
        private void ShowUsers()
        {
            Console.Clear();
            List<User> allUsers = _userManager.GetUsers();


            if (allUsers.Count == 0)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                foreach (User user in allUsers)
                {
                    Console.WriteLine($"ID: {user.Id} Name: {user.Name} Age: {user.Age} Phonenumber: {user.PhoneNumber}");
                }
            }
            
        }
        private void deleteUsers()
        {
            
            ShowUsers();

            string idInput;
            int idDelete;

            
            
            Console.Write("Enter ID you want to delete: ");
            idInput = Console.ReadLine();


            if (int.TryParse(idInput, out idDelete))
            {
                _userManager.RemoveById(idDelete);
            }
            else
            {
                deleteUsers();
                Console.WriteLine("Invalid input. Please enter a number.");
                
            }

            goBack();


        }

        private void searchUser()
        {
            Console.Clear();
            Console.Write("Enter age to filter: ");
            if (!int.TryParse(Console.ReadLine(), out int searchAge))
            {
                Console.WriteLine("Invalid age.");
                return;
            }
        }

        private void goBack()
        {
            
            Console.WriteLine("type something to go back");
            string goBack = Console.ReadLine();
            if (goBack == "1")
            {
                Console.Clear();
                mainMenu();
            }
            else
            {
                Console.Clear();
                mainMenu();
            }
        }

    }
}


