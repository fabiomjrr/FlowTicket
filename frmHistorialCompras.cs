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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace frmFlowTicket_v1
{
    public partial class frmHistorialCompras : Form
    {
        public frmHistorialCompras()
        {
            InitializeComponent();
            var estados = new List<object>
            {
                new { Texto = "PENDIENTE", Valor = "PEN" },
                new { Texto = "PAGADA", Valor = "PAG" },
                new { Texto = "ANULADA", Valor = "ANU" },
                new { Texto = "GENERADA", Valor = "GEN" },
                new { Texto = "SUSPENDIDA", Valor = "SUS" },
                new { Texto = "TODAS", Valor = "TOD" },

            };
            CmbEstado.DataSource = estados;
            CmbEstado.SelectedIndex = 0;
            CmbEstado.DisplayMember = "Texto";
            CmbEstado.ValueMember = "Valor";
            
            CmbFacturas.Items.Clear();
            CmbFacturas.Items.Add("FACTURAS");
            CmbFacturas.SelectedItem = "FACTURAS";
            CmbEstado.DataSource = estados;
            CmbEstado.SelectedIndex = 0;
            CmbEstado.DisplayMember = "Texto";
            CmbEstado.ValueMember = "Valor";

            LblHistCompras.Text = "Historial de compras: " + SesionUsuario.NombreUsuario;
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Factura f = new Factura();
            FacturasDAO fDAO = new FacturasDAO();
            Usuario user = new Usuario();
            UsuarioDAO uDAO = new UsuarioDAO();
            f.Estado = CmbEstado.SelectedValue.ToString();
            user = uDAO.BuscarUsuario("", "", SesionUsuario.NombreUsuario, "", "");
            CmbFacturas.DataSource = fDAO.BuscarFacturas(f.Estado, user.UsuarioID);
        }

        private void BtnVerFactura_Click(object sender, EventArgs e)
        {
            if (CmbFacturas.SelectedItem.ToString().Equals("FACTURAS")){
                MessageBox.Show("Debes buscar facturas segun estado");
            }
            else
            {
                Factura f = new Factura();
                FacturasDAO fDAO = new FacturasDAO();
                f = fDAO.VerFactura(CmbFacturas.SelectedItem.ToString());
                if (f != null)
                {
                    LblCodigoFactura.Text = f.FacturaID;
                    LblCorrelativo.Text = f.Correlativo.ToString();
                    LblEstado.Text = f.Estado;
                    LblUsuario.Text = f.UsuarioID;
                    LblTotalPago.Text = f.TotalPago.ToString();
                    List<DetalleFacturaVista> ldfv = new List<DetalleFacturaVista>();
                    ldfv = fDAO.ObtenerDetalleFactura(f.FacturaID);
                    DgvDetalleFactura.DataSource = ldfv;
                }
                else
                {
                    Console.WriteLine("Revisar frmHistorialCompras");
                }
            }            
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuUf frmMenuUf = new frmMenuUf();
            frmMenuUf.Show();
            this.Close();
        }
    }
}
