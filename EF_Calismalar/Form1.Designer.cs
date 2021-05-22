
namespace EF_Calismalar
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnOgrenciListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtFOTO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSOYAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrenciID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtDersAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDersId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnNotGuncelle = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSinavOrt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDersListele = new System.Windows.Forms.Button();
            this.BtnNotListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnDersKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOgrenciListele
            // 
            this.BtnOgrenciListele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnOgrenciListele.Location = new System.Drawing.Point(43, 377);
            this.BtnOgrenciListele.Name = "BtnOgrenciListele";
            this.BtnOgrenciListele.Size = new System.Drawing.Size(55, 37);
            this.BtnOgrenciListele.TabIndex = 1;
            this.BtnOgrenciListele.Text = "Ogrenci Listele";
            this.BtnOgrenciListele.UseVisualStyleBackColor = true;
            this.BtnOgrenciListele.Click += new System.EventHandler(this.BtnOgrenciListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnKaydet.Location = new System.Drawing.Point(6, 152);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(55, 37);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSil.Location = new System.Drawing.Point(64, 152);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(55, 37);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGüncelle.Location = new System.Drawing.Point(121, 152);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(59, 37);
            this.BtnGüncelle.TabIndex = 4;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBul.Location = new System.Drawing.Point(530, 377);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(59, 37);
            this.BtnBul.TabIndex = 5;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.TxtFOTO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSOYAD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtAD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtOgrenciID);
            this.groupBox1.Controls.Add(this.BtnGüncelle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Location = new System.Drawing.Point(620, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 195);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci";
            // 
            // TxtFOTO
            // 
            this.TxtFOTO.Location = new System.Drawing.Point(80, 117);
            this.TxtFOTO.Name = "TxtFOTO";
            this.TxtFOTO.Size = new System.Drawing.Size(100, 20);
            this.TxtFOTO.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "FOTOĞRAF:";
            // 
            // TxtSOYAD
            // 
            this.TxtSOYAD.Location = new System.Drawing.Point(80, 88);
            this.TxtSOYAD.Name = "TxtSOYAD";
            this.TxtSOYAD.Size = new System.Drawing.Size(100, 20);
            this.TxtSOYAD.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "SOYAD:";
            // 
            // TxtAD
            // 
            this.TxtAD.Location = new System.Drawing.Point(80, 57);
            this.TxtAD.Name = "TxtAD";
            this.TxtAD.Size = new System.Drawing.Size(100, 20);
            this.TxtAD.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "AD:";
            // 
            // TxtOgrenciID
            // 
            this.TxtOgrenciID.Location = new System.Drawing.Point(80, 24);
            this.TxtOgrenciID.Name = "TxtOgrenciID";
            this.TxtOgrenciID.Size = new System.Drawing.Size(100, 20);
            this.TxtOgrenciID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.BtnDersKaydet);
            this.groupBox2.Controls.Add(this.TxtDersAdi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtDersId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(822, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 131);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders";
            // 
            // TxtDersAdi
            // 
            this.TxtDersAdi.Location = new System.Drawing.Point(80, 57);
            this.TxtDersAdi.Name = "TxtDersAdi";
            this.TxtDersAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtDersAdi.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "AD:";
            // 
            // TxtDersId
            // 
            this.TxtDersId.Location = new System.Drawing.Point(80, 24);
            this.TxtDersId.Name = "TxtDersId";
            this.TxtDersId.Size = new System.Drawing.Size(100, 20);
            this.TxtDersId.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.BtnNotGuncelle);
            this.groupBox3.Controls.Add(this.BtnHesapla);
            this.groupBox3.Controls.Add(this.TxtDurum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TxtSinavOrt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtSinav3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtSinav2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtSinav1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(721, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 223);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // BtnNotGuncelle
            // 
            this.BtnNotGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnNotGuncelle.Location = new System.Drawing.Point(91, 170);
            this.BtnNotGuncelle.Name = "BtnNotGuncelle";
            this.BtnNotGuncelle.Size = new System.Drawing.Size(87, 45);
            this.BtnNotGuncelle.TabIndex = 26;
            this.BtnNotGuncelle.Text = "Sınav Notu Güncelle";
            this.BtnNotGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnHesapla.Location = new System.Drawing.Point(6, 170);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(79, 45);
            this.BtnHesapla.TabIndex = 25;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(78, 143);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(100, 20);
            this.TxtDurum.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "DURUM";
            // 
            // TxtSinavOrt
            // 
            this.TxtSinavOrt.Location = new System.Drawing.Point(78, 115);
            this.TxtSinavOrt.Name = "TxtSinavOrt";
            this.TxtSinavOrt.Size = new System.Drawing.Size(100, 20);
            this.TxtSinavOrt.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "ORTALAMA";
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(78, 88);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(100, 20);
            this.TxtSinav3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "SINAV3";
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(78, 57);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(100, 20);
            this.TxtSinav2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "SINAV2";
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(78, 24);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(100, 20);
            this.TxtSinav1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "SINAV1";
            // 
            // BtnDersListele
            // 
            this.BtnDersListele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDersListele.Location = new System.Drawing.Point(104, 377);
            this.BtnDersListele.Name = "BtnDersListele";
            this.BtnDersListele.Size = new System.Drawing.Size(55, 37);
            this.BtnDersListele.TabIndex = 23;
            this.BtnDersListele.Text = "Ders Listele";
            this.BtnDersListele.UseVisualStyleBackColor = true;
            this.BtnDersListele.Click += new System.EventHandler(this.BtnDersListele_Click);
            // 
            // BtnNotListele
            // 
            this.BtnNotListele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnNotListele.Location = new System.Drawing.Point(165, 377);
            this.BtnNotListele.Name = "BtnNotListele";
            this.BtnNotListele.Size = new System.Drawing.Size(55, 37);
            this.BtnNotListele.TabIndex = 24;
            this.BtnNotListele.Text = "Not Listele";
            this.BtnNotListele.UseVisualStyleBackColor = true;
            this.BtnNotListele.Click += new System.EventHandler(this.BtnNotListele_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(607, 371);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // BtnDersKaydet
            // 
            this.BtnDersKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDersKaydet.Location = new System.Drawing.Point(55, 89);
            this.BtnDersKaydet.Name = "BtnDersKaydet";
            this.BtnDersKaydet.Size = new System.Drawing.Size(55, 37);
            this.BtnDersKaydet.TabIndex = 22;
            this.BtnDersKaydet.Text = "Kaydet";
            this.BtnDersKaydet.UseVisualStyleBackColor = true;
            this.BtnDersKaydet.Click += new System.EventHandler(this.BtnDersKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1018, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnNotListele);
            this.Controls.Add(this.BtnDersListele);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.BtnOgrenciListele);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnOgrenciListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFOTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSOYAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrenciID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDersAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDersId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtSinavOrt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnDersListele;
        private System.Windows.Forms.Button BtnNotListele;
        private System.Windows.Forms.Button BtnNotGuncelle;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnDersKaydet;
    }
}

