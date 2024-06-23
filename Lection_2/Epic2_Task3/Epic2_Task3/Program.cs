using Epic2_Task3;
using System;

namespace Epic2_Task3
{
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
                        string order = Console.ReadLine();
                        phoneBook.GetByName(order);
                        break;
                    case 4:
                        string ordernum = Console.ReadLine();
                        phoneBook.GetByPhone(ordernum);
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
}