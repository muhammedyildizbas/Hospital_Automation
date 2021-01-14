namespace WindowsFormsApp1
{
    partial class FrmRandevuSilme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.randevuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_AutomationDataSet7 = new WindowsFormsApp1.Hospital_AutomationDataSet7();
            this.randevularTableAdapter = new WindowsFormsApp1.Hospital_AutomationDataSet7TableAdapters.RandevularTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.TxtTcNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRandevuId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_AutomationDataSet7)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 253);
            this.dataGridView1.TabIndex = 0;
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
            // randevularBindingSource
            // 
            this.randevularBindingSource.DataMember = "Randevular";
            this.randevularBindingSource.DataSource = this.hospital_AutomationDataSet7;
            // 
            // hospital_AutomationDataSet7
            // 
            this.hospital_AutomationDataSet7.DataSetName = "Hospital_AutomationDataSet7";
            this.hospital_AutomationDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevularTableAdapter
            // 
            this.randevularTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "T.C. Kimlik No:";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(270, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 26);
            this.button8.TabIndex = 30;
            this.button8.Text = "Sorgula";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // TxtTcNo
            // 
            this.TxtTcNo.Location = new System.Drawing.Point(120, 46);
            this.TxtTcNo.Name = "TxtTcNo";
            this.TxtTcNo.Size = new System.Drawing.Size(144, 20);
            this.TxtTcNo.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(565, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 26);
            this.button1.TabIndex = 33;
            this.button1.Text = "Randevuyu Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(379, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Randevu Id:";
            // 
            // TxtRandevuId
            // 
            this.TxtRandevuId.Location = new System.Drawing.Point(468, 45);
            this.TxtRandevuId.Name = "TxtRandevuId";
            this.TxtRandevuId.Size = new System.Drawing.Size(91, 20);
            this.TxtRandevuId.TabIndex = 109;
            // 
            // FrmRandevuSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 369);
            this.Controls.Add(this.TxtRandevuId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.TxtTcNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmRandevuSilme";
            this.Text = "Randevu Silme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_AutomationDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Hospital_AutomationDataSet7 hospital_AutomationDataSet7;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private Hospital_AutomationDataSet7TableAdapters.RandevularTableAdapter randevularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox TxtTcNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRandevuId;
    }
}