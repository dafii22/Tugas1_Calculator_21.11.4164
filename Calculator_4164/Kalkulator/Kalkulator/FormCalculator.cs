﻿using System;
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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }
        private void proses(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil)
        {
            TampilanPerhitungan.Items.Add(
                String.Format($"Hasil {operasiLabel} dari {nilaiA} {operasi} {nilaiB} = ") +
                String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.prosesEvent += proses;
            calculator.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
