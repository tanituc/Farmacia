namespace Farmacia.Vistas
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getionMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionLaboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPrincipioActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.medicamentosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.laboratoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getionMedicamentosToolStripMenuItem,
            this.nuevoPrincipioActivoToolStripMenuItem});
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // laboratoriosToolStripMenuItem
            // 
            this.laboratoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionLaboratoriosToolStripMenuItem});
            this.laboratoriosToolStripMenuItem.Name = "laboratoriosToolStripMenuItem";
            this.laboratoriosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.laboratoriosToolStripMenuItem.Text = "Laboratorios";
            // 
            // getionMedicamentosToolStripMenuItem
            // 
            this.getionMedicamentosToolStripMenuItem.Name = "getionMedicamentosToolStripMenuItem";
            this.getionMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.getionMedicamentosToolStripMenuItem.Text = "Getion Medicamentos";
            this.getionMedicamentosToolStripMenuItem.Click += new System.EventHandler(this.getionMedicamentosToolStripMenuItem_Click);
            // 
            // gestionClientesToolStripMenuItem
            // 
            this.gestionClientesToolStripMenuItem.Name = "gestionClientesToolStripMenuItem";
            this.gestionClientesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.gestionClientesToolStripMenuItem.Text = "Gestion Clientes";
            // 
            // gestionLaboratoriosToolStripMenuItem
            // 
            this.gestionLaboratoriosToolStripMenuItem.Name = "gestionLaboratoriosToolStripMenuItem";
            this.gestionLaboratoriosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestionLaboratoriosToolStripMenuItem.Text = "Gestion Laboratorios";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.consultaVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            // 
            // consultaVentaToolStripMenuItem
            // 
            this.consultaVentaToolStripMenuItem.Name = "consultaVentaToolStripMenuItem";
            this.consultaVentaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.consultaVentaToolStripMenuItem.Text = "Consulta Venta";
            // 
            // nuevoPrincipioActivoToolStripMenuItem
            // 
            this.nuevoPrincipioActivoToolStripMenuItem.Name = "nuevoPrincipioActivoToolStripMenuItem";
            this.nuevoPrincipioActivoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.nuevoPrincipioActivoToolStripMenuItem.Text = "Nuevo Principio Activo";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 439);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getionMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionLaboratoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPrincipioActivoToolStripMenuItem;
    }
}