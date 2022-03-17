using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8_SeriousTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Работа с текстом";
            labelOnLoad.Text = "Операции с текстом";
            labelOnLoad.BackColor = Color.White;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Green;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            labelOnLoad.ForeColor = Color.White;
        }

        private void qsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void сделатьТекстБелымToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelOnLoad.ForeColor = Color.White;
        }
    }
}
