using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crypto;

namespace TestCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Crypto";

            string str = "Hello My name is andrew how is the bissnes";
            string key = "cvn";
            
           

           string a = VigenereCipher.EncryptString(str, key);
           string b = VigenereCipher.DecryptString(a, key);

            Console.WriteLine(a);
            Console.WriteLine(b);

            //DECLINE
            Console.ReadLine();
        }
    }
}
