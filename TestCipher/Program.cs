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
            string key = "IFJGUBNDIDMVBJFJVNDJCSUHHAHICUGUGSFUGSDYGSUFYG";
            string str = "HELLO WORLD";
            
            string a = VigenereCipher.EncryptString(str, key);
            string b = VigenereCipher.DecryptString(a, key);
            Console.WriteLine(a);
            Console.WriteLine(b);
            //DECLINE
            Console.ReadLine();
        }
    }
}
