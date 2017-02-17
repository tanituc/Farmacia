namespace Farmacia.Vistas.Medicamentos
{
    partial class NuevoMedicamento
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbPrincipioActivo = new System.Windows.Forms.ComboBox();
            this.tbNombreComercial = new System.Windows.Forms.TextBox();
            this.lblPrincipioActivo = new System.Windows.Forms.Label();
            this.lblNombreComercial = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.lblPrecioLista = new System.Windows.Forms.Label();
            this.cbLaboratorio = new System.Windows.Forms.ComboBox();
            this.btnAgregarPrincipioActivo = new System.Windows.Forms.Button();
            this.btnAgregarLaboratorio = new System.Windows.Forms.Button();
            this.nudPrecioLista = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(93, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(415, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbPrincipioActivo
            // 
            this.cbPrincipioActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrincipioActivo.FormattingEnabled = true;
            this.cbPrincipioActivo.Location = new System.Drawing.Point(132, 83);
            this.cbPrincipioActivo.Name = "cbPrincipioActivo";
            this.cbPrincipioActivo.Size = new System.Drawing.Size(121, 21);
            this.cbPrincipioActivo.TabIndex = 3;
            // 
            // tbNombreComercial
            // 
            this.tbNombreComercial.Location = new System.Drawing.Point(132, 137);
            this.tbNombreComercial.Name = "tbNombreComercial";
            this.tbNombreComercial.Size = new System.Drawing.Size(202, 20);
            this.tbNombreComercial.TabIndex = 4;
            // 
            // lblPrincipioActivo
            // 
            this.lblPrincipioActivo.AutoSize = true;
            this.lblPrincipioActivo.Location = new System.Drawing.Point(46, 86);
            this.lblPrincipioActivo.Name = "lblPrincipioActivo";
            this.lblPrincipioActivo.Size = new System.Drawing.Size(80, 13);
            this.lblPrincipioActivo.TabIndex = 5;
            this.lblPrincipioActivo.Text = "Principio Activo";
            // 
            // lblNombreComercial
            // 
            this.lblNombreComercial.AutoSize = true;
            this.lblNombreComercial.Location = new System.Drawing.Point(33, 140);
            this.lblNombreComercial.Name = "lblNombreComercial";
            this.lblNombreComercial.Size = new System.Drawing.Size(93, 13);
            this.lblNombreComercial.TabIndex = 6;
            this.lblNombreComercial.Text = "Nombre Comercial";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Location = new System.Drawing.Point(66, 113);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(60, 13);
            this.lblLaboratorio.TabIndex = 7;
            this.lblLaboratorio.Text = "Laboratorio";
            // 
            // lblPrecioLista
            // 
            this.lblPrecioLista.AutoSize = true;
            this.lblPrecioLista.Location = new System.Drawing.Point(64, 165);
            this.lblPrecioLista.Name = "lblPrecioLista";
            this.lblPrecioLista.Size = new System.Drawing.Size(62, 13);
            this.lblPrecioLista.TabIndex = 8;
            this.lblPrecioLista.Text = "Precio Lista";
            // 
            // cbLaboratorio
            // 
            this.cbLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLaboratorio.FormattingEnabled = true;
            this.cbLaboratorio.Location = new System.Drawing.Point(132, 110);
            this.cbLaboratorio.Name = "cbLaboratorio";
            this.cbLaboratorio.Size = new System.Drawing.Size(121, 21);
            this.cbLaboratorio.TabIndex = 9;
            // 
            // btnAgregarPrincipioActivo
            // 
            this.btnAgregarPrincipioActivo.Location = new System.Drawing.Point(259, 81);
            this.btnAgregarPrincipioActivo.Name = "btnAgregarPrincipioActivo";
            this.btnAgregarPrincipioActivo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPrincipioActivo.TabIndex = 11;
            this.btnAgregarPrincipioActivo.Text = "Agregar";
            this.btnAgregarPrincipioActivo.UseVisualStyleBackColor = true;
            this.btnAgregarPrincipioActivo.Click += new System.EventHandler(this.btnAgregarPrincipioActivo_Click);
            // 
            // btnAgregarLaboratorio
            // 
            this.btnAgregarLaboratorio.Location = new System.Drawing.Point(259, 108);
            this.btnAgregarLaboratorio.Name = "btnAgregarLaboratorio";
            this.btnAgregarLaboratorio.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarLaboratorio.TabIndex = 12;
            this.btnAgregarLaboratorio.Text = "Agregar";
            this.btnAgregarLaboratorio.UseVisualStyleBackColor = true;
            // 
            // nudPrecioLista
            // 
            this.nudPrecioLista.Location = new System.Drawing.Point(133, 163);
            this.nudPrecioLista.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudPrecioLista.Name = "nudPrecioLista";
            this.nudPrecioLista.Size = new System.Drawing.Size(201, 20);
            this.nudPrecioLista.TabIndex = 13;
            this.nudPrecioLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrecioLista.ThousandsSeparator = true;
            // 
            // NuevoMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 237);
            this.Controls.Add(this.nudPrecioLista);
            this.Controls.Add(this.btnAgregarLaboratorio);
            this.Controls.Add(this.btnAgregarPrincipioActivo);
            this.Controls.Add(this.cbLaboratorio);
            this.Controls.Add(this.lblPrecioLista);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.lblNombreComercial);
            this.Controls.Add(this.lblPrincipioActivo);
            this.Controls.Add(this.tbNombreComercial);
            this.Controls.Add(this.cbPrincipioActivo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "NuevoMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Medicamento";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbPrincipioActivo;
        private System.Windows.Forms.TextBox tbNombreComercial;
        private System.Windows.Forms.Label lblPrincipioActivo;
        private System.Windows.Forms.Label lblNombreComercial;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Label lblPrecioLista;
        private System.Windows.Forms.ComboBox cbLaboratorio;
        private System.Windows.Forms.Button btnAgregarPrincipioActivo;
        private System.Windows.Forms.Button btnAgregarLaboratorio;
        private System.Windows.Forms.NumericUpDown nudPrecioLista;
    }
}