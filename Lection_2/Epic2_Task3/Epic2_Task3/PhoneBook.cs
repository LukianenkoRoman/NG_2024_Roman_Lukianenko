using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Epic2_Task3
{
    class PhoneBook
    {
        private List<Person> contacts;

        public PhoneBook()
        {
            contacts = new List<Person>();
        }

        public void Add()
        {
            string name = Console.ReadLine();
            string number = Console.ReadLine();

            foreach (var contact in contacts)
            {
                if (contact.Number == number)
                {
                    Console.WriteLine("Error");
                }
            }

            contacts.Add(new Person { Name = name, Number = number });
        }

        public void DisplayAll()
        {
            foreach (Person contact in contacts)
            {
                int i = 1;
                Console.WriteLine($"{i}. {contact.Name} - {contact.Number}");
                i++;
            }
        }

        public void GetByName(string name) 
        {
            var order = contacts.Find(c => c.Name == name);

            Console.WriteLine($"{order.Name} - {order.Number}");
        }

        public void GetByPhone(string num)
        {
            var ordernum = contacts.Find(c => c.Number == num);

            Console.WriteLine($"{ordernum.Number} - {ordernum.Name}");
        }
    }
}
