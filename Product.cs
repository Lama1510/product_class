using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_class
{
    internal class Product
    {

        public int Id;
        public string Name;
        public string Description;
        public double Price;

        public void print()
        {
            Console.WriteLine($" Product id is {Id}  , name is {Name} , description is {Description} and its price is {Price}");


        }
    }
}
