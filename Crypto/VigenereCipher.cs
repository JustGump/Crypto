using System;

namespace Crypto
{
    public static class VigenereCipher
    {
        private static readonly char[] _symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ 0123456789?!,.".ToCharArray();
        public static string EncryptString(string str, string key)
        {
            str = str.ToUpper();
            key = key.ToUpper();
            string result = "";
            int keyIndx = 0;      
            foreach (char item in str)
            {
                int crypted = (Array.IndexOf(_symbols, item) + Array.IndexOf(_symbols, key[keyIndx])) % _symbols.Length;
                result += _symbols[crypted];
                keyIndx++;
                if (keyIndx == key.Length) keyIndx = 0;
            }
            return result;
        }
        public static string DecryptString(string str, string key)
        {
            str = str.ToUpper();
            key = key.ToUpper();
            string result = "";
            int keyIndx = 0;
            foreach (char item in str)
            {
                int decrypted = (Array.IndexOf(_symbols, item) - Array.IndexOf(_symbols, key[keyIndx]) + _symbols.Length) % _symbols.Length;
                result += _symbols[decrypted];
                keyIndx++;
                if (keyIndx == key.Length) keyIndx = 0;
            }
            return result;
        }
    }

    
}
