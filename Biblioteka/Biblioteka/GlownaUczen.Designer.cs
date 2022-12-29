
namespace Biblioteka
{
    partial class GlownaUczen
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
            this.bazaDataSet1 = new Biblioteka.BazaDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bazaDataSet = new Biblioteka.BazaDataSet();
            this.wypozyczoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczoneTableAdapter = new Biblioteka.BazaDataSetTableAdapters.WypozyczoneTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wypozyczoneKsiazkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiedyWypozyczonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doKiedyWypozyczoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czyOddanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "D";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.wypozyczoneKsiazkaDataGridViewTextBoxColumn,
            this.kiedyWypozyczonaDataGridViewTextBoxColumn,
            this.doKiedyWypozyczoneDataGridViewTextBoxColumn,
            this.czyOddanaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wypozyczoneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wypozyczoneBindingSource
            // 
            this.wypozyczoneBindingSource.DataMember = "Wypozyczone";
            this.wypozyczoneBindingSource.DataSource = this.bazaDataSet;
            // 
            // wypozyczoneTableAdapter
            // 
            this.wypozyczoneTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // wypozyczoneKsiazkaDataGridViewTextBoxColumn
            // 
            this.wypozyczoneKsiazkaDataGridViewTextBoxColumn.DataPropertyName = "WypozyczoneKsiazka";
            this.wypozyczoneKsiazkaDataGridViewTextBoxColumn.HeaderText = "WypozyczoneKsiazka";
            this.wypozyczoneKsiazkaDataGridViewTextBoxColumn.Name = "wypozyczoneKsiazkaDataGridViewTextBoxColumn";
            // 
            // kiedyWypozyczonaDataGridViewTextBoxColumn
            // 
            this.kiedyWypozyczonaDataGridViewTextBoxColumn.DataPropertyName = "KiedyWypozyczona";
            this.kiedyWypozyczonaDataGridViewTextBoxColumn.HeaderText = "KiedyWypozyczona";
            this.kiedyWypozyczonaDataGridViewTextBoxColumn.Name = "kiedyWypozyczonaDataGridViewTextBoxColumn";
            // 
            // doKiedyWypozyczoneDataGridViewTextBoxColumn
            // 
            this.doKiedyWypozyczoneDataGridViewTextBoxColumn.DataPropertyName = "DoKiedyWypozyczone";
            this.doKiedyWypozyczoneDataGridViewTextBoxColumn.HeaderText = "DoKiedyWypozyczone";
            this.doKiedyWypozyczoneDataGridViewTextBoxColumn.Name = "doKiedyWypozyczoneDataGridViewTextBoxColumn";
            // 
            // czyOddanaDataGridViewTextBoxColumn
            // 
            this.czyOddanaDataGridViewTextBoxColumn.DataPropertyName = "CzyOddana";
            this.czyOddanaDataGridViewTextBoxColumn.HeaderText = "CzyOddana";
            this.czyOddanaDataGridViewTextBoxColumn.Name = "czyOddanaDataGridViewTextBoxColumn";
            // 
            // GlownaUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GlownaUczen";
            this.Text = "Glowna";
            this.Load += new System.EventHandler(this.GlownaUczen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczoneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BazaDataSet bazaDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource wypozyczoneBindingSource;
        private BazaDataSetTableAdapters.WypozyczoneTableAdapter wypozyczoneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wypozyczoneKsiazkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiedyWypozyczonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doKiedyWypozyczoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czyOddanaDataGridViewTextBoxColumn;
    }
}