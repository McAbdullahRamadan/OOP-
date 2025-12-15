
//pass By Value Example
string firstnam, lastname;
firstnam = "John";
lastname = "Doe";
Console.WriteLine($"Inside Main Method Before Calling {firstnam},{lastname}");

ChangeValues(firstnam, lastname);
Console.WriteLine($"Inside Main Method After Calling {firstnam},{lastname}");

static void ChangeValues(string firstnam, string lastname)
{
    firstnam = "Dark";
    lastname = "Smith";
    Console.WriteLine($"Inside ChangeValues Method: {firstnam},{lastname}");
}
Console.ReadLine();