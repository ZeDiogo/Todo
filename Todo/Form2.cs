using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Todo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string task)
        {
            InitializeComponent();
            this.label3.Text = task;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void No(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void Yes(object sender, EventArgs e)
        {
            //if (this.checkBox1.Checked)
            //{
            //    ENABLED = false;
            //}
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        public bool ShowAndReturn ()
        {
            try
            {
                var result = this.ShowDialog();
                //MessageBox.Show("MESSAGE: " + result);
                if (result == DialogResult.Yes)
                {
                    return true;
                }
                else if (result == DialogResult.No)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            } finally
            {
                this.Dispose();
            }
        }

    }
}
