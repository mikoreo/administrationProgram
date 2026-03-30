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
        private string _phoneNumber;
        private string _email;
        private int _age;
        public string Name
        {
            get
            {
                return _name;
            }
            private set => _name = value;
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            private set => _phoneNumber = value;
        }
        public string Email
        {
            get
            {
                return _email;
            }
            private set => _email = value;
        }
        public int Age
        {
            get
            {
                return _age;
            }
            private set => _age = value;
        }


        public User(string name, string phoneNumber, string email, int age)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _email = email;
            _age = age;
        }


  

    

   
    }
}
