using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Studentski_projekti.Entiteti;

namespace Studentski_projekti.Forme
{
    public partial class DodajPredmetForm : Form
    {
        public ComboBox combox;
        public DodajPredmetForm()
        {
            InitializeComponent();
            combox = cb;
            cb.Items.Add("Prvi");
            cb.Items.Add("Drugi");
            cb.Items.Add("Treci");
            cb.Items.Add("Cetvrti");
            cb.Items.Add("Peti");
            cb.Items.Add("Sesti");
            cb.Items.Add("Sedmi");
            cb.Items.Add("Osmi");
        }

        private void DodajPredmetForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifra = tbSifra.Text;
            string naziv = tbNaziv.Text;
            string katedra = tbKatedra.Text;
            string semestar = cb.Text;

            try
            {
                NHibernate.ISession s = DataLayer.GetSession();


                Studentski_projekti.Entiteti.Predmet p = new Studentski_projekti.Entiteti.Predmet();

                p.Sifra = sifra;
                p.Naziv_predmeta = naziv;
                p.Semestar = semestar;
                p.Katedra = katedra;
              
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
