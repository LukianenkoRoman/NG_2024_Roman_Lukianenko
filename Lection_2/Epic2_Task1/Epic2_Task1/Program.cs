using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Epic2_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashFunc hashFunc = new HashFunc();

            var Password = (hashFunc.ToSHA512(Console.ReadLine()));
            Console.WriteLine("Registaration complited");

            var newPassword = (hashFunc.ToSHA512(Console.ReadLine()));

            if (newPassword == Password) 
            {
                Console.WriteLine("Succes");
            }
            else 
            {
                Console.WriteLine("Fail");
            }

        }
    }
}