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
    public partial class ObrisiPredmetForm : Form
    {
        public ObrisiPredmetForm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                NHibernate.ISession s = DataLayer.GetSession();
                string sifra = textBox1.Text;
                Predmet o = s.Load<Predmet>(sifra);

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
    }
}
