﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kadai_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}",2+2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}", 2 - 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}", 2 * 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}", 2 / 2);
        }
    }
}
