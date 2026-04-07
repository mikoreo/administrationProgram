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
     
        public void AddUser(User newUser)
        {
            User.Add(newUser);
       
        }
        public List<User> GetUsers()
        {
            return User;
        }
        public void RemoveById(int idDelete)
        {
            
            User userDelete = User.Find(u => u.Id == idDelete);

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
    }
}
