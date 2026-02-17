using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgram
{
    internal class User
    {
        private string _name;
        private string _adress;
        private string _phoneNumber;
        private string _email;
        private int _age;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public User(string name, string adress, string phoneNumber, string email, int age)
        {
            _name = name;
            _adress = adress;
            _phoneNumber = phoneNumber;
            _email = email;
            _age = age;
        }

        public void SetEmail(string email)
        {
            if (email.Contains("@gmail.com"))
            {
                _email = email;
            }
            else
            {
                Console.WriteLine("ERROR, NIET GELDIG");
            }
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
