namespace frmFlowTicket_v1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnConectarDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConectarDb
            // 
            this.BtnConectarDb.Location = new System.Drawing.Point(34, 53);
            this.BtnConectarDb.Name = "BtnConectarDb";
            this.BtnConectarDb.Size = new System.Drawing.Size(89, 23);
            this.BtnConectarDb.TabIndex = 0;
            this.BtnConectarDb.Text = "Conectar DB";
            this.BtnConectarDb.UseVisualStyleBackColor = true;
            this.BtnConectarDb.Click += new System.EventHandler(this.BtnConectarDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 129);
            this.Controls.Add(this.BtnConectarDb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConectarDb;
    }
}

