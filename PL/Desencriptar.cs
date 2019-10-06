using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encript;
using Microsoft.VisualBasic;

namespace PL
{
    public partial class Desencriptar : Form
    {
        private Cypher cypher = new Cypher();
        public Desencriptar()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            string selectedFileName = null;
            do
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    selectedFileName = openFileDialog1.FileName;
                }
            } while (selectedFileName == null);

            string text = System.IO.File.ReadAllText(selectedFileName);

            String result = cypher.niceTry(text);

            string folderPath = null;
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            do
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    folderPath = folderBrowserDialog1.SelectedPath;
                }
            } while (folderPath == null);
            String fileName = "Texto original.txt";
            do
            {
                fileName = Interaction.InputBox("Ingresa el nombre del archivo:", "Guardar desencriptación", "Texto original.txt", -1, -1);
            } while (!fileName.EndsWith(".txt"));

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(folderPath, fileName)))
            {
                outputFile.WriteLine(result);
            }

            MessageBox.Show("Desencriptado con éxito", "Mensaje importante");
        }
    }
}
