﻿//Kayla Arns
//September 17, 2020
//Chapter 5, exercise 9
//Sum 200

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

            for(int i=0; i<= 200; i++)
            {
                sum += i;

                if (i == 100)
                {
                    txtHalfWay.Text = Convert.ToString(sum);
                    //Console.WriteLine("i = " + i + " Sum " + sum);
                }
            }

            txtSum.Text = Convert.ToString(sum);
        }
    }
}
