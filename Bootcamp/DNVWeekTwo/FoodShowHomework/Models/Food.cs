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
<<<<<<< HEAD
        //Delete this, theres no need for a collection of food items within the food class itself.
        // Usually you'd have another class containing a collection of the class, in this case "food".
        // Ex: If you have a class of Car...you wouldn't have a collection of cars within itself because 1 car doesn't own many cars or its not made up
        //  of many cars, its the car itself.
        //  you'd have another class, like a dealership class or a family class that has a collection of cars representing all the cars on the lot of the
        //      dealership or all cars that belong to a family.
        //      make sense? message me if it doesnt.
        //  So thats why food wouldn't have a collection of itself. There may be some edge cases im not thinking of, but a majority of the time, a class
        //      regardless of what it is, wouldn't contain a collection of itself.
        public List <Food> FoodItems { get; set; }
=======
>>>>>>> 4f418df01c9b2fbd08f15678cba43c4e20670323

    }
}
