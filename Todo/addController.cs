using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Todo
{
    public partial class addController : Controller
    {
        public addController()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.submit();
        }

        public void restartController()
        {
            this.button2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.restartController();
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.submit();
                //MessageBox.Show("Pressed enter.");
            }   
        }

        private void submit()
        {
            string entry = textBox1.Text;
            if (entry.Trim() == "")
            {
                MessageBox.Show("Please write something");
                return;
            }
            Data.getInstance().addList(entry, Data.FILEPATH);

            //Empty input box
            this.textBox1.Text = "";
            //Show done symbol
            this.button2.Visible = true;
        }

        public override void resizeWindow()
        {
            //No especific elements to redraw
        }
    }
}
