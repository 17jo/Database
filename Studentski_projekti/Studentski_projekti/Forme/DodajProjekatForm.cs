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
    public partial class DodajProjekatForm : Form
    {
        public ComboBox combox;
        public DodajProjekatForm()
        {
            InitializeComponent();
            combox = cb;
            cb.Items.Add("Da");
            cb.Items.Add("Ne");
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int jid = (int)numericUpDown1.Value;
            string naziv = tbNaziv.Text;
            string godina = tbGodina.Text;
            string grupniRad = cb.Text;

            try
            {
                NHibernate.ISession s = DataLayer.GetSession();

                string predmet = tbSifraPredmeta.Text;

                Studentski_projekti.Entiteti.Projekat p = new Studentski_projekti.Entiteti.Projekat();
                Studentski_projekti.Entiteti.Predmet pred = s.Load<Studentski_projekti.Entiteti.Predmet>(predmet);
                if (pred == null) MessageBox.Show("Ne postoji predmet");
                p.JID = jid;
                p.Predmet = pred;
                p.Ime_projekta = naziv;
                p.Godina = godina;
                p.Grupni_rad = grupniRad;

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

        private void DodajProjekatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
