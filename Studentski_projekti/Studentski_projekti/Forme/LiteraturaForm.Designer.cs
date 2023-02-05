
namespace Studentski_projekti.Forme
{
    partial class LiteraturaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiteraturaForm));
            this.btnKnjiga = new System.Windows.Forms.Button();
            this.btnClanak = new System.Windows.Forms.Button();
            this.btnRadovi = new System.Windows.Forms.Button();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.btnIzbrisiKnjigu = new System.Windows.Forms.Button();
            this.btnIzbrisiClanak = new System.Windows.Forms.Button();
            this.btnDodajClanak = new System.Windows.Forms.Button();
            this.btnIzbrisiRad = new System.Windows.Forms.Button();
            this.btnDodajRad = new System.Windows.Forms.Button();
            this.prikazi = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prikaziClanke = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prikaziRadove = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.prikazLiterature = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnKnjiga
            // 
            this.btnKnjiga.Location = new System.Drawing.Point(16, 141);
            this.btnKnjiga.Name = "btnKnjiga";
            this.btnKnjiga.Size = new System.Drawing.Size(75, 42);
            this.btnKnjiga.TabIndex = 0;
            this.btnKnjiga.Text = "Knjige";
            this.btnKnjiga.UseVisualStyleBackColor = true;
            this.btnKnjiga.Click += new System.EventHandler(this.btnKnjiga_Click);
            // 
            // btnClanak
            // 
            this.btnClanak.Location = new System.Drawing.Point(16, 308);
            this.btnClanak.Name = "btnClanak";
            this.btnClanak.Size = new System.Drawing.Size(75, 42);
            this.btnClanak.TabIndex = 1;
            this.btnClanak.Text = "Clanci";
            this.btnClanak.UseVisualStyleBackColor = true;
            this.btnClanak.Click += new System.EventHandler(this.btnClanak_Click);
            // 
            // btnRadovi
            // 
            this.btnRadovi.Location = new System.Drawing.Point(16, 464);
            this.btnRadovi.Name = "btnRadovi";
            this.btnRadovi.Size = new System.Drawing.Size(75, 42);
            this.btnRadovi.TabIndex = 2;
            this.btnRadovi.Text = "Radovi";
            this.btnRadovi.UseVisualStyleBackColor = true;
            this.btnRadovi.Click += new System.EventHandler(this.btnRadovi_Click);
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.Location = new System.Drawing.Point(118, 116);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(75, 47);
            this.btnDodajKnjigu.TabIndex = 3;
            this.btnDodajKnjigu.Text = "Dodaj knjigu";
            this.btnDodajKnjigu.UseVisualStyleBackColor = true;
            this.btnDodajKnjigu.Visible = false;
            this.btnDodajKnjigu.Click += new System.EventHandler(this.btnDodajKnjigu_Click);
            // 
            // btnIzbrisiKnjigu
            // 
            this.btnIzbrisiKnjigu.Location = new System.Drawing.Point(118, 169);
            this.btnIzbrisiKnjigu.Name = "btnIzbrisiKnjigu";
            this.btnIzbrisiKnjigu.Size = new System.Drawing.Size(75, 47);
            this.btnIzbrisiKnjigu.TabIndex = 4;
            this.btnIzbrisiKnjigu.Text = "Izbrisi knjigu";
            this.btnIzbrisiKnjigu.UseVisualStyleBackColor = true;
            this.btnIzbrisiKnjigu.Visible = false;
            this.btnIzbrisiKnjigu.Click += new System.EventHandler(this.btnIzbrisiKnjigu_Click);
            // 
            // btnIzbrisiClanak
            // 
            this.btnIzbrisiClanak.Location = new System.Drawing.Point(118, 328);
            this.btnIzbrisiClanak.Name = "btnIzbrisiClanak";
            this.btnIzbrisiClanak.Size = new System.Drawing.Size(75, 47);
            this.btnIzbrisiClanak.TabIndex = 6;
            this.btnIzbrisiClanak.Text = "Izbrisi clanak";
            this.btnIzbrisiClanak.UseVisualStyleBackColor = true;
            this.btnIzbrisiClanak.Visible = false;
            this.btnIzbrisiClanak.Click += new System.EventHandler(this.btnIzbrisiClanak_Click);
            // 
            // btnDodajClanak
            // 
            this.btnDodajClanak.Location = new System.Drawing.Point(118, 275);
            this.btnDodajClanak.Name = "btnDodajClanak";
            this.btnDodajClanak.Size = new System.Drawing.Size(75, 47);
            this.btnDodajClanak.TabIndex = 5;
            this.btnDodajClanak.Text = "Dodaj clanak";
            this.btnDodajClanak.UseVisualStyleBackColor = true;
            this.btnDodajClanak.Visible = false;
            this.btnDodajClanak.Click += new System.EventHandler(this.btnDodajClanak_Click);
            // 
            // btnIzbrisiRad
            // 
            this.btnIzbrisiRad.Location = new System.Drawing.Point(118, 494);
            this.btnIzbrisiRad.Name = "btnIzbrisiRad";
            this.btnIzbrisiRad.Size = new System.Drawing.Size(75, 47);
            this.btnIzbrisiRad.TabIndex = 8;
            this.btnIzbrisiRad.Text = "Izbrisi rad";
            this.btnIzbrisiRad.UseVisualStyleBackColor = true;
            this.btnIzbrisiRad.Visible = false;
            this.btnIzbrisiRad.Click += new System.EventHandler(this.btnIzbrisiRad_Click);
            // 
            // btnDodajRad
            // 
            this.btnDodajRad.Location = new System.Drawing.Point(118, 441);
            this.btnDodajRad.Name = "btnDodajRad";
            this.btnDodajRad.Size = new System.Drawing.Size(75, 47);
            this.btnDodajRad.TabIndex = 7;
            this.btnDodajRad.Text = "Dodaj rad";
            this.btnDodajRad.UseVisualStyleBackColor = true;
            this.btnDodajRad.Visible = false;
            this.btnDodajRad.Click += new System.EventHandler(this.btnDodajRad_Click);
            // 
            // prikazi
            // 
            this.prikazi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.prikazi.HideSelection = false;
            this.prikazi.Location = new System.Drawing.Point(237, 116);
            this.prikazi.Name = "prikazi";
            this.prikazi.Size = new System.Drawing.Size(814, 425);
            this.prikazi.TabIndex = 9;
            this.prikazi.UseCompatibleStateImageBehavior = false;
            this.prikazi.View = System.Windows.Forms.View.Details;
            this.prikazi.Visible = false;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Literatura_ID";
            this.columnHeader0.Width = 124;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ISBN";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Izdavac";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Godina izdavanja";
            this.columnHeader3.Width = 129;
            // 
            // prikaziClanke
            // 
            this.prikaziClanke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.prikaziClanke.HideSelection = false;
            this.prikaziClanke.Location = new System.Drawing.Point(237, 116);
            this.prikaziClanke.Name = "prikaziClanke";
            this.prikaziClanke.Size = new System.Drawing.Size(814, 425);
            this.prikaziClanke.TabIndex = 10;
            this.prikaziClanke.UseCompatibleStateImageBehavior = false;
            this.prikaziClanke.View = System.Windows.Forms.View.Details;
            this.prikaziClanke.Visible = false;
            this.prikaziClanke.SelectedIndexChanged += new System.EventHandler(this.prikaziClanke_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Literatura_ID";
            this.columnHeader4.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj";
            this.columnHeader5.Width = 52;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ISSN";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ime casopisa";
            this.columnHeader7.Width = 139;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Godina";
            // 
            // prikaziRadove
            // 
            this.prikaziRadove.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.prikaziRadove.HideSelection = false;
            this.prikaziRadove.Location = new System.Drawing.Point(237, 116);
            this.prikaziRadove.Name = "prikaziRadove";
            this.prikaziRadove.Size = new System.Drawing.Size(814, 425);
            this.prikaziRadove.TabIndex = 11;
            this.prikaziRadove.UseCompatibleStateImageBehavior = false;
            this.prikaziRadove.View = System.Windows.Forms.View.Details;
            this.prikaziRadove.Visible = false;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Literatura_ID";
            this.columnHeader9.Width = 96;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Format";
            this.columnHeader10.Width = 112;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Web adresa";
            this.columnHeader11.Width = 215;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Konferencija";
            this.columnHeader12.Width = 108;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Prikazi literature";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prikazLiterature
            // 
            this.prikazLiterature.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.prikazLiterature.HideSelection = false;
            this.prikazLiterature.Location = new System.Drawing.Point(237, 116);
            this.prikazLiterature.Name = "prikazLiterature";
            this.prikazLiterature.Size = new System.Drawing.Size(814, 425);
            this.prikazLiterature.TabIndex = 13;
            this.prikazLiterature.UseCompatibleStateImageBehavior = false;
            this.prikazLiterature.View = System.Windows.Forms.View.Details;
            this.prikazLiterature.Visible = false;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ID";
            this.columnHeader13.Width = 98;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Naziv";
            this.columnHeader14.Width = 113;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Teorijski";
            this.columnHeader15.Width = 128;
            // 
            // LiteraturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 568);
            this.Controls.Add(this.prikazLiterature);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prikaziRadove);
            this.Controls.Add(this.prikaziClanke);
            this.Controls.Add(this.prikazi);
            this.Controls.Add(this.btnIzbrisiRad);
            this.Controls.Add(this.btnDodajRad);
            this.Controls.Add(this.btnIzbrisiClanak);
            this.Controls.Add(this.btnDodajClanak);
            this.Controls.Add(this.btnIzbrisiKnjigu);
            this.Controls.Add(this.btnDodajKnjigu);
            this.Controls.Add(this.btnRadovi);
            this.Controls.Add(this.btnClanak);
            this.Controls.Add(this.btnKnjiga);
            this.Name = "LiteraturaForm";
            this.Text = "LiteraturaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKnjiga;
        private System.Windows.Forms.Button btnClanak;
        private System.Windows.Forms.Button btnRadovi;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.Button btnIzbrisiKnjigu;
        private System.Windows.Forms.Button btnIzbrisiClanak;
        private System.Windows.Forms.Button btnDodajClanak;
        private System.Windows.Forms.Button btnIzbrisiRad;
        private System.Windows.Forms.Button btnDodajRad;
        private System.Windows.Forms.ListView prikazi;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView prikaziClanke;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView prikaziRadove;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView prikazLiterature;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
    }
}