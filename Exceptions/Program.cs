using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    List<string> students = new List<string> { "Merve", "Zümra", "Kutluhan" };

            //    if (!students.Contains("Ahmet"))
            //    {
            //        throw new RecordNotFoundException("Record Not Found");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Record found!");
            //    }
            //}
            //catch (RecordNotFoundException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //catch (IndexOutOfRangeException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //catch (DivideByZeroException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //HandleException(() =>     //Method
            //{

            //    List<string> students = new List<string> { "Merve", "Zümra", "Kutluhan" };

            //    if (!students.Contains("Ahmet"))
            //    {
            //        throw new RecordNotFoundException("Record Not Found");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Record found!");
            //    }
            //});
            Func<int, int, int> add = Topla;  //Delegate Func yazımı  yukarıda delega yazımı gerekmez func yazımında
            Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate ()  //Parametresiz methodları gerı deger donduruyor demektir int yazımı
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            
            Func<int> getRandomNumber2 = () => new Random().Next(1,100);
            Console.WriteLine(getRandomNumber2());
            Thread.Sleep(1000); // 1 sn bekle random ıcın komutu
            Console.WriteLine(getRandomNumber());
            //Console.WriteLine(Topla(2,3));


            Console.ReadLine();
        }
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }
        private static void Find()
        {
            throw new NotImplementedException();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

    }
}
