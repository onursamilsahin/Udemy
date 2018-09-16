namespace Udemy.WFUI
{
    partial class AnaForm
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
            this.lst_liste = new System.Windows.Forms.ListBox();
            this.grtBoxKayit = new System.Windows.Forms.GroupBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Emailadres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_telefon1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telefon3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_telefon2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_dataDurum = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_jsonver = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_xmlVer = new System.Windows.Forms.Button();
            this.btn_KayitSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grtBoxKayit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_liste);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 659);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber Listesi";
            // 
            // lst_liste
            // 
            this.lst_liste.FormattingEnabled = true;
            this.lst_liste.ItemHeight = 16;
            this.lst_liste.Location = new System.Drawing.Point(6, 21);
            this.lst_liste.Name = "lst_liste";
            this.lst_liste.Size = new System.Drawing.Size(317, 612);
            this.lst_liste.TabIndex = 0;
            this.lst_liste.SelectedIndexChanged += new System.EventHandler(this.lst_liste_SelectedIndexChanged);
            this.lst_liste.DoubleClick += new System.EventHandler(this.lst_liste_DoubleClick);
            // 
            // grtBoxKayit
            // 
            this.grtBoxKayit.Controls.Add(this.btn_KayitSil);
            this.grtBoxKayit.Controls.Add(this.btn_Guncelle);
            this.grtBoxKayit.Controls.Add(this.button1);
            this.grtBoxKayit.Controls.Add(this.tabControl1);
            this.grtBoxKayit.Location = new System.Drawing.Point(359, 12);
            this.grtBoxKayit.Name = "grtBoxKayit";
            this.grtBoxKayit.Size = new System.Drawing.Size(747, 419);
            this.grtBoxKayit.TabIndex = 1;
            this.grtBoxKayit.TabStop = false;
            this.grtBoxKayit.Text = "Yeni Rehber Kaydı";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(6, 356);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(360, 44);
            this.btn_Guncelle.TabIndex = 20;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(731, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "Yeni Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 289);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_adres);
            this.tabPage1.Controls.Add(this.txt_website);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_Emailadres);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_telefon1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_telefon3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_soyisim);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_telefon2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_isim);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(727, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişisel bilgiler ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(419, 27);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(255, 207);
            this.txt_adres.TabIndex = 18;
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(112, 211);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(214, 22);
            this.txt_website.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Web site";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adres";
            // 
            // txt_Emailadres
            // 
            this.txt_Emailadres.Location = new System.Drawing.Point(112, 183);
            this.txt_Emailadres.Name = "txt_Emailadres";
            this.txt_Emailadres.Size = new System.Drawing.Size(214, 22);
            this.txt_Emailadres.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email Adres";
            // 
            // txt_telefon1
            // 
            this.txt_telefon1.Location = new System.Drawing.Point(112, 86);
            this.txt_telefon1.Name = "txt_telefon1";
            this.txt_telefon1.Size = new System.Drawing.Size(214, 22);
            this.txt_telefon1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon I";
            // 
            // txt_telefon3
            // 
            this.txt_telefon3.Location = new System.Drawing.Point(112, 145);
            this.txt_telefon3.Name = "txt_telefon3";
            this.txt_telefon3.Size = new System.Drawing.Size(214, 22);
            this.txt_telefon3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon II";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(112, 58);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(214, 22);
            this.txt_soyisim.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyisim";
            // 
            // txt_telefon2
            // 
            this.txt_telefon2.Location = new System.Drawing.Point(112, 117);
            this.txt_telefon2.Name = "txt_telefon2";
            this.txt_telefon2.Size = new System.Drawing.Size(214, 22);
            this.txt_telefon2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon III";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(112, 27);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(214, 22);
            this.txt_isim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "isim";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_aciklama);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Acıklama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(6, 6);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(715, 248);
            this.txt_aciklama.TabIndex = 0;
            this.txt_aciklama.TextChanged += new System.EventHandler(this.txt_aciklama_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_dataDurum);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btn_jsonver);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.btn_xmlVer);
            this.groupBox3.Location = new System.Drawing.Point(359, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 186);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Al/Ver";
            // 
            // lbl_dataDurum
            // 
            this.lbl_dataDurum.AutoSize = true;
            this.lbl_dataDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dataDurum.Location = new System.Drawing.Point(477, 73);
            this.lbl_dataDurum.Name = "lbl_dataDurum";
            this.lbl_dataDurum.Size = new System.Drawing.Size(148, 20);
            this.lbl_dataDurum.TabIndex = 4;
            this.lbl_dataDurum.Text = "Durum Beklemede";
            this.lbl_dataDurum.Click += new System.EventHandler(this.lbl_dataDurum_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(380, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 83);
            this.button5.TabIndex = 3;
            this.button5.Text = "XML Al";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_jsonver
            // 
            this.btn_jsonver.Location = new System.Drawing.Point(263, 43);
            this.btn_jsonver.Name = "btn_jsonver";
            this.btn_jsonver.Size = new System.Drawing.Size(75, 83);
            this.btn_jsonver.TabIndex = 2;
            this.btn_jsonver.Text = "JSON ver";
            this.btn_jsonver.UseVisualStyleBackColor = true;
            this.btn_jsonver.Click += new System.EventHandler(this.btn_jsonver_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 83);
            this.button3.TabIndex = 1;
            this.button3.Text = "CSVver";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_xmlVer
            // 
            this.btn_xmlVer.Location = new System.Drawing.Point(27, 43);
            this.btn_xmlVer.Name = "btn_xmlVer";
            this.btn_xmlVer.Size = new System.Drawing.Size(77, 83);
            this.btn_xmlVer.TabIndex = 0;
            this.btn_xmlVer.Text = "XMLver";
            this.btn_xmlVer.UseVisualStyleBackColor = true;
            this.btn_xmlVer.Click += new System.EventHandler(this.btn_xmlVer_Click);
            // 
            // btn_KayitSil
            // 
            this.btn_KayitSil.Location = new System.Drawing.Point(380, 357);
            this.btn_KayitSil.Name = "btn_KayitSil";
            this.btn_KayitSil.Size = new System.Drawing.Size(357, 43);
            this.btn_KayitSil.TabIndex = 21;
            this.btn_KayitSil.Text = "Kayıt Sil";
            this.btn_KayitSil.UseVisualStyleBackColor = true;
            this.btn_KayitSil.Click += new System.EventHandler(this.btn_KayitSil_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 729);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grtBoxKayit);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.grtBoxKayit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grtBoxKayit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Emailadres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_telefon1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_telefon3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_telefon2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.ListBox lst_liste;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_dataDurum;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_jsonver;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_xmlVer;
        private System.Windows.Forms.Button btn_KayitSil;
    }
}