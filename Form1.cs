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
    public partial class Form1 : Form
    {
        public Form1()
        {
            //InitializeComponent();
            IniciarSesion sesion = new IniciarSesion();
            sesion.Show();
            this.Hide();
        }

        private void BtnConectarDb_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.Abrir();
                frmMantenimientoUsuarios fhu = new frmMantenimientoUsuarios();
                fhu.Show();
                this.Hide();
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
