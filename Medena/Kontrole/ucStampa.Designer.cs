namespace Medena.Kontrole
{
    partial class ucStampa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStampa));
            this.labelSifra = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelCena = new System.Windows.Forms.Label();
            this.labelAkcija = new System.Windows.Forms.Label();
            this.labelSifArt = new System.Windows.Forms.Label();
            this.labelNazArt = new System.Windows.Forms.Label();
            this.labelCenaArt = new System.Windows.Forms.Label();
            this.labelAkcijaArt = new System.Windows.Forms.Label();
            this.buttonStampajArtikal = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelZaStampu = new System.Windows.Forms.Panel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panelZaStampu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSifra.Location = new System.Drawing.Point(80, 50);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Padding = new System.Windows.Forms.Padding(10);
            this.labelSifra.Size = new System.Drawing.Size(69, 40);
            this.labelSifra.TabIndex = 0;
            this.labelSifra.Text = "Šifra:";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaziv.Location = new System.Drawing.Point(73, 90);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Padding = new System.Windows.Forms.Padding(10);
            this.labelNaziv.Size = new System.Drawing.Size(76, 40);
            this.labelNaziv.TabIndex = 1;
            this.labelNaziv.Text = "Naziv:";
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCena.Location = new System.Drawing.Point(80, 130);
            this.labelCena.Name = "labelCena";
            this.labelCena.Padding = new System.Windows.Forms.Padding(10);
            this.labelCena.Size = new System.Drawing.Size(73, 40);
            this.labelCena.TabIndex = 2;
            this.labelCena.Text = "Cena:";
            // 
            // labelAkcija
            // 
            this.labelAkcija.AutoSize = true;
            this.labelAkcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAkcija.Location = new System.Drawing.Point(73, 169);
            this.labelAkcija.Name = "labelAkcija";
            this.labelAkcija.Padding = new System.Windows.Forms.Padding(10);
            this.labelAkcija.Size = new System.Drawing.Size(132, 40);
            this.labelAkcija.TabIndex = 3;
            this.labelAkcija.Text = "Akcijska cena";
            // 
            // labelSifArt
            // 
            this.labelSifArt.AutoSize = true;
            this.labelSifArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSifArt.Location = new System.Drawing.Point(218, 53);
            this.labelSifArt.Name = "labelSifArt";
            this.labelSifArt.Padding = new System.Windows.Forms.Padding(10);
            this.labelSifArt.Size = new System.Drawing.Size(84, 45);
            this.labelSifArt.TabIndex = 4;
            this.labelSifArt.Text = "label1";
            // 
            // labelNazArt
            // 
            this.labelNazArt.AutoSize = true;
            this.labelNazArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazArt.Location = new System.Drawing.Point(218, 92);
            this.labelNazArt.Name = "labelNazArt";
            this.labelNazArt.Padding = new System.Windows.Forms.Padding(10);
            this.labelNazArt.Size = new System.Drawing.Size(84, 45);
            this.labelNazArt.TabIndex = 5;
            this.labelNazArt.Text = "label2";
            // 
            // labelCenaArt
            // 
            this.labelCenaArt.AutoSize = true;
            this.labelCenaArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCenaArt.Location = new System.Drawing.Point(218, 133);
            this.labelCenaArt.Name = "labelCenaArt";
            this.labelCenaArt.Padding = new System.Windows.Forms.Padding(10);
            this.labelCenaArt.Size = new System.Drawing.Size(84, 45);
            this.labelCenaArt.TabIndex = 6;
            this.labelCenaArt.Text = "label3";
            // 
            // labelAkcijaArt
            // 
            this.labelAkcijaArt.AutoSize = true;
            this.labelAkcijaArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAkcijaArt.Location = new System.Drawing.Point(218, 173);
            this.labelAkcijaArt.Name = "labelAkcijaArt";
            this.labelAkcijaArt.Padding = new System.Windows.Forms.Padding(10);
            this.labelAkcijaArt.Size = new System.Drawing.Size(84, 45);
            this.labelAkcijaArt.TabIndex = 7;
            this.labelAkcijaArt.Text = "label4";
            // 
            // buttonStampajArtikal
            // 
            this.buttonStampajArtikal.Location = new System.Drawing.Point(77, 314);
            this.buttonStampajArtikal.Name = "buttonStampajArtikal";
            this.buttonStampajArtikal.Size = new System.Drawing.Size(225, 34);
            this.buttonStampajArtikal.TabIndex = 8;
            this.buttonStampajArtikal.Text = "Stampaj";
            this.buttonStampajArtikal.UseVisualStyleBackColor = true;
            this.buttonStampajArtikal.Click += new System.EventHandler(this.buttonStampajArtikal_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // panelZaStampu
            // 
            this.panelZaStampu.Controls.Add(this.buttonStampajArtikal);
            this.panelZaStampu.Controls.Add(this.labelAkcijaArt);
            this.panelZaStampu.Controls.Add(this.labelNazArt);
            this.panelZaStampu.Controls.Add(this.labelCenaArt);
            this.panelZaStampu.Controls.Add(this.labelSifra);
            this.panelZaStampu.Controls.Add(this.labelNaziv);
            this.panelZaStampu.Controls.Add(this.labelSifArt);
            this.panelZaStampu.Controls.Add(this.labelCena);
            this.panelZaStampu.Controls.Add(this.labelAkcija);
            this.panelZaStampu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZaStampu.Location = new System.Drawing.Point(0, 0);
            this.panelZaStampu.Name = "panelZaStampu";
            this.panelZaStampu.Size = new System.Drawing.Size(378, 399);
            this.panelZaStampu.TabIndex = 9;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ucStampa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelZaStampu);
            this.Name = "ucStampa";
            this.Size = new System.Drawing.Size(378, 399);
            this.panelZaStampu.ResumeLayout(false);
            this.panelZaStampu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.Label labelAkcija;
        private System.Windows.Forms.Label labelSifArt;
        private System.Windows.Forms.Label labelNazArt;
        private System.Windows.Forms.Label labelCenaArt;
        private System.Windows.Forms.Label labelAkcijaArt;
        private System.Windows.Forms.Button buttonStampajArtikal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panelZaStampu;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
