namespace Farmacia.Vistas.Medicamentos
{
    partial class GestionMedicamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvMedicamentosActivos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvMedicamentosInactivos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedicamentosInactivos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(697, 321);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnHabilitar.TabIndex = 1;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(697, 86);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDeshabilitar.TabIndex = 2;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dgvMedicamentosActivos
            // 
            this.dgvMedicamentosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicamentosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentosActivos.Location = new System.Drawing.Point(12, 115);
            this.dgvMedicamentosActivos.Name = "dgvMedicamentosActivos";
            this.dgvMedicamentosActivos.Size = new System.Drawing.Size(760, 200);
            this.dgvMedicamentosActivos.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(588, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvMedicamentosInactivos
            // 
            this.dgvMedicamentosInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentosInactivos.Location = new System.Drawing.Point(12, 350);
            this.dgvMedicamentosInactivos.Name = "dgvMedicamentosInactivos";
            this.dgvMedicamentosInactivos.Size = new System.Drawing.Size(760, 200);
            this.dgvMedicamentosInactivos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Medicamentos Activos";
            // 
            // lblMedicamentosInactivos
            // 
            this.lblMedicamentosInactivos.AutoSize = true;
            this.lblMedicamentosInactivos.Location = new System.Drawing.Point(12, 326);
            this.lblMedicamentosInactivos.Name = "lblMedicamentosInactivos";
            this.lblMedicamentosInactivos.Size = new System.Drawing.Size(122, 13);
            this.lblMedicamentosInactivos.TabIndex = 8;
            this.lblMedicamentosInactivos.Text = "Medicamentos Inactivos";
            // 
            // GestionMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblMedicamentosInactivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedicamentosInactivos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvMedicamentosActivos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "GestionMedicamentos";
            this.Text = "Gestion Medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosInactivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvMedicamentosActivos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvMedicamentosInactivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedicamentosInactivos;
    }
}