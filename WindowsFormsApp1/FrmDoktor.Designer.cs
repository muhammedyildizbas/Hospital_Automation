namespace WindowsFormsApp1
{
    partial class FrmDoktor
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPolAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDoktorAd = new System.Windows.Forms.Label();
            this.button38 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CmbDoktorNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hospital_AutomationDataSet2 = new WindowsFormsApp1.Hospital_AutomationDataSet2();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.randevularTableAdapter = new WindowsFormsApp1.Hospital_AutomationDataSet2TableAdapters.RandevularTableAdapter();
            this.randevuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_AutomationDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Poliklinik Adı:";
            // 
            // lblPolAd
            // 
            this.lblPolAd.AutoSize = true;
            this.lblPolAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPolAd.Location = new System.Drawing.Point(112, 22);
            this.lblPolAd.Name = "lblPolAd";
            this.lblPolAd.Size = new System.Drawing.Size(128, 18);
            this.lblPolAd.TabIndex = 10;
            this.lblPolAd.Text = "Ağız ve Diş Sağlığı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(270, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Doktor:";
            // 
            // lblDoktorAd
            // 
            this.lblDoktorAd.AutoSize = true;
            this.lblDoktorAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorAd.Location = new System.Drawing.Point(333, 23);
            this.lblDoktorAd.Name = "lblDoktorAd";
            this.lblDoktorAd.Size = new System.Drawing.Size(92, 18);
            this.lblDoktorAd.TabIndex = 12;
            this.lblDoktorAd.Text = "Gamze Adalı";
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button38.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button38.Location = new System.Drawing.Point(231, 52);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(126, 26);
            this.button38.TabIndex = 103;
            this.button38.Text = "Randevuları Getir";
            this.button38.UseVisualStyleBackColor = false;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(638, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 26);
            this.button1.TabIndex = 104;
            this.button1.Text = "İlaç Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(520, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 26);
            this.button2.TabIndex = 105;
            this.button2.Text = "Muayene Kaydı";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CmbDoktorNo
            // 
            this.CmbDoktorNo.FormattingEnabled = true;
            this.CmbDoktorNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CmbDoktorNo.Location = new System.Drawing.Point(134, 55);
            this.CmbDoktorNo.Name = "CmbDoktorNo";
            this.CmbDoktorNo.Size = new System.Drawing.Size(91, 21);
            this.CmbDoktorNo.TabIndex = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 106;
            this.label5.Text = "Doktor Numara:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuIdDataGridViewTextBoxColumn,
            this.doktorIdDataGridViewTextBoxColumn,
            this.randevuTarihiDataGridViewTextBoxColumn,
            this.tcNoDataGridViewTextBoxColumn,
            this.randevuSaatiDataGridViewTextBoxColumn,
            this.polidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.randevularBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 222);
            this.dataGridView1.TabIndex = 108;
            // 
            // hospital_AutomationDataSet2
            // 
            this.hospital_AutomationDataSet2.DataSetName = "Hospital_AutomationDataSet2";
            this.hospital_AutomationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevularBindingSource
            // 
            this.randevularBindingSource.DataMember = "Randevular";
            this.randevularBindingSource.DataSource = this.hospital_AutomationDataSet2;
            // 
            // randevularTableAdapter
            // 
            this.randevularTableAdapter.ClearBeforeFill = true;
            // 
            // randevuIdDataGridViewTextBoxColumn
            // 
            this.randevuIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.randevuIdDataGridViewTextBoxColumn.DataPropertyName = "RandevuId";
            this.randevuIdDataGridViewTextBoxColumn.HeaderText = "RandevuId";
            this.randevuIdDataGridViewTextBoxColumn.Name = "randevuIdDataGridViewTextBoxColumn";
            this.randevuIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorIdDataGridViewTextBoxColumn
            // 
            this.doktorIdDataGridViewTextBoxColumn.DataPropertyName = "DoktorId";
            this.doktorIdDataGridViewTextBoxColumn.HeaderText = "DoktorId";
            this.doktorIdDataGridViewTextBoxColumn.Name = "doktorIdDataGridViewTextBoxColumn";
            // 
            // randevuTarihiDataGridViewTextBoxColumn
            // 
            this.randevuTarihiDataGridViewTextBoxColumn.DataPropertyName = "RandevuTarihi";
            this.randevuTarihiDataGridViewTextBoxColumn.HeaderText = "RandevuTarihi";
            this.randevuTarihiDataGridViewTextBoxColumn.Name = "randevuTarihiDataGridViewTextBoxColumn";
            // 
            // tcNoDataGridViewTextBoxColumn
            // 
            this.tcNoDataGridViewTextBoxColumn.DataPropertyName = "TcNo";
            this.tcNoDataGridViewTextBoxColumn.HeaderText = "TcNo";
            this.tcNoDataGridViewTextBoxColumn.Name = "tcNoDataGridViewTextBoxColumn";
            // 
            // randevuSaatiDataGridViewTextBoxColumn
            // 
            this.randevuSaatiDataGridViewTextBoxColumn.DataPropertyName = "RandevuSaati";
            this.randevuSaatiDataGridViewTextBoxColumn.HeaderText = "RandevuSaati";
            this.randevuSaatiDataGridViewTextBoxColumn.Name = "randevuSaatiDataGridViewTextBoxColumn";
            // 
            // polidDataGridViewTextBoxColumn
            // 
            this.polidDataGridViewTextBoxColumn.DataPropertyName = "Pol_id";
            this.polidDataGridViewTextBoxColumn.HeaderText = "Pol_id";
            this.polidDataGridViewTextBoxColumn.Name = "polidDataGridViewTextBoxColumn";
            // 
            // FrmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 352);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmbDoktorNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.lblDoktorAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPolAd);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoktor";
            this.Text = "Doktor Randevu Ekranı";
            this.Load += new System.EventHandler(this.FrmDoktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_AutomationDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPolAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDoktorAd;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CmbDoktorNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Hospital_AutomationDataSet2 hospital_AutomationDataSet2;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private Hospital_AutomationDataSet2TableAdapters.RandevularTableAdapter randevularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polidDataGridViewTextBoxColumn;
    }
}