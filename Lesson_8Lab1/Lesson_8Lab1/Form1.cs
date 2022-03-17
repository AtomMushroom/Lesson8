using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_8Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Add(lstMenu.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Remove(lstZakaz.SelectedItem);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lstZakaz.Items)
            {
                switch (item)
                {
                    case "Доширак (60)":
                        sum += 60;
                        break;
                    case "Тортик (120)":
                        sum += 120;
                        break;
                    case "Супчик (80)":
                        sum += 80;
                        break;
                    case "Пицца (120)":
                        sum += 120;
                        break;
                    case "Шаурма (160)":
                        sum += 160;
                        break;
                    case "Самса (70)":
                        sum += 70;
                        break;
                }
            }
            MessageBox.Show($"Приятного аппетита! Сумма к оплате: {sum} рублей", "Две самсы");
            this.Close();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lstZakaz.Items.Clear();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            lstMenu.Items.Add(txtNew.Text);
        }
    }
}
