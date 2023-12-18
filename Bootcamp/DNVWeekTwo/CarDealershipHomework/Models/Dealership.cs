using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipHomework.Models
{
    public class Dealership
    {
        private List<Car> _carsInDealership = new List<Car>();
        private int _electricCars = 0;
        private int _numberOfCars = 0;
        public void Add(Car car)
        {
            _carsInDealership.Add(car);
        }
        public void Add(List<Car> cars)
        {
            _carsInDealership.AddRange(cars);
        }
        public int GetNumberOfCars()
        {
            return _carsInDealership.Count();
        }
        public int GetNumberOfCars(bool isElectric)
        {
            return _carsInDealership.Where(c => c.IsElectric == true).Count();
        }
        public double GetMSRPTotal()
        {
            return _carsInDealership.Sum(c => c.MSRP);
        }
        public double GetMSRPTotal(bool isElectric)
        {
            return _carsInDealership.Where(c => c.IsElectric == true).Sum(c => c.MSRP);
        }
        public double GetMSRPTotal(string make)
        {
            return _carsInDealership.Where(c => c.Make.Contains(make)).Sum(c => c.MSRP);
        }
        public double GetMSRPAverage()
        {
            return GetMSRPTotal() / _carsInDealership.Count();
        }
        public double GetMSRPAverage(bool isElectric)
        {
            return GetMSRPTotal(isElectric) / GetNumberOfCars(isElectric);
        }
        public double GetMSRPAverage(string make)
        {
            return GetMSRPTotal(make) / _carsInDealership.Count();
        }
        public int GetMileageTotal()
        {
            return _carsInDealership.Sum(c => c.Odometer);
        }
        public int GetMileageTotal(bool isElectric)
        {
            return _carsInDealership.Where(c => c.IsElectric == true).Sum(c => c.Odometer);
        }
        public int GetMileageTotal(string make)
        {
            return _carsInDealership.Where(c => c.Make.Contains(make)).Sum(c => c.Odometer);
        }
        public int GetAverageMileage()
        {
            return GetMileageTotal() / _carsInDealership.Count();
        }
        public int GetAverageMileage(bool isElectric)
        {
            return GetMileageTotal(isElectric) / GetNumberOfCars(isElectric);
        }
        public int GetAverageMileage(string make)
        {
            return GetMileageTotal(make) / _carsInDealership.Count();
        }
    }
}
//*Dealership-> class
//    private variable of Cars which is a collection of Car CHECK

//    method to Add -> pass in a single car or a collection of cars -> hint: overload. CHECK

//    * A method to get the number of cars on the lot CHECK
//        overload to get the number of electric vehicles on the lot. CHECK
//        hint: reading comprehension important "get the number of vehicles on the lot" ex: if its sold its noton lot. CHECK

//    *A method to get the total msrp of all cars CHECK
//        an overload to get total msrp of electric vehicles. CHECK
//        another overload to get total msrp by make. CHECK
//    * A method to get the average msrp of all cars CHECK
//        an overload to get average msrp of electric vehicles. CHECK
//        another overload to get average msrp by make. CHECK
//    * Average odometer value of all cars on the lot. CHECK
//        overload for average odometer reading by electric vehicles. CHECK
//        overload for average odometer reading by make CHECK
//    * Average age of vehicles on the lot.
//        overload for average age of vehicles by make.

//    * create amethod to display inventory of dealrship.
//        utilize all methods above to print out data about the daerlship
//            in a readable manner
//        within this method, get the unique makes of all vehicles currently on the lot
//            in order to loop over and utilize any methods with overloads by make.

//    * 

//* Class of Car
//    year
//    make
//    model
//    odometer -> capture # of miles.
//    MSRP
//    is electric
//    is sold

//    * add a method to this class to display just the information about this individaual car.