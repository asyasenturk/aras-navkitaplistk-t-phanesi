namespace HesapKontrolSistem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            txtKategori = new TextBox();
            txtAd = new TextBox();
            txtYazar = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            txtTarih = new TextBox();
            txtNo = new Label();
            txtKno = new TextBox();
            label5 = new Label();
            txtBarcode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 113);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Yazar Adı";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 66);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 154);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Kategori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 197);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 3;
            label4.Text = "Yayın Tarihi";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.AntiqueWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(854, 375);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(230, 147);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(192, 27);
            txtKategori.TabIndex = 6;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(230, 66);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(192, 27);
            txtAd.TabIndex = 7;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(230, 106);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(192, 27);
            txtYazar.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(456, 11);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(170, 75);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Kitap Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(456, 99);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(170, 75);
            btnSil.TabIndex = 10;
            btnSil.Text = "Kitap Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(456, 194);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(170, 83);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle/Düzenle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(230, 194);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(192, 27);
            txtTarih.TabIndex = 12;
            // 
            // txtNo
            // 
            txtNo.AutoSize = true;
            txtNo.Location = new Point(135, 23);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(68, 20);
            txtNo.TabIndex = 13;
            txtNo.Text = "Kitap No";
            // 
            // txtKno
            // 
            txtKno.Location = new Point(230, 20);
            txtKno.Name = "txtKno";
            txtKno.Size = new Size(192, 27);
            txtKno.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 240);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 15;
            label5.Text = "Barkod No";
            label5.Click += label5_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(230, 237);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(192, 27);
            txtBarcode.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
           
            ClientSize = new Size(918, 696);
            Controls.Add(txtBarcode);
            Controls.Add(label5);
            Controls.Add(txtKno);
            Controls.Add(txtNo);
            Controls.Add(txtTarih);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtYazar);
            Controls.Add(txtAd);
            Controls.Add(txtKategori);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox txtKategori;
        private TextBox txtAd;
        private TextBox txtYazar;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private TextBox txtTarih;
        private Label txtNo;
        private TextBox txtKno;
        private Label label5;
        private TextBox txtBarcode;
    }
}
