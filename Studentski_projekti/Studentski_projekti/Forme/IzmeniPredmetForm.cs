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

namespace Studentski_projekti
{
    public partial class IzmeniPredmetForm : Form
    {
        public ComboBox combox;
        public IzmeniPredmetForm()
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

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                NHibernate.ISession s = DataLayer.GetSession();

                string sifra = tbSifra.Text;
                string naziv = tbNaziv.Text;
                string katedra = tbKatedra.Text;
                string semestar = cb.Text;

                Predmet o = s.Load<Predmet>(sifra);
                if (sifra.CompareTo("")==0) { MessageBox.Show("Niste uneli sifru"); }
                if (naziv.CompareTo("") == 0) {}
                else o.Naziv_predmeta = naziv;
                if(semestar.CompareTo("") == 0) {}
                else o.Semestar = semestar;
                if(katedra.CompareTo("") == 0) {}
                else   o.Katedra = katedra;

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
    }
}
