using frmFlowTicket_v1.Data_Access_Object;
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
    public partial class frmHistorialUsuarios : Form
    {
        public frmHistorialUsuarios()
        {
            InitializeComponent();
            CmbUsuario.DataSource = CargarUsuarios();
            CmbFactura.Items.Clear();
            CmbFactura.Items.Add("Facturas..");
            CmbFactura.SelectedItem = "Facturas..";
        }

        public List<string> CargarUsuarios()
        {
            UsuarioDAO uDAO = new UsuarioDAO();
            List<string> lista = uDAO.BuscarCodigoNombre();
            return lista;  
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            UsuarioDAO uDao = new UsuarioDAO();
            FacturasDAO fDao = new FacturasDAO();
            string seleccion = (string) CmbUsuario.SelectedItem;
            string codigo = seleccion.Substring(0, 10);
            u.UsuarioID = codigo;
            List<string> lfactura = fDao.BuscarFacturas(u.UsuarioID);
            
            CmbFactura.DataSource = lfactura.ToList();
        }

        private void BtnBuscarDetalleFactura_Click(object sender, EventArgs e)
        {
            if (CmbFactura.SelectedItem.Equals("Facturas.."))
            {
                MessageBox.Show("Debes elegir un usuario y buscar sus facturas");
            }
            else
            {
                DetalleFactura df = new DetalleFactura();
                FacturasDAO fDao = new FacturasDAO();
                df.FacturaID = (string)CmbFactura.SelectedItem;
                MessageBox.Show(df.FacturaID);
                List<DetalleFacturaVista> lista = fDao.ObtenerDetalleFactura(df.FacturaID);

                DgvDetalleFactura.DataSource = lista;

            }
            
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            frmReportes fma = new frmReportes();
            fma.Show();
            this.Close();
        }
    }
}
