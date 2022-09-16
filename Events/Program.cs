using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product hardDisk = new Product(50);
            hardDisk.ProductName = "Hard Disk";

            Product GSM = new Product(50);
            GSM.ProductName = "GSM";
            GSM.StockControlEvent += GSM_StockControlEvent;
            for (int i = 0; i < 10; i++)
            {
                hardDisk.Sell(10);
                GSM.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void GSM_StockControlEvent()
        {
            Console.WriteLine("GSM about to finished");
        }
    }
}
