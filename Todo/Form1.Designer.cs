using System;

namespace Todo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.slider = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maximizeButton2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.listController1 = new Todo.listController();
            this.aboutController1 = new Todo.aboutController(this);
            this.addController1 = new Todo.addController();
            this.secureController1 = new Todo.secureController();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.slider);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 720);
            this.panel1.TabIndex = 0;
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.SystemColors.Highlight;
            this.slider.Location = new System.Drawing.Point(0, 65);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(12, 64);
            this.slider.TabIndex = 2;
            this.slider.Paint += new System.Windows.Forms.PaintEventHandler(this.slider_Paint);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.maximizeButton2);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.maximizeButton);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 36);
            this.panel2.TabIndex = 1;
            // 
            // maximizeButton2
            // 
            this.maximizeButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.maximizeButton2.FlatAppearance.BorderSize = 0;
            this.maximizeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximizeButton2.Image = global::Todo.Properties.Resources._392519_16_1_;
            this.maximizeButton2.Location = new System.Drawing.Point(994, 0);
            this.maximizeButton2.Name = "maximizeButton2";
            this.maximizeButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maximizeButton2.Size = new System.Drawing.Size(46, 36);
            this.maximizeButton2.TabIndex = 5;
            this.maximizeButton2.UseVisualStyleBackColor = true;
            this.maximizeButton2.Click += new System.EventHandler(this.maximizeButton2_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = global::Todo.Properties.Resources._392510_24;
            this.button5.Location = new System.Drawing.Point(948, 0);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(46, 36);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.maximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximizeButton.Image = global::Todo.Properties.Resources._392519_16;
            this.maximizeButton.Location = new System.Drawing.Point(994, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maximizeButton.Size = new System.Drawing.Size(46, 36);
            this.maximizeButton.TabIndex = 3;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximize_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Image = global::Todo.Properties.Resources._392517_16;
            this.exit.Location = new System.Drawing.Point(1040, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(40, 36);
            this.exit.TabIndex = 2;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // listController1
            // 
            this.listController1.Location = new System.Drawing.Point(200, 36);
            this.listController1.Name = "listController1";
            this.listController1.Size = new System.Drawing.Size(1080, 684);
            this.listController1.TabIndex = 7;
            // 
            // aboutController1
            // 
            this.aboutController1.Location = new System.Drawing.Point(200, 36);
            this.aboutController1.Name = "aboutController1";
            this.aboutController1.Size = new System.Drawing.Size(1080, 684);
            this.aboutController1.TabIndex = 6;
            // 
            // addController1
            // 
            this.addController1.Location = new System.Drawing.Point(200, 36);
            this.addController1.Name = "addController1";
            this.addController1.Size = new System.Drawing.Size(1080, 684);
            this.addController1.TabIndex = 4;
            this.addController1.Load += new System.EventHandler(this.addController1_Load);
            // 
            // secureController1
            // 
            this.secureController1.Location = new System.Drawing.Point(200, 36);
            this.secureController1.Name = "secureController1";
            this.secureController1.Size = new System.Drawing.Size(1080, 684);
            this.secureController1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listController1);
            this.Controls.Add(this.aboutController1);
            this.Controls.Add(this.addController1);
            this.Controls.Add(this.secureController1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotKeys);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel slider;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button button5;
        private aboutController aboutController1;
        private addController addController1;
        private listController listController1;
        private System.Windows.Forms.Button maximizeButton2;
        private secureController secureController1;
    }
}

