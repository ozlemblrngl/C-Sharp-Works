using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Calculator
{
    public partial class Form1 : Form
    {

        char _expression;
        bool _isScreenClear;
        int _firstNumber;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                screenLabel.Text = "";
                _isScreenClear = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                screenLabel.Text = "";
                _isScreenClear = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                screenLabel.Text = "";
                _isScreenClear = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                screenLabel.Text = "";
                _isScreenClear = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "5";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _expression = '+';
            _isScreenClear = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        private void number2Button_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                screenLabel.Text = "";
                _isScreenClear = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "2";
        }

        private void number3Button_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                screenLabel.Text = "";
                _isScreenClear = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "3";
        }

        private void number7Button_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                screenLabel.Text = "";
                _isScreenClear = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "7";
        }

        private void number8Button_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                screenLabel.Text = "";
                _isScreenClear = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "8";
        }

        private void number9Button_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                screenLabel.Text = "";
                _isScreenClear = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "9";
        }

        private void number0Button_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                screenLabel.Text = "";
                _isScreenClear = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "0";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            int secondNumber = Convert.ToInt32(screenLabel.Text);
            int result;

            switch (_expression) 
            {
                case '+':
                    result = _firstNumber + secondNumber;
                    break;
                case '-':
                    result = _firstNumber - secondNumber;
                    break;
                case '*':
                    result = _firstNumber * secondNumber;
                    break;
                case '/':
                    result = _firstNumber / secondNumber;
                    break;
                default: result = 0;
                    break;
            }

            screenLabel.Text = Convert.ToString(result);
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            _expression = '-';
            _isScreenClear = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            _expression = '*';
            _isScreenClear = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            _expression = '/';
            _isScreenClear = true;
            _firstNumber = Convert.ToInt32(screenLabel.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            screenLabel.Text = "0";
        }
    }
}
