using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin(1, "admin", 1, "Zhitomir");

            Client newClient = new Client(2, "Kropivnitsky", 2, "Ivan Chornozem");
            admin.AddClient(newClient);
            Console.WriteLine($"Current balance: {newClient.GetBalance()}");
            newClient.Deposit(2, 200, 12346);
            Console.WriteLine($"Current balance: {newClient.GetBalance()}");
            admin.ViewTransactions(2);

            Client newClient2 = new Client(3, "Vinitsa", 3, "Valery Shmishenko");
            admin.AddClient(newClient2);
            Console.WriteLine($"Current balance: {newClient2.GetBalance()}");
            newClient2.Deposit(2, 300, 12346);
            Console.WriteLine($"Current balance: {newClient2.GetBalance()}");
            admin.ViewTransactions(3);

            admin.RemoveClient(newClient);

            Console.WriteLine($"Admin ID: {admin.getAdminId}, Role: {admin.Role}");
        }
    }
}
