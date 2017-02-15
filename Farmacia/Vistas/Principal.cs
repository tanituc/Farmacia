using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Vistas.Medicamentos;

namespace Farmacia.Vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void getionMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionMedicamento gm = new GestionMedicamento();
            gm.Show();
        }
    }
}
