using CollectionsHomework;
using System.ComponentModel.DataAnnotations;

List<People> listOfPeeps = new List<People>();
var personOne = new People();
var personTwo = new People();
var personThree = new People();
var personFour = new People();
var personFive = new People();
var personSix = new People();
var personSeven = new People();
var personEight = new People();
var personNine = new People();
var personTen = new People();
var personEleven = new People();
var personTwelve = new People();
var personThirteen = new People();
var personFourteen = new People();
var personFifteen = new People();
var personSixteen = new People();
var personSeventeen = new People();
var personEighteen = new People();
var personNineteen = new People();
var personTwenty = new People();


personOne.Information = new Information();
personTwo.Information = new Information();
personThree.Information = new Information();
personFour.Information = new Information();
personFive.Information = new Information();
personSix.Information = new Information();
personSeven.Information = new Information();
personEight.Information = new Information();
personNine.Information = new Information();
personTen.Information = new Information();
personEleven.Information = new Information();
personTwelve.Information = new Information();
personThirteen.Information = new Information();
personFourteen.Information = new Information();
personFifteen.Information = new Information();
personSixteen.Information = new Information();
personSeventeen.Information = new Information();
personEighteen.Information = new Information();
personNineteen.Information = new Information();
personTwenty.Information = new Information();


personOne.Information.FirstName = "Betti";
personOne.Information.LastName = "Sandcroft";
personOne.Information.StateAbbrev = "VA";
personOne.Information.Age = 59;

personTwo.Information.FirstName = "Eveleen";
personTwo.Information.LastName = "Egerton";
personTwo.Information.StateAbbrev = "KY";
personTwo.Information.Age = 21;

personThree.Information.FirstName = "Giulio";
personThree.Information.LastName = "Coombes";
personThree.Information.StateAbbrev = "NC";
personThree.Information.Age = 30;

personFour.Information.FirstName = "Kristien";
personFour.Information.LastName = "Perago";
personFour.Information.StateAbbrev = "FL";
personFour.Information.Age = 64;

personFive.Information.FirstName = "Bernadine";
personFive.Information.LastName = "Coleman";
personFive.Information.StateAbbrev = "NC";
personFive.Information.Age = 32;

personSix.Information.FirstName = "Emmalynne";
personSix.Information.LastName = "Sopp";
personSix.Information.StateAbbrev = "CA";
personSix.Information.Age = 26;

personSeven.Information.FirstName = "Kingston";
personSeven.Information.LastName = "Purkis";
personSeven.Information.StateAbbrev = "CA";
personSeven.Information.Age = 65;

personEight.Information.FirstName = "Josey";
personEight.Information.LastName = "Capron";
personEight.Information.StateAbbrev = "CA";
personEight.Information.Age = 77;

personNine.Information.FirstName = "Jimmy";
personNine.Information.LastName = "Biers";
personNine.Information.StateAbbrev = "CA";
personNine.Information.Age = 45;

personTen.Information.FirstName = "Berri";
personTen.Information.LastName = "Cleator";
personTen.Information.StateAbbrev = "MA";
personTen.Information.Age = 73;

personEleven.Information.FirstName = "Viki";
personEleven.Information.LastName = "Hebbron";
personEleven.Information.StateAbbrev = "FL";
personEleven.Information.Age = 44;

personTwelve.Information.FirstName = "Hedda";
personTwelve.Information.LastName = "Eitter";
personTwelve.Information.StateAbbrev = "TX";
personTwelve.Information.Age = 60;

personThirteen.Information.FirstName = "Tonie";
personThirteen.Information.LastName = "Summerbell";
personThirteen.Information.StateAbbrev = "CA";
personThirteen.Information.Age = 71;

personFourteen.Information.FirstName = "Gerrie";
personFourteen.Information.LastName = "Smorthwaite";
personFourteen.Information.StateAbbrev = "DC";
personFourteen.Information.Age = 25;

personFifteen.Information.FirstName = "Ken";
personFifteen.Information.LastName = "Braxay";
personFifteen.Information.StateAbbrev = "TX";
personFifteen.Information.Age = 62;

personSixteen.Information.FirstName = "Laurena";
personSixteen.Information.LastName = "Whiteoak";
personSixteen.Information.StateAbbrev = "MT";
personSixteen.Information.Age = 63;

personSeventeen.Information.FirstName = "Ken";
personSeventeen.Information.LastName = "Patsall";
personSeventeen.Information.StateAbbrev = "AL";
personSeventeen.Information.Age = 24;

personEighteen.Information.FirstName = "Silvain";
personEighteen.Information.LastName = "Foxen";
personEighteen.Information.StateAbbrev = "FL";
personEighteen.Information.Age = 32;

personNineteen.Information.FirstName = "Judye";
personNineteen.Information.LastName = "Wimpeney";
personNineteen.Information.StateAbbrev = "AL";
personNineteen.Information.Age = 47;

personTwenty.Information.FirstName = "Sabastian";
personTwenty.Information.LastName = "Roggers";
personTwenty.Information.StateAbbrev = "CA";
personTwenty.Information.Age = 61;

listOfPeeps.Add(personOne);
listOfPeeps.Add(personTwo);
listOfPeeps.Add(personThree);
listOfPeeps.Add(personFour);
listOfPeeps.Add(personFive);
listOfPeeps.Add(personSix);
listOfPeeps.Add(personSeven);
listOfPeeps.Add(personEight);
listOfPeeps.Add(personNine);
listOfPeeps.Add(personTen);
listOfPeeps.Add(personEleven);
listOfPeeps.Add(personTwelve);
listOfPeeps.Add(personThirteen);
listOfPeeps.Add(personFourteen);
listOfPeeps.Add(personFifteen);
listOfPeeps.Add(personSixteen);
listOfPeeps.Add(personSeventeen);
listOfPeeps.Add(personEighteen);
listOfPeeps.Add(personNineteen);
listOfPeeps.Add(personTwenty);

//Question 1
var numberOfPpl = listOfPeeps.Count;
Console.WriteLine(numberOfPpl);
Console.WriteLine("");

//Question 2
var avgAge = listOfPeeps.Average(p => p.Information.Age);
Console.WriteLine(avgAge);
Console.WriteLine("");

//Question 3
var minAge = listOfPeeps.Min(p => p.Information.Age);
var maxAge = listOfPeeps.Max(p => p.Information.Age);
var ageDifference = maxAge - minAge;
Console.WriteLine(maxAge);
Console.WriteLine(minAge);
Console.WriteLine(ageDifference);
Console.WriteLine("");

//Question 4
var olderThanSixFive = listOfPeeps.Any(p => p.Information.Age > 65);
Console.WriteLine(olderThanSixFive);
Console.WriteLine("");

//Question 5
var startsWithB = listOfPeeps.Where(p => p.Information.FirstName.StartsWith("B")).Count();
Console.WriteLine(startsWithB);
Console.WriteLine("");

//Question 6
var firstNameContainsIn = listOfPeeps.Where(p => p.Information.FirstName.Contains("in")).Count();
var lastNameContainsIn = listOfPeeps.Where(p => p.Information.LastName.Contains("in")).Count();
var fullNameContainsIn = firstNameContainsIn + lastNameContainsIn;
Console.WriteLine(firstNameContainsIn);
Console.WriteLine(lastNameContainsIn);
Console.WriteLine(fullNameContainsIn);
Console.WriteLine("");

//Question 7
var totalsOfKen = listOfPeeps.Where(p => p.Information.FirstName.Contains("Ken")).Count();
double percentageofKen = (totalsOfKen * 100) / numberOfPpl;
Console.WriteLine($"{percentageofKen}%");
Console.WriteLine("");

//Question 8
var totalsOfCali = listOfPeeps.Where(p => p.Information.StateAbbrev.Contains("CA")).Count();
double percentageOfCali = (totalsOfCali * 100) / numberOfPpl;
Console.WriteLine($"{percentageOfCali}%");
Console.WriteLine("");

//Bonus Question
var uniqueStates = listOfPeeps.Select(p => p.Information.StateAbbrev).Distinct().ToList();

foreach (var state in uniqueStates)
{
    Console.WriteLine(state);
}

//Printing out each state uniquely one by one. Figuring put how to only print the ones wiht no duplicates


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