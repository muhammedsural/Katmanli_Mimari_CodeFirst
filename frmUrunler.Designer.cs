namespace Katmanlı_Mimari_Tekrar
{
    partial class frmUrunler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmrFiyat = new System.Windows.Forms.NumericUpDown();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBirimAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstKategoriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmrFiyat);
            this.groupBox1.Controls.Add(this.nmrAdet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBirimAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbKategoriler);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 186);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori İşlemleri";
            // 
            // nmrFiyat
            // 
            this.nmrFiyat.Location = new System.Drawing.Point(412, 62);
            this.nmrFiyat.Name = "nmrFiyat";
            this.nmrFiyat.Size = new System.Drawing.Size(120, 20);
            this.nmrFiyat.TabIndex = 12;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(412, 31);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(120, 20);
            this.nmrAdet.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fiyat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stok Adedi :";
            // 
            // txtBirimAdi
            // 
            this.txtBirimAdi.Location = new System.Drawing.Point(104, 94);
            this.txtBirimAdi.Name = "txtBirimAdi";
            this.txtBirimAdi.Size = new System.Drawing.Size(232, 20);
            this.txtBirimAdi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Birim :";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(103, 35);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(232, 21);
            this.cmbKategoriler.TabIndex = 6;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(549, 127);
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
            this.btnSil.Location = new System.Drawing.Point(549, 90);
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
            this.btnGuncelle.Location = new System.Drawing.Point(549, 49);
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
            this.btnKaydet.Location = new System.Drawing.Point(549, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 33);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(104, 62);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(232, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı :";
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstKategoriler.GridLines = true;
            this.lstKategoriler.HideSelection = false;
            this.lstKategoriler.Location = new System.Drawing.Point(12, 204);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(685, 178);
            this.lstKategoriler.TabIndex = 11;
            this.lstKategoriler.UseCompatibleStateImageBehavior = false;
            this.lstKategoriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stok Adet";
            this.columnHeader3.Width = 235;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Birim";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kategori";
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriler.ForeColor = System.Drawing.Color.White;
            this.btnKategoriler.Location = new System.Drawing.Point(12, 389);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(685, 23);
            this.btnKategoriler.TabIndex = 12;
            this.btnKategoriler.Text = "KATEGORİLER";
            this.btnKategoriler.UseVisualStyleBackColor = false;
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.btnKategoriler);
            this.Name = "frmUrunler";
            this.Text = "frmUrunler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmrFiyat;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBirimAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstKategoriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnKategoriler;
    }
}