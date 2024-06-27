using System;

namespace Task_1
{
    public class Person 
    {
        private int _PersonId;
        private string _Address;

        public Person(int personId, string address)
        {
            _PersonId = personId;
            _Address = address;
        }

        public int PersonId()
        {
            return _PersonId;
        }
    }
}