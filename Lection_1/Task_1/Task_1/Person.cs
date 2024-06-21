using System;

namespace Task_1
{
    public class Person : Client
    {
        private int _personId;
        private string _address;

        public Person(int clientId, string clientName, int personId, string address)
            : base(clientId, clientName)
        {
            _personId = clientId;
            _address = address;
        }

        public int PersonId()
        {
            return _personId;
        }
    }
}