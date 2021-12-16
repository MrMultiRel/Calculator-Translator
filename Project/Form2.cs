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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void translatorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Translator tr = new Translator();
            tr.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            if (FirstNumberBox.Text == "" || SecondNumberBox.Text == "" || OperationBox.Text == "" || FirstFromBox.Text == "" || SecondFromBox.Text == "" || ResultFormBox.Text == "")
            {
                MessageBox.Show("Не все данные введены", "Ошибка!");
                return;
            }

            Number firstNumber = new Number(FirstNumberBox.Text, FirstFromBox.Text);
            Number secondNumber = new Number(SecondNumberBox.Text, SecondFromBox.Text);

            try
            {
                long decFirst = Convert.ToInt64(firstNumber.Translate("Десятичную"));
                long decSecond = Convert.ToInt64(secondNumber.Translate("Десятичную"));

                string operation = OperationBox.Text;
                Number resultNumber = null;

                switch (operation)
                {
                    case "+":
                        resultNumber = new Number((decFirst + decSecond).ToString(), "Десятичной");
                        break;

                    case "-":

                        if (decFirst < decSecond)
                        {
                            throw new ArgumentException();
                        }

                        resultNumber = new Number((decFirst - decSecond).ToString(), "Десятичной");
                        break;

                    case "*":
                        resultNumber = new Number((decFirst * decSecond).ToString(), "Десятичной");
                        break;

                    case ":":
                        resultNumber = new Number((decFirst / decSecond).ToString(), "Десятичной");
                        break;

                    default:
                        throw new ArgumentException();
                }

                ResultBox.Text = resultNumber.Translate(ResultFormBox.Text);
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
