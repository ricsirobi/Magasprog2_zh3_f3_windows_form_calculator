using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamologep
{
    public partial class Calculator : Form
    {
        //tc92hl
        public int counter,operation;
        public string firstNum, secondNum;
        public char operationChar;
        public Calculator()
        {
            InitializeComponent();
            ActiveControl = null;
        }

        private void TextBox_numTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !("\b01".Contains(e.KeyChar));
        }

        private void TextBox_numOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !("\b01".Contains(e.KeyChar));
        }

        private void Button_new_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            counter = 0;
            operation = 0;
            firstNum = null;
            secondNum = null;
            InitializeComponent();
        }

        private void radioButton_mul_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button_intake_Click(object sender, EventArgs e)
        {

            if (radioButton_add.Checked) { operation = 1;  operationChar = '+'; }
            if (radioButton_sub.Checked) { operation = 2; operationChar = '-'; }
            if (radioButton_mul.Checked) { operation = 3; operationChar = '*'; }
            if (radioButton_div.Checked) { operation = 4; operationChar = '/'; }
            if (textBox_numOne.Text == "" || (textBox_numTwo.Text == "" && counter == 2)) MessageBox.Show("Nem lehet üres a mező!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                counter++;
                firstNum = textBox_numOne.Text;
                textBox_result.Text = Convert.ToString(Convert.ToInt64(textBox_numOne.Text, 2), 2);
                secondNum = textBox_numTwo.Text;
            }
            if (counter == 1)
            {
                groupBox_operations.Visible = true;
                textBox_numOne.Visible = false;
                label_number.Visible = false;
                textBox_numTwo.Visible = false;
            }
            if (counter == 2)
            {
                label_number.Text = "2. szám bevitele:";
                textBox_result.Text = textBox_result.Text + " " + operationChar;
                label_number.Visible = true;
                groupBox_operations.Visible = false;
                textBox_numOne.Visible = false;
                textBox_numTwo.Visible = true;
                button_intake.Text = "=";
            }
            if (counter > 2)
            {
                textBox_result.Text = textBox_result.Text + " " + operationChar + " "+ Convert.ToString(Convert.ToInt64(textBox_numTwo.Text, 2), 2);
                panel_numbers.Visible = false;
                groupBox_operations.Visible = false;
                button_intake.Visible = false;//tc92hl
                Action(firstNum, secondNum, operation);
            }

        }
        public void Action(string first, string second, int op)
        {
            string result = "";
            if (op == 1) result = Convert.ToString(Convert.ToInt64(first, 2) + Convert.ToInt64(second, 2), 2);
            if (op == 2) result = Convert.ToString(Convert.ToInt64(first, 2) - Convert.ToInt64(second, 2), 2);
            if (op == 3) result = Convert.ToString(Convert.ToInt64(first, 2) * Convert.ToInt64(second, 2), 2);
            if (op == 4) result = Convert.ToString(Convert.ToInt64(first, 2) / Convert.ToInt64(second, 2), 2);
            textBox_result.Text = textBox_result.Text + " = " + result;
            button_new.Visible = true;
        }
    }
}
