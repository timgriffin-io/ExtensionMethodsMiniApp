namespace Models;
public class PersonModel
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; } = 0;
    public int NumberOfChildren { get; set; } = 0;

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Age: {Age}, Number of children: {NumberOfChildren}";
    }
}