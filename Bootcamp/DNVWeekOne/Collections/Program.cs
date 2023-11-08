var ages = new List<int>();
var names = new string[7];
var namesV2 = new string[] {"A", "B", "C" };
var students = new Dictionary<string, string>();

ages.Add(30);
ages.Add(10);
ages.Add(20);

names[0] = "Vincent";
names[1] = "Dave";
names[2] = "Bill";
names[3] = "Vito";
names[4] = "Justin";
names[5] = "Dave";
names[6] = "Dave";

students.Add("123456","David");
students.Add("654321","Vincent");
students.Add("78910","Joe");
students.Add("98765","Jim");

Console.WriteLine("for loop on lists:");
for (int i = 0; i < ages.Count; i++)
{
    Console.WriteLine(ages[i]);
}

Console.WriteLine("");
Console.WriteLine("For loop on dictionary:");
for (int i = 0; i < students.Count; i++ )
{
    var key = students.Keys.ToList()[i];
    var value = students[key];
    Console.WriteLine($"Student ID: {key}, Name: {value}");
}

Console.WriteLine("");
Console.WriteLine("Foreach loop on dictionary");
foreach (var key in students.Keys)
{
    var value = students[key];
    Console.WriteLine($"FE - Student ID: {key}, Name: {value}");
}

Console.WriteLine("");
Console.WriteLine("While loop on lists");
int ageLength = ages.Count;
while (ageLength > 0)
{
    var age = ages[ageLength - 1];
    Console.WriteLine($"Age is: {age}");

    ageLength = ageLength - 1;
}

Console.WriteLine("");
Console.WriteLine("Do While on Lists:");
var nameCount = names.Length;
do
{
    Console.WriteLine($"Name is {names[nameCount - 1]}");
    nameCount = nameCount - 1;
}while  (nameCount > 0);

//starting LINQ Functions 11/6/2023

var totalAge = ages.Sum();
var numberOfAges = ages.Count();
var averageAge = totalAge / numberOfAges;
var oldestAge = ages.Max();
var youngestAge = ages.Min();
var legalAges = ages.Where(m => m > 18 && m < 29);
var hasLegalAges = ages.Any(m => m > 18);
var orderedAges = ages.OrderBy(m => m);
var orderedAgesDesc = ages.OrderByDescending(m => m);
var youngestTake = ages.OrderBy(m => m).Take(1);
var skipOldestAge = ages.OrderByDescending(m => m).Skip(1);

foreach (var item in skipOldestAge)
{
    Console.WriteLine(item);
}

Console.WriteLine(legalAges.Count());

var hasItInName = names.Contains("it");  //boolean
var hasItInNameV2 = names.Any(m => m.Contains("it"));  //boolean
var hasItInNameV3 = names.Where(m => m.Contains("it")).Any();  //boolean
var namesWithIt = names.Where(m => m.Contains("it"));  //collection
var namesWithItCount = names.Where(m => m.Contains("it")).Count();  //int variable
var namesWithItCountV2 = names.Count(m => m.Contains("it"));  //int variable
var namesEqualToDave = names.Where(m => m == "Dave");

foreach (var item in namesEqualToDave)
{
    Console.WriteLine(item);
}
Console.WriteLine(namesEqualToDave.Any());
Console.WriteLine(namesEqualToDave.Count());

//last method in code is what declares the variable or collection type

//create a class of person
//think about the attributes of a person that all people have
//all have name, age, address etc etc
//create a bunch of test data - use the mockaroo site given by dave - use that to set up the fake mock up data
//create enough test date. add it to a list
//tell dave the number of ppl in collection, avg age in the collection, difference between the min age and max age to get the age range
//figure out if there's anybody in the person collection that is older than 65 - yes or no? hint - is there ANYbody?
//pull the number of all people whose names start with "C" - or any specific letter w multiples
//pull number of people whose names contain "in"
//when you generate the test data - pick a name - then give dave a name -  then calculate the percentage of how often that name appears in the collection itself
//do same calculation as above, but find percentage of people that live in a certain state in this mock up
//BONUS: we havent covered it together yet - Of our data that I create in the collection, give Dave a list of states in the data set that has NO DUPLICATES