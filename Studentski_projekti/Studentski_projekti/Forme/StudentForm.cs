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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajStudentForm ds = new DodajStudentForm();
            ds.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ObrisiStudentaForm os = new ObrisiStudentaForm();
            os.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            IzmeniStudentaForm os = new IzmeniStudentaForm();
            os.ShowDialog();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Student");

                IList<Student> studenti = q.List<Student>();
                listStudenti.Items.Clear();
                foreach (Student o in studenti)
                {
                    ListViewItem item = new ListViewItem(new string[] { o.Broj_indeksa.ToString(), o.Ime,
                    o.Ime_roditelja,o.Prezime, o.Smer });
                    listStudenti.Items.Add(item);
                }

                listStudenti.Refresh();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
