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
    public partial class frmMenuAdm : Form
    {
        public frmMenuAdm()
        {
            InitializeComponent();
        }

        private void TsmMantenimientoUsuarios_Click(object sender, EventArgs e)
        {
            frmMantenimientoUsuarios fmu = new frmMantenimientoUsuarios();
            fmu.Show();
            this.Close();
        }

        private void TsmHistorialFacturas_Click(object sender, EventArgs e)
        {
            frmReportes repo = new frmReportes();
            repo.Show();
            this.Close();
        }

        private void TsmMantenimientoEventos_Click(object sender, EventArgs e)
        {
            frmMantenimientoEventos fme = new frmMantenimientoEventos();
            fme.Show();
            this.Close();
        }
    }
}
