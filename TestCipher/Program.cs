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

            string str = "Hello user 05791135! nice to see YOU again here, how is your day?";
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
