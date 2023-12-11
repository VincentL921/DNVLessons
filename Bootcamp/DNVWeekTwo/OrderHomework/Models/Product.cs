using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderHomework.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }

        public void Display()
        {
            Console.WriteLine($"Item Name: {this.Name}");
            Console.WriteLine($"Item Department: {this.Department}");
            Console.WriteLine($"Item Price: {this.Price}");
            Console.WriteLine("");
        }
    }
}
