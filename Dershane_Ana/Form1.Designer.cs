namespace Dershane_Ana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ogretmen_Kyt = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Ogrenci_Kyt = new System.Windows.Forms.Button();
            this.Ders_Kyt = new System.Windows.Forms.Button();
            this.Not_grs = new System.Windows.Forms.Button();
            this.Karne = new System.Windows.Forms.Button();
            this.Cıkıs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ogretmen_Kyt
            // 
            this.Ogretmen_Kyt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ogretmen_Kyt.ImageIndex = 6;
            this.Ogretmen_Kyt.ImageList = this.ımageList1;
            this.Ogretmen_Kyt.Location = new System.Drawing.Point(11, 19);
            this.Ogretmen_Kyt.Name = "Ogretmen_Kyt";
            this.Ogretmen_Kyt.Size = new System.Drawing.Size(101, 97);
            this.Ogretmen_Kyt.TabIndex = 0;
            this.Ogretmen_Kyt.Text = "Öğretmen Kayıt";
            this.Ogretmen_Kyt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ogretmen_Kyt.UseVisualStyleBackColor = true;
            this.Ogretmen_Kyt.Click += new System.EventHandler(this.Ogretmen_Kyt_Click_1);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "çıkış.ico");
            this.ımageList1.Images.SetKeyName(1, "ders kayıt.png");
            this.ımageList1.Images.SetKeyName(2, "ders.png");
            this.ımageList1.Images.SetKeyName(3, "etüt kayıt.png");
            this.ımageList1.Images.SetKeyName(4, "karne.jpg");
            this.ımageList1.Images.SetKeyName(5, "ÖĞrenci icon.png");
            this.ımageList1.Images.SetKeyName(6, "öğretmen icon.jpg");
            this.ımageList1.Images.SetKeyName(7, "dolu boş.png");
            // 
            // Ogrenci_Kyt
            // 
            this.Ogrenci_Kyt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ogrenci_Kyt.ImageIndex = 5;
            this.Ogrenci_Kyt.ImageList = this.ımageList1;
            this.Ogrenci_Kyt.Location = new System.Drawing.Point(118, 19);
            this.Ogrenci_Kyt.Name = "Ogrenci_Kyt";
            this.Ogrenci_Kyt.Size = new System.Drawing.Size(98, 97);
            this.Ogrenci_Kyt.TabIndex = 1;
            this.Ogrenci_Kyt.Text = "Öğrenci Kayıt";
            this.Ogrenci_Kyt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ogrenci_Kyt.UseVisualStyleBackColor = true;
            this.Ogrenci_Kyt.Click += new System.EventHandler(this.Ogrenci_Kyt_Click_1);
            // 
            // Ders_Kyt
            // 
            this.Ders_Kyt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ders_Kyt.ImageIndex = 2;
            this.Ders_Kyt.ImageList = this.ımageList1;
            this.Ders_Kyt.Location = new System.Drawing.Point(222, 19);
            this.Ders_Kyt.Name = "Ders_Kyt";
            this.Ders_Kyt.Size = new System.Drawing.Size(102, 97);
            this.Ders_Kyt.TabIndex = 2;
            this.Ders_Kyt.Text = "Ders Kayıt";
            this.Ders_Kyt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ders_Kyt.UseVisualStyleBackColor = true;
            this.Ders_Kyt.Click += new System.EventHandler(this.Ders_Kyt_Click_1);
            // 
            // Not_grs
            // 
            this.Not_grs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Not_grs.ImageIndex = 1;
            this.Not_grs.ImageList = this.ımageList1;
            this.Not_grs.Location = new System.Drawing.Point(330, 21);
            this.Not_grs.Name = "Not_grs";
            this.Not_grs.Size = new System.Drawing.Size(104, 93);
            this.Not_grs.TabIndex = 3;
            this.Not_grs.Text = "Not Giriş";
            this.Not_grs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Not_grs.UseVisualStyleBackColor = true;
            this.Not_grs.Click += new System.EventHandler(this.Not_grs_Click_1);
            // 
            // Karne
            // 
            this.Karne.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Karne.ImageIndex = 4;
            this.Karne.ImageList = this.ımageList1;
            this.Karne.Location = new System.Drawing.Point(440, 25);
            this.Karne.Name = "Karne";
            this.Karne.Size = new System.Drawing.Size(115, 93);
            this.Karne.TabIndex = 6;
            this.Karne.Text = "Genel Rapor";
            this.Karne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Karne.UseVisualStyleBackColor = true;
            this.Karne.Click += new System.EventHandler(this.Karne_Click_1);
            // 
            // Cıkıs
            // 
            this.Cıkıs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cıkıs.ImageIndex = 0;
            this.Cıkıs.ImageList = this.ımageList1;
            this.Cıkıs.Location = new System.Drawing.Point(561, 25);
            this.Cıkıs.Name = "Cıkıs";
            this.Cıkıs.Size = new System.Drawing.Size(110, 93);
            this.Cıkıs.TabIndex = 7;
            this.Cıkıs.Text = "Çıkış";
            this.Cıkıs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cıkıs.UseVisualStyleBackColor = true;
            this.Cıkıs.Click += new System.EventHandler(this.Cıkıs_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Ogretmen_Kyt);
            this.panel1.Controls.Add(this.Cıkıs);
            this.panel1.Controls.Add(this.Ogrenci_Kyt);
            this.panel1.Controls.Add(this.Karne);
            this.panel1.Controls.Add(this.Ders_Kyt);
            this.panel1.Controls.Add(this.Not_grs);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 119);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Dershane_Ana.Properties.Resources.indir;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 413);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ana_sayfa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Ogretmen_Kyt;
        private Button Ogrenci_Kyt;
        private Button Ders_Kyt;
        private Button Not_grs;
        private Button Karne;
        private Button Cıkıs;
        private Panel panel1;
        private ImageList ımageList1;
    }
}