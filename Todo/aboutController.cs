using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Todo
{
    public partial class aboutController : Controller
    {
        Form1 parent = null;
        public aboutController()
        {
            InitializeComponent();
            //Data.getInstance().EncryptFile(Data.FILEPATH, Data.FILEPATH + ".enc");

        }

        public aboutController(Form1 parent) : this()
        {
            this.parent = parent;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public override void resizeWindow()
        {
            //No especific elements to redraw
        }

        private void secureDoubleClick(object sender, MouseEventArgs e)
        {
            this.secureUnlock(false);
        }

        private void secureUnlock(bool error)
        {
            try
            {
                var encryptedFile = Data.FILEPATH + ".enc";
                //var decryptedFile = Data.FILEPATH + ".dec";
                var data = Data.getInstance();
                string label, password;
                if (!File.Exists(encryptedFile))
                {
                    label = "New Secure List";
                    password = ask4password(label, error);
                    if (password == null) { return; }
                    //data.newFile(decryptedFile);
                    Console.WriteLine("PASS: " + password);
                    data.EncryptAndSerialize(new List<String>(), encryptedFile, password);
                } else
                {
                    label = "Secure List";
                    password = ask4password(label, error);
                    if (password == null) { return; }
                }
                
                //data.DecryptFile(encryptedFile, decryptedFile, password);
                //List<string> list = data.getList(decryptedFile);

                //foreach (var el in list)
                //{
                //    Console.WriteLine("LIST: " + el);
                //}
                this.parent.switchToSecureList(password);

                //File.Delete(Data.filePath+".enc");  //Only delete file when updating

            }
            catch
            {
                this.secureUnlock(true);
            }
        }

        public string ask4password(string label, bool error)
        {
            var form = new Form3(label, error);
            var password = form.ShowAndReturn();
            return password;
        }
    }
}
