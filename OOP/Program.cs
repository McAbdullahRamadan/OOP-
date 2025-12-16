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
//BankAccount bankAccount = new BankAccount("asu Bank", "main branch", "556 main st,sitycll", "JonDark", "USD", "D11922", 500);
//bankAccount.BankName = "ABC Bank";
//bankAccount.BranchName = "Main Branch";
//bankAccount.BranchAdress = "123 Main St, Cityville";
//bankAccount.AccountName = "John Doe";
//bankAccount.AccountCurrency = "USD";
//bankAccount.AccountNumber = "123456789";
//bankAccount.Balance = 6000;

//Console.WriteLine(bankAccount.AccountName);
//Console.WriteLine(bankAccount.Balance);
//bankAccount.Withdraw(200);



//class BankAccount
//{
//    public string BankName { get; set; }
//    public string BranchName { get; set; }
//    public string BranchAdress { get; set; }
//    public string AccountName { get; set; }
//    public string AccountCurrency { get; set; }

//    public string AccountNumber { get; set; }

//    public decimal Balance { get; set; }
//    public BankAccount(string bankname, string branchname, string branchadress, string accountname, string accountcurrency, string accountnum, decimal balance)
//    {
//        BankName = bankname;
//        BranchName = branchname;
//        BranchAdress = branchadress;
//        AccountName = accountname;
//        AccountCurrency = accountcurrency;
//        AccountNumber = accountnum;
//        Balance = balance;

//    }
//    public void Withdraw(decimal amount)
//    {
//        decimal newBalance = Balance - amount;
//        if (newBalance < 0)
//        {
//            Console.WriteLine("Insufficient funds for this withdrawal.");
//        }
//        else
//        {

//            Console.WriteLine($"Withdrew {amount:C}");
//            Console.WriteLine($"your new Balance for {AccountNumber} is {newBalance} ");
//        }
//        Console.WriteLine(DateTime.Now);
//    }

//    public void Deposit(decimal amount)
//    {
//        decimal newBalance = Balance + amount;
//        if (newBalance < 0)
//        {
//            Console.WriteLine("Insufficient funds for this withdrawal.");
//        }
//        else
//        {

//            Console.WriteLine($"Withdrew {amount:C}");
//            Console.WriteLine($"your new Balance for {AccountNumber} is {newBalance} ");
//        }
//        Console.WriteLine(DateTime.Now);
//    }
//}












//static void Main(string[] arg)
//{

//    string guestName = "";
//    Console.WriteLine(addNamber(5, 10));
//    Console.WriteLine(addNamber(5, 10, 15));
//    Console.WriteLine("dear guest : waht is your name ");
//    guestName = Console.ReadLine();
//    if (guestName == string.Empty)
//    {
//        WlecomeGuest();
//    }
//    else
//    {
//        WlecomeGuest(guestName);
//    }

//    Console.ReadLine();
//}
//public static void WlecomeGuest()
//{

//    Console.WriteLine($"Can i help you ");

//}
//public static void WlecomeGuest(string name)
//{

//    Console.WriteLine($"Good day {name} Welcome to my app ");

//}
//public static int addNamber(int x, int y)
//{

//    return x + y;
//}
//public static int addNamber(int x, int y, int r)
//{

//    return x + y + r;
//}


// Factorial Calculator Recursive Methods
//Non Recursive Method

//int number = 10;
//Console.WriteLine("Non Recursive way");
//Console.WriteLine(FactorialNonRecursine(number));

//static int FactorialNonRecursine(int num)
//{
//    if (num == 0)

//        return 1;
//    int result = 1;

//    for (int i = num; i > 0; i--)
//    {
//        result *= i;
//        Console.WriteLine(i);
//    }
//    return result;
//}
//Console.ReadLine();

//// Recursive Method
//Console.WriteLine("Recursive way");
//Console.WriteLine(FactorialRecursive(number));
//static int FactorialRecursive(int num)
//{
//    if (num == 0)
//        return 1;
//    else
//        return num * FactorialRecursive(num - 1);
//}
//string path = string.Empty;
//path = @"D:\InterView-Abdullah\Behaviours"; // Specify your directory path here access folder
//Console.WriteLine(path);
//DisplayFolders(path, 0);


//static void DisplayFolders(string path, int indent)
//{
//    foreach (var folder in Directory.GetDirectories(path))
//    {
//        Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
//        DisplayFolders(folder, indent + 3);
//    }
//}

//Console.ReadLine();

//polymorphism example
//A a = new B();
//a.Show();
//A[] arr = new A[3];
//arr[0] = new A();
//arr[1] = new B();
//arr[2] = new C();
//foreach (A item in arr)
//{
//    item.Show();
//}
//Console.ReadLine();
//class A
//{
//    public virtual void Show()
//    {
//        Console.WriteLine("Class A Show A");
//    }
//}
//class B : A
//{
//    public override void Show()
//    {
//        Console.WriteLine("Class B Show B");
//    }
//}
//class C : A
//{
//    public override void Show()
//    {
//        Console.WriteLine("Class C Show C");
//    }
//}

//abstract class  example
//SyseemAnimal myDog = new Dog();
//myDog.MakeSound();
//myDog.Sleep();
//abstract class SyseemAnimal
//{
//    public abstract void MakeSound();
//    public void Sleep()
//    {
//        Console.WriteLine("The animal is sleeping.");
//    }
//}
//class Dog : SyseemAnimal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Woof Woof");
//    }
//}


//Static class example
/* 1. only static members allowed 
 * 2. cannot be instantiated
 * 3. sealed by default
 * 
 * */

Console.WriteLine(TemperatureConverter.CelsiusToFahrenheit(100));
Console.WriteLine(TemperatureConverter.FahrenheitToCelsius(90));

public static class TemperatureConverter
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

}
