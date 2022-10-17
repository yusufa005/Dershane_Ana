namespace Dershane_Ana
{
    partial class Not_giris
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
            this.Not_giriş = new System.Windows.Forms.Label();
            this.Ders_not_adı = new System.Windows.Forms.Label();
            this.comNot_ders = new System.Windows.Forms.ComboBox();
            this.Ders_not_bölüm = new System.Windows.Forms.Label();
            this.com_not_branş = new System.Windows.Forms.ComboBox();
            this.sınav1 = new System.Windows.Forms.Label();
            this.sınav2 = new System.Windows.Forms.Label();
            this.txt_sınav1 = new System.Windows.Forms.TextBox();
            this.txt_sınav2 = new System.Windows.Forms.TextBox();
            this.Ortalama = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.Ders_ögretmen = new System.Windows.Forms.Label();
            this.com_not_ogr = new System.Windows.Forms.ComboBox();
            this.Not_ekle = new System.Windows.Forms.Button();
            this.Not_Sil = new System.Windows.Forms.Button();
            this.Ogrenci_ad_not = new System.Windows.Forms.Label();
            this.Ogrenci_no_not = new System.Windows.Forms.Label();
            this.txtOgrenci_ad_not = new System.Windows.Forms.TextBox();
            this.Not_degistir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comOgrenci_no_not = new System.Windows.Forms.ComboBox();
            this.btn_ort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Not_giriş
            // 
            this.Not_giriş.AutoSize = true;
            this.Not_giriş.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Not_giriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Not_giriş.Location = new System.Drawing.Point(209, 3);
            this.Not_giriş.Name = "Not_giriş";
            this.Not_giriş.Size = new System.Drawing.Size(383, 76);
            this.Not_giriş.TabIndex = 7;
            this.Not_giriş.Text = "NOT GİRİŞ";
            this.Not_giriş.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ders_not_adı
            // 
            this.Ders_not_adı.AutoSize = true;
            this.Ders_not_adı.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ders_not_adı.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ders_not_adı.Location = new System.Drawing.Point(111, 185);
            this.Ders_not_adı.Name = "Ders_not_adı";
            this.Ders_not_adı.Size = new System.Drawing.Size(78, 23);
            this.Ders_not_adı.TabIndex = 8;
            this.Ders_not_adı.Text = "Ders Adı:";
            // 
            // comNot_ders
            // 
            this.comNot_ders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comNot_ders.FormattingEnabled = true;
            this.comNot_ders.Items.AddRange(new object[] {
            "Matematik",
            "Türkçe",
            "Kİmya",
            "Coğrafya"});
            this.comNot_ders.Location = new System.Drawing.Point(199, 176);
            this.comNot_ders.Name = "comNot_ders";
            this.comNot_ders.Size = new System.Drawing.Size(151, 36);
            this.comNot_ders.TabIndex = 9;
            // 
            // Ders_not_bölüm
            // 
            this.Ders_not_bölüm.AutoSize = true;
            this.Ders_not_bölüm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ders_not_bölüm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ders_not_bölüm.Location = new System.Drawing.Point(77, 229);
            this.Ders_not_bölüm.Name = "Ders_not_bölüm";
            this.Ders_not_bölüm.Size = new System.Drawing.Size(112, 23);
            this.Ders_not_bölüm.TabIndex = 10;
            this.Ders_not_bölüm.Text = "Ders Bölümü:";
            // 
            // com_not_branş
            // 
            this.com_not_branş.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.com_not_branş.FormattingEnabled = true;
            this.com_not_branş.Items.AddRange(new object[] {
            "Sayısal",
            "Sözel"});
            this.com_not_branş.Location = new System.Drawing.Point(199, 227);
            this.com_not_branş.Name = "com_not_branş";
            this.com_not_branş.Size = new System.Drawing.Size(151, 36);
            this.com_not_branş.TabIndex = 11;
            // 
            // sınav1
            // 
            this.sınav1.AutoSize = true;
            this.sınav1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sınav1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sınav1.Location = new System.Drawing.Point(382, 105);
            this.sınav1.Name = "sınav1";
            this.sınav1.Size = new System.Drawing.Size(111, 23);
            this.sınav1.TabIndex = 12;
            this.sınav1.Text = "1.Sınav Notu:";
            // 
            // sınav2
            // 
            this.sınav2.AutoSize = true;
            this.sınav2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sınav2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sınav2.Location = new System.Drawing.Point(382, 149);
            this.sınav2.Name = "sınav2";
            this.sınav2.Size = new System.Drawing.Size(111, 23);
            this.sınav2.TabIndex = 13;
            this.sınav2.Text = "2.Sınav Notu:";
            // 
            // txt_sınav1
            // 
            this.txt_sınav1.Location = new System.Drawing.Point(499, 104);
            this.txt_sınav1.Multiline = true;
            this.txt_sınav1.Name = "txt_sınav1";
            this.txt_sınav1.Size = new System.Drawing.Size(73, 31);
            this.txt_sınav1.TabIndex = 15;
            // 
            // txt_sınav2
            // 
            this.txt_sınav2.Location = new System.Drawing.Point(499, 141);
            this.txt_sınav2.Multiline = true;
            this.txt_sınav2.Name = "txt_sınav2";
            this.txt_sınav2.Size = new System.Drawing.Size(73, 31);
            this.txt_sınav2.TabIndex = 16;
            // 
            // Ortalama
            // 
            this.Ortalama.AutoSize = true;
            this.Ortalama.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ortalama.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ortalama.Location = new System.Drawing.Point(382, 188);
            this.Ortalama.Name = "Ortalama";
            this.Ortalama.Size = new System.Drawing.Size(85, 23);
            this.Ortalama.TabIndex = 17;
            this.Ortalama.Text = "Ortalama:";
            this.Ortalama.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(463, 183);
            this.txtOrtalama.Multiline = true;
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(109, 32);
            this.txtOrtalama.TabIndex = 18;
            // 
            // Ders_ögretmen
            // 
            this.Ders_ögretmen.AutoSize = true;
            this.Ders_ögretmen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ders_ögretmen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ders_ögretmen.Location = new System.Drawing.Point(54, 275);
            this.Ders_ögretmen.Name = "Ders_ögretmen";
            this.Ders_ögretmen.Size = new System.Drawing.Size(135, 23);
            this.Ders_ögretmen.TabIndex = 19;
            this.Ders_ögretmen.Text = "Ders Öğretmeni:";
            // 
            // com_not_ogr
            // 
            this.com_not_ogr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.com_not_ogr.FormattingEnabled = true;
            this.com_not_ogr.Items.AddRange(new object[] {
            "S.Serkan Tan - Matematik",
            "Fatma Yivli Türkçe",
            "Tülay Koç - Kimya",
            "Müzeyyen Yağcı - Coğrafya"});
            this.com_not_ogr.Location = new System.Drawing.Point(199, 268);
            this.com_not_ogr.Name = "com_not_ogr";
            this.com_not_ogr.Size = new System.Drawing.Size(174, 36);
            this.com_not_ogr.TabIndex = 20;
            // 
            // Not_ekle
            // 
            this.Not_ekle.Location = new System.Drawing.Point(642, 63);
            this.Not_ekle.Name = "Not_ekle";
            this.Not_ekle.Size = new System.Drawing.Size(101, 51);
            this.Not_ekle.TabIndex = 21;
            this.Not_ekle.Text = "Not Ekle";
            this.Not_ekle.UseVisualStyleBackColor = true;
            this.Not_ekle.Click += new System.EventHandler(this.Not_ekle_Click);
            // 
            // Not_Sil
            // 
            this.Not_Sil.Location = new System.Drawing.Point(642, 119);
            this.Not_Sil.Name = "Not_Sil";
            this.Not_Sil.Size = new System.Drawing.Size(101, 51);
            this.Not_Sil.TabIndex = 22;
            this.Not_Sil.Text = "Not Sil";
            this.Not_Sil.UseVisualStyleBackColor = true;
            this.Not_Sil.Click += new System.EventHandler(this.Not_Sil_Click);
            // 
            // Ogrenci_ad_not
            // 
            this.Ogrenci_ad_not.AutoSize = true;
            this.Ogrenci_ad_not.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ogrenci_ad_not.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ogrenci_ad_not.Location = new System.Drawing.Point(32, 140);
            this.Ogrenci_ad_not.Name = "Ogrenci_ad_not";
            this.Ogrenci_ad_not.Size = new System.Drawing.Size(161, 23);
            this.Ogrenci_ad_not.TabIndex = 23;
            this.Ogrenci_ad_not.Text = "Öğrenci Adı/Soyadı:";
            // 
            // Ogrenci_no_not
            // 
            this.Ogrenci_no_not.AutoSize = true;
            this.Ogrenci_no_not.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ogrenci_no_not.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ogrenci_no_not.Location = new System.Drawing.Point(86, 107);
            this.Ogrenci_no_not.Name = "Ogrenci_no_not";
            this.Ogrenci_no_not.Size = new System.Drawing.Size(102, 23);
            this.Ogrenci_no_not.TabIndex = 24;
            this.Ogrenci_no_not.Text = "Öğrenci No:";
            // 
            // txtOgrenci_ad_not
            // 
            this.txtOgrenci_ad_not.Location = new System.Drawing.Point(199, 139);
            this.txtOgrenci_ad_not.Multiline = true;
            this.txtOgrenci_ad_not.Name = "txtOgrenci_ad_not";
            this.txtOgrenci_ad_not.Size = new System.Drawing.Size(151, 31);
            this.txtOgrenci_ad_not.TabIndex = 27;
            // 
            // Not_degistir
            // 
            this.Not_degistir.Location = new System.Drawing.Point(642, 175);
            this.Not_degistir.Name = "Not_degistir";
            this.Not_degistir.Size = new System.Drawing.Size(101, 51);
            this.Not_degistir.TabIndex = 29;
            this.Not_degistir.Text = "Not Değiştir";
            this.Not_degistir.UseVisualStyleBackColor = true;
            this.Not_degistir.Click += new System.EventHandler(this.Not_degistir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 164);
            this.dataGridView1.TabIndex = 31;
            // 
            // comOgrenci_no_not
            // 
            this.comOgrenci_no_not.FormattingEnabled = true;
            this.comOgrenci_no_not.Location = new System.Drawing.Point(199, 101);
            this.comOgrenci_no_not.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comOgrenci_no_not.Name = "comOgrenci_no_not";
            this.comOgrenci_no_not.Size = new System.Drawing.Size(138, 28);
            this.comOgrenci_no_not.TabIndex = 33;
            this.comOgrenci_no_not.SelectedIndexChanged += new System.EventHandler(this.comOgrenci_no_not_SelectedIndexChanged_1);
            // 
            // btn_ort
            // 
            this.btn_ort.Location = new System.Drawing.Point(642, 232);
            this.btn_ort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ort.Name = "btn_ort";
            this.btn_ort.Size = new System.Drawing.Size(101, 51);
            this.btn_ort.TabIndex = 34;
            this.btn_ort.Text = "Ortalama Hesaplama";
            this.btn_ort.UseVisualStyleBackColor = true;
            this.btn_ort.Click += new System.EventHandler(this.btn_ort_Click);
            // 
            // Not_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Dershane_Ana.Properties.Resources.nott_giriş_arka_plan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.btn_ort);
            this.Controls.Add(this.comOgrenci_no_not);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Not_degistir);
            this.Controls.Add(this.txtOgrenci_ad_not);
            this.Controls.Add(this.Ogrenci_no_not);
            this.Controls.Add(this.Ogrenci_ad_not);
            this.Controls.Add(this.Not_Sil);
            this.Controls.Add(this.Not_ekle);
            this.Controls.Add(this.com_not_ogr);
            this.Controls.Add(this.Ders_ögretmen);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.Ortalama);
            this.Controls.Add(this.txt_sınav2);
            this.Controls.Add(this.txt_sınav1);
            this.Controls.Add(this.sınav2);
            this.Controls.Add(this.sınav1);
            this.Controls.Add(this.com_not_branş);
            this.Controls.Add(this.Ders_not_bölüm);
            this.Controls.Add(this.comNot_ders);
            this.Controls.Add(this.Ders_not_adı);
            this.Controls.Add(this.Not_giriş);
            this.Name = "Not_giris";
            this.Text = "Not_giris";
            this.Load += new System.EventHandler(this.Not_giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Not_giriş;
        private Label Ders_not_adı;
        private ComboBox comNot_ders;
        private Label Ders_not_bölüm;
        private ComboBox com_not_branş;
        private Label sınav1;
        private Label sınav2;
        private TextBox txt_sınav1;
        private TextBox txt_sınav2;
        private Label Ortalama;
        private TextBox txtOrtalama;
        private Label Ders_ögretmen;
        private ComboBox com_not_ogr;
        private Button Not_ekle;
        private Button Not_Sil;
        private Label Ogrenci_ad_not;
        private Label Ogrenci_no_not;
        private TextBox txtOgrenci_ad_not;
        private Button Not_degistir;
        private DataGridView dataGridView1;
        private ComboBox comOgrenci_no_not;
        private Button btn_ort;
    }
}