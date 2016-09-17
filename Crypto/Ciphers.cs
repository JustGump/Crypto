using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    static public class VigenereCipher
    {
        static readonly char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ".ToCharArray(); 

        public static string EncryptString(string str, string key)
        {
            string result = "";
            int key_indx = 0;

            foreach (char item in str)
            {
                int crypted = (Array.IndexOf(_alphabet, item) + Array.IndexOf(_alphabet, key[key_indx])) % _alphabet.Length;
                result += _alphabet[crypted];
                key_indx++;
                if (key_indx == key.Length) key_indx = 0;
            }
            

            return result;
        }
        public static string DecryptString(string str, string key)
        {
            string result = "";
            int key_indx = 0;

            foreach (char item in str)
            {
                int decrypted = (Array.IndexOf(_alphabet, item) - Array.IndexOf(_alphabet, key[key_indx]) + _alphabet.Length) % _alphabet.Length;
                result += _alphabet[decrypted];
                key_indx++;
                if (key_indx + 1== key.Length) key_indx = 0;
            }


            return result;
        }
    }
}
