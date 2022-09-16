using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Merve Bayındır";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Zümra Bayındır";

            bool result3 = sentence.EndsWith("r");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");
            var result13 = sentence.Remove(2,5);

            Console.WriteLine(result13);
            string City = "Yozgat";
            //Console.WriteLine(City[0]);
            foreach (var item in City)
            {
                //Console.WriteLine(item);
            }
            string city2 = "Ankara";
            //string result = City + city2;
           // Console.WriteLine(String.Format("{0} {1}",City,city2));
            Console.ReadLine();
        }
    }
}
