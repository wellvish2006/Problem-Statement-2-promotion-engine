using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SKU> skus = new List<SKU>();

            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                SKU p = new SKU(type);
                skus.Add(p);
            }

            int totalPrice = GetTotalPrice(skus);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
        private static int GetTotalPrice(List<SKU> products)
        {
            int ctrA = 0;
            int priceA = 50;
            int ctrB = 0;
            int priceB = 30;
            int ctrC = 0;
            int priceC = 20;
            int ctrD = 0;
            int priceD = 15;
            foreach (SKU pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    ctrA = ctrA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    ctrB = ctrB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    ctrC = ctrC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    ctrD = ctrD + 1;
                }
            }
            int totalpriceA = (ctrA / 3) * 130 + (ctrA % 3 * priceA);
            int totalpriceB = (ctrB / 2) * 45 + (ctrB % 2 * priceB);
            int totalpriceC = (ctrC * priceC);
            int totalpriceD = (ctrD * priceD);
            return totalpriceA + totalpriceB + totalpriceC + totalpriceD;

        }
    }
}
