﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encript
{
    public class Cypher
    {
        
		public String Encode(String txt)
        {
            byte[] codes = Encoding.Unicode.GetBytes(txt);
            String encode = "";
            String key;
            String binary;
            String temp;

            for (int i = 0; i < codes.Length; i++)
            {
                key = GenerateKey();
                binary = toBinary(codes[i]);

                temp = xor(key, binary) + key;
                encode = encode + temp;
            }
            return encode;
        }

        public String Decode(String txt)
        {
            String result = "";
            String temp, letter, key;
            int code;
            do
            {
                temp = txt.Substring(0, 16);
                txt = txt.Remove(0, 16);

                letter = temp.Substring(0, 8);
                key = temp.Substring(8, 8);
                letter = xor(key, letter);

                code = toDecimal(letter);
                if (code == 0)
                {
                    continue;
                }
                result = result + ((char)code);
            } while (txt.Length > 0);

            return result;
        }

        //
        private String toBinary(byte num)
        { 
            String result = Convert.ToString(num, 2);

            while (result.Length < 8)
            {
                result = "0" + result;
            }

            return result;
        }

        private int toDecimal(String num)
        {
            return Convert.ToInt32(num, 2);
        }

        private String secondRound(String txt)
        {
            var map = new Dictionary<string, char>();
            map.Add("1111", 'A');
            map.Add("1110", 'B');
            map.Add("1101", 'C');
            map.Add("1100", 'D');
            map.Add("1011", 'E');
            map.Add("1010", 'F');
            map.Add("1001", 'G');
            map.Add("1000", 'H');
            map.Add("0111", 'I');
            map.Add("0110", 'J');
            map.Add("0101", 'K');
            map.Add("0100", 'L');
            map.Add("0011", 'M');
            map.Add("0010", 'N');
            map.Add("0001", 'O');
            map.Add("0000", 'P');

            String result = "";
            String temp;
            do
            {
                temp = txt.Substring(0, 4);
                txt = txt.Remove(0, 4);

                result.Append(map[temp]);
            } while (txt.Length > 0);

            return result;
        }

        private String xor(String key, String binary)
        {
            String encript = "";
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary.ElementAt(i).Equals(key.ElementAt(i)))
                {
                    encript = encript + "0";
                }
                else
                {
                    encript = encript + "1";
                }
            }

            return encript;
        }

        private String GenerateKey()
        {
            Random rnd = new Random();
            int random;
            String key = "";

            for (int i = 0; i < 8; i++)
            {
                random = rnd.Next(0, 2);
                key = random + key;
            }

            return key;
        }
    }
}
