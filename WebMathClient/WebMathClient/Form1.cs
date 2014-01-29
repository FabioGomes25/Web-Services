using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WebMathClient
{
    public partial class Form1 : Form
    {
        MathService.CalculatorClient service = new MathService.CalculatorClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = Convert.ToDouble(txtValueOne.Text);
                double v2 = Convert.ToDouble(txtValueTwo.Text);
                lblResult.Text = service.Add(v1, v2);
            }catch(Exception exc)
            {
                lblResult.Text = exc.Message;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = Convert.ToDouble(txtValueOne.Text);
                double v2 = Convert.ToDouble(txtValueTwo.Text);
                lblResult.Text = service.Subtract(v1, v2);
            }catch(Exception exc)
            {
                lblResult.Text = exc.Message;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = Convert.ToDouble(txtValueOne.Text);
                double v2 = Convert.ToDouble(txtValueTwo.Text);
                lblResult.Text = service.Multiply(v1, v2);
            }catch (Exception exc)
            {
                lblResult.Text = exc.Message;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = Convert.ToDouble(txtValueOne.Text);
                double v2 = Convert.ToDouble(txtValueTwo.Text);
                lblResult.Text = service.Divide(v1, v2);
            }catch (Exception exc)
            {
                lblResult.Text = exc.Message;
            }
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = Convert.ToDouble(txtValueOne.Text);
                double v2 = Convert.ToDouble(txtValueTwo.Text);
                lblResult.Text = service.Modulus(v1, v2);
            }catch (Exception exc)
            {
                lblResult.Text = exc.Message;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
