using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrderHomework.Models
{
    internal class Order
    {
        private List<Product> _productsOrdered = new List<Product>();
        private double _costAccrued = 0;
        private double _pricePaid = 0;
        //private string _department = "";
        public void Add(Product product)
        {
            _productsOrdered.Add(product);
        }
        public void Add(List<Product> products)
        {
            _productsOrdered.AddRange(products);
        }
        public double GetTotalCost()
        {
            return _productsOrdered.Sum(m => m.Cost);
        }
        public double GetTotalCost(string department)
        {
            return _productsOrdered.Where(m => m.Department.Contains(department)).Sum(m => m.Cost);
        }
        public double GetAverageCost()
        {
            return GetTotalCost() / _productsOrdered.Count;
        }
        public double GetTotalPrice()
        {
            return _productsOrdered.Sum(m => m.Price);
        }
        public double GetAveragePrice()
        {
            return GetTotalPrice() / _productsOrdered.Count;
        }
        public void MakePayment(int pricingNumber)
        {
            _pricePaid = _pricePaid + pricingNumber;
        }
        public double GetRemainingBalance()
        {
            return GetTotalPrice() - _pricePaid;
        }
        public double GetTotalPrice(string department)
        {
            return _productsOrdered.Where(x => x.Department.Contains(department)).Sum(m => m.Price);
        }
        public double GetAveragePrice(string department)
        {
            var departmentTotals = _productsOrdered.Where(x => x.Department.Contains(department)).Sum(m => m.Price);
            return departmentTotals / _productsOrdered.Count;
        }
        public void DisplayInvoice()
        {
            var totalPrice = GetTotalPrice();
            var averagePrice = GetAveragePrice();

            var totalForElectronics = GetTotalPrice("Electronics");
            var averageForDept = GetAveragePrice("Electronics");

            var totalForClothing = GetTotalPrice("Clothing");
            var averageForClothing = GetAveragePrice("Clothing");

            var totalForShoes = GetTotalPrice("Shoes");
            var averageForShoes = GetAveragePrice("Shoes");

            var totalForKitchenware = GetTotalPrice("Kitchenware");
            var averageForKitchenware = GetAveragePrice("Kitchenware");

            Console.WriteLine("Sailor Dave's Poop Deck");
            Console.WriteLine($"---------------------");

            foreach (var item in _productsOrdered)
            {
                item.Display();
            }

            Console.WriteLine($"---------------------");
            Console.WriteLine($"Total Price: {totalPrice}");
            Console.WriteLine($"Average Price: {averagePrice}");
            Console.WriteLine($"---------------------");

            var uniqueDepartments = _productsOrdered.Select(x => x.Department).Distinct().ToList();

            Console.WriteLine($"Deparments Selected:");
            foreach (var item in uniqueDepartments)
            {
                Console.WriteLine($"{item}");
                Console.WriteLine($"{totalForClothing }");
            }
            Console.WriteLine("");
            Console.WriteLine($"Total for Electronics Department: {totalForElectronics}");
            Console.WriteLine($"Average for Electronics Department: {totalForElectronics}");
            Console.WriteLine("");
            Console.WriteLine($"Total for Clothing Department: {totalForClothing}");
            Console.WriteLine($"Average for Clothing Department: {totalForClothing}");
            Console.WriteLine("");
            Console.WriteLine($"Total for Shoes Department: {totalForShoes}");
            Console.WriteLine($"Average for Shoes Department: {totalForShoes}");
            Console.WriteLine("");
            Console.WriteLine($"Total for Kitchenware Department: {totalForKitchenware}");
            Console.WriteLine($"Average for Kitchenware Department: {totalForKitchenware}");
        }


    }
}

#region hw 12/5
//* methods to 
//    * get total cost
//    * add 1 overload to get total cost by department.
//        - note, you've done this in weekone -> collections code/project
//    * get average cost
//    * get total price
//    * get average price
//    * making payment -> we need to track total amount paid so use private variable above to do so and add to itself.
//    * get remaining balance

//*create a display method that displays everything like an invoice
//so loop through all the products and display the price/cost of each item -
//format it nicely so its readable then  have a footer of the output to show total cost, total price, average price, remaining balance...etc
//so a void Display() method
#endregion

#region hw 12/10
//Add overloads for department handling for methods.
//            GetAverageCost
//            GetTotalPrice
//            GetAveragePrice

//        Figure out a way to get a unique list of departments based on the products on the order.
//            hint: Select and Distinct. Hint pt2: Inside display invoice method.
//            hint 3: if your stuck on this, pull code out to one off console app not in git repo and test just getting a unique
//                list.

//        Then loop over the departments and get the values for the methods by department and include that 
//            inside the display invoice method of the order.
//            hint: inside this foreach loop, you'll use all the overloads youve created.
#endregion
