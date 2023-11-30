using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShowHomework.Models
{
    // I'm thinking i may need to create a format where i present a problem statement and then a more clearly defined list of requirements
    // That may be part of whats missing here, my bad.
    //
    //  With that said, also lay out a list / steps of what it is you are needing to do as a checklist and then work your way through that.
    public class Oven
    {
<<<<<<< HEAD
        // make this private, we don't want to access it from outside of the class and bypass the code we are going to put in place here
        //  to control how items are being added to the oven.
        //
        //  so this should look something like
        //  private List<Food> _foodInOven = new List<Food>();
        //
        //  Same deal in food, an oven wouldn't have a collection of itself. When you write something like this, read through it and talk through
        // out loud what the properties are.
        //  "Oven class with a property of OvenList which is a collection of class Oven" - that doesn't make sense. The only time you'd have a collection
        //      of ovens is like a home depot or lowes or somewhere that sells ovens, know what i mean?
        //  
        public List<Oven> OvenList = new List<Oven>();


        // So first thing to do is tackle this one method at a time. If you can't add items to the foodInOven collection, none of the rest of these methods
        //  matter because you won't be able to get proper results from them, so ignore all other methods until you get add done.

        //The add method is where we are going to utilize method overloading - if not clear, do research on this first before tackling these items.
        //  so method overloading example.
        //  public void Add(Food newItem)
        //  public void Add(List<Food> newItems)
        //  
        //  See how its the same method name but different method signatures? (signatures being different itemse being passed into the method itself).
        //  For example if you tried to do
        //
        //  public void Add(Food newItem)
        //  public void Add(Food yourMother)
        //  public void Add(List<Food> newItems)
        //
        //  This wouldn't compile because the first two methods accept 1 paramter which is a Food object, it doesn't matter that the first ones variable
        //      name is newItem and the second variable is yourMother, the data type of the first parameter is the same and thats all that matters so 
        //      because of that, this wouldn't compile since the compiler wouldn't be able to know which Add method you were using if you were passing
        //      in a single object of food
        //      ex:
        //          var oven = new Ove();
        //          var yourFace = new Food();
        //          oven.Add(yourFace);
        //
        //      Because there are 2 methods iwth the same signature, it wouldn't know if it was using the newItem variable method or yourMother's method.
        //
        //  So thats why the first example (2 method example) works but the second one does not.
        //
        // When you add items to the foodinoven collection via the add methods, you'll need a private variable to keep track of the current cook time
        //  which adds the food cook time being added to the current cook time every time either add method gets called.
        //
        //  what i mean is
        //  currenCookTime = currentCookTime + yourMother.CookTime;
        //  Where if currentCookTime == 0 minutes. If yourMother takes 15 minutes to cook it would be
        //  currentCookTime = 0 + 15; 
        //  and now currentCookTime is 15 minutes.
        //
        //  Then say you add yourFace to the oven and that takes 7 minutes to cook.
        //  currentCookTime is 15 minutes at the moment, then after adding yourFace it would become 22 minutes.
        //  currentCookTime = currentCookTime + yourFace.CookTime;
        //  currentCookTime = 15 + 7; -> so now currentCookTime is 22 minutes.
        //
        //  And then if you use the Add overload that passes in a collection of food you'd use the .Sum extension method to total up the cooktime for all the food
        //      in the collection being passed in and add that to currentCookTime.

        // Won't go into these because im thinking if you get the above going, these may fall into place, if not let me know and we can discuss.
        // but all of these would need to return a relevant data type (ex: int, double...etc.).
        public void GetTimeRemaining()
=======

        public void GetCookTime(Food food)
>>>>>>> 4f418df01c9b2fbd08f15678cba43c4e20670323
        {
            
        }
        public void SetTimeElapsed(Food food) 
        {

        }
        public void GetTimeRemaining(Food food)
        {

        }
    }
}
