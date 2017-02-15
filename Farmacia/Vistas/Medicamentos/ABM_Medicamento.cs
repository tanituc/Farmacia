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
    public partial class ABM_Medicamento : Form
    {
        private IPresentadorMedicamentos presentador;
        public ABM_Medicamento()
        {
            InitializeComponent();
            presentador = new PresentadorMedicamentos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            presentador.guardarMedicamento((int)cbPrincipioActivo.SelectedValue, tbNombreComercial.Text
                ,(int)cbLaboratorio.SelectedValue,double.Parse(tbPrecioLista.Text));
        }
    }
}
