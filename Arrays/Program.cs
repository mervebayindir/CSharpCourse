using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Mustafa", "Emre", "Batu" };
            students = new string[4] { "", "", "", "" };
            string[] students2 = { "Mustafa","Emre","Batu" };
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);

            //}
            string[,] regions = new string[5, 3]
                {
                {"İstanbul","Bursa","İzmit" },
                {"Yozgat","Konya","Ankara" },
                {"Mersin","Adana","Antalya" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" },
                };
            for (int i = 0; i < regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j < regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("************");
            }
            Console.ReadLine();
        }
    }
}
