namespace frmFlowTicket_v1
{
    partial class frmMenuAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMantenimientoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMantenimientoEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMantenimientoBoletos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmReporteria = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmHistorialFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmAdministracion,
            this.TsmReporteria,
            this.TsmSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmAdministracion
            // 
            this.TsmAdministracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TsmAdministracion.BackgroundImage")));
            this.TsmAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmMantenimientoUsuarios,
            this.TsmMantenimientoEventos,
            this.TsmMantenimientoBoletos});
            this.TsmAdministracion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmAdministracion.ForeColor = System.Drawing.Color.Magenta;
            this.TsmAdministracion.Name = "TsmAdministracion";
            this.TsmAdministracion.Size = new System.Drawing.Size(128, 24);
            this.TsmAdministracion.Text = "Administración";
            // 
            // TsmMantenimientoUsuarios
            // 
            this.TsmMantenimientoUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TsmMantenimientoUsuarios.BackgroundImage")));
            this.TsmMantenimientoUsuarios.ForeColor = System.Drawing.Color.Magenta;
            this.TsmMantenimientoUsuarios.Name = "TsmMantenimientoUsuarios";
            this.TsmMantenimientoUsuarios.Size = new System.Drawing.Size(251, 24);
            this.TsmMantenimientoUsuarios.Text = "Mantenimiento Usuarios";
            this.TsmMantenimientoUsuarios.Click += new System.EventHandler(this.TsmMantenimientoUsuarios_Click);
            // 
            // TsmMantenimientoEventos
            // 
            this.TsmMantenimientoEventos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TsmMantenimientoEventos.BackgroundImage")));
            this.TsmMantenimientoEventos.ForeColor = System.Drawing.Color.Magenta;
            this.TsmMantenimientoEventos.Name = "TsmMantenimientoEventos";
            this.TsmMantenimientoEventos.Size = new System.Drawing.Size(251, 24);
            this.TsmMantenimientoEventos.Text = "Mantenimiento Eventos";
            this.TsmMantenimientoEventos.Click += new System.EventHandler(this.TsmMantenimientoEventos_Click);
            // 
            // TsmMantenimientoBoletos
            // 
            this.TsmMantenimientoBoletos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TsmMantenimientoBoletos.BackgroundImage")));
            this.TsmMantenimientoBoletos.ForeColor = System.Drawing.Color.Magenta;
            this.TsmMantenimientoBoletos.Name = "TsmMantenimientoBoletos";
            this.TsmMantenimientoBoletos.Size = new System.Drawing.Size(251, 24);
            this.TsmMantenimientoBoletos.Text = "Mantenimiento Boletos";
            // 
            // TsmReporteria
            // 
            this.TsmReporteria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmHistorialFacturas});
            this.TsmReporteria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmReporteria.ForeColor = System.Drawing.Color.Magenta;
            this.TsmReporteria.Name = "TsmReporteria";
            this.TsmReporteria.Size = new System.Drawing.Size(95, 24);
            this.TsmReporteria.Text = "Reportería";
            // 
            // TsmHistorialFacturas
            // 
            this.TsmHistorialFacturas.BackColor = System.Drawing.SystemColors.Control;
            this.TsmHistorialFacturas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TsmHistorialFacturas.BackgroundImage")));
            this.TsmHistorialFacturas.ForeColor = System.Drawing.Color.Magenta;
            this.TsmHistorialFacturas.Name = "TsmHistorialFacturas";
            this.TsmHistorialFacturas.Size = new System.Drawing.Size(180, 24);
            this.TsmHistorialFacturas.Text = "Reportería";
            this.TsmHistorialFacturas.Click += new System.EventHandler(this.TsmHistorialFacturas_Click);
            // 
            // TsmSalir
            // 
            this.TsmSalir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.TsmSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmSalir.ForeColor = System.Drawing.Color.Magenta;
            this.TsmSalir.Name = "TsmSalir";
            this.TsmSalir.Size = new System.Drawing.Size(51, 24);
            this.TsmSalir.Text = "Salir";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrarSesiónToolStripMenuItem.BackgroundImage")));
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.Magenta;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // frmMenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 473);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuAdm";
            this.Text = "frmMenuAdm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmAdministracion;
        private System.Windows.Forms.ToolStripMenuItem TsmMantenimientoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem TsmMantenimientoEventos;
        private System.Windows.Forms.ToolStripMenuItem TsmMantenimientoBoletos;
        private System.Windows.Forms.ToolStripMenuItem TsmReporteria;
        private System.Windows.Forms.ToolStripMenuItem TsmHistorialFacturas;
        private System.Windows.Forms.ToolStripMenuItem TsmSalir;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}