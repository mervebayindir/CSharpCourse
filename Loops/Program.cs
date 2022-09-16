using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            if(IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            static bool IsPrimeNumber(int number3)
            {
                bool result = true;
                for (int i = 2; i < number3-1; i++)
                {
                    if(number3%i==0)
                    {
                        result = false;
                        i = number3;
                    }
                }
                return result;
            }
            string[] students = new string[3] { "Mustafa", "Emre", "Batu" };
            foreach (var student in students)
            {
                //Console.WriteLine(student);
            }
            while (number>=0)
            {
               // Console.WriteLine(number);
                number--;
            }
            //Console.WriteLine("Now number is {0}",number);
            int number2 = 10;
            do
            {
                //Console.WriteLine(number2);
                    number2--;
            } while (number2>=0);
            for (int i = 0; i <= 100; i=i+2)
            {
               // Console.WriteLine(i);
            }
           // Console.WriteLine("Finished!!!");

            Console.ReadLine();        
        }
    }
}
