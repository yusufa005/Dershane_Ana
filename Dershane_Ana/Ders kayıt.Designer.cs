namespace Dershane_Ana
{
    partial class Ders_kayıt
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
            this.Ders_adı = new System.Windows.Forms.Label();
            this.Ders_bölüm = new System.Windows.Forms.Label();
            this.comDers_ad = new System.Windows.Forms.ComboBox();
            this.comDers_branş = new System.Windows.Forms.ComboBox();
            this.Ders_ekle = new System.Windows.Forms.Button();
            this.Ders_Sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ders_adı
            // 
            this.Ders_adı.AutoSize = true;
            this.Ders_adı.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ders_adı.Location = new System.Drawing.Point(24, 53);
            this.Ders_adı.Name = "Ders_adı";
            this.Ders_adı.Size = new System.Drawing.Size(54, 15);
            this.Ders_adı.TabIndex = 0;
            this.Ders_adı.Text = "Ders Adı:";
            this.Ders_adı.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ders_bölüm
            // 
            this.Ders_bölüm.AutoSize = true;
            this.Ders_bölüm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ders_bölüm.Location = new System.Drawing.Point(-1, 88);
            this.Ders_bölüm.Name = "Ders_bölüm";
            this.Ders_bölüm.Size = new System.Drawing.Size(78, 15);
            this.Ders_bölüm.TabIndex = 1;
            this.Ders_bölüm.Text = "Ders Bölümü:";
            // 
            // comDers_ad
            // 
            this.comDers_ad.FormattingEnabled = true;
            this.comDers_ad.Items.AddRange(new object[] {
            "Matematik",
            "Türkçe",
            "Kİmya",
            "Coğrafya"});
            this.comDers_ad.Location = new System.Drawing.Point(89, 53);
            this.comDers_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comDers_ad.Name = "comDers_ad";
            this.comDers_ad.Size = new System.Drawing.Size(133, 23);
            this.comDers_ad.TabIndex = 2;
            // 
            // comDers_branş
            // 
            this.comDers_branş.FormattingEnabled = true;
            this.comDers_branş.Items.AddRange(new object[] {
            "Sayısal",
            "Sözel"});
            this.comDers_branş.Location = new System.Drawing.Point(89, 86);
            this.comDers_branş.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comDers_branş.Name = "comDers_branş";
            this.comDers_branş.Size = new System.Drawing.Size(133, 23);
            this.comDers_branş.TabIndex = 3;
            // 
            // Ders_ekle
            // 
            this.Ders_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ders_ekle.Location = new System.Drawing.Point(24, 119);
            this.Ders_ekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ders_ekle.Name = "Ders_ekle";
            this.Ders_ekle.Size = new System.Drawing.Size(82, 28);
            this.Ders_ekle.TabIndex = 4;
            this.Ders_ekle.Text = "Kayıt Ekle";
            this.Ders_ekle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ders_ekle.UseVisualStyleBackColor = true;
            this.Ders_ekle.Click += new System.EventHandler(this.Ders_ekle_Click);
            // 
            // Ders_Sil
            // 
            this.Ders_Sil.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ders_Sil.Location = new System.Drawing.Point(130, 119);
            this.Ders_Sil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ders_Sil.Name = "Ders_Sil";
            this.Ders_Sil.Size = new System.Drawing.Size(82, 28);
            this.Ders_Sil.TabIndex = 5;
            this.Ders_Sil.Text = "Kayıt Sil";
            this.Ders_Sil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ders_Sil.UseVisualStyleBackColor = true;
            this.Ders_Sil.Click += new System.EventHandler(this.Ders_Sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "DERS EKLEME...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 152);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(348, 101);
            this.dataGridView1.TabIndex = 7;
            // 
            // Ders_kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Dershane_Ana.Properties.Resources.ders_kayıt_arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 254);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ders_Sil);
            this.Controls.Add(this.Ders_ekle);
            this.Controls.Add(this.comDers_branş);
            this.Controls.Add(this.comDers_ad);
            this.Controls.Add(this.Ders_bölüm);
            this.Controls.Add(this.Ders_adı);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ders_kayıt";
            this.Text = "Ders_kayıt";
            this.Load += new System.EventHandler(this.Ders_kayıt_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Ders_adı;
        private Label Ders_bölüm;
        private ComboBox comDers_ad;
        private ComboBox comDers_branş;
        private Button Ders_ekle;
        private Button Ders_Sil;
        private Label label1;
        private DataGridView dataGridView1;
    }
}