
namespace Biblioteka
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tNazwa = new System.Windows.Forms.TextBox();
            this.tHaslo = new System.Windows.Forms.TextBox();
            this.bLog = new System.Windows.Forms.Button();
            this.bRej = new System.Windows.Forms.Button();
            this.lBlad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(287, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa Użytkownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(287, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło";
            // 
            // tNazwa
            // 
            this.tNazwa.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tNazwa.Location = new System.Drawing.Point(291, 117);
            this.tNazwa.Name = "tNazwa";
            this.tNazwa.Size = new System.Drawing.Size(228, 21);
            this.tNazwa.TabIndex = 2;
            // 
            // tHaslo
            // 
            this.tHaslo.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tHaslo.Location = new System.Drawing.Point(291, 209);
            this.tHaslo.Name = "tHaslo";
            this.tHaslo.PasswordChar = '*';
            this.tHaslo.Size = new System.Drawing.Size(228, 21);
            this.tHaslo.TabIndex = 3;
            // 
            // bLog
            // 
            this.bLog.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLog.Location = new System.Drawing.Point(444, 250);
            this.bLog.Name = "bLog";
            this.bLog.Size = new System.Drawing.Size(75, 23);
            this.bLog.TabIndex = 4;
            this.bLog.Text = "Loguj";
            this.bLog.UseVisualStyleBackColor = true;
            this.bLog.Click += new System.EventHandler(this.bLog_Click);
            // 
            // bRej
            // 
            this.bRej.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bRej.Location = new System.Drawing.Point(291, 250);
            this.bRej.Name = "bRej";
            this.bRej.Size = new System.Drawing.Size(89, 23);
            this.bRej.TabIndex = 5;
            this.bRej.Text = "Rejestracja";
            this.bRej.UseVisualStyleBackColor = true;
            this.bRej.Click += new System.EventHandler(this.bRej_Click);
            // 
            // lBlad
            // 
            this.lBlad.AutoSize = true;
            this.lBlad.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBlad.ForeColor = System.Drawing.Color.Red;
            this.lBlad.Location = new System.Drawing.Point(287, 276);
            this.lBlad.Name = "lBlad";
            this.lBlad.Size = new System.Drawing.Size(266, 23);
            this.lBlad.TabIndex = 6;
            this.lBlad.Text = "Niepoprawne hasło lub nazwa";
            this.lBlad.Visible = false;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lBlad);
            this.Controls.Add(this.bRej);
            this.Controls.Add(this.bLog);
            this.Controls.Add(this.tHaslo);
            this.Controls.Add(this.tNazwa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNazwa;
        private System.Windows.Forms.TextBox tHaslo;
        private System.Windows.Forms.Button bLog;
        private System.Windows.Forms.Button bRej;
        private System.Windows.Forms.Label lBlad;
    }
}

