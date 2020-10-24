namespace Katmanlı_Mimari_Tekrar
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
            this.btnUrunler = new System.Windows.Forms.Button();
            this.lstKategoriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.ForeColor = System.Drawing.Color.White;
            this.btnUrunler.Location = new System.Drawing.Point(12, 389);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(501, 23);
            this.btnUrunler.TabIndex = 9;
            this.btnUrunler.Text = "ÜRÜNLER";
            this.btnUrunler.UseVisualStyleBackColor = false;
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstKategoriler.GridLines = true;
            this.lstKategoriler.HideSelection = false;
            this.lstKategoriler.Location = new System.Drawing.Point(12, 204);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(501, 178);
            this.lstKategoriler.TabIndex = 8;
            this.lstKategoriler.UseCompatibleStateImageBehavior = false;
            this.lstKategoriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori Adı";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Açıklama";
            this.columnHeader3.Width = 235;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.txtKategoriAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 186);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori İşlemleri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(358, 124);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(112, 32);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(358, 87);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 31);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(358, 46);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 35);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(358, 9);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 33);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(103, 46);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(232, 105);
            this.txtAciklama.TabIndex = 1;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(103, 16);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(232, 20);
            this.txtKategoriAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.ListView lstKategoriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

