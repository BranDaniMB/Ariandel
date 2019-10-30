using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encript
{
    public class Cypher
    {
        public String encrypt(String text)
        {
            LinkedList list = new LinkedList(text, true);
            return list.ToString();
        }

        public String decrypt(String text)
        {
            LinkedList list = new LinkedList(text, false);
            return list.ToString();
        }

        private class LinkedList
        {
            private Node first, last;

            public LinkedList(string text, bool mode)
            {
                if (mode)
                {
                    fillToEncrypt(text);
                    encrypt();
                } else
                {
                    fillToDecrypt(text);
                    decrypt();
                }
            }

            public void add(String content)
            {
                Node temp = new Node(content);
                if (this.first == null)
                {
                    this.first = temp;
                    this.last = temp;
                } else
                {
                    this.last.setNext(temp);
                    temp.setPrevious(this.last);
                    this.last = temp;
                }
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

            private String toBinary(byte num)
            {
                String result = Convert.ToString(num, 2);

                while (result.Length < 8)
                {
                    result = "0" + result;
                }

                return result;
            }

            private int toDecimalFromBinary(String num)
            {
                return Convert.ToInt32(num, 2);
            }

            private String toBinaryFromHexa(String num)
            {
                String temp = Convert.ToString(Convert.ToInt32(num, 16), 2);

                while (temp.Length < 8)
                {
                    temp = "0" + temp;
                }

                return temp;
            }

            private String toHexaFromBinary(String num)
            {
                String temp = Convert.ToString(Convert.ToInt32(num, 2), 16);
                while (temp.Length < 2)
                {
                    temp = "0" + temp;
                }

                return temp;
            }

            private void fillToEncrypt(string text)
            {
                byte[] codes = Encoding.Unicode.GetBytes(text);

                foreach(byte code in codes)
                {
                    if (code == 0)
                    {
                        continue;
                    }
                    add(toBinary(code));
                }
            }

            private void fillToDecrypt(string text)
            {
                while(text.Length > 0)
                {
                    string temp = text.Substring(0, 2);
                    text = text.Remove(0, 2);
                    if (temp.Equals("\r\n"))
                    {
                        continue;
                    }
                    temp = toBinaryFromHexa(temp);

                    add(temp);
                }
            }

            private void encrypt()
            {
                Node tempNode = this.first;

                while (tempNode != null)
                {
                    if (tempNode.getNext() == null)
                    {
                        tempNode.setContent(toHexaFromBinary(tempNode.getContent()));
                    } else
                    {
                        tempNode.setContent(toHexaFromBinary(xor(tempNode.getNext().getContent(), tempNode.getContent())));
                    }

                    tempNode = tempNode.getNext();
                }
            }

            private void decrypt()
            {
                Node tempNode = this.last.getPrevious();

                while (tempNode != null)
                {
                    tempNode.setContent(xor(tempNode.getNext().getContent(), tempNode.getContent()));

                    tempNode = tempNode.getPrevious();
                }

                tempNode = this.first;

                while (tempNode != null)
                {
                    tempNode.setContent(((Char) toDecimalFromBinary(tempNode.getContent())).ToString());

                    tempNode = tempNode.getNext();
                }
            }

            override
            public String ToString()
            {
                Node tempNode = this.first;
                String text = "";

                while (tempNode != null)
                {
                    text += tempNode.getContent();
                    tempNode = tempNode.getNext();
                }

                return text;
            }
        }

        private class Node
        {
            private Node previous, next;
            private String content;

            public Node(string content)
            {
                this.content = content;
            }

            public Node getPrevious()
            {
                return this.previous;
            }

            public Node getNext()
            {
                return this.next;
            }

            public String getContent()
            {
                return this.content;
            }

            public void setNext(Node next)
            {
                this.next = next;
            }

            public void setPrevious(Node previous)
            {
                this.previous = previous;
            }

            public void setContent(String content)
            {
                this.content = content;
            }
        }
    }
}
