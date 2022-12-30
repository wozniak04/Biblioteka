
namespace Biblioteka
{
    partial class DodawanieWypozyczenia
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tImie = new System.Windows.Forms.TextBox();
            this.tNazwisko = new System.Windows.Forms.TextBox();
            this.tTytul = new System.Windows.Forms.TextBox();
            this.Tpesel = new System.Windows.Forms.TextBox();
            this.bDodaj = new System.Windows.Forms.Button();
            
           
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Książka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pesel";
            // 
            // tImie
            // 
            this.tImie.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tImie.Location = new System.Drawing.Point(60, 67);
            this.tImie.Name = "tImie";
            this.tImie.Size = new System.Drawing.Size(266, 21);
            this.tImie.TabIndex = 4;
            // 
            // tNazwisko
            // 
            this.tNazwisko.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tNazwisko.Location = new System.Drawing.Point(110, 113);
            this.tNazwisko.Name = "tNazwisko";
            this.tNazwisko.Size = new System.Drawing.Size(220, 21);
            this.tNazwisko.TabIndex = 5;
            // 
            // tTytul
            // 
            this.tTytul.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tTytul.Location = new System.Drawing.Point(94, 155);
            this.tTytul.Name = "tTytul";
            this.tTytul.Size = new System.Drawing.Size(278, 21);
            this.tTytul.TabIndex = 6;
            // 
            // Tpesel
            // 
           
            this.Tpesel.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tpesel.Location = new System.Drawing.Point(75, 201);
            this.Tpesel.Name = "Tpesel";
            this.Tpesel.Size = new System.Drawing.Size(251, 21);
            this.Tpesel.TabIndex = 7;
            // 
            // bDodaj
            // 
            this.bDodaj.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDodaj.Location = new System.Drawing.Point(297, 271);
            this.bDodaj.Name = "bDodaj";
            this.bDodaj.Size = new System.Drawing.Size(75, 23);
            this.bDodaj.TabIndex = 8;
            this.bDodaj.Text = "Dodaj";
            this.bDodaj.UseVisualStyleBackColor = true;
            this.bDodaj.Click += new System.EventHandler(this.bDodaj_Click);
           
            // 
            // DodawanieWypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDodaj);
            this.Controls.Add(this.Tpesel);
            this.Controls.Add(this.tTytul);
            this.Controls.Add(this.tNazwisko);
            this.Controls.Add(this.tImie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodawanieWypozyczenia";
            this.Text = "DodawanieWypozyczenia";
  
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tImie;
        private System.Windows.Forms.TextBox tNazwisko;
        private System.Windows.Forms.TextBox tTytul;
        private System.Windows.Forms.TextBox Tpesel;
        private System.Windows.Forms.Button bDodaj;
    }
}