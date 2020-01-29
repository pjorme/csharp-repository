using System;
using System.Collection.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "pj";
            string lastname = "orme";

            Console.WriteLine("name " +firstname+ " " + lastname);
            Console.WriteLine("please enter a new name");
            firstname = Console.ReadLine();
            Console.WriteLine("new name: " + firstname + "" + lastname);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        }
}
