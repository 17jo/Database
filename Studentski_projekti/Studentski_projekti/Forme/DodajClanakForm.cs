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
    public partial class DodajClanakForm : Form
    {
        public DodajClanakForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int teorijski = (int)ndTeorijski.Value;
            string naziv = tbNaziv.Text;
           
            int god = (int)ndGodina.Value;
            string godina = god.ToString();

            int br = (int)ndBroj.Value;
            string broj = br.ToString();

            int is1 = (int)ndISSN.Value;
            string ISSN = is1.ToString();

            string imeCasopisa = tbImeCasopisa.Text;
            try
            {
                NHibernate.ISession s = DataLayer.GetSession();

                Studentski_projekti.Entiteti.Clanci p = new Studentski_projekti.Entiteti.Clanci();
                Studentski_projekti.Entiteti.Teorijski teor = s.Load<Studentski_projekti.Entiteti.Teorijski>(teorijski);
                    
                if(teor.JID>0) p.Teorijski = teor;
                else MessageBox.Show("Pogresan unos teorijskog dela");

                if (naziv.CompareTo("") == 0) { MessageBox.Show("Niste uneli naziv knjige"); }
                else p.Naziv = naziv;

                
               

                if (godina.CompareTo("") == 0) { MessageBox.Show("Niste uneli godinu"); }
                else p.Godina = godina;

                if (broj.CompareTo("") == 0) { MessageBox.Show("Niste uneli broj"); }
                else p.Broj= br;

                if (ISSN.CompareTo("") == 0) { MessageBox.Show("Niste uneli ISSN"); }
                else p.ISSN= is1;

                if (imeCasopisa.CompareTo("") == 0) { MessageBox.Show("Niste uneli ime casopisa"); }
                else p.Ime_casopisa = imeCasopisa;

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
