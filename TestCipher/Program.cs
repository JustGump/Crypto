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
            int[] keys = new[] {10, 20, 30};
            string str =  FeistelCipher.Encrypt("Hello My Name Is Andrew!", keys);
           
            Console.WriteLine("Encrypt: "+ str);
            Console.WriteLine("Decrypt: "+ FeistelCipher.Decrypt(str, keys));
            //DECLINE
            Console.ReadLine();
        }
    }
}
