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

    public partial class FormGuess : Form
    {
        int number;
        int i = 1;
        public FormGuess()
        {
            InitializeComponent();
            resultLbl.Text = "";
            NumberBtn.Text = "Нажмите чтобы сгенерировать число от 1 до 100";
            Lbl1.Text = "";
            answerBox.Visible = false;
            checkAnswer.Visible = false;
        }

        private void guessLbl_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswer_Click(object sender, EventArgs e)
        {
            
                if (int.Parse(answerBox.Text) == number)
                {
                    FormWin f = new FormWin();
                    f.ShowDialog();
                }
                else if (int.Parse(answerBox.Text) > number && i < 5)
                {
                    resultLbl.Text = "Вы ввели слишком большое число";
            }
            else if (int.Parse(answerBox.Text) < number && i < 5)
                {
                    resultLbl.Text = "Вы ввели слишком маленькое число";
            }
            else if (i == 5)
                {
                    FormLose f = new FormLose();
                    f.ShowDialog();
                }

            i++;
        }

        private void NumberBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            number = rnd.Next(1, 100);
            NumberBtn.Visible = false;
            Lbl1.Text = "а теперь попробуйте его угадать за 5 попыток";
            answerBox.Visible = true;
            checkAnswer.Visible = true;
        }

        private void resultLbl_Click(object sender, EventArgs e)
        {

        }

        private void Lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
