using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmFlowTicket_v1
{
    internal class Evento
    {
        int eventoID, cantidad;
        string nombreEvento, lugar, imagen;
        DateTime fecha;

        public string NombreEvento { get { return nombreEvento; } set { nombreEvento = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public string Lugar { get { return lugar; } set { lugar = value; } }
        public string Imagen { get { return imagen; } set { imagen = value; } }
        public int EventoID { get { return eventoID; } set { eventoID = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }

    }
}
