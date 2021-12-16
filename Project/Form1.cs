using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Translator : Form
    {
        public Translator()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculator calc = new Calculator();
            calc.Show();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {

            if (NumberBox.Text == "" || FromBox.Text == "" || ToBox.Text == "")
            {
                MessageBox.Show("Не все данные введены", "Ошибка!");
                return;
            }

            Number number = new Number(NumberBox.Text, FromBox.Text);

            try
            {
                ResultBox.Text = number.Translate(ToBox.Text);
            }
            catch (ArgumentException)
            {
                ResultBox.Text = "";
                MessageBox.Show("Данные введены не корректно", "Ошибка!");
                return;
            }
            
        }
    }
}
