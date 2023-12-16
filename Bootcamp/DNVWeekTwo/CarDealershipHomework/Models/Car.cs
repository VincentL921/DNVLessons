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