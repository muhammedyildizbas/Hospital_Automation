﻿namespace WindowsFormsApp1
{
    partial class FrmBilgiIslemKullanici
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
            this.TxtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtYeniSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTcNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button38 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtYeniSifreTekrar
            // 
            this.TxtYeniSifreTekrar.Location = new System.Drawing.Point(191, 114);
            this.TxtYeniSifreTekrar.Name = "TxtYeniSifreTekrar";
            this.TxtYeniSifreTekrar.Size = new System.Drawing.Size(153, 20);
            this.TxtYeniSifreTekrar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // TxtYeniSifre
            // 
            this.TxtYeniSifre.Location = new System.Drawing.Point(190, 77);
            this.TxtYeniSifre.Name = "TxtYeniSifre";
            this.TxtYeniSifre.Size = new System.Drawing.Size(153, 20);
            this.TxtYeniSifre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // TxtTcNo
            // 
            this.TxtTcNo.Location = new System.Drawing.Point(190, 32);
            this.TxtTcNo.Name = "TxtTcNo";
            this.TxtTcNo.Size = new System.Drawing.Size(153, 20);
            this.TxtTcNo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "TcKimlik No:";
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.Gold;
            this.button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button38.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button38.Location = new System.Drawing.Point(267, 151);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(77, 26);
            this.button38.TabIndex = 102;
            this.button38.Text = "Değiştir";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(42, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 26);
            this.button1.TabIndex = 103;
            this.button1.Text = "Yeni Kullanıcı Ekle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmBilgiIslemKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.TxtYeniSifreTekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtYeniSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTcNo);
            this.Controls.Add(this.label1);
            this.Name = "FrmBilgiIslemKullanici";
            this.Text = "Bilgi İşlem Şifre Değiştirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtYeniSifreTekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtYeniSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button1;
    }
}