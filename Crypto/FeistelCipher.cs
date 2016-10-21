using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    public static class FeistelСipher
    {
        private static byte Func()
        {
            return 0;
        }

        public static string Encrypt(string str, int rounds)
        {
            string res;
            if (str.Length % 2 != 0) str += " ";
            byte[] strBytes = Encoding.ASCII.GetBytes(str);
            foreach (var strByte in strBytes) Console.WriteLine(strByte);
            res = Encoding.ASCII.GetString(strBytes);
            return res;
        }

        public static string Decrypt()
        {
            return "";
        }

    }
}
