using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Epic2_Task2
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

        public void GetByNAme()
        {
            string oreder = Console.ReadLine();

            var contname = contacts.FirstOrDefault(c => c.Name == oreder);
            Console.WriteLine(contname.Name, contname.Number);
        }

        public void GetByPhone()
        {
            string oreder = Console.ReadLine();

            var contname = contacts.FirstOrDefault(c => c.Name == oreder);
            Console.WriteLine(contname.Name, contname.Number);
        }


    }
}
