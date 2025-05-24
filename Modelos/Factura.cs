using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmFlowTicket_v1
{
    internal class Factura
    {
        string facturaID, usuarioID, estado;
        DateTime fechaEmision;
        int correlativo;
        double totalPago;

        public int Correlativo { get { return correlativo; } set { correlativo = value; } }
        public string FacturaID { get { return facturaID; } set { facturaID = value; } }
        public string UsuarioID { get { return usuarioID; } set { usuarioID = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
        public DateTime FechaEmision { get { return fechaEmision; } set { fechaEmision = value; } }
        public double TotalPago{ get { return totalPago; } set { totalPago = value; } }

    }
}
