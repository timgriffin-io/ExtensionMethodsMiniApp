namespace Models;
public static class PersonModelExtensions
{
    public static void PrintPersonInfo(this PersonModel person)
        => Console.WriteLine($"{person.FirstName} {person.LastName}, Age: {person.Age}, Number of children: {person.NumberOfChildren}");
    
}