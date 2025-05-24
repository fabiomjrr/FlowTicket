namespace frmFlowTicket_v1
{
    partial class frmComprarBoletos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvLocalidades = new System.Windows.Forms.DataGridView();
            this.LblLugarEvento = new System.Windows.Forms.Label();
            this.LblFechaEvento = new System.Windows.Forms.Label();
            this.LblNombreEvento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PtbEvento = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbCantidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbTipoEntrada = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEvento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DgvLocalidades);
            this.groupBox2.Controls.Add(this.LblLugarEvento);
            this.groupBox2.Controls.Add(this.LblFechaEvento);
            this.groupBox2.Controls.Add(this.LblNombreEvento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PtbEvento);
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 277);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del Evento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Localidades:";
            // 
            // DgvLocalidades
            // 
            this.DgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLocalidades.Location = new System.Drawing.Point(247, 138);
            this.DgvLocalidades.Name = "DgvLocalidades";
            this.DgvLocalidades.Size = new System.Drawing.Size(308, 111);
            this.DgvLocalidades.TabIndex = 7;
            // 
            // LblLugarEvento
            // 
            this.LblLugarEvento.AutoSize = true;
            this.LblLugarEvento.Location = new System.Drawing.Point(321, 92);
            this.LblLugarEvento.Name = "LblLugarEvento";
            this.LblLugarEvento.Size = new System.Drawing.Size(77, 13);
            this.LblLugarEvento.TabIndex = 6;
            this.LblLugarEvento.Text = "$Lugar Evento";
            this.LblLugarEvento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblFechaEvento
            // 
            this.LblFechaEvento.AutoSize = true;
            this.LblFechaEvento.Location = new System.Drawing.Point(321, 63);
            this.LblFechaEvento.Name = "LblFechaEvento";
            this.LblFechaEvento.Size = new System.Drawing.Size(80, 13);
            this.LblFechaEvento.TabIndex = 5;
            this.LblFechaEvento.Text = "$Fecha Evento";
            this.LblFechaEvento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblNombreEvento
            // 
            this.LblNombreEvento.AutoSize = true;
            this.LblNombreEvento.Location = new System.Drawing.Point(321, 34);
            this.LblNombreEvento.Name = "LblNombreEvento";
            this.LblNombreEvento.Size = new System.Drawing.Size(87, 13);
            this.LblNombreEvento.TabIndex = 4;
            this.LblNombreEvento.Text = "$Nombre Evento";
            this.LblNombreEvento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lugar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Evento: ";
            // 
            // PtbEvento
            // 
            this.PtbEvento.Location = new System.Drawing.Point(17, 31);
            this.PtbEvento.Name = "PtbEvento";
            this.PtbEvento.Size = new System.Drawing.Size(210, 228);
            this.PtbEvento.TabIndex = 0;
            this.PtbEvento.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbTipoEntrada);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de compra";
            // 
            // CmbCantidad
            // 
            this.CmbCantidad.FormattingEnabled = true;
            this.CmbCantidad.Location = new System.Drawing.Point(143, 84);
            this.CmbCantidad.Name = "CmbCantidad";
            this.CmbCantidad.Size = new System.Drawing.Size(193, 21);
            this.CmbCantidad.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad";
            // 
            // CmbTipoEntrada
            // 
            this.CmbTipoEntrada.FormattingEnabled = true;
            this.CmbTipoEntrada.Location = new System.Drawing.Point(143, 42);
            this.CmbTipoEntrada.Name = "CmbTipoEntrada";
            this.CmbTipoEntrada.Size = new System.Drawing.Size(193, 21);
            this.CmbTipoEntrada.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de entrada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSalir);
            this.groupBox3.Controls.Add(this.BtnFinalizar);
            this.groupBox3.Controls.Add(this.BtnAgregar);
            this.groupBox3.Location = new System.Drawing.Point(388, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 133);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(46, 35);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(110, 23);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar Pedido";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(46, 64);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(110, 23);
            this.BtnFinalizar.TabIndex = 1;
            this.BtnFinalizar.Text = "Finalizar Compra";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(46, 93);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // frmComprarBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 446);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmComprarBoletos";
            this.Text = "frmComprarBoletos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEvento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvLocalidades;
        private System.Windows.Forms.Label LblLugarEvento;
        private System.Windows.Forms.Label LblFechaEvento;
        private System.Windows.Forms.Label LblNombreEvento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PtbEvento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbTipoEntrada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnAgregar;
    }
}