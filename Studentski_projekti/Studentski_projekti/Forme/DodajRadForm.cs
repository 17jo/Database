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
    public partial class DodajRadForm : Form
    {
        public DodajRadForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naziv = tbNaziv.Text;
            int teorijski = (int)numericUpDown1.Value;
            string format = tbFormat.Text;
            string web = tbWeb.Text;
            string konf = tbKonferencija.Text;

            try
            {
                NHibernate.ISession s = DataLayer.GetSession();

                Studentski_projekti.Entiteti.Radovi p = new Studentski_projekti.Entiteti.Radovi();
                Studentski_projekti.Entiteti.Teorijski teor = s.Load<Studentski_projekti.Entiteti.Teorijski>(teorijski);

                if (naziv.CompareTo("") == 0) { MessageBox.Show("Niste uneli naziv knjige"); }
                else p.Naziv = naziv;

                if (teor == null) { MessageBox.Show("Niste uneli teorijski"); }
                else p.Teorijski = teor;

                if (format.CompareTo("") == 0) { MessageBox.Show("Niste uneli format"); }
                else p.Format = format;

                if (web.CompareTo("")==0) { MessageBox.Show("Niste uneli web adresu"); }
                else p.Web_adresa = web;

                if (konf.CompareTo("") == 0) { MessageBox.Show("Niste uneli konferenciju"); }
                else p.Konferencija = konf;

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
    }
}
