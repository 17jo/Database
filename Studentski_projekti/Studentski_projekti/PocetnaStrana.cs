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
    public partial class PocetnaStrana : Form
    {
        public PocetnaStrana()
        {
            InitializeComponent();
        }

        private void PocetnaStrana_Load(object sender, EventArgs e)
        {

        }

        private void btnPredmet_Click(object sender, EventArgs e)
        {
            PredmetForm lf = new PredmetForm();
            lf.ShowDialog();
        }

        private void btnProjekat_Click(object sender, EventArgs e)
        {
            ProjekatForm lf = new ProjekatForm();
            lf.ShowDialog();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentForm lf = new StudentForm();
            lf.ShowDialog();
        }

        private void btnLiteratura_Click(object sender, EventArgs e)
        {
           
           LiteraturaForm lf = new LiteraturaForm();
           lf.ShowDialog();
            
        }
    }
}
