
namespace LibraryProject
{
    partial class UyeEklePanel
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
            this.kabuletbutton = new System.Windows.Forms.Button();
            this.anasayfabutton = new System.Windows.Forms.Button();
            this.uyeklelabel = new System.Windows.Forms.Label();
            this.reddetbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idcolumn = new System.Windows.Forms.ColumnHeader();
            this.isimcolumn = new System.Windows.Forms.ColumnHeader();
            this.soyisimcolumn = new System.Windows.Forms.ColumnHeader();
            this.mailcolumn = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kabuletbutton
            // 
            this.kabuletbutton.BackColor = System.Drawing.Color.Chocolate;
            this.kabuletbutton.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.kabuletbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kabuletbutton.Location = new System.Drawing.Point(41, 325);
            this.kabuletbutton.Margin = new System.Windows.Forms.Padding(2);
            this.kabuletbutton.Name = "kabuletbutton";
            this.kabuletbutton.Size = new System.Drawing.Size(97, 31);
            this.kabuletbutton.TabIndex = 18;
            this.kabuletbutton.Text = "Kabul Et";
            this.kabuletbutton.UseVisualStyleBackColor = false;
            this.kabuletbutton.Click += new System.EventHandler(this.kabuletbutton_Click);
            // 
            // anasayfabutton
            // 
            this.anasayfabutton.BackColor = System.Drawing.Color.Peru;
            this.anasayfabutton.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.anasayfabutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.anasayfabutton.Location = new System.Drawing.Point(430, 325);
            this.anasayfabutton.Margin = new System.Windows.Forms.Padding(2);
            this.anasayfabutton.Name = "anasayfabutton";
            this.anasayfabutton.Size = new System.Drawing.Size(118, 31);
            this.anasayfabutton.TabIndex = 19;
            this.anasayfabutton.Text = "Anasayfaya Dön";
            this.anasayfabutton.UseVisualStyleBackColor = false;
            this.anasayfabutton.Click += new System.EventHandler(this.anasayfabutton_Click);
            // 
            // uyeklelabel
            // 
            this.uyeklelabel.AutoSize = true;
            this.uyeklelabel.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.uyeklelabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.uyeklelabel.Location = new System.Drawing.Point(113, 14);
            this.uyeklelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uyeklelabel.Name = "uyeklelabel";
            this.uyeklelabel.Size = new System.Drawing.Size(102, 20);
            this.uyeklelabel.TabIndex = 20;
            this.uyeklelabel.Text = "ÜYE KABUL";
            // 
            // reddetbutton
            // 
            this.reddetbutton.BackColor = System.Drawing.Color.DarkRed;
            this.reddetbutton.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.reddetbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reddetbutton.Location = new System.Drawing.Point(221, 325);
            this.reddetbutton.Margin = new System.Windows.Forms.Padding(2);
            this.reddetbutton.Name = "reddetbutton";
            this.reddetbutton.Size = new System.Drawing.Size(97, 31);
            this.reddetbutton.TabIndex = 21;
            this.reddetbutton.Text = "Reddet";
            this.reddetbutton.UseVisualStyleBackColor = false;
            this.reddetbutton.Click += new System.EventHandler(this.reddetbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryProject.Properties.Resources.gunclleme2;
            this.pictureBox1.Location = new System.Drawing.Point(344, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idcolumn,
            this.isimcolumn,
            this.soyisimcolumn,
            this.mailcolumn});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 72);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(325, 238);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idcolumn
            // 
            this.idcolumn.Text = "id";
            // 
            // isimcolumn
            // 
            this.isimcolumn.Text = "İsim";
            // 
            // soyisimcolumn
            // 
            this.soyisimcolumn.Text = "Soyisim";
            // 
            // mailcolumn
            // 
            this.mailcolumn.Text = "Mail Adresi";
            // 
            // UyeEklePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(566, 404);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reddetbutton);
            this.Controls.Add(this.uyeklelabel);
            this.Controls.Add(this.anasayfabutton);
            this.Controls.Add(this.kabuletbutton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UyeEklePanel";
            this.Text = "UyeEklePanel";
            this.Load += new System.EventHandler(this.UyeEklePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kabuletbutton;
        private System.Windows.Forms.Button anasayfabutton;
        private System.Windows.Forms.Label uyeklelabel;
        private System.Windows.Forms.Button reddetbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader isimcolumn;
        private System.Windows.Forms.ColumnHeader soyisimcolumn;
        private System.Windows.Forms.ColumnHeader mailcolumn;
        private System.Windows.Forms.ColumnHeader idcolumn;
    }
}