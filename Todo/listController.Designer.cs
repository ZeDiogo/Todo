namespace Todo
{
    partial class listController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.editBox1 = new System.Windows.Forms.TextBox();
            this.edit1 = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "To do list";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(66, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(944, 513);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // editBox1
            // 
            this.editBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBox1.Location = new System.Drawing.Point(66, 88);
            this.editBox1.Name = "editBox1";
            this.editBox1.Size = new System.Drawing.Size(944, 41);
            this.editBox1.TabIndex = 8;
            this.editBox1.Visible = false;
            this.editBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editBox1_KeyDown);
            // 
            // edit1
            // 
            this.edit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.edit1.FlatAppearance.BorderSize = 0;
            this.edit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit1.Image = global::Todo.Properties.Resources._290134_20;
            this.edit1.Location = new System.Drawing.Point(3, 130);
            this.edit1.Name = "edit1";
            this.edit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edit1.Size = new System.Drawing.Size(36, 36);
            this.edit1.TabIndex = 7;
            this.edit1.UseVisualStyleBackColor = true;
            this.edit1.Visible = false;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
            // 
            // delete1
            // 
            this.delete1.Cursor = System.Windows.Forms.Cursors.Default;
            this.delete1.FlatAppearance.BorderSize = 0;
            this.delete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete1.Image = global::Todo.Properties.Resources._4472999_24;
            this.delete1.Location = new System.Drawing.Point(3, 88);
            this.delete1.Name = "delete1";
            this.delete1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delete1.Size = new System.Drawing.Size(36, 36);
            this.delete1.TabIndex = 6;
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Visible = false;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // listController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editBox1);
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "listController";
            this.Size = new System.Drawing.Size(1080, 684);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.Button edit1;
        private System.Windows.Forms.TextBox editBox1;
    }
}
