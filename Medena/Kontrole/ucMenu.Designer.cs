namespace Medena.Kontrole
{
    partial class ucMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrikaziArtikle = new System.Windows.Forms.Button();
            this.buttonDodajNovi = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonStampaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrikaziArtikle
            // 
            this.buttonPrikaziArtikle.Location = new System.Drawing.Point(36, 41);
            this.buttonPrikaziArtikle.Name = "buttonPrikaziArtikle";
            this.buttonPrikaziArtikle.Size = new System.Drawing.Size(120, 40);
            this.buttonPrikaziArtikle.TabIndex = 0;
            this.buttonPrikaziArtikle.Text = "Prikazi artikle\r\n";
            this.buttonPrikaziArtikle.UseVisualStyleBackColor = true;
            this.buttonPrikaziArtikle.Click += new System.EventHandler(this.buttonPrikaziArtikle_Click);
            // 
            // buttonDodajNovi
            // 
            this.buttonDodajNovi.Location = new System.Drawing.Point(36, 105);
            this.buttonDodajNovi.Name = "buttonDodajNovi";
            this.buttonDodajNovi.Size = new System.Drawing.Size(120, 40);
            this.buttonDodajNovi.TabIndex = 1;
            this.buttonDodajNovi.Text = "Dodaj novi ";
            this.buttonDodajNovi.UseVisualStyleBackColor = true;
            this.buttonDodajNovi.Click += new System.EventHandler(this.buttonDodajNovi_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(36, 174);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(120, 40);
            this.buttonIzmeni.TabIndex = 2;
            this.buttonIzmeni.Text = "Izmeni postojeci";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(36, 248);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(120, 40);
            this.buttonObrisi.TabIndex = 3;
            this.buttonObrisi.Text = "Obrisi artikal";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonStampaj
            // 
            this.buttonStampaj.Location = new System.Drawing.Point(36, 395);
            this.buttonStampaj.Name = "buttonStampaj";
            this.buttonStampaj.Size = new System.Drawing.Size(120, 40);
            this.buttonStampaj.TabIndex = 4;
            this.buttonStampaj.Text = "STAMPAJ";
            this.buttonStampaj.UseVisualStyleBackColor = true;
            this.buttonStampaj.Click += new System.EventHandler(this.buttonStampaj_Click);
            // 
            // ucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonStampaj);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodajNovi);
            this.Controls.Add(this.buttonPrikaziArtikle);
            this.Name = "ucMenu";
            this.Size = new System.Drawing.Size(198, 498);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrikaziArtikle;
        private System.Windows.Forms.Button buttonDodajNovi;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonStampaj;
    }
}
