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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.passwordLabel.Location = new Point(this.passwordInput.Location.X, this.passwordLabel.Location.Y);
            this.ActiveControl = this.passwordInput;
        }

        public Form3(string label, bool error) : this()
        {
            if(error) this.errorLabel.Visible = true;
            centerLabelToForm(this.taskName, label);
            centerInputToForm(this.passwordInput);
        }

        private void centerInputToForm(Control component)
        {
            var formCenterX = this.Size.Width / 2;
            var newX = formCenterX - (component.Size.Width / 2);
            component.Location = new Point(newX, component.Location.Y);
        }

        private void centerLabelToForm (Control component, String label)
        {
            int length = component.Text.Length;
            if (length == 0) { length = 1; } //Erase  divisions by zero
            var widthPerLetter = component.Size.Width / length;
            if (label != null) { component.Text = label; }
            var componentWidth = widthPerLetter * component.Text.Length;
            var formCenterX = this.Size.Width / 2;
            var newX = formCenterX - (componentWidth / 2);
            component.Location = new Point(newX, component.Location.Y);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.errorLabel.Visible = false;
        }

        public string ShowAndReturn()
        {
            try
            {   
                var result = this.ShowDialog();
                //MessageBox.Show("MESSAGE: " + result);
                if (result == DialogResult.OK)
                {
                    return this.passwordInput.Text;
                }
                else if (result == DialogResult.Cancel)
                {
                    return null;
                }
                else
                {
                    return  null;
                }
            }
            finally
            {
                this.Dispose();
            }
        }

        private void OK(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.OK(sender, e);
            }
        }
    }
}
