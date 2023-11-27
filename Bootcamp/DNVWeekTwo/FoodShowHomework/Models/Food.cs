using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShowHomework.Models
{
    public class Food
    {
        public Food()
        {  
        }
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public int CookTimeMin { get; set; }
        public string ElapsedCookTime {  get; set; }
        public List <Food> FoodItems { get; set; }

    }
}
