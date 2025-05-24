using frmFlowTicket_v1.Data_Access_Object;
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
    public partial class HistorialFechas : Form
    {
        public HistorialFechas()
        {
            InitializeComponent();
            var estados = new List<object>
            {
                new { Texto = "ESTADO FACTURA", Valor = "0" },
                new { Texto = "PENDIENTE", Valor = "PEN" },
                new { Texto = "PAGADA", Valor = "PAG" },
                new { Texto = "ANULADA", Valor = "ANU" },
                new { Texto = "GENERADA", Valor = "GEN" },
                new { Texto = "SUSPENDIDA", Valor = "SUS" },
                new { Texto = "TODAS", Valor = "TOD" },
            };
            CmbEstadoFactura.DataSource = estados;
            CmbEstadoFactura.DisplayMember = "Texto";
            CmbEstadoFactura.ValueMember = "Valor";

            CmbFacturaID.Items.Clear();
            CmbFacturaID.Items.Add("Facturas..");
            CmbFacturaID.SelectedItem = "Facturas..";

        }

        private void BtnVerFacturas_Click(object sender, EventArgs e)
        {
            Factura f = new Factura();
            FacturasDAO fdao = new FacturasDAO();
            DateTime fechainicio = DtpFechaInicio.Value;
            DateTime fechafin = DtpFechaFin.Value;
            f.Estado = CmbEstadoFactura.SelectedValue.ToString();

            if (fechafin < fechainicio)
                MessageBox.Show("La fecha de inicio no puede ser menor que la de inicio. Intenta nuevamente");
            else if (f.Estado.Equals("0"))
                MessageBox.Show("Debes seleccionar un estado para las facturas a buscar, o seleccionar todas para ver todos los estados");
            else 
            {
                List<string> facturas = fdao.BuscarFacturas(f.Estado,fechainicio,fechafin);
                CmbFacturaID.DataSource = facturas;
            }
        }

        private void BtmVerDetalleFact_Click(object sender, EventArgs e)
        {
            if (CmbFacturaID.SelectedItem.Equals("Facturas..")){
                MessageBox.Show("Debes buscar las facturas!");
            }
            else
            {
                Factura f = new Factura();
                FacturasDAO fdao = new FacturasDAO();
                f.FacturaID = CmbFacturaID.SelectedItem as string;
                DgvFacturas.DataSource = fdao.ObtenerDetalleFactura(f.FacturaID);
            }

            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DtpFechaInicio.Value = DateTime.Now;
            DtpFechaFin.Value = DateTime.Now;
            CmbEstadoFactura.SelectedItem = "ESTADO FACTURA";
            DgvFacturas.DataSource = null;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            frmReportes repo = new frmReportes();
            repo.Show();
            this.Close();
        }
    }
}
