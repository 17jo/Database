using NHibernate;
using Studentski_projekti.Entiteti;
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
    public partial class LiteraturaForm : Form
    {
        public LiteraturaForm()
        {
            InitializeComponent();
        }

        private void btnKnjiga_Click(object sender, EventArgs e)
        {
            btnDodajKnjigu.Visible = true;
            btnIzbrisiKnjigu.Visible = true;
            prikazi.Visible = true;
            prikaziClanke.Visible = false;
            prikaziRadove.Visible = false;
            btnDodajRad.Visible = false;
            btnIzbrisiRad.Visible = false;
            btnIzbrisiClanak.Visible = false;
            btnDodajClanak.Visible = false;
            prikazLiterature.Visible = false;

            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Knjiga");

                IList<Knjiga> knjige = q.List<Knjiga>();
                prikazi.Items.Clear();
                foreach (Knjiga o in knjige)
                {
                    ListViewItem item = new ListViewItem(new string[] { o.Id_literature.ToString(), o.ISBN.ToString(),
                    o.Izdavac,o.Godina_izdavanja});
                    prikazi.Items.Add(item);
                }

                prikazi.Refresh();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnClanak_Click(object sender, EventArgs e)
        {
            btnDodajClanak.Visible = true;
            btnIzbrisiClanak.Visible = true;
            prikaziClanke.Visible = true;
            prikazi.Visible = false;
            prikaziRadove.Visible = false;
            btnIzbrisiRad.Visible = false;
            btnDodajRad.Visible = false;
            btnDodajKnjigu.Visible = false;
            btnIzbrisiKnjigu.Visible = false;
            prikazLiterature.Visible = false;

            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Clanci");


                IList<Clanci> clanci = q.List<Clanci>();
                prikaziClanke.Items.Clear();
                foreach (Clanci o in clanci)
                {
                    ListViewItem item = new ListViewItem(new string[] { o.Id_literature.ToString(), o.Broj.ToString(),
                    o.ISSN.ToString(),o.Ime_casopisa, o.Godina});
                    prikaziClanke.Items.Add(item);
                }

                prikaziClanke.Refresh();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void prikaziClanke_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRadovi_Click(object sender, EventArgs e)
        {
            btnDodajClanak.Visible = false;
            btnIzbrisiClanak.Visible = false;
            prikaziClanke.Visible = false;
            prikazi.Visible = false;
            btnDodajKnjigu.Visible = false;
            btnIzbrisiKnjigu.Visible = false;

            prikaziRadove.Visible = true;
            btnIzbrisiRad.Visible = true;
            btnDodajRad.Visible = true;

            prikazLiterature.Visible = false;
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Radovi");


                IList<Radovi> radovi = q.List<Radovi>();
                prikaziRadove.Items.Clear();
                foreach (Radovi o in radovi)
                {
                    ListViewItem item = new ListViewItem(new string[] { o.Id_literature.ToString(), o.Format.ToString(),
                    o.Web_adresa.ToString(),o.Konferencija});
                    prikaziRadove.Items.Add(item);
                }

                prikaziRadove.Refresh();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            DodajKnjiguForm dk = new DodajKnjiguForm();
            dk.ShowDialog();
        }

        private void btnIzbrisiKnjigu_Click(object sender, EventArgs e)
        {
            IzbrisiKnjiguForm ik = new IzbrisiKnjiguForm();
            ik.ShowDialog();
        }

        private void btnDodajClanak_Click(object sender, EventArgs e)
        {
            DodajClanakForm dc = new DodajClanakForm();
            dc.ShowDialog();
        }

        private void btnIzbrisiClanak_Click(object sender, EventArgs e)
        {
            IzbrisiClanciForm ic = new IzbrisiClanciForm();
            ic.ShowDialog();
        }

        private void btnDodajRad_Click(object sender, EventArgs e)
        {
            DodajRadForm dr = new DodajRadForm();
            dr.ShowDialog();
        }

        private void btnIzbrisiRad_Click(object sender, EventArgs e)
        {
            IzbrisiRadForm ir = new IzbrisiRadForm();
            ir.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnDodajClanak.Visible = false;
            btnIzbrisiClanak.Visible = false;
            prikaziClanke.Visible = false;
            prikazi.Visible = false;
            btnDodajKnjigu.Visible = false;
            btnIzbrisiKnjigu.Visible = false;

            prikaziRadove.Visible = false;
            btnIzbrisiRad.Visible = false;
            btnDodajRad.Visible = false;

            prikazLiterature.Visible = true;
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Literatura");


                IList<Literatura> lit = q.List<Literatura>();
                prikazLiterature.Items.Clear();
                foreach (Literatura o in lit)
                {
                    ListViewItem item = new ListViewItem(new string[] { o.Id_literature.ToString(), o.Naziv.ToString(),
                    o.Teorijski.JID.ToString()});
                    prikazLiterature.Items.Add(item);
                }

                prikazLiterature.Refresh();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

    }
}
