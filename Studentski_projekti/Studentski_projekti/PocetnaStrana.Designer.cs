
namespace Studentski_projekti
{
    partial class PocetnaStrana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaStrana));
            this.btnLiteratura = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnProjekat = new System.Windows.Forms.Button();
            this.btnPredmet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLiteratura
            // 
            this.btnLiteratura.Location = new System.Drawing.Point(85, 294);
            this.btnLiteratura.Name = "btnLiteratura";
            this.btnLiteratura.Size = new System.Drawing.Size(149, 43);
            this.btnLiteratura.TabIndex = 60;
            this.btnLiteratura.Text = "LITERATURA";
            this.btnLiteratura.UseVisualStyleBackColor = true;
            this.btnLiteratura.Click += new System.EventHandler(this.btnLiteratura_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(85, 215);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(149, 43);
            this.btnStudent.TabIndex = 59;
            this.btnStudent.Text = "STUDENT";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnProjekat
            // 
            this.btnProjekat.Location = new System.Drawing.Point(85, 134);
            this.btnProjekat.Name = "btnProjekat";
            this.btnProjekat.Size = new System.Drawing.Size(149, 42);
            this.btnProjekat.TabIndex = 58;
            this.btnProjekat.Text = "PROJEKAT";
            this.btnProjekat.UseVisualStyleBackColor = true;
            this.btnProjekat.Click += new System.EventHandler(this.btnProjekat_Click);
            // 
            // btnPredmet
            // 
            this.btnPredmet.Location = new System.Drawing.Point(85, 63);
            this.btnPredmet.Name = "btnPredmet";
            this.btnPredmet.Size = new System.Drawing.Size(149, 42);
            this.btnPredmet.TabIndex = 57;
            this.btnPredmet.Text = "PREDMET";
            this.btnPredmet.UseVisualStyleBackColor = true;
            this.btnPredmet.Click += new System.EventHandler(this.btnPredmet_Click);
            // 
            // PocetnaStrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 443);
            this.Controls.Add(this.btnLiteratura);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnProjekat);
            this.Controls.Add(this.btnPredmet);
            this.Name = "PocetnaStrana";
            this.Text = "PocetnaStrana";
            this.Load += new System.EventHandler(this.PocetnaStrana_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLiteratura;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnProjekat;
        private System.Windows.Forms.Button btnPredmet;
    }
}