namespace frmFlowTicket_v1
{
    partial class frmVerEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerEventos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbEventos = new System.Windows.Forms.ComboBox();
            this.BtnVerEvento = new System.Windows.Forms.Button();
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.DtpFechaFin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtpFechaInicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Magenta;
            this.BtnBuscar.Location = new System.Drawing.Point(477, 47);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 35);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Location = new System.Drawing.Point(258, 62);
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.Size = new System.Drawing.Size(195, 20);
            this.DtpFechaFin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(255, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Fin";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Location = new System.Drawing.Point(43, 62);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(195, 20);
            this.DtpFechaInicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(85, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Elige evento";
            // 
            // CmbEventos
            // 
            this.CmbEventos.BackColor = System.Drawing.Color.MidnightBlue;
            this.CmbEventos.ForeColor = System.Drawing.Color.Magenta;
            this.CmbEventos.FormattingEnabled = true;
            this.CmbEventos.Location = new System.Drawing.Point(185, 219);
            this.CmbEventos.Name = "CmbEventos";
            this.CmbEventos.Size = new System.Drawing.Size(274, 21);
            this.CmbEventos.TabIndex = 6;
            // 
            // BtnVerEvento
            // 
            this.BtnVerEvento.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnVerEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerEvento.ForeColor = System.Drawing.Color.Magenta;
            this.BtnVerEvento.Location = new System.Drawing.Point(465, 213);
            this.BtnVerEvento.Name = "BtnVerEvento";
            this.BtnVerEvento.Size = new System.Drawing.Size(130, 34);
            this.BtnVerEvento.TabIndex = 5;
            this.BtnVerEvento.Text = "Ver Evento";
            this.BtnVerEvento.UseVisualStyleBackColor = false;
            this.BtnVerEvento.Click += new System.EventHandler(this.BtnVerEvento_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DgvLocalidades);
            this.groupBox2.Controls.Add(this.LblLugarEvento);
            this.groupBox2.Controls.Add(this.LblFechaEvento);
            this.groupBox2.Controls.Add(this.LblNombreEvento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PtbEvento);
            this.groupBox2.Location = new System.Drawing.Point(24, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 277);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del Evento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MidnightBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Magenta;
            this.label7.Location = new System.Drawing.Point(258, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Localidades:";
            // 
            // DgvLocalidades
            // 
            this.DgvLocalidades.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.DgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLocalidades.Location = new System.Drawing.Point(356, 138);
            this.DgvLocalidades.Name = "DgvLocalidades";
            this.DgvLocalidades.Size = new System.Drawing.Size(196, 111);
            this.DgvLocalidades.TabIndex = 7;
            // 
            // LblLugarEvento
            // 
            this.LblLugarEvento.AutoSize = true;
            this.LblLugarEvento.BackColor = System.Drawing.Color.MidnightBlue;
            this.LblLugarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLugarEvento.ForeColor = System.Drawing.Color.Magenta;
            this.LblLugarEvento.Location = new System.Drawing.Point(353, 92);
            this.LblLugarEvento.Name = "LblLugarEvento";
            this.LblLugarEvento.Size = new System.Drawing.Size(0, 15);
            this.LblLugarEvento.TabIndex = 6;
            this.LblLugarEvento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblFechaEvento
            // 
            this.LblFechaEvento.AutoSize = true;
            this.LblFechaEvento.BackColor = System.Drawing.Color.MidnightBlue;
            this.LblFechaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaEvento.ForeColor = System.Drawing.Color.Magenta;
            this.LblFechaEvento.Location = new System.Drawing.Point(353, 63);
            this.LblFechaEvento.Name = "LblFechaEvento";
            this.LblFechaEvento.Size = new System.Drawing.Size(0, 15);
            this.LblFechaEvento.TabIndex = 5;
            this.LblFechaEvento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblNombreEvento
            // 
            this.LblNombreEvento.AutoSize = true;
            this.LblNombreEvento.BackColor = System.Drawing.Color.MidnightBlue;
            this.LblNombreEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreEvento.ForeColor = System.Drawing.Color.Magenta;
            this.LblNombreEvento.Location = new System.Drawing.Point(353, 34);
            this.LblNombreEvento.Name = "LblNombreEvento";
            this.LblNombreEvento.Size = new System.Drawing.Size(0, 15);
            this.LblNombreEvento.TabIndex = 4;
            this.LblNombreEvento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MidnightBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Magenta;
            this.label6.Location = new System.Drawing.Point(258, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lugar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Magenta;
            this.label5.Location = new System.Drawing.Point(258, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Magenta;
            this.label4.Location = new System.Drawing.Point(258, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Evento: ";
            // 
            // PtbEvento
            // 
            this.PtbEvento.BackColor = System.Drawing.Color.MidnightBlue;
            this.PtbEvento.Location = new System.Drawing.Point(17, 31);
            this.PtbEvento.Name = "PtbEvento";
            this.PtbEvento.Size = new System.Drawing.Size(221, 230);
            this.PtbEvento.TabIndex = 0;
            this.PtbEvento.TabStop = false;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.Magenta;
            this.btnComprar.Location = new System.Drawing.Point(169, 558);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(141, 36);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar boletos";
            this.btnComprar.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Magenta;
            this.BtnSalir.Location = new System.Drawing.Point(319, 558);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(112, 36);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MidnightBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Magenta;
            this.label8.Location = new System.Drawing.Point(241, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ver Eventos ";
            // 
            // frmVerEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(621, 606);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnVerEvento);
            this.Controls.Add(this.CmbEventos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerEventos";
            this.Text = "frmVerEventos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DateTimePicker DtpFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbEventos;
        private System.Windows.Forms.Button BtnVerEvento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvLocalidades;
        private System.Windows.Forms.Label LblLugarEvento;
        private System.Windows.Forms.Label LblFechaEvento;
        private System.Windows.Forms.Label LblNombreEvento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PtbEvento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label8;
    }
}