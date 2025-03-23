using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Homework
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            lblExpression.Text = lblExpression.Text + "7";
            lblNumbers.Text = "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            lblExpression.Text = lblExpression.Text + "8";
            lblNumbers.Text = "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            lblExpression.Text = lblExpression.Text + "9";
            lblNumbers.Text = "9";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            lblExpression.Text = lblExpression.Text + "4";
            lblNumbers.Text = "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            lblExpression.Text = lblExpression.Text + "5";
            lblNumbers.Text = "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            lblExpression.Text = lblExpression.Text + "6";
            lblNumbers.Text = "6";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            lblExpression.Text = lblExpression.Text + "1";
            lblNumbers.Text = "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            lblExpression.Text = lblExpression.Text + "2";
            lblNumbers.Text = "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            lblExpression.Text = lblExpression.Text + "3";
            lblNumbers.Text = "3";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (lblNumbers.Text != null && lblNumbers.Text != "" && lblNumbers.Text != "+" &&
                lblNumbers.Text != "-" && lblNumbers.Text != "*" && lblNumbers.Text != "/")
            {
                lblExpression.Text = lblExpression.Text + "0";
                lblNumbers.Text = "0";
            }
            else
            {
                return;
            }
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (lblNumbers.Text != null && lblNumbers.Text != "" && lblNumbers.Text != "+" &&
                lblNumbers.Text != "-" && lblNumbers.Text != "*" && lblNumbers.Text != "/" )
            {
                lblExpression.Text = lblExpression.Text + "/";
                lblNumbers.Text = "/";
            }
            else
            {
                return;
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (lblNumbers.Text != null && lblNumbers.Text != "" && lblNumbers.Text != "+" &&
                lblNumbers.Text != "-" && lblNumbers.Text != "*" && lblNumbers.Text != "/")
            {
                lblExpression.Text = lblExpression.Text + "*";
                lblNumbers.Text = "*";
            }
            else
            {
                return;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (lblNumbers.Text != null && lblNumbers.Text != "" && lblNumbers.Text != "+" &&
                lblNumbers.Text != "-" && lblNumbers.Text != "*" && lblNumbers.Text != "/")
            {
                lblExpression.Text = lblExpression.Text + "-";
                lblNumbers.Text = "-";
            }
            else
            {
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblNumbers.Text != null && lblNumbers.Text != "" && lblNumbers.Text != "+" &&
                lblNumbers.Text != "-" && lblNumbers.Text != "*" && lblNumbers.Text != "/")
            {
                lblExpression.Text = lblExpression.Text + "+";
                lblNumbers.Text = "+";
            }
            else
            {
                return;
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (lblNumbers.Text != null && lblNumbers.Text != "" && lblNumbers.Text != "+" &&
                lblNumbers.Text != "-" && lblNumbers.Text != "*" && lblNumbers.Text != "/")
            {
                string expression = lblExpression.Text;
                var result = new DataTable().Compute(expression, null);
                lblExpression.Text = lblExpression.Text + "=" + result;
                lblNumbers.Text = result.ToString();
            }
            else
            {
                return;
            }
            //string sumArray = lblExpression.Text.ToString();
            //double result = 0;
            //double sumNum = 0;
            //char sumOper = '+';
            //
            //for (int i = 0; i < sumArray.Length; i++)
            //{
            //    char sumChar = sumArray[i];
            //    if (sumChar == '1' || sumChar == '2' || sumChar == '3' || sumChar == '4'
            //        || sumChar == '5' || sumChar == '6' || sumChar == '7' || sumChar == '8'
            //        || sumChar == '9' || sumChar == '0')
            //    {
            //        sumNum = sumNum * 10 + (sumChar - '0');
            //    }
            //    if (!Char.IsDigit(sumChar) || i == sumArray.Length - 1)
            //    {
            //        if (sumOper == '+')
            //            result = result + sumNum;
            //        else if (sumOper == '-')
            //            result = result - sumNum;
            //        else if (sumOper == '*')
            //            result = result * sumNum;
            //        else if (sumOper == '/')
            //            result = result / sumNum;
            //    }
            //    sumOper = sumChar;
            //    sumNum = 0;
            //}
            //lblExpression.Text = lblExpression.Text + "=" + result.ToString();
            //lblNumbers.Text = result.ToString();
            //
        }
    }
}
