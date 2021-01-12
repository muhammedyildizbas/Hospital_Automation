namespace WindowsFormsApp1
{
    partial class FrmDoktorKayit
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtDktrEPosta = new System.Windows.Forms.TextBox();
            this.TxtDktrTel = new System.Windows.Forms.TextBox();
            this.TxtDktrAnneAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDktrBabaAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDgmYeri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDktrSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDktrAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbPoliklinikAdi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(329, 461);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 25);
            this.button4.TabIndex = 51;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(257, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 25);
            this.button3.TabIndex = 50;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(185, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 25);
            this.button2.TabIndex = 49;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtDktrEPosta
            // 
            this.TxtDktrEPosta.Location = new System.Drawing.Point(175, 427);
            this.TxtDktrEPosta.Name = "TxtDktrEPosta";
            this.TxtDktrEPosta.Size = new System.Drawing.Size(153, 20);
            this.TxtDktrEPosta.TabIndex = 48;
            // 
            // TxtDktrTel
            // 
            this.TxtDktrTel.Location = new System.Drawing.Point(175, 363);
            this.TxtDktrTel.Name = "TxtDktrTel";
            this.TxtDktrTel.Size = new System.Drawing.Size(153, 20);
            this.TxtDktrTel.TabIndex = 46;
            // 
            // TxtDktrAnneAd
            // 
            this.TxtDktrAnneAd.Location = new System.Drawing.Point(174, 330);
            this.TxtDktrAnneAd.Name = "TxtDktrAnneAd";
            this.TxtDktrAnneAd.Size = new System.Drawing.Size(153, 20);
            this.TxtDktrAnneAd.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(27, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 44;
            this.label11.Text = "E-Posta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(24, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Cep Telefonu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(23, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "Anne Adı:";
            // 
            // TxtDktrBabaAd
            // 
            this.TxtDktrBabaAd.Location = new System.Drawing.Point(174, 293);
            this.TxtDktrBabaAd.Name = "TxtDktrBabaAd";
            this.TxtDktrBabaAd.Size = new System.Drawing.Size(153, 20);
            this.TxtDktrBabaAd.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(22, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Baba Adı:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Doğum Yeri:";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(171, 215);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(91, 21);
            this.CmbCinsiyet.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cinsiyet:";
            // 
            // TxtDgmYeri
            // 
            this.TxtDgmYeri.Location = new System.Drawing.Point(172, 171);
            this.TxtDgmYeri.Name = "TxtDgmYeri";
            this.TxtDgmYeri.Size = new System.Drawing.Size(153, 20);
            this.TxtDgmYeri.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Doğum Yeri:";
            // 
            // TxtDktrSoyad
            // 
            this.TxtDktrSoyad.Location = new System.Drawing.Point(172, 123);
            this.TxtDktrSoyad.Name = "TxtDktrSoyad";
            this.TxtDktrSoyad.Size = new System.Drawing.Size(153, 20);
            this.TxtDktrSoyad.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Soyadı:";
            // 
            // TxtDktrAd
            // 
            this.TxtDktrAd.Location = new System.Drawing.Point(171, 83);
            this.TxtDktrAd.Name = "TxtDktrAd";
            this.TxtDktrAd.Size = new System.Drawing.Size(153, 20);
            this.TxtDktrAd.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Adı:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(330, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 25);
            this.button1.TabIndex = 28;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(171, 41);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(153, 20);
            this.TxtTc.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "TcKimlik No:";
            // 
            // CmbPoliklinikAdi
            // 
            this.CmbPoliklinikAdi.FormattingEnabled = true;
            this.CmbPoliklinikAdi.Items.AddRange(new object[] {
            "Diş",
            "Cildiye",
            "Noroloji",
            "KBB"});
            this.CmbPoliklinikAdi.Location = new System.Drawing.Point(175, 395);
            this.CmbPoliklinikAdi.Name = "CmbPoliklinikAdi";
            this.CmbPoliklinikAdi.Size = new System.Drawing.Size(155, 21);
            this.CmbPoliklinikAdi.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(27, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 52;
            this.label10.Text = "Poliklinik Adı:";
            // 
            // FrmDoktorKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 494);
            this.Controls.Add(this.CmbPoliklinikAdi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtDktrEPosta);
            this.Controls.Add(this.TxtDktrTel);
            this.Controls.Add(this.TxtDktrAnneAd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDktrBabaAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDgmYeri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDktrSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDktrAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoktorKayit";
            this.Text = "Doktor Kayıt";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtDktrEPosta;
        private System.Windows.Forms.TextBox TxtDktrTel;
        private System.Windows.Forms.TextBox TxtDktrAnneAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDktrBabaAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDgmYeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDktrSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDktrAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbPoliklinikAdi;
        private System.Windows.Forms.Label label10;
    }
}