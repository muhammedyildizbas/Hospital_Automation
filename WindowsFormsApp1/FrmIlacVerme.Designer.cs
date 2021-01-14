namespace WindowsFormsApp1
{
    partial class FrmIlacVerme
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
            this.hospital_AutomationDataSet3 = new WindowsFormsApp1.Hospital_AutomationDataSet3();
            this.ılaclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilaclarTableAdapter = new WindowsFormsApp1.Hospital_AutomationDataSet3TableAdapters.IlaclarTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TxtIlacAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIlacKod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ılacAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacSirketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılacIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_AutomationDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılaclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ılacAdiDataGridViewTextBoxColumn,
            this.ılacSirketDataGridViewTextBoxColumn,
            this.ılacAdetDataGridViewTextBoxColumn,
            this.ılacKodDataGridViewTextBoxColumn,
            this.ılacIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ılaclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hospital_AutomationDataSet3
            // 
            this.hospital_AutomationDataSet3.DataSetName = "Hospital_AutomationDataSet3";
            this.hospital_AutomationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ılaclarBindingSource
            // 
            this.ılaclarBindingSource.DataMember = "Ilaclar";
            this.ılaclarBindingSource.DataSource = this.hospital_AutomationDataSet3;
            // 
            // ilaclarTableAdapter
            // 
            this.ilaclarTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(634, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 25);
            this.button5.TabIndex = 78;
            this.button5.Text = "Sorgula";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(308, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 25);
            this.button6.TabIndex = 77;
            this.button6.Text = "Sorgula";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TxtIlacAdi
            // 
            this.TxtIlacAdi.Location = new System.Drawing.Point(463, 24);
            this.TxtIlacAdi.Name = "TxtIlacAdi";
            this.TxtIlacAdi.Size = new System.Drawing.Size(153, 20);
            this.TxtIlacAdi.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(399, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 75;
            this.label4.Text = "İlaç Adı:";
            // 
            // TxtIlacKod
            // 
            this.TxtIlacKod.Location = new System.Drawing.Point(136, 24);
            this.TxtIlacKod.Name = "TxtIlacKod";
            this.TxtIlacKod.Size = new System.Drawing.Size(153, 20);
            this.TxtIlacKod.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "İlaç kodu:";
            // 
            // ılacAdiDataGridViewTextBoxColumn
            // 
            this.ılacAdiDataGridViewTextBoxColumn.DataPropertyName = "IlacAdi";
            this.ılacAdiDataGridViewTextBoxColumn.HeaderText = "IlacAdi";
            this.ılacAdiDataGridViewTextBoxColumn.Name = "ılacAdiDataGridViewTextBoxColumn";
            // 
            // ılacSirketDataGridViewTextBoxColumn
            // 
            this.ılacSirketDataGridViewTextBoxColumn.DataPropertyName = "IlacSirket";
            this.ılacSirketDataGridViewTextBoxColumn.HeaderText = "IlacSirket";
            this.ılacSirketDataGridViewTextBoxColumn.Name = "ılacSirketDataGridViewTextBoxColumn";
            // 
            // ılacAdetDataGridViewTextBoxColumn
            // 
            this.ılacAdetDataGridViewTextBoxColumn.DataPropertyName = "IlacAdet";
            this.ılacAdetDataGridViewTextBoxColumn.HeaderText = "IlacAdet";
            this.ılacAdetDataGridViewTextBoxColumn.Name = "ılacAdetDataGridViewTextBoxColumn";
            // 
            // ılacKodDataGridViewTextBoxColumn
            // 
            this.ılacKodDataGridViewTextBoxColumn.DataPropertyName = "IlacKod";
            this.ılacKodDataGridViewTextBoxColumn.HeaderText = "IlacKod";
            this.ılacKodDataGridViewTextBoxColumn.Name = "ılacKodDataGridViewTextBoxColumn";
            // 
            // ılacIdDataGridViewTextBoxColumn
            // 
            this.ılacIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ılacIdDataGridViewTextBoxColumn.DataPropertyName = "IlacId";
            this.ılacIdDataGridViewTextBoxColumn.HeaderText = "IlacId";
            this.ılacIdDataGridViewTextBoxColumn.Name = "ılacIdDataGridViewTextBoxColumn";
            this.ılacIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmIlacVerme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 332);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.TxtIlacAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtIlacKod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmIlacVerme";
            this.Text = "İlaçlar Bilgisi";
            this.Load += new System.EventHandler(this.FrmIlacVerme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_AutomationDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılaclarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Hospital_AutomationDataSet3 hospital_AutomationDataSet3;
        private System.Windows.Forms.BindingSource ılaclarBindingSource;
        private Hospital_AutomationDataSet3TableAdapters.IlaclarTableAdapter ilaclarTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox TxtIlacAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIlacKod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacSirketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılacIdDataGridViewTextBoxColumn;
    }
}