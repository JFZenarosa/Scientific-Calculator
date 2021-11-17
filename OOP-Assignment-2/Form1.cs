using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Assignment_2
{
    public partial class Form1 : Form
    {
        double results = 0;
        string operation = "";
        bool enter_value = false;

        public Form1()

        {
            InitializeComponent();
        }
        private void DisplayBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnClearEnt_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = "0";
            DisplayBox2.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = "0";
            DisplayBox2.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text.Length >0)
            {
                DisplayBox.Text = DisplayBox.Text.Remove(DisplayBox.Text.Length - 1, 1);
            }

            if (DisplayBox.Text == "")
            {
                DisplayBox.Text = "0";
            }
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(DisplayBox.Text);
            DisplayBox.Text = "";
            DisplayBox2.Text = System.Convert.ToString(results) + " " + operation;
        }



        private void Button_Click(object sender, EventArgs e)
        {
            if ((DisplayBox.Text == "0") || (enter_value))
                DisplayBox.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!DisplayBox.Text.Contains("."))
                    DisplayBox.Text = DisplayBox.Text + num.Text;
            }
            else
                DisplayBox.Text = DisplayBox.Text + num.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            DisplayBox2.Text = "";
            switch(operation)
            {
                case "+":
                    DisplayBox.Text = (results + Double.Parse(DisplayBox.Text)).ToString();
                    break;

                case "-":
                    DisplayBox.Text = (results - Double.Parse(DisplayBox.Text)).ToString();
                    break;

                case "*":
                    DisplayBox.Text = (results * Double.Parse(DisplayBox.Text)).ToString();
                    break;

                case "/":
                    DisplayBox.Text = (results / Double.Parse(DisplayBox.Text)).ToString();
                    break;

                case "Mod":
                    DisplayBox.Text = (results % Double.Parse(DisplayBox.Text)).ToString();
                    break;

                case "Exp":
                    double i = Double.Parse(DisplayBox.Text);
                    double q;
                    q = (results);
                    DisplayBox.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double alog = Double.Parse(DisplayBox.Text);
            alog = Math.Log10(alog);
            DisplayBox.Text = System.Convert.ToString(alog);
        }
    }
}
