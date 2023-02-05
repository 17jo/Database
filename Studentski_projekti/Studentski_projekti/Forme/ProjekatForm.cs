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
    public partial class ProjekatForm : Form
    {
        public ProjekatForm()
        {
            InitializeComponent();
        }

        private void btnDodajProjekat_Click(object sender, EventArgs e)
        {
            DodajProjekatForm dp = new DodajProjekatForm();
            dp.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ObrisiProjekatForm op = new ObrisiProjekatForm();
            op.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            IzmeniProjekatForm ip = new IzmeniProjekatForm();
            ip.ShowDialog();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Projekat");

                IList<Projekat> projekti = q.List<Projekat>();
                listProjekti.Items.Clear();
                foreach (Projekat o in projekti)
                {
                    ListViewItem item = new ListViewItem(new string[] { o.JID.ToString(), o.Ime_projekta,
                    o.Godina,o.Grupni_rad, o.Predmet.Sifra});
                    listProjekti.Items.Add(item);
                }

                listProjekti.Refresh();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
