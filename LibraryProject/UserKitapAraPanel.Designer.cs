
namespace LibraryProject
{
    partial class UserKitapAraPanel
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.idColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.isimColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.YazarColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.turcolumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.basimyilicolumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.sayfasayisicolumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.kopyasayisicolumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.listelebutton = new System.Windows.Forms.Button();
            this.yazaraditextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kitapaditextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Tan;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnHeader,
            this.isimColumnHeader,
            this.YazarColumnHeader,
            this.turcolumnHeader1,
            this.basimyilicolumnHeader1,
            this.sayfasayisicolumnHeader1,
            this.kopyasayisicolumnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-3, 139);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(542, 331);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idColumnHeader
            // 
            this.idColumnHeader.Text = "id";
            this.idColumnHeader.Width = 25;
            // 
            // isimColumnHeader
            // 
            this.isimColumnHeader.Text = "İsim";
            this.isimColumnHeader.Width = 120;
            // 
            // YazarColumnHeader
            // 
            this.YazarColumnHeader.Text = "Yazar";
            this.YazarColumnHeader.Width = 100;
            // 
            // turcolumnHeader1
            // 
            this.turcolumnHeader1.Text = "Tür";
            // 
            // basimyilicolumnHeader1
            // 
            this.basimyilicolumnHeader1.Text = "Basım Yılı";
            this.basimyilicolumnHeader1.Width = 75;
            // 
            // sayfasayisicolumnHeader1
            // 
            this.sayfasayisicolumnHeader1.Text = "Sayfa Sayısı";
            this.sayfasayisicolumnHeader1.Width = 75;
            // 
            // kopyasayisicolumnHeader1
            // 
            this.kopyasayisicolumnHeader1.Text = "Kopya Sayısı";
            this.kopyasayisicolumnHeader1.Width = 75;
            // 
            // listelebutton
            // 
            this.listelebutton.BackColor = System.Drawing.Color.Chocolate;
            this.listelebutton.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.listelebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listelebutton.Location = new System.Drawing.Point(268, 62);
            this.listelebutton.Margin = new System.Windows.Forms.Padding(2);
            this.listelebutton.Name = "listelebutton";
            this.listelebutton.Size = new System.Drawing.Size(96, 29);
            this.listelebutton.TabIndex = 13;
            this.listelebutton.Text = "LİSTELE";
            this.listelebutton.UseVisualStyleBackColor = false;
            this.listelebutton.Click += new System.EventHandler(this.listelebutton_Click);
            // 
            // yazaraditextBox
            // 
            this.yazaraditextBox.Location = new System.Drawing.Point(136, 84);
            this.yazaraditextBox.Margin = new System.Windows.Forms.Padding(2);
            this.yazaraditextBox.Name = "yazaraditextBox";
            this.yazaraditextBox.Size = new System.Drawing.Size(106, 23);
            this.yazaraditextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(38, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Yazar:";
            // 
            // kitapaditextBox
            // 
            this.kitapaditextBox.Location = new System.Drawing.Point(136, 48);
            this.kitapaditextBox.Margin = new System.Windows.Forms.Padding(2);
            this.kitapaditextBox.Name = "kitapaditextBox";
            this.kitapaditextBox.Size = new System.Drawing.Size(106, 23);
            this.kitapaditextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kitap adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(210, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "KİTAP LİSTELEME";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(398, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "ANASAYFAYA DÖN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserKitapAraPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(544, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listelebutton);
            this.Controls.Add(this.yazaraditextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kitapaditextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserKitapAraPanel";
            this.Text = "UserKitapAraPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idColumnHeader;
        private System.Windows.Forms.ColumnHeader isimColumnHeader;
        private System.Windows.Forms.ColumnHeader YazarColumnHeader;
        private System.Windows.Forms.ColumnHeader turcolumnHeader1;
        private System.Windows.Forms.ColumnHeader basimyilicolumnHeader1;
        private System.Windows.Forms.ColumnHeader sayfasayisicolumnHeader1;
        private System.Windows.Forms.ColumnHeader kopyasayisicolumnHeader1;
        private System.Windows.Forms.Button listelebutton;
        private System.Windows.Forms.TextBox yazaraditextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kitapaditextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}