using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scope_test
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("english");
            SayHello("German");
            SayHello("French");
        }

        private static void SayHello(string language)
        {
            switch(language)
            {
                case "english":
                    Console.WriteLine("hello");
                    break;
                case "german":
                    Console.WriteLine("Guten tag");
                    break;
                case "french":
                    Console.WriteLine("Bonjour");
                    break;
                default:
                    Console.WriteLine("how do?");
                    break;
            }
        }
    }
}
