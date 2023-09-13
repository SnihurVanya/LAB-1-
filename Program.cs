using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello World");
            Console.Out.WriteLine("What is your name?");
            String name = Console.In.ReadLine();
            Console.Out.WriteLine("Ok. " + name);
            Console.In.Read();

        }
    }
}
