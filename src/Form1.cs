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
    public partial class uiMain : Form
    {
        public uiMain()
        {
            InitializeComponent();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            windowVar.Text = "-w";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            windowVar.Text = "-f";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            widthVar.Text = txtWidth.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            heightVar.Text = txtHeight.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Error handling code added*/

            if (System.IO.File.Exists("blenderplayer.exe")){
                if (System.IO.File.Exists(fileToLoad.Text))
                {
                    System.Diagnostics.Process Process = new System.Diagnostics.Process();
                    Process.StartInfo.FileName = "blenderplayer.exe";
                    Process.StartInfo.Arguments = windowVar.Text + " " + widthVar.Text + " " + heightVar.Text + " " + fileToLoad.Text;
                    Process.Start();
                }
                else
                {
                    MessageBox.Show(".blend file not found");
                }
            }
            else
            {
                MessageBox.Show("blenderplayer.exe does not exist in this directory");
            }
        }
    }
}
