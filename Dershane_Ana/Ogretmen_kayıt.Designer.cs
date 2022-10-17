namespace Dershane_Ana
{
    partial class Ogretmen_kayıt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogretmen_kayıt));
            this.Ogretmen_ekle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Ogretmen_sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Ogr_ad_soyad = new System.Windows.Forms.Label();
            this.Ogr_branş = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.Ogr_tc_No = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.com_branş = new System.Windows.Forms.ComboBox();
            this.txtAd_soyad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ogretmen_ekle
            // 
            this.Ogretmen_ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ogretmen_ekle.ImageIndex = 0;
            this.Ogretmen_ekle.ImageList = this.ımageList1;
            this.Ogretmen_ekle.Location = new System.Drawing.Point(117, 203);
            this.Ogretmen_ekle.Name = "Ogretmen_ekle";
            this.Ogretmen_ekle.Size = new System.Drawing.Size(94, 73);
            this.Ogretmen_ekle.TabIndex = 0;
            this.Ogretmen_ekle.Text = "Kayıt Ekle";
            this.Ogretmen_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ogretmen_ekle.UseVisualStyleBackColor = true;
            this.Ogretmen_ekle.Click += new System.EventHandler(this.Ogretmen_ekle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "öğretmen kayıt ekle.png");
            this.ımageList1.Images.SetKeyName(1, "öğretmen kayıt sil.png");
            // 
            // Ogretmen_sil
            // 
            this.Ogretmen_sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ogretmen_sil.ImageIndex = 1;
            this.Ogretmen_sil.ImageList = this.ımageList1;
            this.Ogretmen_sil.Location = new System.Drawing.Point(240, 203);
            this.Ogretmen_sil.Name = "Ogretmen_sil";
            this.Ogretmen_sil.Size = new System.Drawing.Size(94, 73);
            this.Ogretmen_sil.TabIndex = 1;
            this.Ogretmen_sil.Text = "Kayıt Sil";
            this.Ogretmen_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ogretmen_sil.UseVisualStyleBackColor = true;
            this.Ogretmen_sil.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // Ogr_ad_soyad
            // 
            this.Ogr_ad_soyad.AutoSize = true;
            this.Ogr_ad_soyad.BackColor = System.Drawing.Color.Green;
            this.Ogr_ad_soyad.Location = new System.Drawing.Point(79, 92);
            this.Ogr_ad_soyad.Name = "Ogr_ad_soyad";
            this.Ogr_ad_soyad.Size = new System.Drawing.Size(78, 20);
            this.Ogr_ad_soyad.TabIndex = 5;
            this.Ogr_ad_soyad.Text = "Ad/Soyad:";
            this.Ogr_ad_soyad.Click += new System.EventHandler(this.label2_Click);
            // 
            // Ogr_branş
            // 
            this.Ogr_branş.AutoSize = true;
            this.Ogr_branş.BackColor = System.Drawing.Color.Green;
            this.Ogr_branş.Location = new System.Drawing.Point(109, 171);
            this.Ogr_branş.Name = "Ogr_branş";
            this.Ogr_branş.Size = new System.Drawing.Size(48, 20);
            this.Ogr_branş.TabIndex = 6;
            this.Ogr_branş.Text = "Branş:";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(163, 125);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(143, 27);
            this.txt_tc.TabIndex = 8;
            // 
            // Ogr_tc_No
            // 
            this.Ogr_tc_No.AutoSize = true;
            this.Ogr_tc_No.BackColor = System.Drawing.Color.Green;
            this.Ogr_tc_No.Location = new System.Drawing.Point(107, 128);
            this.Ogr_tc_No.Name = "Ogr_tc_No";
            this.Ogr_tc_No.Size = new System.Drawing.Size(50, 20);
            this.Ogr_tc_No.TabIndex = 9;
            this.Ogr_tc_No.Text = "Tc No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "ÖĞRETMEN EKLEME...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(493, 149);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // com_branş
            // 
            this.com_branş.FormattingEnabled = true;
            this.com_branş.Items.AddRange(new object[] {
            "Sözel",
            "Sayısal"});
            this.com_branş.Location = new System.Drawing.Point(163, 163);
            this.com_branş.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_branş.Name = "com_branş";
            this.com_branş.Size = new System.Drawing.Size(138, 28);
            this.com_branş.TabIndex = 13;
            // 
            // txtAd_soyad
            // 
            this.txtAd_soyad.Location = new System.Drawing.Point(163, 89);
            this.txtAd_soyad.Name = "txtAd_soyad";
            this.txtAd_soyad.Size = new System.Drawing.Size(143, 27);
            this.txtAd_soyad.TabIndex = 14;
            // 
            // Ogretmen_kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Dershane_Ana.Properties.Resources.öğretmen_ekle_arka_plan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 433);
            this.Controls.Add(this.txtAd_soyad);
            this.Controls.Add(this.com_branş);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ogr_tc_No);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.Ogr_branş);
            this.Controls.Add(this.Ogr_ad_soyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ogretmen_sil);
            this.Controls.Add(this.Ogretmen_ekle);
            this.Name = "Ogretmen_kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogretmen_kayıt";
            this.Load += new System.EventHandler(this.Ogretmen_kayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Ogretmen_ekle;
        private Button Ogretmen_sil;
        private Label label1;
        private Label Ogr_ad_soyad;
        private Label Ogr_branş;
        private TextBox txt_tc;
        private Label Ogr_tc_No;
        private ImageList ımageList1;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox com_branş;
        private TextBox txtAd_soyad;
    }
}