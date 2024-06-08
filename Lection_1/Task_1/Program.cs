using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin(1, "Victor Vasya", 101, "Zhitomyr", 1001, "Admin");

            Client newClient = new Client(2, "Ivan Chornozem");
            admin.AddClient(newClient);
            Console.WriteLine($"Current balance: {newClient.GetBalance()}");
            newClient.Deposit(2, 200, 12346);
            Console.WriteLine($"Current balance: {newClient.GetBalance()}");

            admin.ViewTransactions();


            Client newClient2 = new Client(3, "Valery Shmishenko");
            admin.AddClient(newClient2);
            Console.WriteLine($"Current balance: {newClient2.GetBalance()}");
            newClient2.Deposit(2, 300, 12346);
            Console.WriteLine($"Current balance: {newClient2.GetBalance()}");

            admin.ViewTransactions();

            admin.RemoveClient(newClient);

            Console.WriteLine($"Admin ID: {admin.getAdminId}, Role: {admin.Role}");
        }
    }
}
