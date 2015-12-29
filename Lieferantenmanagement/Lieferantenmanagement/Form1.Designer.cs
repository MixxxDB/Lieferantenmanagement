namespace Lieferantenmanagement
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.tbxAddSupplier = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Lieferantenmanagement.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lieferantenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lieferantenTableAdapter = new Lieferantenmanagement.Database1DataSetTableAdapters.LieferantenTableAdapter();
            this.lieferantenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieferantenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieferantenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(299, 65);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupplier.TabIndex = 0;
            this.btnAddSupplier.Text = "Hinzufügen";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // tbxAddSupplier
            // 
            this.tbxAddSupplier.Location = new System.Drawing.Point(299, 39);
            this.tbxAddSupplier.Name = "tbxAddSupplier";
            this.tbxAddSupplier.Size = new System.Drawing.Size(100, 20);
            this.tbxAddSupplier.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lieferantenIdDataGridViewTextBoxColumn,
            this.lieferantenNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lieferantenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(299, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // lieferantenBindingSource
            // 
            this.lieferantenBindingSource.DataMember = "Lieferanten";
            this.lieferantenBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // lieferantenTableAdapter
            // 
            this.lieferantenTableAdapter.ClearBeforeFill = true;
            // 
            // lieferantenIdDataGridViewTextBoxColumn
            // 
            this.lieferantenIdDataGridViewTextBoxColumn.DataPropertyName = "Lieferanten_Id";
            this.lieferantenIdDataGridViewTextBoxColumn.HeaderText = "Lieferanten_Id";
            this.lieferantenIdDataGridViewTextBoxColumn.Name = "lieferantenIdDataGridViewTextBoxColumn";
            this.lieferantenIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lieferantenNameDataGridViewTextBoxColumn
            // 
            this.lieferantenNameDataGridViewTextBoxColumn.DataPropertyName = "Lieferanten_Name";
            this.lieferantenNameDataGridViewTextBoxColumn.HeaderText = "Lieferanten_Name";
            this.lieferantenNameDataGridViewTextBoxColumn.Name = "lieferantenNameDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 358);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxAddSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lieferantenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TextBox tbxAddSupplier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource lieferantenBindingSource;
        private Database1DataSetTableAdapters.LieferantenTableAdapter lieferantenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieferantenIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieferantenNameDataGridViewTextBoxColumn;
    }
}

