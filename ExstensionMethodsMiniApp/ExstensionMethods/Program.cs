using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel();

            p.FirstName = "what is your FirstName:  ".RequestString();
           
            p.LastName = "What is your LastName: ".RequestString();

            p.Age = "What is your Age: " .RequestInt(0,120);

            Console.ReadLine();
        }
    }
}