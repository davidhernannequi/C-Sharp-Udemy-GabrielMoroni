using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string selectedOperator;
        double acumulatedValue;

        public Form1()
        {
            InitializeComponent();
        }


        private void NumberAction_Click(object sender, EventArgs e)
        {
            double buttonValue;
            double currentValue = double.Parse(txtValue.Text);


            Button button = (Button)sender;
            buttonValue = double.Parse(button.Text);
            currentValue = currentValue * 10 + buttonValue;
            
            txtValue.Text = currentValue.ToString();
        }

        private void OperatorAction_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            selectedOperator = button.Text;
            acumulatedValue = double.Parse(txtValue.Text);
            txtValue.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
            acumulatedValue = 0;
            selectedOperator = string.Empty;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondAcumulatedValue = double.Parse(txtValue.Text);
            double result = 0;

            switch (selectedOperator)
            {
                case "+":
                    result = acumulatedValue + secondAcumulatedValue;
                    break;
                case "-":
                    result = acumulatedValue - secondAcumulatedValue;
                    break;
                case "*":
                    result = acumulatedValue * secondAcumulatedValue;
                    break;
                case "/":
                    result = acumulatedValue / secondAcumulatedValue;
                    break;
            }
            txtValue.Text = result.ToString();

        }
    }
}
