
namespace Biblioteka
{
    partial class GlownaBibliotekarka
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bDodaj = new System.Windows.Forms.Button();
            this.bZwrot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tImie = new System.Windows.Forms.TextBox();
            this.tNazwisko = new System.Windows.Forms.TextBox();
            this.tPesel = new System.Windows.Forms.TextBox();
            this.bSzukaj = new System.Windows.Forms.Button();
            this.dtgKsiazki = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKsiazki)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // bDodaj
            // 
            this.bDodaj.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDodaj.Location = new System.Drawing.Point(669, 397);
            this.bDodaj.Name = "bDodaj";
            this.bDodaj.Size = new System.Drawing.Size(119, 41);
            this.bDodaj.TabIndex = 2;
            this.bDodaj.Text = "Dodaj";
            this.bDodaj.UseVisualStyleBackColor = true;
            this.bDodaj.Click += new System.EventHandler(this.bDodaj_Click);
            // 
            // bZwrot
            // 
            this.bZwrot.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bZwrot.Location = new System.Drawing.Point(12, 397);
            this.bZwrot.Name = "bZwrot";
            this.bZwrot.Size = new System.Drawing.Size(119, 41);
            this.bZwrot.TabIndex = 3;
            this.bZwrot.Text = "Zwrócono";
            this.bZwrot.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(383, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(28, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pesel";
            // 
            // tImie
            // 
            this.tImie.Location = new System.Drawing.Point(80, 12);
            this.tImie.Name = "tImie";
            this.tImie.Size = new System.Drawing.Size(246, 20);
            this.tImie.TabIndex = 7;
            // 
            // tNazwisko
            // 
            this.tNazwisko.Location = new System.Drawing.Point(481, 14);
            this.tNazwisko.Name = "tNazwisko";
            this.tNazwisko.Size = new System.Drawing.Size(246, 20);
            this.tNazwisko.TabIndex = 8;
            // 
            // tPesel
            // 
            this.tPesel.Location = new System.Drawing.Point(91, 57);
            this.tPesel.Name = "tPesel";
            this.tPesel.Size = new System.Drawing.Size(246, 20);
            this.tPesel.TabIndex = 9;
            // 
            // bSzukaj
            // 
            this.bSzukaj.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSzukaj.Location = new System.Drawing.Point(652, 45);
            this.bSzukaj.Name = "bSzukaj";
            this.bSzukaj.Size = new System.Drawing.Size(75, 32);
            this.bSzukaj.TabIndex = 10;
            this.bSzukaj.Text = "Szukaj";
            this.bSzukaj.UseVisualStyleBackColor = true;
            // 
            // dtgKsiazki
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgKsiazki.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgKsiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKsiazki.Location = new System.Drawing.Point(12, 83);
            this.dtgKsiazki.Name = "dtgKsiazki";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgKsiazki.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgKsiazki.Size = new System.Drawing.Size(784, 294);
            this.dtgKsiazki.TabIndex = 11;
            // 
            // GlownaBibliotekarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.dtgKsiazki);
            this.Controls.Add(this.bSzukaj);
            this.Controls.Add(this.tPesel);
            this.Controls.Add(this.tNazwisko);
            this.Controls.Add(this.tImie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bZwrot);
            this.Controls.Add(this.bDodaj);
            this.Controls.Add(this.label1);
            this.Name = "GlownaBibliotekarka";
            this.Text = "GlownaBibliotekarka";
            this.Load += new System.EventHandler(this.GlownaBibliotekarka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKsiazki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDodaj;
        private System.Windows.Forms.Button bZwrot;      
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tImie;
        private System.Windows.Forms.TextBox tNazwisko;
        private System.Windows.Forms.TextBox tPesel;
        private System.Windows.Forms.Button bSzukaj;
        private System.Windows.Forms.DataGridView dtgKsiazki;
    }
}