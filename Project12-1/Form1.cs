using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project12_1
{
    public partial class Form1 : Form
    {
        Calculator calc;


        public Form1()
        {
            calc = new Calculator(); 
            InitializeComponent();
        }


        private string valueString;
        private decimal valueDecimal;
        

        private bool newValue;
        private bool decimalPresent;
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalculator.Clear();
            calc.Clear();
            valueDecimal = 0;
            valueString = "";
            newValue = true;
            decimalPresent = false;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if(valueString.Length >= 1)
            {
                valueString = valueString.Substring(0, valueString.Length - 1);
            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            
                decimal calculation = calc.Equals(valueDecimal);
                txtCalculator.Text = Convert.ToString(calculation);
            
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            valueDecimal = -valueDecimal;
            txtCalculator.Text = valueDecimal.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            valueDecimal = 0;
            valueString = "";
            decimalPresent = false;
            newValue = true;

        }

        

        private void btn0_Click(object sender, EventArgs e)
        {
            if (newValue)
            {
                valueString = "";
                newValue = false;
            }
            valueString += "0";
            valueDecimal = Convert.ToDecimal(valueString);
            txtCalculator.Text = valueDecimal.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (newValue)
            {
                valueString = "";
                newValue = false;
            }
            valueString += "1";
            valueDecimal = Convert.ToDecimal(valueString);
            txtCalculator.Text = valueDecimal.ToString();


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (newValue)
            {
                valueString = "";
                newValue = false;
            }
            valueString += "2";
            valueDecimal = Convert.ToDecimal(valueString);
            txtCalculator.Text = valueDecimal.ToString();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (newValue)
            {
                valueString = "";
                newValue = false;
            }
            valueString += "3";
            valueDecimal = Convert.ToDecimal(valueString);
            txtCalculator.Text = valueDecimal.ToString();


        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (newValue)
            {
                valueString = "";
                newValue = false;
            }
            valueString += "4";
            valueDecimal = Convert.ToDecimal(valueString);
            txtCalculator.Text = valueDecimal.ToString();


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (newValue)
            {
                valueString = "";
                newValue = false;
            }
            valueString += "5";
            valueDecimal = Convert.ToDecimal(valueString);
            txtCalculator.Text = valueDecimal.ToString();


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (newValue)
            {
                valueString = "";
                newValue = false;
            }
            valueString += "6";
            valueDecimal = Convert.ToDecimal(valueString);
            txtCalculator.Text = valueDecimal.ToString();


        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (newValue)
            {
                valueString = "";
                newValue = false;
            }
            valueString += "7";
            valueDecimal = Convert.ToDecimal(valueString);
            txtCalculator.Text = valueDecimal.ToString();


        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (newValue)
            {
                valueString = "";
                newValue = false;
            }
            valueString += "8";
            valueDecimal = Convert.ToDecimal(valueString);
            txtCalculator.Text = valueDecimal.ToString();



        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (newValue)
            {
                valueString = "";
                newValue = false;
            }
            valueString += "9";
            valueDecimal = Convert.ToDecimal(valueString);
            txtCalculator.Text = valueDecimal.ToString();



        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            calc.Add(valueDecimal);
            newValue = true;
            decimalPresent = false;
            valueDecimal = calc.CalculatedValue;
            valueString = valueDecimal.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calc.Subtract(valueDecimal);
            newValue = true;
            decimalPresent = false;
            valueDecimal = calc.CalculatedValue;
            valueString = valueDecimal.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calc.Multiply(Convert.ToDecimal(valueString));
            newValue = true;
            decimalPresent = false;
            valueDecimal = calc.CalculatedValue;
            valueString = valueDecimal.ToString();

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {

        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {

        }

       
        
    }
}
