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
    public partial class IzmeniStudentaForm : Form
    {
        public ComboBox combox;
        public IzmeniStudentaForm()
        {
            InitializeComponent();
            combox = cb;
            cb.Items.Add("RI");
            cb.Items.Add("EKM");
            cb.Items.Add("Elektronika");
            cb.Items.Add("Telekomunikacije");
            cb.Items.Add("Elektroenergetika");
            cb.Items.Add("Upravljanje sistemima");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NHibernate.ISession s = DataLayer.GetSession();

                int brIndeksa = (int)numericUpDown1.Value;
                string ime = tbIme.Text;
                string imeRoditelja = tbImeRoditelja.Text;
                string prezime = tbPrezime.Text;
                string smer = cb.Text;

                Student o = s.Load<Student>(brIndeksa);
                if (brIndeksa == 0) { MessageBox.Show("Niste uneli indeks"); }
                if (ime.CompareTo("") == 0) { }
                else o.Ime = ime;
                if (imeRoditelja.CompareTo("") == 0) { }
                else o.Ime_roditelja = imeRoditelja;
                if (prezime.CompareTo("") == 0) { }
                else o.Prezime = prezime;
                if (smer.CompareTo("") == 0) { }
                else o.Smer = smer;

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
