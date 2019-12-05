using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Todo
{
    public partial class listController : Controller
    {
        public listController()
        {
            InitializeComponent();
            this.update();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void update()
        {
            delete1.Visible = false;
            edit1.Visible = false;

            listBox1.BeginUpdate();
            listBox1.Items.Clear();

            List<string> list = Data.getInstance().getList(Data.FILEPATH);
            foreach (var line in list)
            {
                Console.WriteLine(line);
                listBox1.Items.Add(line);
            }
                      
            listBox1.EndUpdate();
        }

        public void updateFile()
        {
            List<string> list = new List<string>();
            foreach (var line in listBox1.Items)
            {
                //Console.WriteLine(line.ToString());
                list.Add(line.ToString());
            }
            Data.getInstance().setList(list, Data.FILEPATH);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.showEditOptions();
        }

        private void showEditOptions()
        {
            if (this.listBox1.SelectedIndex != -1)
            {
                this.delete1.Visible = true;
                this.edit1.Visible = true;
            }
        }

        private void hideEditOptions()
        {
            this.delete1.Visible = false;
            this.edit1.Visible = false;
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index >= 0) {
                if (this.ask2Confirm(index))
                {
                    Data.getInstance().rmList(index, Data.FILEPATH);
                }
            } 
            else
            {
                //TODO: add "No item selected" message
            }
            this.update();
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            this.enterEditMode();
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void disableButtons()
        {
            foreach (var resource in GetAll(this.Parent, typeof(Button)))
            {
                resource.Enabled = false;
            }
        }

        private void enableButtons()
        {
            foreach (var resource in GetAll(this.Parent, typeof(Button)))
            {
                resource.Enabled = true;
            }
        }

        private void editBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var index = listBox1.SelectedIndex;
                listBox1.BeginUpdate();
                listBox1.Items.RemoveAt(index);
                var text = editBox1.Text.ToString();
                this.listBox1.Items.Insert(index, text);
                listBox1.EndUpdate();
                this.updateFile();
                editBox1.Visible = false;
                this.enableButtons();
            }
        }

        public override void resizeWindow()
        {
            var width = this.Size.Width;
            var height = this.Size.Height;
            var newWidth = this.Size.Width - 2 * this.listBox1.Location.X;
            var newHeight = this.Size.Height - this.listBox1.Location.Y - this.listBox1.Location.X;
            this.listBox1.Size = new Size(newWidth, newHeight);
        }

        private void enterEditMode()
        {
            if (listBox1.SelectedIndex != -1)
            {
                this.disableButtons();
                int itemHeight = 19; //guess
                var y = listBox1.SelectedIndex * itemHeight + listBox1.Location.Y;
                editBox1.Location = new Point(editBox1.Location.X, y);
                editBox1.Visible = true;
                var text = listBox1.SelectedItem;
                var index = listBox1.SelectedIndex;
                editBox1.Text = text.ToString();
                this.hideEditOptions();
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            this.enterEditMode();
        }

        private bool ask2Confirm(int index)
        {
            var task = this.listBox1.Items[index].ToString();
            var form = new Form2(task);
            var ret = form.ShowAndReturn();
            return ret;
        }
    }
}
