namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(388, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "Doktor";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::WindowsFormsApp1.Properties.Resources.doktor2;
            this.label3.Location = new System.Drawing.Point(367, 146);
            this.label3.MaximumSize = new System.Drawing.Size(100, 90);
            this.label3.MinimumSize = new System.Drawing.Size(120, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 90);
            this.label3.TabIndex = 5;
            this.label3.Text = "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::WindowsFormsApp1.Properties.Resources.hasta21;
            this.label2.Location = new System.Drawing.Point(57, 131);
            this.label2.MaximumSize = new System.Drawing.Size(100, 80);
            this.label2.MinimumSize = new System.Drawing.Size(130, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 120);
            this.label2.TabIndex = 4;
            this.label2.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::WindowsFormsApp1.Properties.Resources.yönetici3;
            this.label1.Location = new System.Drawing.Point(203, 38);
            this.label1.MaximumSize = new System.Drawing.Size(120, 90);
            this.label1.MinimumSize = new System.Drawing.Size(120, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 100);
            this.label1.TabIndex = 3;
            this.label1.Text = "\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(223, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bilgi İşlem";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(82, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hasta Girişi";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(527, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Hastane Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

