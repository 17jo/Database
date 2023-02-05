using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Studentski_projekti.Entiteti;
using Studentski_projekti.Forme;

namespace Studentski_projekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Studentski_projekti.Entiteti.Teorijski p = s.Get<Studentski_projekti.Entiteti.Teorijski>(12121);

                foreach (Literatura o in p.ListaLiteratura)
                {
                    MessageBox.Show(o.Naziv);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void cmdManytoOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Studentski_projekti.Entiteti.Praktican p = s.Load<Studentski_projekti.Entiteti.Praktican>(77777);

                foreach (Izvestaj o in p.ListaIzvestaja)
                {
                    MessageBox.Show(o.Opis);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdTPC_Click(object sender, EventArgs e)
        {
             try
            {
                ISession s = DataLayer.GetSession();

               

                IList<Literatura> proizvodi = s.QueryOver<Literatura>()
                                                .Where(p => p.Naziv== "Osnove relacionih modela")
                                                .List<Literatura>();

                Knjiga o = (Knjiga)proizvodi[0];
                MessageBox.Show(o.Izdavac);                
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Studentski_projekti.Entiteti.Projekat p = s.Load<Studentski_projekti.Entiteti.Projekat>(12121);

                MessageBox.Show(p.Ime_projekta);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdManyToMany_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

               Student r1 = s.Load<Student>(17463);

                foreach (Entiteti.Projekat p1 in r1.Projekti)
                {
                    MessageBox.Show(p1.Ime_projekta);
                }


                Entiteti.Projekat p2 = s.Load<Entiteti.Projekat>(12121);

                foreach (Student r2 in p2.Studenti)
                {
                    MessageBox.Show(r2.Ime);
                }
               
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Studentski_projekti.Entiteti.Predmet p = new Studentski_projekti.Entiteti.Predmet();

                p.Sifra = "998";
                p.Naziv_predmeta = "Proba2";
                p.Semestar = "2012";
                p.Katedra = "na";
                //p.Predmet = "123";

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

        private void cmdCreateOdeljenje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Student r = s.Load<Student>(17463);
                Entiteti.Projekat p = s.Load<Entiteti.Projekat>(12121);

                Odabir ru = new Odabir();
                ru.Id.OdabirStudent= r;
                ru.Id.OdabirProjekat = p;
                ru.Zavrsen = "da";
                ru.Vreme_zavrsetka = DateTime.Now;


                s.Save(ru);

                s.Flush();
                s.Close();

                MessageBox.Show("Dodato");

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

               Izvestaj o = s.Load<Izvestaj>(1);

              
                s.Delete(o);
                

                s.Flush();
                s.Close();
                MessageBox.Show("Obrisan");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Projekat o = s.Load<Projekat>(12123);

            

                o.Ime_projekta= "JAVA";


                //poziva se Update i objekat se povezuje sa novom sesijom
                s.Update(o);

                s.Flush();
                s.Close();
                MessageBox.Show("Update");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdLINQ_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Projekat> projekat = (from o in s.Query<Projekat>()
                                              where (o.Godina == "2019" && o.Grupni_rad == "Ne")
                                              select o).ToList<Projekat>();

                foreach (Projekat o in projekat)
                {
                    MessageBox.Show(o.JID.ToString());
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdQuery_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Projekat");

                IList<Projekat> projekti = q.List<Projekat>();

                foreach (Projekat o in projekti)
                {
                    MessageBox.Show(o.Ime_projekta);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Studentski_projekti.Entiteti.Knjiga p = new Studentski_projekti.Entiteti.Knjiga();

                p.Naziv = "probaProba";
                p.Teorijski = s.Load<Teorijski>(12121);
                p.Izdavac = "Proba";
                p.ISBN = 1230;
                p.Godina_izdavanja = "2022";

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                IList<Literatura> lit = (from o1 in s.Query<Literatura>()
                                              where (o1.Naziv == "Osnove relacionih modela")
                                              select o1).ToList<Literatura>();

                int literatura = lit[0].Id_literature;

                Knjiga o = s.Load<Knjiga>(literatura);

                Literatura l = s.Load<Literatura>(literatura);

                s.Delete(o);
                s.Delete(l);

                s.Flush();
                s.Close();
                MessageBox.Show("Obrisan");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

    }
}
