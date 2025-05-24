using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmFlowTicket_v1
{
    internal class DetalleFactura
    {
        string facturaID;
        int dfID, boletoID;
        byte cantidad;
        double precioUnitario, impuesto, cargo;

        public string FacturaID { get { return facturaID; } set { facturaID = value; } }
        public int DfID { get { return dfID; } set { dfID = value; } }
        public int BoletoID { get { return boletoID; } set { boletoID = value; } }
        public byte Cantidad { get { return cantidad; } set { cantidad = value; } }
        public double PrecioUnitario { get { return precioUnitario; } set { precioUnitario = value; } }
        public double Impuesto { get { return impuesto; } set { impuesto = value; } }
        public double Cargo { get { return cargo; } set { cargo = value; } }
    }
}
