using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Vistas.Medicamentos
{
    public partial class GestionMedicamento : Form
    {
        public GestionMedicamento()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ABM_Medicamento abmM = new ABM_Medicamento();
            abmM.ShowDialog();
        }
    }
}
