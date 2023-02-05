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
    public partial class IzmeniProjekatForm : Form
    {
        public ComboBox combox;
        public IzmeniProjekatForm()
        {
            InitializeComponent();
            combox = cb;
            cb.Items.Add("Da");
            cb.Items.Add("Ne");
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int jid = (int)numericUpDown1.Value;
            string naziv = tbNaziv.Text;
            string godina = tbGodina.Text;
            string grupniRad = cb.Text;

            try
            {
                NHibernate.ISession s = DataLayer.GetSession();

                string predmet = tbSifraPredmeta.Text;
                Studentski_projekti.Entiteti.Predmet pred = s.Load<Studentski_projekti.Entiteti.Predmet>(predmet);
                
                Projekat o = s.Load<Projekat>(jid);

                if (jid == 0) { MessageBox.Show("Niste uneli JID"); }
                if (naziv.CompareTo("") == 0) { }
                else o.Ime_projekta = naziv;
                if (godina.CompareTo("") == 0) { }
                else o.Godina = godina;
                if (grupniRad.CompareTo("") == 0) { }
                else o.Grupni_rad = grupniRad;
                if (predmet.CompareTo("") == 0) { }
                else o.Predmet = pred;
                
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
