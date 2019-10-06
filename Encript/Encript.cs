using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encript
{
    public class Encript
    {
      
		public String Encript(String txt)
        {
            byte[] codes = Encoding.ASCII.GetBytes(txt);


            return "";
        }

        public String toBinary(byte num)
        {
            String result = Convert.ToString(num, 2);

            while (result.Length < 8)
            {
                result = "0" + result;
            }

            return result;
        }

        public static String xor(String key, String binary)
        {
            String encript = "";
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary.ElementAt(i) == key.ElementAt(i))
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

        public static String GenerateKey()
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
