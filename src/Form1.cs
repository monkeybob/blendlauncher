using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace blendlauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            windowvar.Text = "-w";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            windowvar.Text = "-f";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            widthvar.Text = textBox5.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            heightvar.Text = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Process = new System.Diagnostics.Process();
            Process.StartInfo.FileName = "blenderplayer.exe";
            Process.StartInfo.Arguments = windowvar.Text + " " + widthvar.Text + " " + heightvar.Text + " " + fileToLoad.Text;
            Process.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("butts");
        }
    }
}
