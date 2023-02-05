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
    public partial class DodajStudentForm : Form
    {
        public ComboBox combox;
        public DodajStudentForm()
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
            int brIndeksa = (int)numericUpDown1.Value;
            string ime = tbIme.Text;
            string imeRoditelja = tbImeRoditelja.Text;
            string prezime = tbPrezime.Text;
            string smer = cb.Text;

            try
            {
                NHibernate.ISession s = DataLayer.GetSession();


                Studentski_projekti.Entiteti.Student p = new Studentski_projekti.Entiteti.Student();
                

                p.Broj_indeksa = brIndeksa;
                p.Ime = ime;
                p.Ime_roditelja = imeRoditelja;
                p.Prezime = prezime;
                p.Smer = smer;

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

        private void tbImeRoditelja_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
