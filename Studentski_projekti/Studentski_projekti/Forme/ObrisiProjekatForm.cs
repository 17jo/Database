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
    public partial class ObrisiProjekatForm : Form
    {
        public ObrisiProjekatForm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

            try
            {
                NHibernate.ISession s = DataLayer.GetSession();
                int jid = (int)numericUpDown1.Value;
                Projekat o = s.Load<Projekat>(jid);

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
