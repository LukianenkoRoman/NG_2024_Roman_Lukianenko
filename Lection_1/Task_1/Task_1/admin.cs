using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Admin : Person
    {
        private int _adminId;
        private string _role;

        private List<Client> clients = new List<Client>();

        public Admin(int adminId, string role, int personId, string address)
            : base(personId, address)
        {
            _adminId = personId;
            _role = role;
        }

        public int getAdminId
        {
            get { return _adminId; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public void AddClient(Client client)
        {
            int idadd = client.ClientId();
            clients.Add(client);
            Console.WriteLine($"Client {idadd} added successfully.");
        }

        public void RemoveClient(Client client)
        {
            int iddel = client.ClientId();
            clients.Remove(client);
            Console.WriteLine($"Client {iddel} removed successfully.");
        }

        public void ViewTransactions(int clientId)
        {
            Client client = clients.FirstOrDefault(c => c.ClientId() == clientId);

            List<Transaction> clientTransactions = client.GetTransactions();

            foreach (Transaction transaction in clientTransactions)
            {
                Console.WriteLine(transaction.TransId);
                Console.WriteLine(transaction.TransTime);
                Console.WriteLine(transaction.TransAmount);
            }
        }
    }
}

