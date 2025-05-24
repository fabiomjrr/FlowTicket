namespace frmFlowTicket_v1
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPorEventos = new System.Windows.Forms.Button();
            this.btnPorEstadosFactura = new System.Windows.Forms.Button();
            this.BtnPorUsuario = new System.Windows.Forms.Button();
            this.BtnForFecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.BtnPorEventos);
            this.groupBox1.Controls.Add(this.btnPorEstadosFactura);
            this.groupBox1.Controls.Add(this.BtnPorUsuario);
            this.groupBox1.Controls.Add(this.BtnForFecha);
            this.groupBox1.Location = new System.Drawing.Point(31, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnPorEventos
            // 
            this.BtnPorEventos.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnPorEventos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPorEventos.BackgroundImage")));
            this.BtnPorEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPorEventos.ForeColor = System.Drawing.Color.Magenta;
            this.BtnPorEventos.Location = new System.Drawing.Point(346, 32);
            this.BtnPorEventos.Name = "BtnPorEventos";
            this.BtnPorEventos.Size = new System.Drawing.Size(95, 52);
            this.BtnPorEventos.TabIndex = 3;
            this.BtnPorEventos.Text = "Por Eventos";
            this.BtnPorEventos.UseVisualStyleBackColor = false;
            this.BtnPorEventos.Click += new System.EventHandler(this.BtnPorEventos_Click);
            // 
            // btnPorEstadosFactura
            // 
            this.btnPorEstadosFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPorEstadosFactura.BackgroundImage")));
            this.btnPorEstadosFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorEstadosFactura.ForeColor = System.Drawing.Color.Magenta;
            this.btnPorEstadosFactura.Location = new System.Drawing.Point(225, 32);
            this.btnPorEstadosFactura.Name = "btnPorEstadosFactura";
            this.btnPorEstadosFactura.Size = new System.Drawing.Size(105, 52);
            this.btnPorEstadosFactura.TabIndex = 2;
            this.btnPorEstadosFactura.Text = "Por Estados de Factura";
            this.btnPorEstadosFactura.UseVisualStyleBackColor = true;
            this.btnPorEstadosFactura.Click += new System.EventHandler(this.btnPorEstadosFactura_Click);
            // 
            // BtnPorUsuario
            // 
            this.BtnPorUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPorUsuario.BackgroundImage")));
            this.BtnPorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPorUsuario.ForeColor = System.Drawing.Color.Magenta;
            this.BtnPorUsuario.Location = new System.Drawing.Point(116, 32);
            this.BtnPorUsuario.Name = "BtnPorUsuario";
            this.BtnPorUsuario.Size = new System.Drawing.Size(93, 52);
            this.BtnPorUsuario.TabIndex = 1;
            this.BtnPorUsuario.Text = "Por Usuarios";
            this.BtnPorUsuario.UseVisualStyleBackColor = true;
            this.BtnPorUsuario.Click += new System.EventHandler(this.BtnPorUsuario_Click);
            // 
            // BtnForFecha
            // 
            this.BtnForFecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnForFecha.BackgroundImage")));
            this.BtnForFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnForFecha.ForeColor = System.Drawing.Color.Magenta;
            this.BtnForFecha.Location = new System.Drawing.Point(15, 32);
            this.BtnForFecha.Name = "BtnForFecha";
            this.BtnForFecha.Size = new System.Drawing.Size(81, 52);
            this.BtnForFecha.TabIndex = 0;
            this.BtnForFecha.Text = "Por Fecha";
            this.BtnForFecha.UseVisualStyleBackColor = true;
            this.BtnForFecha.Click += new System.EventHandler(this.BtnForFecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(143, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reportería FlowTicket";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.BackgroundImage")));
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.Magenta;
            this.BtnRegresar.Location = new System.Drawing.Point(341, 190);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(83, 43);
            this.BtnRegresar.TabIndex = 3;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 254);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportes";
            this.Text = "Reportería";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPorEstadosFactura;
        private System.Windows.Forms.Button BtnPorUsuario;
        private System.Windows.Forms.Button BtnForFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnPorEventos;
    }
}