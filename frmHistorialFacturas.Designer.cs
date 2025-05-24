namespace frmFlowTicket_v1
{
    partial class frmHistorialFacturas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.DtpFechainicio = new System.Windows.Forms.DateTimePicker();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.DgvFacturasPorFiltro = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbFiltro2 = new System.Windows.Forms.ComboBox();
            this.DgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturasPorFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.DtpFechaFin);
            this.groupBox1.Controls.Add(this.DtpFechainicio);
            this.groupBox1.Controls.Add(this.CmbFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elige Estado de factura y rango de fechas a buscar";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(531, 75);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            //this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Location = new System.Drawing.Point(406, 40);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaFin.TabIndex = 4;
            // 
            // DtpFechainicio
            // 
            this.DtpFechainicio.Location = new System.Drawing.Point(199, 40);
            this.DtpFechainicio.Name = "DtpFechainicio";
            this.DtpFechainicio.Size = new System.Drawing.Size(200, 20);
            this.DtpFechainicio.TabIndex = 3;
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Location = new System.Drawing.Point(20, 39);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(160, 21);
            this.CmbFiltro.TabIndex = 0;
            // 
            // DgvFacturasPorFiltro
            // 
            this.DgvFacturasPorFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturasPorFiltro.Location = new System.Drawing.Point(12, 201);
            this.DgvFacturasPorFiltro.Name = "DgvFacturasPorFiltro";
            this.DgvFacturasPorFiltro.Size = new System.Drawing.Size(631, 164);
            this.DgvFacturasPorFiltro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Elige la factura para ver detalle:";
            // 
            // CmbFiltro2
            // 
            this.CmbFiltro2.FormattingEnabled = true;
            this.CmbFiltro2.Location = new System.Drawing.Point(127, 399);
            this.CmbFiltro2.Name = "CmbFiltro2";
            this.CmbFiltro2.Size = new System.Drawing.Size(121, 21);
            this.CmbFiltro2.TabIndex = 6;
            // 
            // DgvDetalleFactura
            // 
            this.DgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleFactura.Location = new System.Drawing.Point(12, 437);
            this.DgvDetalleFactura.Name = "DgvDetalleFactura";
            this.DgvDetalleFactura.Size = new System.Drawing.Size(631, 151);
            this.DgvDetalleFactura.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Historial Facturas";
            // 
            // frmHistorialFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 638);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvDetalleFactura);
            this.Controls.Add(this.CmbFiltro2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvFacturasPorFiltro);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHistorialFacturas";
            this.Text = "frmHistorialFacturas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturasPorFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.DateTimePicker DtpFechainicio;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DgvFacturasPorFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbFiltro2;
        private System.Windows.Forms.DataGridView DgvDetalleFactura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}