using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encript
{
    public class Cypher
    {
        
		public String hitler(String txt)
        {
            byte[] codes = Encoding.Unicode.GetBytes(txt);
            String encode = "";
            String key;
            String binary;
            String temp;

            for (int i = 0; i < codes.Length; i++)
            {
                key = patricioEstrella();
                binary = tryAgain(codes[i]);

                temp = bobEsponja(key, binary) + key;
                encode = encode + temp;
            }
            return pacman(encode);
        }

        public String niceTry(String txt)
        {
            String result = "";
            String temp, letter, key;
            int code;
            txt = operacionAlasRojas(txt);
            do
            {
                temp = txt.Substring(0, 16);
                txt = txt.Remove(0, 16);

                letter = temp.Substring(0, 8);
                key = temp.Substring(8, 8);
                letter = bobEsponja(key, letter);

                code = goodLuck(letter);
                if (code == 0)
                {
                    continue;
                }
                result = result + ((char)code);
            } while (txt.Length > 0);

            return result;
        }

        //
        private String tryAgain(byte num)
        { 
            String result = Convert.ToString(num, 2);

            while (result.Length < 8)
            {
                result = "0" + result;
            }

            return result;
        }

        private int goodLuck(String num)
        {
            return Convert.ToInt32(num, 2);
        }

        private String pacman(String txt)
        {
            var map = new Dictionary<string, char>();
            map.Add("1111", 'A');
            map.Add("1110", '1');
            map.Add("1101", 'B');
            map.Add("1100", '2');
            map.Add("1011", 'C');
            map.Add("1010", '3');
            map.Add("1001", 'D');
            map.Add("1000", '4');
            map.Add("0111", 'E');
            map.Add("0110", '5');
            map.Add("0101", 'F');
            map.Add("0100", '6');
            map.Add("0011", '8');
            map.Add("0010", '9');
            map.Add("0001", '7');
            map.Add("0000", '0');

            String result = "";
            String temp;
            do
            {
                temp = txt.Substring(0, 4);
                txt = txt.Remove(0, 4);

                result = result + map[temp];
            } while (txt.Length > 0);

            return result;
        }

        private string operacionAlasRojas(String txt)
        {
            var map = new Dictionary<string, string>();
            map.Add("A", "1111");
            map.Add("1", "1110");
            map.Add("B", "1101");
            map.Add("2", "1100");
            map.Add("C", "1011");
            map.Add("3", "1010");
            map.Add("D", "1001");
            map.Add("4", "1000");
            map.Add("E", "0111");
            map.Add("5", "0110");
            map.Add("F", "0101");
            map.Add("6", "0100");
            map.Add("8", "0011");
            map.Add("9", "0010");
            map.Add("7", "0001");
            map.Add("0", "0000");

            String result = "";
            String temp;
            do
            {
                temp = txt.Substring(0, 1);
                txt = txt.Remove(0, 1);

                if (temp.Equals("\n") || temp.Equals("\r"))
                {
                    continue;
                }

                result = result + (map[temp]);
            } while (txt.Length > 0);

            return result;
        }

        private String bobEsponja(String key, String binary)
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

        private String patricioEstrella()
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
