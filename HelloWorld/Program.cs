using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */

            // Questions 
            Console.WriteLine("Enter the following details");
            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.Write("What is your partner's name: ");
            string partnerName = Console.ReadLine();

            Console.Write("What is your age: ");
            string myAge = Console.ReadLine();

            Console.Write("What is your partners age: ");
            string partnerAge = Console.ReadLine();

            // Age Calculate
            int d;
            int l;
            int z;

            // String convert to an Int
            d = int.Parse(partnerAge);
            d = Convert.ToInt32(partnerAge);
            l = int.Parse(myAge);
            l = Convert.ToInt32(myAge);
            z = d - l;

            // Final output code
            Console.WriteLine("Hello " + myFirstName + " " + myLastName + ", you are " + z + " years younger then " + partnerName + " and he loves you, Congratulations " +  ":)" );
            Console.ReadLine();

        }
    }
}
