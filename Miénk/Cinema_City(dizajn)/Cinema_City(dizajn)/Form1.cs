﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mozizas;

namespace Cinema_City_dizajn_
{
    public partial class Form1 : Form
    {
        Mozi mozi = new Mozi();
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            checkedListBox1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            checkedListBox1.Visible = false;
        }
    }
}
