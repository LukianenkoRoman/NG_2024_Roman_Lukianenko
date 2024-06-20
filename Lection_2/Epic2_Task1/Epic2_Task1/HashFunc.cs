using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Epic2_Task1
{
    public class HashFunc
    {
        public string ToSHA512(string input)
        {
            string output = "";

            SHA512Managed sha512 = new SHA512Managed();
            byte[] toBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = sha512.ComputeHash(toBytes);

            foreach (byte b in hash) 
                output += b.ToString("x2");

            return output;
        }
    }
}
