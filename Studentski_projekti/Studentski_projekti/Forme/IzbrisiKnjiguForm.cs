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
    public partial class IzbrisiKnjiguForm : Form
    {
        public IzbrisiKnjiguForm()
        {
            InitializeComponent();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            string naziv = textBox1.Text;
            try
            {
                ISession s = DataLayer.GetSession();


                IList<Literatura> lit = (from o1 in s.Query<Literatura>()
                                         where (o1.Naziv.CompareTo(naziv)==0)
                                         select o1).ToList<Literatura>();
                if (lit == null) MessageBox.Show("Pogresan naziv");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
