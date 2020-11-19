using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Удвоитель1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            BtnPlay.Text = "Играть в игру \"Удвоитель\"";
            BtnPlay2.Text = "Играть в игру \"Угадай число\"";
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void BtnPlay2_Click(object sender, EventArgs e)
        {
            FormGuess f = new FormGuess();
            f.ShowDialog();
        }
    }
}
