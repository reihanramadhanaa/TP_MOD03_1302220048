﻿using System;
using System.Windows.Forms;

namespace tpmodul3_1302220048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string namaPraktikan = textBoxInput.Text;

            if (!string.IsNullOrWhiteSpace(namaPraktikan))
            {
                labelOutput.Text = "Halo " + namaPraktikan;
            }
            else
            {
                MessageBox.Show("Mohon isi nama praktikan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}