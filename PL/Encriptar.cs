using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Encript;
using Microsoft.VisualBasic;

namespace PL
{
    public partial class Encriptar : Form
    {
        Cypher cypher;
        public Encriptar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Encriptar_Click(object sender, EventArgs e)
        {
            cypher = new Cypher();
            if (validate(TextBox.Text))
            {
                string folderPath = null;
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                do
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        folderPath = folderBrowserDialog1.SelectedPath;
                    }
                } while (folderPath == null);
                String fileName = "Cifrado mieo.txt";
                do
                {
                    fileName = Interaction.InputBox("Ingresa el nombre del archivo:", "Guardar encriptación", "Cifrado mieo.txt", -1, -1);
                } while (!fileName.EndsWith(".txt"));
                String result = cypher.hitler(TextBox.Text);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(folderPath, fileName)))
                {
                    outputFile.WriteLine(result);
                }

                MessageBox.Show("Nice try, try again.");
            }
            else
            {
                MessageBox.Show("Texto inválido.");
            }
        }

        private bool validate(String txt)
        { 
            byte[] codes = Encoding.Unicode.GetBytes(txt);
            int count = codes.Length;
            for (int i = 0; i < codes.Length; i++)
            {
                byte code = codes[i];
                if ((code >= 97 && code <= 122)
                    || (code >= 65 && code <= 90)
                    || (code >= 48 && code <= 57)
                    || (code == 10 || code == 13 || code == 0 || code == 59 || code == 46 || code == 44 || code == 225 || code == 233 || code == 237 || code == 243 || code == 250 || code == 193 || code == 201 || code == 205 || code == 211 || code == 218 || code == 63 || code == 191 || code == 32))
                {
                    count--;
                }
            }

            return count == 0;
        }
    }
}
