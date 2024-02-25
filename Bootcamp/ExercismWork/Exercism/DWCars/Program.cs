var carsFromCsv = new List<string>();
carsFromCsv.Add("2013,Chevrolet,Cruze,5N1AL0MM8DC905806");
carsFromCsv.Add("1968,Shelby,GT500,WAULD54B24N209532");
carsFromCsv.Add("2009,Subaru,Forester,3G5DB03E02S938828");
carsFromCsv.Add("2004,Chevrolet,Express 1500,1G6KF54935U066283");
carsFromCsv.Add("2003,Chevrolet,Blazer,4USBT33483L552696");
carsFromCsv.Add("1987,Porsche,924 S,1C4RJEAG3FC402521");
carsFromCsv.Add("1993,Saab,900,WBAKX8C50BC690776");
carsFromCsv.Add("1994,Volvo,940,5UXFH0C56BL167540");

var cars = new List<Car>();

foreach (var item in carsFromCsv)
{
    var values = item.Split(',');
    //Splitting each source of info now as their own respective arrays

    var car = new Car
    {
        Year = int.Parse(values[0]),
        Make = values[1],
        Model = values[2],
        Vin = values[3]
    };

    // Add the car to the list
    cars.Add(car);
}

Console.WriteLine(cars.Count); 


public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Vin { get; set; }
}