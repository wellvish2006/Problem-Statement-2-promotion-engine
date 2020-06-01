using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SKU
    {
        public string  Id { get; set; }
        public decimal Price { get; set; }

        public SKU(string id)        
        {
            this.Id = id;
            bool isDone = false;
            switch (id)
            {
                case "A":
                    isDone = true;
                    this.Price = 50m;

                    break;

                case "B":
                    isDone = true;
                    this.Price = 30m;

                    break;
                case "C":
                    isDone = true;
                    this.Price = 20m;

                    break;
                case "D":
                    isDone = true;
                    this.Price = 15m;
                    break;
                default:
                    isDone = true;
                    break;
            }
        }
    }
}
