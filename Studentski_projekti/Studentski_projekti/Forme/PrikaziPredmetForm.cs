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
    public partial class PrikaziPredmetForm : Form
    {
        public PrikaziPredmetForm()
        {
            InitializeComponent();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            string naziv = tbNaziv.Text;
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Predmet> predmet= (from o in s.Query<Predmet>()
                                            where (o.Naziv_predmeta.ToLower().CompareTo(naziv.ToLower())==0)
                                            select o).ToList<Predmet>();

                listPredmeti.Items.Clear();
                foreach (Predmet o in predmet)
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
    }
}
