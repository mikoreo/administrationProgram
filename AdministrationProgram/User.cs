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



        public User(string name, string phoneNumber, string email, int age)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _email = email;
            _age = age;
        }


        //public void SetName(string name)
        //{
        //    _name = name;
        //}

        //public void SetAge(int age)
        //{
        //    _age = age;
        //}
 
        //public void SetPhoneNumber(string number)
        //{
        //    _phoneNumber = number;
        //}

   
    }
}
