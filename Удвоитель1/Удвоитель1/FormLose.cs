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
    public partial class FormLose : Form
    {
        public FormLose()
        {
            InitializeComponent();
            loseLbl.Text = "К сожалению вы проиграли:(";
        }

        private void loseLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
