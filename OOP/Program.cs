//pass By Value Example
//string firstnam, lastname;
//firstnam = "John";
//lastname = "Doe";
//Console.WriteLine($"Inside Main Method Before Calling {firstnam},{lastname}");

//ChangeValues(firstnam, lastname);
//Console.WriteLine($"Inside Main Method After Calling {firstnam},{lastname}");

//static void ChangeValues(string firstnam, string lastname)
//{
//    firstnam = "Dark";
//    lastname = "Smith";
//    Console.WriteLine($"Inside ChangeValues Method: {firstnam},{lastname}");
//}
//Console.ReadLine();

//pass By Ref Example
//string firstnam, lastname;
//firstnam = "John";
//lastname = "Doe";
//Console.WriteLine($"Inside Main Method Before Calling {firstnam},{lastname}");

//ChangeValues(ref firstnam, ref lastname);
//Console.WriteLine($"Inside Main Method After Calling {firstnam},{lastname}");

//static void ChangeValues(ref string firstnam, ref string lastname)
//{
//    firstnam = "Dark";
//    lastname = "Smith";
//    Console.WriteLine($"Inside ChangeValues Method: {firstnam},{lastname}");
//}
class Program
{

    static void Main(string[] arg)
    {

        string guestName = "";
        Console.WriteLine(addNamber(5, 10));
        Console.WriteLine(addNamber(5, 10, 15));
        Console.WriteLine("dear guest : waht is your name ");
        guestName = Console.ReadLine();
        if (guestName == string.Empty)
        {
            WlecomeGuest();
        }
        else
        {
            WlecomeGuest(guestName);
        }

        Console.ReadLine();
    }
    public static void WlecomeGuest()
    {

        Console.WriteLine($"Can i help you ");

    }
    public static void WlecomeGuest(string name)
    {

        Console.WriteLine($"Good day {name} Welcome to my app ");

    }
    public static int addNamber(int x, int y)
    {

        return x + y;
    }
    public static int addNamber(int x, int y, int r)
    {

        return x + y + r;
    }


}



