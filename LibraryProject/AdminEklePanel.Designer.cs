﻿
namespace LibraryProject
{
    partial class AdminEklePanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.isimtextBox = new System.Windows.Forms.TextBox();
            this.soyisimtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.adminbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // isimtextBox
            // 
            this.isimtextBox.Location = new System.Drawing.Point(193, 74);
            this.isimtextBox.Name = "isimtextBox";
            this.isimtextBox.Size = new System.Drawing.Size(150, 31);
            this.isimtextBox.TabIndex = 1;
            // 
            // soyisimtextBox
            // 
            this.soyisimtextBox.Location = new System.Drawing.Point(193, 136);
            this.soyisimtextBox.Name = "soyisimtextBox";
            this.soyisimtextBox.Size = new System.Drawing.Size(150, 31);
            this.soyisimtextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(-2, 249);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(492, 479);
            this.listBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminbutton
            // 
            this.adminbutton.Location = new System.Drawing.Point(566, 377);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(210, 104);
            this.adminbutton.TabIndex = 6;
            this.adminbutton.Text = "Admin Olarak Değiştir";
            this.adminbutton.UseVisualStyleBackColor = true;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // AdminEklePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(957, 736);
            this.Controls.Add(this.adminbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.soyisimtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isimtextBox);
            this.Controls.Add(this.label1);
            this.Name = "AdminEklePanel";
            this.Text = "AdminEklePanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isimtextBox;
        private System.Windows.Forms.TextBox soyisimtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button adminbutton;
    }
}