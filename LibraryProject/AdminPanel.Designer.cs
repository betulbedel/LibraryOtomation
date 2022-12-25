
namespace LibraryProject
{
    partial class AdminPanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.anasayfabutton = new System.Windows.Forms.Button();
            this.basarilitextBox = new System.Windows.Forms.TextBox();
            this.sayfainfo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.copytextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sayfatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yazartextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapismitextbox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.anasayfabutton);
            this.tabPage1.Controls.Add(this.basarilitextBox);
            this.tabPage1.Controls.Add(this.sayfainfo);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.copytextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.sayfatextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.yazartextBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.kitapismitextbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(558, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // anasayfabutton
            // 
            this.anasayfabutton.BackColor = System.Drawing.Color.Peru;
            this.anasayfabutton.Font = new System.Drawing.Font("Book Antiqua", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.anasayfabutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.anasayfabutton.Location = new System.Drawing.Point(217, 382);
            this.anasayfabutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.anasayfabutton.Name = "anasayfabutton";
            this.anasayfabutton.Size = new System.Drawing.Size(118, 28);
            this.anasayfabutton.TabIndex = 17;
            this.anasayfabutton.Text = "Anasayfaya Dön";
            this.anasayfabutton.UseVisualStyleBackColor = false;
            this.anasayfabutton.Click += new System.EventHandler(this.anasayfabutton_Click);
            // 
            // basarilitextBox
            // 
            this.basarilitextBox.BackColor = System.Drawing.Color.PaleGreen;
            this.basarilitextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.basarilitextBox.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.basarilitextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.basarilitextBox.Location = new System.Drawing.Point(106, 10);
            this.basarilitextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.basarilitextBox.Name = "basarilitextBox";
            this.basarilitextBox.Size = new System.Drawing.Size(275, 15);
            this.basarilitextBox.TabIndex = 16;
            this.basarilitextBox.Text = "Kitap Başarıyla Eklendi.";
            this.basarilitextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.basarilitextBox.Visible = false;
            // 
            // sayfainfo
            // 
            this.sayfainfo.AutoSize = true;
            this.sayfainfo.Location = new System.Drawing.Point(217, 267);
            this.sayfainfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sayfainfo.Name = "sayfainfo";
            this.sayfainfo.Size = new System.Drawing.Size(0, 17);
            this.sayfainfo.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 165);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 25);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 224);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(11, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adet";
            // 
            // copytextBox
            // 
            this.copytextBox.Location = new System.Drawing.Point(11, 340);
            this.copytextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.copytextBox.Name = "copytextBox";
            this.copytextBox.Size = new System.Drawing.Size(155, 22);
            this.copytextBox.TabIndex = 11;
            this.copytextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.copytextBox_PreviewKeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(11, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sayfa Sayısı";
            // 
            // sayfatextBox
            // 
            this.sayfatextBox.Location = new System.Drawing.Point(11, 283);
            this.sayfatextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sayfatextBox.Name = "sayfatextBox";
            this.sayfatextBox.Size = new System.Drawing.Size(155, 22);
            this.sayfatextBox.TabIndex = 9;
            this.sayfatextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.sayfatextBox_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(11, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Basım Yılı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yazarı";
            // 
            // yazartextBox
            // 
            this.yazartextBox.Location = new System.Drawing.Point(11, 109);
            this.yazartextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yazartextBox.Name = "yazartextBox";
            this.yazartextBox.Size = new System.Drawing.Size(155, 22);
            this.yazartextBox.TabIndex = 3;
            this.yazartextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.yazartextBox_PreviewKeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(35, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap İsmi";
            // 
            // kitapismitextbox
            // 
            this.kitapismitextbox.Location = new System.Drawing.Point(11, 52);
            this.kitapismitextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kitapismitextbox.Name = "kitapismitextbox";
            this.kitapismitextbox.Size = new System.Drawing.Size(155, 22);
            this.kitapismitextbox.TabIndex = 0;
            this.kitapismitextbox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.kitapismitextbox_PreviewKeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(558, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(394, 382);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "Liste Olarak Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(576, 470);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox copytextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sayfatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yazartextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kitapismitextbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label sayfainfo;
        private System.Windows.Forms.TextBox basarilitextBox;
        private System.Windows.Forms.Button anasayfabutton;
        private System.Windows.Forms.Button button2;
    }
}