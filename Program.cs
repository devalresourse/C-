
Console.WriteLine("What is your First Name: ");
string firstName = Console.ReadLine();

Console.WriteLine("What is your age: ");
string ageText = Console.ReadLine();

string formattedName;

if (int.TryParse(ageText, out int age))
{
    if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
    {
        formattedName = $"Professor {firstName}";
    }
    else
    {
        formattedName = firstName;
    }

    if (age < 21)
    {
        Console.WriteLine($"I recommend you wait {21 - age} years. {formattedName}");
    }
    else
    {
        Console.WriteLine($"Welcome to class {formattedName}");
    }
}
else
{
    Console.WriteLine();
}