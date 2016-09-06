﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    static public class VigenereCipher
    {
        static char[,] _table = new char[25, 25];
        static readonly string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string key { set; get; } = "KEYWORD";
       

        static VigenereCipher()
        {
            CreateTable();
        }
        static void CreateTable()
        {
            int shift = 0;

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    shift = i + j;
                    if (shift >= 25) shift = shift % 25; 
                    _table[i, j] = _alphabet[shift];
                }
            }
        }
        public static void ShowTable()
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    Console.Write(_table[i, j] + " ");
                }
                Console.Write("\n");
            }
        } 

        public static string EncryptString(string str)
        {
            string result = str;
            return result;
        }
        public static string DecryptString(string str)
        {
          /*  if (str == "YO")
            {
                throw new ArgumentException("Parameter cannot be YO", "original");
            }*/
            string result = str;
            return "Dis shit decrypted! fck yeah";
        }
    }
}
