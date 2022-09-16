using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            // Console.WriteLine("Hello Word!");

            string days = "Mondey";
            double number5 = 10.4;
            decimal number6 = 10.9m;
            char character = 'A';
            string city = "Ankara";
            bool condition = false;
            byte number4 = 20;
            short number3 = -32768;
            int number1 = 1000000000;
            long number2 = 2147483648;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is : {0}", (int) character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}",number7);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }
}
enum Days
{
    Mondey=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday,
}