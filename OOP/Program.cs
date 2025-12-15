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
BankAccount bankAccount = new BankAccount("asu Bank", "main branch", "556 main st,sitycll", "JonDark", "USD", "D11922", 500);
//bankAccount.BankName = "ABC Bank";
//bankAccount.BranchName = "Main Branch";
//bankAccount.BranchAdress = "123 Main St, Cityville";
//bankAccount.AccountName = "John Doe";
//bankAccount.AccountCurrency = "USD";
//bankAccount.AccountNumber = "123456789";
bankAccount.Balance = 6000;

Console.WriteLine(bankAccount.AccountName);
Console.WriteLine(bankAccount.Balance);
bankAccount.Withdraw(200);



class BankAccount
{
    public string BankName { get; set; }
    public string BranchName { get; set; }
    public string BranchAdress { get; set; }
    public string AccountName { get; set; }
    public string AccountCurrency { get; set; }

    public string AccountNumber { get; set; }

    public decimal Balance { get; set; }
    public BankAccount(string bankname, string branchname, string branchadress, string accountname, string accountcurrency, string accountnum, decimal balance)
    {
        BankName = bankname;
        BranchName = branchname;
        BranchAdress = branchadress;
        AccountName = accountname;
        AccountCurrency = accountcurrency;
        AccountNumber = accountnum;
        Balance = balance;

    }
    public void Withdraw(decimal amount)
    {
        decimal newBalance = Balance - amount;
        if (newBalance < 0)
        {
            Console.WriteLine("Insufficient funds for this withdrawal.");
        }
        else
        {

            Console.WriteLine($"Withdrew {amount:C}");
            Console.WriteLine($"your new Balance for {AccountNumber} is {newBalance} ");
        }
        Console.WriteLine(DateTime.Now);
    }

    public void Deposit(decimal amount)
    {
        decimal newBalance = Balance + amount;
        if (newBalance < 0)
        {
            Console.WriteLine("Insufficient funds for this withdrawal.");
        }
        else
        {

            Console.WriteLine($"Withdrew {amount:C}");
            Console.WriteLine($"your new Balance for {AccountNumber} is {newBalance} ");
        }
        Console.WriteLine(DateTime.Now);
    }
}












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





