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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            Count.Text = "0";
            informlbl.Text = "Количества отданных команд удвоителю: ";
            ConditionLbl.Text = "Вам нужно набрать число 72 за 8 ходов";
            checkBtn.Text = "Проверить";
            this.Text = "Удвоитель";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            Count.Text = (int.Parse(Count.Text) + 1).ToString();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            Count.Text = (int.Parse(Count.Text) + 1).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            Count.Text = (int.Parse(Count.Text) + 1).ToString();

        }

        private void lblNumber_Click(object sender, EventArgs e)
        {
            
        }

        private void Count_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConditionLbl_Click(object sender, EventArgs e)
        {

        }

        private void lblNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if(int.Parse(lblNumber.Text) == 72 && int.Parse(Count.Text) <= 8)
            {
                FormWin f = new FormWin();
                f.ShowDialog();
            }
            else
            {
                FormLose f = new FormLose();
                f.ShowDialog();
            }
        }
    }
}
