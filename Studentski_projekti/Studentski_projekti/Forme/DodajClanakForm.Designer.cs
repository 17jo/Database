
namespace Studentski_projekti.Forme
{
    partial class DodajClanakForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajClanakForm));
            this.ndISSN = new System.Windows.Forms.NumericUpDown();
            this.ndTeorijski = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbImeCasopisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ndGodina = new System.Windows.Forms.NumericUpDown();
            this.ndBroj = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ndISSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndTeorijski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndGodina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // ndISSN
            // 
            this.ndISSN.Location = new System.Drawing.Point(200, 253);
            this.ndISSN.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ndISSN.Name = "ndISSN";
            this.ndISSN.Size = new System.Drawing.Size(120, 22);
            this.ndISSN.TabIndex = 33;
            // 
            // ndTeorijski
            // 
            this.ndTeorijski.Location = new System.Drawing.Point(200, 113);
            this.ndTeorijski.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ndTeorijski.Name = "ndTeorijski";
            this.ndTeorijski.Size = new System.Drawing.Size(120, 22);
            this.ndTeorijski.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ime casopisa:";
            // 
            // tbImeCasopisa
            // 
            this.tbImeCasopisa.Location = new System.Drawing.Point(199, 318);
            this.tbImeCasopisa.Name = "tbImeCasopisa";
            this.tbImeCasopisa.Size = new System.Drawing.Size(121, 22);
            this.tbImeCasopisa.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 52);
            this.button1.TabIndex = 29;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "ISSN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Broj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Teorijski:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Naziv:";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(199, 48);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(121, 22);
            this.tbNaziv.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Godina:";
            // 
            // ndGodina
            // 
            this.ndGodina.Location = new System.Drawing.Point(200, 370);
            this.ndGodina.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ndGodina.Name = "ndGodina";
            this.ndGodina.Size = new System.Drawing.Size(120, 22);
            this.ndGodina.TabIndex = 36;
            // 
            // ndBroj
            // 
            this.ndBroj.Location = new System.Drawing.Point(200, 186);
            this.ndBroj.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ndBroj.Name = "ndBroj";
            this.ndBroj.Size = new System.Drawing.Size(120, 22);
            this.ndBroj.TabIndex = 37;
            // 
            // DodajClanakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 519);
            this.Controls.Add(this.ndBroj);
            this.Controls.Add(this.ndGodina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ndISSN);
            this.Controls.Add(this.ndTeorijski);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbImeCasopisa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNaziv);
            this.Name = "DodajClanakForm";
            this.Text = "DodajClanakForm";
            ((System.ComponentModel.ISupportInitialize)(this.ndISSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndTeorijski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndGodina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndBroj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown ndISSN;
        private System.Windows.Forms.NumericUpDown ndTeorijski;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbImeCasopisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ndGodina;
        private System.Windows.Forms.NumericUpDown ndBroj;
    }
}