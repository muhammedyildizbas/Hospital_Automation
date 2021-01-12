namespace WindowsFormsApp1
{
    partial class FrmPoliklinikEkle
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
            this.TxtPoliklinik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPoliklinikEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPoliklinik
            // 
            this.TxtPoliklinik.Location = new System.Drawing.Point(158, 52);
            this.TxtPoliklinik.Name = "TxtPoliklinik";
            this.TxtPoliklinik.Size = new System.Drawing.Size(169, 20);
            this.TxtPoliklinik.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Poliklinik Adı:";
            // 
            // btnPoliklinikEkle
            // 
            this.btnPoliklinikEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPoliklinikEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPoliklinikEkle.Location = new System.Drawing.Point(261, 82);
            this.btnPoliklinikEkle.Name = "btnPoliklinikEkle";
            this.btnPoliklinikEkle.Size = new System.Drawing.Size(66, 25);
            this.btnPoliklinikEkle.TabIndex = 26;
            this.btnPoliklinikEkle.Text = "Ekle";
            this.btnPoliklinikEkle.UseVisualStyleBackColor = false;
            this.btnPoliklinikEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmPoliklinikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 120);
            this.Controls.Add(this.btnPoliklinikEkle);
            this.Controls.Add(this.TxtPoliklinik);
            this.Controls.Add(this.label1);
            this.Name = "FrmPoliklinikEkle";
            this.Text = "Poliklinik Ekle";
            this.Load += new System.EventHandler(this.FrmPoliklinikEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPoliklinik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPoliklinikEkle;
    }
}