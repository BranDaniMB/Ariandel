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

namespace PL
{
    public partial class Main : Form
    {
        public Main()
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
            if (validate(TextBox.Text))
            {
                string folderPath = "";
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    folderPath = folderBrowserDialog1.SelectedPath;
                }
                MessageBox.Show("Folter " + folderPath);
            } else
            {
                MessageBox.Show("Texto inválido.");
            }
            MessageBox.Show("Nice try, try again.");
        }

        private bool validate(String txt)
        { 
            byte[] codes = Encoding.ASCII.GetBytes(txt);
            int count = codes.Length;
            for (int i = 0; i < codes.Length; i++)
            {
                byte code = codes[i];
                if ((code >= 97 && code <= 122)
                    || (code >= 65 && code <= 90)
                    || (code >= 48 && code <= 57)
                    || (code == 59 || code == 46 || code == 44 || code == 225 || code == 233 || code == 237 || code == 243 || code == 250 || code == 193 || code == 201 || code == 205 || code == 211 || code == 218 || code == 63 || code == 191 || code == 32))
                {
                    count--;
                }
            }

            return count == 0;
        }
    }
}
