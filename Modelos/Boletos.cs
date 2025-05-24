using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmFlowTicket_v1
{
    internal class Boletos
    {
        int boletoID, eventoID, capacidad, disponible;
        decimal precio;
        string tipoEntrada;

        public int BoletoID { get { return boletoID; } set { boletoID = value; } }
        public int EventoID { get { return eventoID; } set { eventoID = value; } }
        public int Capacidad { get { return capacidad; } set { capacidad = value; } }
        public int Disponible { get { return disponible; } set { disponible = value; } }
        public decimal Precio { get { return precio; } set { precio = value; } }
        public string TipoEntrada { get { return tipoEntrada; } set { tipoEntrada = value; } }

    }
}
