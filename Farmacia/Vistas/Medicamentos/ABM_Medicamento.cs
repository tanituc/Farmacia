﻿using System;
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
    public partial class ABM_Medicamento : Form
    {
        public ABM_Medicamento()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoMedicamento abmM = new NuevoMedicamento();
            abmM.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void GestionMedicamento_Load(object sender, EventArgs e)
        {

        }
    }
}
