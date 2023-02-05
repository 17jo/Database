using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentski_projekti.Forme
{
    public partial class DodajKnjiguForm : Form
    {
        public DodajKnjiguForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int teorijski = (int)numericUpDown1.Value;
            string naziv = tbNaziv.Text;
            string izdavac = tbIzdavac.Text;
            int ISBN = (int)numericUpDown2.Value;
            string godina = tbGodina.Text;

            try
            {
                NHibernate.ISession s = DataLayer.GetSession();

                Studentski_projekti.Entiteti.Knjiga p = new Studentski_projekti.Entiteti.Knjiga();
                Studentski_projekti.Entiteti.Teorijski teor = s.Load<Studentski_projekti.Entiteti.Teorijski>(teorijski);
                
                if(naziv.CompareTo("")==0) { MessageBox.Show("Niste uneli naziv knjige"); }
                else p.Naziv = naziv;
                
                if (teor==null) { MessageBox.Show("Niste uneli teorijski"); }
                else p.Teorijski = teor;
               
                if (izdavac.CompareTo("") == 0) { MessageBox.Show("Niste uneli izdavaca"); }
                else p.Izdavac = izdavac;
                
                if (ISBN == 0) { MessageBox.Show("Niste uneli ISBN"); }
                else  p.ISBN = ISBN;
                
                if (godina.CompareTo("") == 0) { MessageBox.Show("Niste uneli godinu"); }
                else p.Godina_izdavanja = godina;

                s.Save(p);
                s.Flush();

                s.Close();
                MessageBox.Show("Dodato");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbGodina_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIzdavac_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbNaziv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
