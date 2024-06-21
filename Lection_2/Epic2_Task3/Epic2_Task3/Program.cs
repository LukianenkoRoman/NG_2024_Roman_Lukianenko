using Epic2_Task2;
using System;

class Program
{

    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();

        Console.WriteLine("1-Exit");
        Console.WriteLine("2-Add person");
        Console.WriteLine("3-Get by name");
        Console.WriteLine("4-Get by phpne");
        Console.WriteLine("5-Display all");

        int choice = int.Parse(Console.ReadLine());

        while (true)
        {
            switch (choice)
            {
                case 1:
                    return;
                case 2:  
                    phoneBook.Add();
                    break;
                case 3:
                    phoneBook.GetByNAme();
                    break;
                case 4:
                    phoneBook.GetByPhone();
                    break;
                case 5:
                    phoneBook.DisplayAll();
                    break;
                default:
                    Console.WriteLine("Error.");
                    break;
            }
        }
    }
}