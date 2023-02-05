
namespace Studentski_projekti
{
    partial class Form1
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
            this.cmdTPC = new System.Windows.Forms.Button();
            this.cmdManyToMany = new System.Windows.Forms.Button();
            this.cmdCreateOdeljenje = new System.Windows.Forms.Button();
            this.cmdOneToMany = new System.Windows.Forms.Button();
            this.cmdManytoOne = new System.Windows.Forms.Button();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.cmdRead = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdLINQ = new System.Windows.Forms.Button();
            this.cmdQuery = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdTPC
            // 
            this.cmdTPC.Location = new System.Drawing.Point(32, 256);
            this.cmdTPC.Margin = new System.Windows.Forms.Padding(4);
            this.cmdTPC.Name = "cmdTPC";
            this.cmdTPC.Size = new System.Drawing.Size(361, 28);
            this.cmdTPC.TabIndex = 43;
            this.cmdTPC.Text = "Table-per-Class inheritance";
            this.cmdTPC.UseVisualStyleBackColor = true;
            this.cmdTPC.Click += new System.EventHandler(this.cmdTPC_Click);
            // 
            // cmdManyToMany
            // 
            this.cmdManyToMany.Location = new System.Drawing.Point(32, 220);
            this.cmdManyToMany.Margin = new System.Windows.Forms.Padding(4);
            this.cmdManyToMany.Name = "cmdManyToMany";
            this.cmdManyToMany.Size = new System.Drawing.Size(361, 28);
            this.cmdManyToMany.TabIndex = 40;
            this.cmdManyToMany.Text = "Prikaz odabranog Studenta i Projekata(HasManytoMany)";
            this.cmdManyToMany.UseVisualStyleBackColor = true;
            this.cmdManyToMany.Click += new System.EventHandler(this.cmdManyToMany_Click);
            // 
            // cmdCreateOdeljenje
            // 
            this.cmdCreateOdeljenje.Location = new System.Drawing.Point(32, 183);
            this.cmdCreateOdeljenje.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreateOdeljenje.Name = "cmdCreateOdeljenje";
            this.cmdCreateOdeljenje.Size = new System.Drawing.Size(361, 28);
            this.cmdCreateOdeljenje.TabIndex = 39;
            this.cmdCreateOdeljenje.Text = "Kreiranje odabira(Student-Predmet N:M)";
            this.cmdCreateOdeljenje.UseVisualStyleBackColor = true;
            this.cmdCreateOdeljenje.Click += new System.EventHandler(this.cmdCreateOdeljenje_Click);
            // 
            // cmdOneToMany
            // 
            this.cmdOneToMany.Location = new System.Drawing.Point(32, 146);
            this.cmdOneToMany.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOneToMany.Name = "cmdOneToMany";
            this.cmdOneToMany.Size = new System.Drawing.Size(361, 28);
            this.cmdOneToMany.TabIndex = 38;
            this.cmdOneToMany.Text = "Ucitavanje podataka o teorijskom delu";
            this.cmdOneToMany.UseVisualStyleBackColor = true;
            this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
            // 
            // cmdManytoOne
            // 
            this.cmdManytoOne.Location = new System.Drawing.Point(32, 109);
            this.cmdManytoOne.Margin = new System.Windows.Forms.Padding(4);
            this.cmdManytoOne.Name = "cmdManytoOne";
            this.cmdManytoOne.Size = new System.Drawing.Size(361, 28);
            this.cmdManytoOne.TabIndex = 37;
            this.cmdManytoOne.Text = "Ucitavanje podataka o prakticnom delu";
            this.cmdManytoOne.UseVisualStyleBackColor = true;
            this.cmdManytoOne.Click += new System.EventHandler(this.cmdManytoOne_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(32, 75);
            this.cmdCreate.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(361, 28);
            this.cmdCreate.TabIndex = 36;
            this.cmdCreate.Text = "Dodavanje novog predmeta";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // cmdRead
            // 
            this.cmdRead.Location = new System.Drawing.Point(32, 39);
            this.cmdRead.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(361, 28);
            this.cmdRead.TabIndex = 35;
            this.cmdRead.Text = "Ucitavanje podataka o projektu";
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(32, 292);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(361, 28);
            this.cmdDelete.TabIndex = 44;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(32, 328);
            this.cmdUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(361, 28);
            this.cmdUpdate.TabIndex = 45;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdLINQ
            // 
            this.cmdLINQ.Location = new System.Drawing.Point(32, 364);
            this.cmdLINQ.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLINQ.Name = "cmdLINQ";
            this.cmdLINQ.Size = new System.Drawing.Size(361, 28);
            this.cmdLINQ.TabIndex = 46;
            this.cmdLINQ.Text = "LINQ";
            this.cmdLINQ.UseVisualStyleBackColor = true;
            this.cmdLINQ.Click += new System.EventHandler(this.cmdLINQ_Click);
            // 
            // cmdQuery
            // 
            this.cmdQuery.Location = new System.Drawing.Point(32, 401);
            this.cmdQuery.Margin = new System.Windows.Forms.Padding(4);
            this.cmdQuery.Name = "cmdQuery";
            this.cmdQuery.Size = new System.Drawing.Size(361, 28);
            this.cmdQuery.TabIndex = 47;
            this.cmdQuery.Text = "Krieranje upita";
            this.cmdQuery.UseVisualStyleBackColor = true;
            this.cmdQuery.Click += new System.EventHandler(this.cmdQuery_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(361, 30);
            this.button1.TabIndex = 54;
            this.button1.Text = "DodajKnjigu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(361, 33);
            this.button2.TabIndex = 55;
            this.button2.Text = "ObrisiKnjigu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 567);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdQuery);
            this.Controls.Add(this.cmdLINQ);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdTPC);
            this.Controls.Add(this.cmdManyToMany);
            this.Controls.Add(this.cmdCreateOdeljenje);
            this.Controls.Add(this.cmdOneToMany);
            this.Controls.Add(this.cmdManytoOne);
            this.Controls.Add(this.cmdCreate);
            this.Controls.Add(this.cmdRead);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdTPC;
        private System.Windows.Forms.Button cmdManyToMany;
        private System.Windows.Forms.Button cmdCreateOdeljenje;
        private System.Windows.Forms.Button cmdOneToMany;
        private System.Windows.Forms.Button cmdManytoOne;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdLINQ;
        private System.Windows.Forms.Button cmdQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

