using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmFlowTicket_v1
{
    internal class Conexion
    {
        private readonly string cadenaConexion;
        private SqlConnection conexion;

        public Conexion()
        {
            // Cambia los valores según tu configuración
            cadenaConexion = "Server=RICARDO;Database=FACTURACIONPI;User Id=prograuno;Password=Pr0gr4.;";
            conexion = new SqlConnection(cadenaConexion);
        }

        // Obtener la conexión actual (puede ser útil en otras clases)
        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }

        // Abrir conexión
        public void Abrir()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        // Cerrar conexión
        public void Cerrar()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
