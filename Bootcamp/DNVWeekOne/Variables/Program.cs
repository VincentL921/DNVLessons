//Structure of A Variable
//{data type} {variable name} = {value};

//explicit variable declaration
string name = "Vincent";
//implicit variable declaration
var age = 28;

//Existing class & custom classes can be used as data types as well
NotImplementedException nex = new NotImplementedException();
var nexTwo = new NotImplementedException();

//Operators
if (age > 21)
{

}

bool isOldEnough = age > 21;

if (isOldEnough)
{

}


//Logic control flow
if (age > 60)
{

}
else if (age > 45 && age < 60 && name == "Vincent")
{

}
else if (age > 45 && age < 60)
{

}
else
{

}

//Switch Statements
switch(name.ToLower())
{
    case "vito":
    case "vincent":
        break;
    case "david":
        break;
    case "John":
        break;
    default:
        break;
}

//look into SQL and describe what SQL is and what it's used for
//Look up compile time languages - write out what it is that i find. Question: Are there languages that are not compiled time? If so, what is an example of one?
//Tell dave the difference between if/else if/else statements & switch statement. Let him know when you would use either one.
