using ConsoleUILibrary.ExtensionMethods;
using Models;

PersonModel person = new()
{
    FirstName = "Enter your first name: ".RequestString(),
    LastName = "Enter your last name: ".RequestString(),
    Age = "Enter your age: ".RequestInt(0, 500), //possible?
    NumberOfChildren = "Enter the number of children you have: ".RequestInt()
};

//print with extension method
person.PrintPersonInfo();

//print with override
Console.WriteLine(person);
