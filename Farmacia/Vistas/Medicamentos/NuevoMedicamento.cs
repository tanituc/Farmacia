using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace Farmacia.Vistas.Medicamentos
{
    public partial class NuevoMedicamento : Form
    {
        private IPresentadorMedicamentos presentador;
        public NuevoMedicamento()
        {
            InitializeComponent();
            presentador = new PresentadorMedicamentos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            presentador.guardarMedicamento((int)cbPrincipioActivo.SelectedValue, tbNombreComercial.Text
                ,(int)cbLaboratorio.SelectedValue,double.Parse(nudPrecioLista.Text));
        }

        private void btnAgregarPrincipioActivo_Click(object sender, EventArgs e)
        {
            ABM_PrincipioActivo abmP = new ABM_PrincipioActivo();
            abmP.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
