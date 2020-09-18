//Kayla Arns
//Date: September 17, 2020
//Chapter 5, exercise 9
//New Feature Sum 200 Program

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sum200
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int topValue;

            topValue = Convert.ToInt32(txtTop.Text);

            for(int i=0; i<= topValue; i++)
            {
                sum += i;

                if (i == topValue/2)
                {
                    txtHalfWay.Text = Convert.ToString(sum);
                    //Console.WriteLine("i = " + i + " Sum " + sum);
                }
            }

            txtSum.Text = Convert.ToString(sum);
        }
    }
}
