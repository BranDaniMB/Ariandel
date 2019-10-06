using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Encriptar_Click(object sender, EventArgs e)
        {
            Encriptar encriptar = new Encriptar();
            encriptar.ShowDialog();
        }
    }
}
