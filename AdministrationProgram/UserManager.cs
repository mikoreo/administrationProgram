using AdministrationProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgram
{
    internal class UserManager
    {
        private readonly List<User> User = new List<User>();

        //adds the created users in the list
        public void AddUser(User newUser)
        {
            User.Add(newUser);

        }

        //when called shows the users
        public List<User> GetUsers()
        {
            return User;
        }

        //when called removes the user in the list
        public void RemoveById(int idDelete)
        {

            User userDelete = User.Find(user => user.Id == idDelete);

            if (userDelete != null)
            {
                User.Remove(userDelete);
                Console.WriteLine("User successfully deleted.");
            }
            else
            {
                Console.WriteLine("No user found with that ID.");
            }
        }

        //when called edits the user with the inputted info
        public bool UpdateUser(int id, string name, string phone, string email, int age)
        {
            User userEdit = User.Find(user => user.Id == id);

            if (userEdit != null)
            {
                
                userEdit.UpdateDetails(name, phone, email, age);
                return true;
            }
            return false;
        }
    }
}