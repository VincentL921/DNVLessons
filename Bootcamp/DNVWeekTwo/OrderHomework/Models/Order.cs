﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderHomework.Models
{
    internal class Order
    {
        private List<Product> _productsOrdered = new List<Product>();
        private double _costAccrued = 0;
        private double _pricePaid = 0;
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
        public double GetTotalCost(string playstattionFive, string samsungTV, string adidasTracksuit, string nikeHoodie,
            string airForceOnes, string nikeDunks, string kitchenAidMixer, string vitamixBlender )
        {
            return _productsOrdered.Sum(m => m.Cost);
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
        public double GetRemainingBalance () 
        {
            return GetAveragePrice() - _pricePaid;
        }
    }
}

//* methods to 
//    * get total cost
//    * add 1 overload to get total cost by department.
//        - note, you've done this in weekone -> collections code/project
//    * get average cost
//    * get total price
//    * get average price
//    * making payment -> we need to track total amount paid so use private variable above to do so and add to itself.
//    * get remaining balance