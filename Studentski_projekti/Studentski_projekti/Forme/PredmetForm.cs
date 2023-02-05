using NHibernate;
using Studentski_projekti.Entiteti;
using Studentski_projekti.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Studentski_projekti
{
    public partial class PredmetForm : Form
    {

        public PredmetForm()
        {
            InitializeComponent();
           
        }

        private void PredmetForm_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            DodajPredmetForm pf = new DodajPredmetForm();
            pf.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ObrisiPredmetForm op = new ObrisiPredmetForm();
            op.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            IzmeniPredmetForm ip = new IzmeniPredmetForm();
            ip.ShowDialog();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Predmet");

                IList<Predmet> predmeti = q.List<Predmet>();
                listPredmeti.Items.Clear();
                foreach (Predmet o in predmeti)
                {
                    ListViewItem item = new ListViewItem(new string[] { o.Sifra, o.Naziv_predmeta,
                    o.Katedra,o.Semestar });
                    listPredmeti.Items.Add(item);
                }

                listPredmeti.Refresh();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PredmetForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrikaziPredmetForm pf = new PrikaziPredmetForm();
            pf.ShowDialog();
        }
    }
}
