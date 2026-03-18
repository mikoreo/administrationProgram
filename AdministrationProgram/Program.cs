using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationProgram
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("insert name");
            string name = Console.ReadLine();

            Console.WriteLine("insert email");
            string email = Console.ReadLine();

            Console.WriteLine("insert age");
            int age = int.Parse(Console.ReadLine());

            User NewUser = new User(name, "number", email, age);

            Console.Clear();
            Console.WriteLine(NewUser);

            
            
            Console.WriteLine(NewUser.GetName());
            Console.WriteLine(NewUser.GetEmail());
            Console.WriteLine(NewUser.GetAge());
        }
    }
}
