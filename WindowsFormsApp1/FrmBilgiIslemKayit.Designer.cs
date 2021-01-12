namespace WindowsFormsApp1
{
    partial class FrmBilgiIslemKayit
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
            this.TxtBlgIslemEPosta = new System.Windows.Forms.TextBox();
            this.TxtBlgIslemTel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBlgIslemSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBlgIslemAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtBlgIslemSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(319, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 25);
            this.button4.TabIndex = 79;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(247, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 25);
            this.button3.TabIndex = 78;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(175, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 25);
            this.button2.TabIndex = 77;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtBlgIslemEPosta
            // 
            this.TxtBlgIslemEPosta.Location = new System.Drawing.Point(172, 202);
            this.TxtBlgIslemEPosta.Name = "TxtBlgIslemEPosta";
            this.TxtBlgIslemEPosta.Size = new System.Drawing.Size(153, 20);
            this.TxtBlgIslemEPosta.TabIndex = 76;
            // 
            // TxtBlgIslemTel
            // 
            this.TxtBlgIslemTel.Location = new System.Drawing.Point(174, 159);
            this.TxtBlgIslemTel.Name = "TxtBlgIslemTel";
            this.TxtBlgIslemTel.Size = new System.Drawing.Size(153, 20);
            this.TxtBlgIslemTel.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(24, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 73;
            this.label11.Text = "E-Posta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(23, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 72;
            this.label9.Text = "Cep Telefonu:";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(175, 284);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(91, 21);
            this.CmbCinsiyet.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 65;
            this.label5.Text = "Cinsiyet:";
            // 
            // TxtBlgIslemSoyad
            // 
            this.TxtBlgIslemSoyad.Location = new System.Drawing.Point(172, 114);
            this.TxtBlgIslemSoyad.Name = "TxtBlgIslemSoyad";
            this.TxtBlgIslemSoyad.Size = new System.Drawing.Size(153, 20);
            this.TxtBlgIslemSoyad.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Soyadı:";
            // 
            // TxtBlgIslemAd
            // 
            this.TxtBlgIslemAd.Location = new System.Drawing.Point(171, 73);
            this.TxtBlgIslemAd.Name = "TxtBlgIslemAd";
            this.TxtBlgIslemAd.Size = new System.Drawing.Size(153, 20);
            this.TxtBlgIslemAd.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Adı:";
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(171, 28);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(153, 20);
            this.TxtTc.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "TcKimlik No:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(330, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 25);
            this.button1.TabIndex = 58;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TxtBlgIslemSifre
            // 
            this.TxtBlgIslemSifre.Location = new System.Drawing.Point(172, 244);
            this.TxtBlgIslemSifre.Name = "TxtBlgIslemSifre";
            this.TxtBlgIslemSifre.Size = new System.Drawing.Size(153, 20);
            this.TxtBlgIslemSifre.TabIndex = 81;
            this.TxtBlgIslemSifre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 80;
            this.label4.Text = "Şifre:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmBilgiIslemKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 394);
            this.Controls.Add(this.TxtBlgIslemSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtBlgIslemEPosta);
            this.Controls.Add(this.TxtBlgIslemTel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBlgIslemSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBlgIslemAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.label1);
            this.Name = "FrmBilgiIslemKayit";
            this.Text = "Bilgi İşlem Kayıt";
            this.Load += new System.EventHandler(this.FrmBilgiIslemKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtBlgIslemEPosta;
        private System.Windows.Forms.TextBox TxtBlgIslemTel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBlgIslemSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBlgIslemAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtBlgIslemSifre;
        private System.Windows.Forms.Label label4;
    }
}