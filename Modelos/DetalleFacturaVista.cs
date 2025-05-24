using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmFlowTicket_v1.Modelos
{
    internal class DetalleFacturaVista
    {
        string facturaID, nombreCompleto, evento, tipoEntrada, estado;
        int correlativo, cantidad;
        decimal precioUnitario, cargoPorServicio, impuesto, subTotal;
        DateTime fechaEmision;

        public string FacturaID {  get { return facturaID; } set { facturaID = value; } }
        public string NombreCompleto { get { return nombreCompleto; } set { nombreCompleto = value; } }
        public int Correlativo { get { return correlativo; } set { correlativo = value; } }
        public int Cantidad { get { return cantidad; } set {  cantidad = value; } }
        public string Evento { get { return evento; } set { evento = value; } }
        public string TipoEntrada { get { return tipoEntrada; } set { tipoEntrada = value; } }
        public decimal PrecioUnitario { get { return precioUnitario; } set { precioUnitario = value; } }
        public decimal CargoPorServicio { get { return cargoPorServicio; } set { cargoPorServicio = value; } }
        public decimal Impuesto { get {return impuesto; } set { impuesto = value; } }

        public DateTime FechaEmision { get { return fechaEmision; } set { fechaEmision = value; } }
        public decimal Subtotal { get {return subTotal; } set { subTotal = value; } }
        public string Estado { get{ return estado; } set { estado = value; } }
    }
}
