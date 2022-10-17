namespace Dershane_Ana
{
    partial class Ögrenci_kayıt
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
            this.txtOgrenci_ad = new System.Windows.Forms.TextBox();
            this.txtOgrenci_no = new System.Windows.Forms.TextBox();
            this.Ogrenci_no_ekle = new System.Windows.Forms.Label();
            this.Ogrenci_ad_ekle = new System.Windows.Forms.Label();
            this.Ogrenci_bölüm = new System.Windows.Forms.Label();
            this.com_Ogrenci_branş = new System.Windows.Forms.ComboBox();
            this.Ogrenci_ekle = new System.Windows.Forms.Button();
            this.Ogrenci_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 25.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "ÖĞRENCİ EKLEME...";
            // 
            // txtOgrenci_ad
            // 
            this.txtOgrenci_ad.Location = new System.Drawing.Point(204, 78);
            this.txtOgrenci_ad.Multiline = true;
            this.txtOgrenci_ad.Name = "txtOgrenci_ad";
            this.txtOgrenci_ad.Size = new System.Drawing.Size(151, 31);
            this.txtOgrenci_ad.TabIndex = 32;
            // 
            // txtOgrenci_no
            // 
            this.txtOgrenci_no.Location = new System.Drawing.Point(204, 113);
            this.txtOgrenci_no.Multiline = true;
            this.txtOgrenci_no.Name = "txtOgrenci_no";
            this.txtOgrenci_no.Size = new System.Drawing.Size(151, 31);
            this.txtOgrenci_no.TabIndex = 31;
            // 
            // Ogrenci_no_ekle
            // 
            this.Ogrenci_no_ekle.AutoSize = true;
            this.Ogrenci_no_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ogrenci_no_ekle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ogrenci_no_ekle.Location = new System.Drawing.Point(92, 121);
            this.Ogrenci_no_ekle.Name = "Ogrenci_no_ekle";
            this.Ogrenci_no_ekle.Size = new System.Drawing.Size(102, 23);
            this.Ogrenci_no_ekle.TabIndex = 30;
            this.Ogrenci_no_ekle.Text = "Öğrenci No:";
            // 
            // Ogrenci_ad_ekle
            // 
            this.Ogrenci_ad_ekle.AutoSize = true;
            this.Ogrenci_ad_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ogrenci_ad_ekle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ogrenci_ad_ekle.Location = new System.Drawing.Point(33, 79);
            this.Ogrenci_ad_ekle.Name = "Ogrenci_ad_ekle";
            this.Ogrenci_ad_ekle.Size = new System.Drawing.Size(161, 23);
            this.Ogrenci_ad_ekle.TabIndex = 29;
            this.Ogrenci_ad_ekle.Text = "Öğrenci Adı/Soyadı:";
            // 
            // Ogrenci_bölüm
            // 
            this.Ogrenci_bölüm.AutoSize = true;
            this.Ogrenci_bölüm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ogrenci_bölüm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ogrenci_bölüm.Location = new System.Drawing.Point(60, 162);
            this.Ogrenci_bölüm.Name = "Ogrenci_bölüm";
            this.Ogrenci_bölüm.Size = new System.Drawing.Size(138, 23);
            this.Ogrenci_bölüm.TabIndex = 33;
            this.Ogrenci_bölüm.Text = "Öğrenci Bölümü:";
            // 
            // com_Ogrenci_branş
            // 
            this.com_Ogrenci_branş.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.com_Ogrenci_branş.FormattingEnabled = true;
            this.com_Ogrenci_branş.Items.AddRange(new object[] {
            "Sayısal",
            "Sözel"});
            this.com_Ogrenci_branş.Location = new System.Drawing.Point(204, 154);
            this.com_Ogrenci_branş.Name = "com_Ogrenci_branş";
            this.com_Ogrenci_branş.Size = new System.Drawing.Size(151, 36);
            this.com_Ogrenci_branş.TabIndex = 34;
            // 
            // Ogrenci_ekle
            // 
            this.Ogrenci_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ogrenci_ekle.Location = new System.Drawing.Point(82, 210);
            this.Ogrenci_ekle.Name = "Ogrenci_ekle";
            this.Ogrenci_ekle.Size = new System.Drawing.Size(112, 37);
            this.Ogrenci_ekle.TabIndex = 35;
            this.Ogrenci_ekle.Text = "Öğrenci Ekle";
            this.Ogrenci_ekle.UseVisualStyleBackColor = true;
            this.Ogrenci_ekle.Click += new System.EventHandler(this.Ogrenci_ekle_Click);
            // 
            // Ogrenci_sil
            // 
            this.Ogrenci_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ogrenci_sil.Location = new System.Drawing.Point(216, 210);
            this.Ogrenci_sil.Name = "Ogrenci_sil";
            this.Ogrenci_sil.Size = new System.Drawing.Size(112, 37);
            this.Ogrenci_sil.TabIndex = 36;
            this.Ogrenci_sil.Text = "Öğrenci Sil";
            this.Ogrenci_sil.UseVisualStyleBackColor = true;
            this.Ogrenci_sil.Click += new System.EventHandler(this.Ogrenci_sil_Click);
            // 
            // Ögrenci_kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Dershane_Ana.Properties.Resources.öğrenci_kayıt_arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 379);
            this.Controls.Add(this.Ogrenci_sil);
            this.Controls.Add(this.Ogrenci_ekle);
            this.Controls.Add(this.com_Ogrenci_branş);
            this.Controls.Add(this.Ogrenci_bölüm);
            this.Controls.Add(this.txtOgrenci_ad);
            this.Controls.Add(this.txtOgrenci_no);
            this.Controls.Add(this.Ogrenci_no_ekle);
            this.Controls.Add(this.Ogrenci_ad_ekle);
            this.Controls.Add(this.label1);
            this.Name = "Ögrenci_kayıt";
            this.Text = "Ögrenci_kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtOgrenci_ad;
        private TextBox txtOgrenci_no;
        private Label Ogrenci_no_ekle;
        private Label Ogrenci_ad_ekle;
        private Label Ogrenci_bölüm;
        private ComboBox com_Ogrenci_branş;
        private Button Ogrenci_ekle;
        private Button Ogrenci_sil;
    }
}