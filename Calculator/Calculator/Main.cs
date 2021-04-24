using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Main : Form
    {
        double First_No ;
     
       string operatation = null;
        
        public Main()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (tb_Res.Text == "0")
            {

                tb_Res.Text = "1";
            }
            else
            {
                tb_Res.Text += "1";
            }



        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (tb_Res.Text == "0")
            {

                tb_Res.Text = "2";
            }
            else
            {
                tb_Res.Text += "2";
            }
        
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (tb_Res.Text == "0")
            {

                tb_Res.Text = "3";
            }
            else
            {
                tb_Res.Text += "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (tb_Res.Text == "0")
            {

                tb_Res.Text = "4";
            }
            else
            {
                tb_Res.Text += "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (tb_Res.Text == "0")
            {

                tb_Res.Text = "5";
            }
            else
            {
                tb_Res.Text += "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (tb_Res.Text == "0")
            {

                tb_Res.Text = "6";
            }
            else
            {
                tb_Res.Text += "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (tb_Res.Text == "0")
            {

                tb_Res.Text = "7";
            }
            else
            {
                tb_Res.Text += "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (tb_Res.Text == "0")
            {

                tb_Res.Text = "8";
            }
            else
            {
                tb_Res.Text += "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (tb_Res.Text == "0")
            {

                tb_Res.Text = "9";
            }
            else
            {
                tb_Res.Text += "9";
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (tb_Res.Text == "0")
            {

                tb_Res.Text = "0";
            }
            else
            {
                tb_Res.Text += "0";
            }
        }

        private void bc_Click(object sender, EventArgs e)
        {

            tb_Res.Text = "0";
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            if (tb_Res.Text == "0")
            {

                tb_Res.Text = ".";
            }
            else
            {
                tb_Res.Text += ".";
            }
        }

        private void badd_Click(object sender, EventArgs e)
        {
            First_No = Convert.ToDouble(tb_Res.Text);
            tb_Res.Text = "0";

            operatation = "+";


        }

        private void bsub_Click(object sender, EventArgs e)
        {
            First_No = Convert.ToDouble(tb_Res.Text);
            tb_Res.Text = "0";

            operatation = "-";
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            First_No = Convert.ToDouble(tb_Res.Text);
            tb_Res.Text = "0";

            operatation = "*";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            First_No = Convert.ToDouble(tb_Res.Text);
            tb_Res.Text = "0";

            operatation = "/";
        }

        private void bmod_Click(object sender, EventArgs e)
        {
            First_No = Convert.ToDouble(tb_Res.Text);
            tb_Res.Text = "0";

            operatation = "%";
        }

        private void beql_Click(object sender, EventArgs e)
        {
            double second_Number = Convert.ToDouble(tb_Res.Text);
            double result;

            if(operatation == "+")
            {
                result = First_No + second_Number;
                tb_Res.Text = result.ToString();
                
            }
            if (operatation == "-")
            {
                result = First_No - second_Number;
                tb_Res.Text = result.ToString();

            }
            if (operatation == "*")
            {
                result = First_No * second_Number;
                tb_Res.Text = result.ToString();

            }
            if (operatation == "/")
            {
                result = First_No / second_Number;
                tb_Res.Text = result.ToString();

            }
            if (operatation == "%")
            {
                result = First_No - second_Number;
                tb_Res.Text = result.ToString();

            }
        }

        
    }
}
