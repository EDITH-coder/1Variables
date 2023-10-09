using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare a variable
            string name = "Edith";
            int Age;

            //initialisation
            name = "Edith";
            Age = 1;
            // What will be seen on the Console
            Console.WriteLine("There once was a girl called " + name);
            Console.WriteLine( name + " was " + Age + " of age ");
            Console.WriteLine (name + " Really never liked her name ");

            //change variable values
            Age= 10;
            name = "Lethabo";

            Console.WriteLine("at age" + Age + " She changed her name to " + name);

            //to freeze the console
            Console.ReadLine();

            /* Notes: You can also declare and initialise on the same line
             * eg
             * string name="John"
             */

        }
    }
}
