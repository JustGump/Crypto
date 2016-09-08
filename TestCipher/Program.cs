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
            //VigenereCipher.ShowTable();
            
            string a = VigenereCipher.CreateKey("hey", "MyNameIsJephh");

            Console.WriteLine(a);
            //DECLINE
            Console.ReadLine();
        }
    }
}
