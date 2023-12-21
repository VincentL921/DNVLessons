using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipHomework.Models
{
    public class Car
    {
        public int Year { get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Odometer { get; set; }
        public double MSRP { get; set; }
        public bool IsElectric { get; set; }
        public bool IsSold { get; set; }
        public TestData TestData { get; set; } 
        public void Display()
        {
            if (this.IsSold == false)
            {
                Console.WriteLine($"Car: {this.Year} {this.Make} {this.Model}");
                Console.WriteLine($"Price: ${this.MSRP}, Mileage: {this.Odometer} Miles ");
                Console.WriteLine("");
            }
            else
            {
                
            }
        }

    }
}
//* Class of Car
//    year
//    make
//    model
//    odometer -> capture # of miles.
//    MSRP
//    is electric
//    is sold