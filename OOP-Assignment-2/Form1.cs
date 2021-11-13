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
        public Form1()

        {
            InitializeComponent();
        }
        private void DisplayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "0";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(DisplayBox.Text!="")
            {
                DisplayBox.Text = DisplayBox.Text.Substring(0, DisplayBox.Text.Length - 1);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "/";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "log(";
        }

        private void btnOpenBrack_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "(";
        }

        private void btnCloseBrack_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + ")";
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "sin(";
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "cos(";
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "tan(";
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "tanh(";
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "cosh(";
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            if (DisplayBox.Text == "0")
            {
                DisplayBox.Text = "";
            }
            DisplayBox.Text = DisplayBox.Text + "sinh(";
        }

        private void btnClearEnt_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = "0";
            DisplayBox.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = "0";
            DisplayBox.Text = "";
        }
    }
}
