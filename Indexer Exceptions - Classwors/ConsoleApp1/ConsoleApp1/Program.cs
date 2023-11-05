using ConsoleApp1;

#region Indexer

//Library library = new Library();
//Book book = new Book();
//book.Id = 1;
//book.Name  = "Test1";

//library[0] = book;

//Console.WriteLine(library[0].Name);

#endregion


//try
//{
//	int[] nums = new int[0];
//	nums[2] = 100;

//	int a = 5;
//	int b = 0;

//	int result = a / b;

//    Console.WriteLine(result);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Mesaj yoxdur");
//}


static void Register(string username, string password);
{
    try
    {
        if (username == "oruc123")
        {
            Console.WriteLine("Register success");
        }
        else
        {
            throw new NullReferenceException("Register failed");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Register("oruc12", "ssfdhfh");


static void SendEmail(bool isSuccess)
{
    if (isSuccess)
    {
        Console.WriteLine("success register email");
    }
    else
    {
        Console.WriteLine("Failed register email");
    }
}
