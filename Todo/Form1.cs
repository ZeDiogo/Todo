using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;

namespace Todo
{
    public partial class Form1 : Form
    {
        private delegate void MenuClick(object sender, EventArgs e);
        private Hands<MenuClick> menuHistory;
        public Form1()
        {
            InitializeComponent();
            //bindKeys();
            this.maximizeButton2.SendToBack();
            this.slider.Location = new Point(this.slider.Location.X, this.button1.Location.Y);
            listController1.BringToFront();
            this.KeyPreview = true;
            this.menuHistory = new Hands<MenuClick>(new MenuClick(button1_Click), new MenuClick(button1_Click));
        }

        //private void bindKeys() 
        //{
        //    Boolean success = Form1.RegisterHotKey(this.Handle, this.GetType().GetHashCode(), (int)Keys.Control, (int)Keys.Tab);//Set hotkey as 'b'
        //    if (success == true)
        //    {
        //        MessageBox.Show("Success");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error");
        //    }
        //}

        //[DllImport("user32.dll")]
        //public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        //[DllImport("user32.dll")]
        //public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x0312)
        //    {
        //        MessageBox.Show("Catched");//You can replace this statement with your desired response to the Hotkey.
        //    }
        //    base.WndProc(ref m);
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            this.slider.Location = new Point(this.slider.Location.X, this.button3.Location.Y);
            aboutController1.BringToFront();
            this.menuHistory.pushIfNotCurrent(button3_Click);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.slider.Location = new Point(this.slider.Location.X, this.button2.Location.Y);
            addController1.BringToFront();
            addController1.restartController();
            this.menuHistory.pushIfNotCurrent(button2_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.slider.Location = new Point(this.slider.Location.X, this.button1.Location.Y);
            this.listController1.update();
            listController1.BringToFront();
            this.menuHistory.pushIfNotCurrent(button1_Click);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void resizeControllers()
        {
            var controllers = new Controller[] { listController1, addController1, aboutController1 };
            foreach (var controller in controllers)
            {
                var newWidth = this.Size.Width - controller.Location.X;
                var newHeight = this.Size.Height - controller.Location.Y;
                controller.Size = new Size(newWidth, newHeight);
                controller.resizeWindow();
            }
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

                this.maximizeButton2.BringToFront();
                this.maximizeButton2.Location = new Point(this.maximizeButton.Location.X, this.maximizeButton.Location.Y);
                this.resizeControllers();
            }
        }

        //Copy Paste grab window
        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;

        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //public static extern bool ReleaseCapture();

        //private void Form1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}

        private void listController1_Load(object sender, EventArgs e)
        {

        }

        private void addController1_Load(object sender, EventArgs e)
        {

        }

        private void slider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maximizeButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.maximizeButton2.SendToBack();
                this.resizeControllers();
            }
        }

        private void secureClick(object sender, EventArgs e)
        {

        }

        private void switchToPreviousTab (object sender, System.Windows.Forms.KeyEventArgs e)
        {
            this.menuHistory.swap();
            var menuClick = this.menuHistory.getCurrent();
            menuClick(sender, e); //Not sure what is inside sender/e
        }

        private void hotKeys(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //MessageBox.Show("key detected: " + e.Control);
            if (e.Control && e.KeyCode == Keys.Tab) {
                //e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
                this.switchToPreviousTab(sender, e);
            }
        }

        public void switchToSecureList(string password)
        {
            this.secureController1.setPassword(password);
            this.secureController1.update();
            this.secureController1.BringToFront();
        }
    }
}
