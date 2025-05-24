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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void BtnForFecha_Click(object sender, EventArgs e)
        {
            HistorialFechas hf = new HistorialFechas();
            hf.Show();
            this.Close();   
        }

        private void BtnPorUsuario_Click(object sender, EventArgs e)
        {
            frmHistorialUsuarios frmHistorialUsuarios = new frmHistorialUsuarios();
            frmHistorialUsuarios.Show();
            this.Close();
        }

        private void btnPorEstadosFactura_Click(object sender, EventArgs e)
        {
            frmHistorialFacturas frm = new frmHistorialFacturas();
            frm.Show();
            this.Close();
        }

        private void BtnPorEventos_Click(object sender, EventArgs e)
        {

        }
    }
}
