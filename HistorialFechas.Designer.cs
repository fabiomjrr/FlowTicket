namespace frmFlowTicket_v1
{
    partial class HistorialFechas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialFechas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbEstadoFactura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnVerFacturas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DgvFacturas = new System.Windows.Forms.DataGridView();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.CmbFacturaID = new System.Windows.Forms.ComboBox();
            this.BtmVerDetalleFact = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbEstadoFactura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnVerFacturas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtpFechaFin);
            this.groupBox1.Controls.Add(this.DtpFechaInicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Magenta;
            this.groupBox1.Location = new System.Drawing.Point(30, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona los datos de búsqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado Factura";
            // 
            // CmbEstadoFactura
            // 
            this.CmbEstadoFactura.BackColor = System.Drawing.Color.MidnightBlue;
            this.CmbEstadoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEstadoFactura.ForeColor = System.Drawing.Color.Magenta;
            this.CmbEstadoFactura.FormattingEnabled = true;
            this.CmbEstadoFactura.Location = new System.Drawing.Point(410, 38);
            this.CmbEstadoFactura.Name = "CmbEstadoFactura";
            this.CmbEstadoFactura.Size = new System.Drawing.Size(121, 23);
            this.CmbEstadoFactura.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Fin";
            // 
            // BtnVerFacturas
            // 
            this.BtnVerFacturas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVerFacturas.BackgroundImage")));
            this.BtnVerFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerFacturas.Location = new System.Drawing.Point(328, 68);
            this.BtnVerFacturas.Name = "BtnVerFacturas";
            this.BtnVerFacturas.Size = new System.Drawing.Size(203, 31);
            this.BtnVerFacturas.TabIndex = 0;
            this.BtnVerFacturas.Text = "Ver Facturas";
            this.BtnVerFacturas.UseVisualStyleBackColor = true;
            this.BtnVerFacturas.Click += new System.EventHandler(this.BtnVerFacturas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicio";
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Location = new System.Drawing.Point(100, 75);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(200, 21);
            this.DtpFechaFin.TabIndex = 2;
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Location = new System.Drawing.Point(100, 40);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(200, 21);
            this.DtpFechaInicio.TabIndex = 1;
            // 
            // DgvFacturas
            // 
            this.DgvFacturas.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturas.Location = new System.Drawing.Point(30, 228);
            this.DgvFacturas.Name = "DgvFacturas";
            this.DgvFacturas.Size = new System.Drawing.Size(556, 210);
            this.DgvFacturas.TabIndex = 1;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.BackgroundImage")));
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.Magenta;
            this.BtnRegresar.Location = new System.Drawing.Point(472, 190);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(114, 23);
            this.BtnRegresar.TabIndex = 5;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // CmbFacturaID
            // 
            this.CmbFacturaID.BackColor = System.Drawing.Color.MidnightBlue;
            this.CmbFacturaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFacturaID.ForeColor = System.Drawing.Color.Magenta;
            this.CmbFacturaID.FormattingEnabled = true;
            this.CmbFacturaID.Location = new System.Drawing.Point(30, 190);
            this.CmbFacturaID.Name = "CmbFacturaID";
            this.CmbFacturaID.Size = new System.Drawing.Size(113, 23);
            this.CmbFacturaID.TabIndex = 8;
            // 
            // BtmVerDetalleFact
            // 
            this.BtmVerDetalleFact.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtmVerDetalleFact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtmVerDetalleFact.BackgroundImage")));
            this.BtmVerDetalleFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmVerDetalleFact.ForeColor = System.Drawing.Color.Magenta;
            this.BtmVerDetalleFact.Location = new System.Drawing.Point(149, 189);
            this.BtmVerDetalleFact.Name = "BtmVerDetalleFact";
            this.BtmVerDetalleFact.Size = new System.Drawing.Size(166, 23);
            this.BtmVerDetalleFact.TabIndex = 8;
            this.BtmVerDetalleFact.Text = "Ver Detalle de Factura";
            this.BtmVerDetalleFact.UseVisualStyleBackColor = false;
            this.BtmVerDetalleFact.Click += new System.EventHandler(this.BtmVerDetalleFact_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.BackgroundImage")));
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Magenta;
            this.BtnLimpiar.Location = new System.Drawing.Point(321, 190);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(145, 23);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar Filtros";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Magenta;
            this.label4.Location = new System.Drawing.Point(160, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reporte de Facturas por fecha";
            // 
            // HistorialFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtmVerDetalleFact);
            this.Controls.Add(this.CmbFacturaID);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.DgvFacturas);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialFechas";
            this.Text = "HistorialFechas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnVerFacturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DataGridView DgvFacturas;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbEstadoFactura;
        private System.Windows.Forms.ComboBox CmbFacturaID;
        private System.Windows.Forms.Button BtmVerDetalleFact;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label4;
    }
}