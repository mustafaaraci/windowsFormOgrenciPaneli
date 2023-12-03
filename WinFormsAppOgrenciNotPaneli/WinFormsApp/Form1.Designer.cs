namespace WinFormsApp
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            listeGosterEkrani = new ListBox();
            groupBox2 = new GroupBox();
            btn_takdirAlanOgrenciler = new Button();
            btn_tesekkurAlanOgrenciler = new Button();
            btn_gecenOgrenciler = new Button();
            btn_kalanOgrenciler = new Button();
            btn_tumOgrenciListesi = new Button();
            ogrenci_ortalamasi = new Label();
            ögrenci_adi = new Label();
            btnEkle = new Button();
            ortalamasi = new TextBox();
            ogrenciAdi = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Tomato;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(ogrenci_ortalamasi);
            groupBox1.Controls.Add(ögrenci_adi);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(ortalamasi);
            groupBox1.Controls.Add(ogrenciAdi);
            groupBox1.Cursor = Cursors.AppStarting;
            groupBox1.Location = new Point(30, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 345);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Paneli";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(136, 17);
            label1.Name = "label1";
            label1.Size = new Size(176, 33);
            label1.TabIndex = 7;
            label1.Text = "Öğrenci Not Paneli";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listeGosterEkrani);
            groupBox3.Location = new Point(195, 140);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(233, 199);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "GörüntüEkranı";
            // 
            // listeGosterEkrani
            // 
            listeGosterEkrani.FormattingEnabled = true;
            listeGosterEkrani.ItemHeight = 15;
            listeGosterEkrani.Location = new Point(6, 22);
            listeGosterEkrani.Name = "listeGosterEkrani";
            listeGosterEkrani.Size = new Size(221, 154);
            listeGosterEkrani.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_takdirAlanOgrenciler);
            groupBox2.Controls.Add(btn_tesekkurAlanOgrenciler);
            groupBox2.Controls.Add(btn_gecenOgrenciler);
            groupBox2.Controls.Add(btn_kalanOgrenciler);
            groupBox2.Controls.Add(btn_tumOgrenciListesi);
            groupBox2.Location = new Point(6, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 199);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "işlemler";
            // 
            // btn_takdirAlanOgrenciler
            // 
            btn_takdirAlanOgrenciler.BackColor = Color.FromArgb(255, 128, 0);
            btn_takdirAlanOgrenciler.Location = new Point(7, 155);
            btn_takdirAlanOgrenciler.Name = "btn_takdirAlanOgrenciler";
            btn_takdirAlanOgrenciler.Size = new Size(127, 44);
            btn_takdirAlanOgrenciler.TabIndex = 0;
            btn_takdirAlanOgrenciler.Text = "Takdir Alan Öğrenciler";
            btn_takdirAlanOgrenciler.UseVisualStyleBackColor = false;
            btn_takdirAlanOgrenciler.Click += btn_takdirAlanOgrenciler_Click;
            // 
            // btn_tesekkurAlanOgrenciler
            // 
            btn_tesekkurAlanOgrenciler.BackColor = Color.FromArgb(255, 128, 0);
            btn_tesekkurAlanOgrenciler.Location = new Point(7, 108);
            btn_tesekkurAlanOgrenciler.Name = "btn_tesekkurAlanOgrenciler";
            btn_tesekkurAlanOgrenciler.Size = new Size(127, 44);
            btn_tesekkurAlanOgrenciler.TabIndex = 0;
            btn_tesekkurAlanOgrenciler.Text = "Teşekkür Alan Öğrenciler";
            btn_tesekkurAlanOgrenciler.UseVisualStyleBackColor = false;
            btn_tesekkurAlanOgrenciler.Click += btn_tesekkurAlanOgrenciler_Click;
            // 
            // btn_gecenOgrenciler
            // 
            btn_gecenOgrenciler.BackColor = Color.FromArgb(255, 128, 0);
            btn_gecenOgrenciler.Location = new Point(7, 79);
            btn_gecenOgrenciler.Name = "btn_gecenOgrenciler";
            btn_gecenOgrenciler.Size = new Size(127, 23);
            btn_gecenOgrenciler.TabIndex = 0;
            btn_gecenOgrenciler.Text = "Geçen Öğrenciler";
            btn_gecenOgrenciler.UseVisualStyleBackColor = false;
            btn_gecenOgrenciler.Click += btn_gecenOgrenciler_Click;
            // 
            // btn_kalanOgrenciler
            // 
            btn_kalanOgrenciler.BackColor = Color.FromArgb(255, 128, 0);
            btn_kalanOgrenciler.Location = new Point(7, 50);
            btn_kalanOgrenciler.Name = "btn_kalanOgrenciler";
            btn_kalanOgrenciler.Size = new Size(127, 23);
            btn_kalanOgrenciler.TabIndex = 0;
            btn_kalanOgrenciler.Text = "Kalan Öğrenciler";
            btn_kalanOgrenciler.UseVisualStyleBackColor = false;
            btn_kalanOgrenciler.Click += btn_kalanOgrenciler_Click;
            // 
            // btn_tumOgrenciListesi
            // 
            btn_tumOgrenciListesi.BackColor = Color.FromArgb(255, 128, 0);
            btn_tumOgrenciListesi.Location = new Point(7, 21);
            btn_tumOgrenciListesi.Name = "btn_tumOgrenciListesi";
            btn_tumOgrenciListesi.Size = new Size(127, 23);
            btn_tumOgrenciListesi.TabIndex = 0;
            btn_tumOgrenciListesi.Text = "Öğrencileri Listele";
            btn_tumOgrenciListesi.UseVisualStyleBackColor = false;
            btn_tumOgrenciListesi.Click += btn_tumOgrenciListesi_Click;
            // 
            // ogrenci_ortalamasi
            // 
            ogrenci_ortalamasi.BackColor = Color.FromArgb(255, 255, 128);
            ogrenci_ortalamasi.Location = new Point(78, 85);
            ogrenci_ortalamasi.Name = "ogrenci_ortalamasi";
            ogrenci_ortalamasi.Size = new Size(87, 20);
            ogrenci_ortalamasi.TabIndex = 4;
            ogrenci_ortalamasi.Text = "Not Ortalaması";
            // 
            // ögrenci_adi
            // 
            ögrenci_adi.BackColor = Color.FromArgb(255, 255, 128);
            ögrenci_adi.Location = new Point(78, 56);
            ögrenci_adi.Name = "ögrenci_adi";
            ögrenci_adi.Size = new Size(87, 20);
            ögrenci_adi.TabIndex = 3;
            ögrenci_adi.Text = "Öğrenci Adı";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(255, 128, 0);
            btnEkle.Location = new Point(183, 111);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // ortalamasi
            // 
            ortalamasi.Location = new Point(171, 82);
            ortalamasi.Name = "ortalamasi";
            ortalamasi.Size = new Size(100, 23);
            ortalamasi.TabIndex = 1;
            // 
            // ogrenciAdi
            // 
            ogrenciAdi.Location = new Point(171, 53);
            ogrenciAdi.Name = "ogrenciAdi";
            ogrenciAdi.Size = new Size(100, 23);
            ogrenciAdi.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(277, 56);
            label2.Name = "label2";
            label2.Size = new Size(124, 59);
            label2.TabIndex = 8;
            label2.Text = "Not:Sisteme en fazla 10 öğrencinin notunu ekleyebilirsiniz!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox ogrenciAdi;
        private Label ogrenci_ortalamasi;
        private Label ögrenci_adi;
        private Button btnEkle;
        private TextBox ortalamasi;
        private GroupBox groupBox2;
        private Button btn_takdirAlanOgrenciler;
        private Button btn_tesekkurAlanOgrenciler;
        private Button btn_gecenOgrenciler;
        private Button btn_kalanOgrenciler;
        private Button btn_tumOgrenciListesi;
        private GroupBox groupBox3;
        private ListBox listeGosterEkrani;
        private Label label1;
        private Label label2;
    }
}
