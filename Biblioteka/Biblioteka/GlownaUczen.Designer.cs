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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgKsiazki = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKsiazki)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(349, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Książki do zwrócenia";
            // 
            // dtgKsiazki
            // 
            this.dtgKsiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKsiazki.Location = new System.Drawing.Point(12, 95);
            this.dtgKsiazki.Name = "dtgKsiazki";
            this.dtgKsiazki.Size = new System.Drawing.Size(872, 460);
            this.dtgKsiazki.TabIndex = 1;
            // 
            // GlownaUczen
            // 
            this.ClientSize = new System.Drawing.Size(896, 567);
            this.Controls.Add(this.dtgKsiazki);
            this.Controls.Add(this.label1);
            this.Name = "GlownaUczen";
            this.Load += new System.EventHandler(this.GlownaUczen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKsiazki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgKsiazki;
    }
}