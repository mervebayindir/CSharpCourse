using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            List<string> cities2 = new List<string>();
            cities2.Add("Yozgat");
            cities2.Add("Antalya");

            //Console.WriteLine(cities2.Contains("Yozgat"));

            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Merve" });
            //customers.Add(new Customer { Id = 2, FirstName = "Zümra" });

            List<Customer> customers = new List<Customer>()
            {
            new Customer { Id = 1, FirstName = "Merve" },
            new Customer { Id = 2, FirstName = "Zümra" }
            };

            
            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Kutluhan"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4, FirstName="Ali" },
                new Customer{Id=5, FirstName="Ayşe"}
            });
            Console.WriteLine(customers.Contains(customer2));
            //customers.Clear();
            customers.Add(customer2);
            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index : {0}", index);
            

            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("Index : {0}",index2);

            customers.Insert(0,customer2);


            //customers.Add(customer2);
            //customers.Add(customer2);
            //customers.Add(customer2);
            customers.RemoveAll(c => c.FirstName == "Kutluhan");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);


            string[] cities = new string[2] { "Ankara", "İstanbul" };
            //cities[1] = "Adana";
            cities = new string[3];
            // Console.WriteLine(cities[1]);


            ArrayList citiesList = new ArrayList();
            citiesList.Add("Ankara");
            citiesList.Add("Adana");


            citiesList.Add("İstanbul");
            citiesList.Add(1);
            citiesList.Add('A');
            foreach (var city in citiesList)
            {
                Console.WriteLine(city);
            }
            //Console.WriteLine(citiesList[2]);
            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
