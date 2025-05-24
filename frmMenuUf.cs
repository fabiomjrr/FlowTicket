using frmFlowTicket_v1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmFlowTicket_v1
{
    public partial class frmMenuUf : Form
    {
        public frmMenuUf()
        {
            InitializeComponent();
            
        }
        private void TsmCerrarSesion_Click(object sender, EventArgs e)
        {
            SesionUsuario.NombreUsuario = null;
            SesionUsuario.Tipo = false;
            IniciarSesion login = new IniciarSesion();
            login.Show();
            this.Close();
        }

        private void historialDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialCompras fhc = new frmHistorialCompras();
            fhc.Show();
            this.Close();
        }

        private void TsmVerEventos_Click(object sender, EventArgs e)
        {
            frmVerEventos fve = new frmVerEventos();
            fve.Show();
            this.Close();
        }
    }
}
