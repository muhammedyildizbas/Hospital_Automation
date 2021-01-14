namespace WindowsFormsApp1
{
    partial class FrmMuayeneler
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtHstSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtHstAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.hospital_AutomationDataSet1 = new WindowsFormsApp1.Hospital_AutomationDataSet1();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevularTableAdapter = new WindowsFormsApp1.Hospital_AutomationDataSet1TableAdapters.RandevularTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_AutomationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(318, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bilgileri Getir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(150, 110);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(153, 20);
            this.TxtTc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "TcKimlik No:";
            // 
            // TxtHstSoyad
            // 
            this.TxtHstSoyad.Location = new System.Drawing.Point(150, 194);
            this.TxtHstSoyad.Name = "TxtHstSoyad";
            this.TxtHstSoyad.Size = new System.Drawing.Size(153, 20);
            this.TxtHstSoyad.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soyadı:";
            // 
            // TxtHstAd
            // 
            this.TxtHstAd.Location = new System.Drawing.Point(150, 153);
            this.TxtHstAd.Name = "TxtHstAd";
            this.TxtHstAd.Size = new System.Drawing.Size(153, 20);
            this.TxtHstAd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adı:";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(150, 46);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(91, 21);
            this.CmbCinsiyet.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(40, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Doktor Numara:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(150, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(261, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 25);
            this.button3.TabIndex = 14;
            this.button3.Text = "İptal";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // hospital_AutomationDataSet1
            // 
            this.hospital_AutomationDataSet1.DataSetName = "Hospital_AutomationDataSet1";
            this.hospital_AutomationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevularBindingSource
            // 
            this.randevularBindingSource.DataMember = "Randevular";
            this.randevularBindingSource.DataSource = this.hospital_AutomationDataSet1;
            // 
            // randevularTableAdapter
            // 
            this.randevularTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMuayeneler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtHstSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtHstAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.label1);
            this.Name = "FrmMuayeneler";
            this.Text = "Muayeneler";
            this.Load += new System.EventHandler(this.FrmMuayeneler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospital_AutomationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHstSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtHstAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Hospital_AutomationDataSet1 hospital_AutomationDataSet1;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private Hospital_AutomationDataSet1TableAdapters.RandevularTableAdapter randevularTableAdapter;
    }
}