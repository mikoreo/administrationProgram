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
            User hoi = new User("michael", "dik", "111111111111", "hoi@hoi.nl", 16);
            hoi.SetEmail("kees@gmail.com");
            Console.WriteLine(hoi.GetEmail());
            Console.WriteLine(hoi.GetName());
        }
    }
}
