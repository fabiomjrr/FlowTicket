using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmFlowTicket_v1.Data_Access_Object
{
    internal class BoletoDAO
    {
        public List<Boletos> VerLocalidades(int evento)
        {
            List<Boletos> listaBoletos = new List<Boletos>();
            Conexion conexion = new Conexion();

            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_BuscarBoleto", conexion.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@evento", evento);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Boletos boleto = new Boletos();
                    boleto.BoletoID = sdr.IsDBNull(0) ? 0 : sdr.GetInt32(0);
                    boleto.TipoEntrada = sdr.IsDBNull(1) ? "" : sdr.GetString(1);
                    boleto.Precio = sdr.IsDBNull(2) ? 0 : Math.Round(sdr.GetDecimal(2),2);
                    boleto.Capacidad = sdr.IsDBNull(3) ? 0 : sdr.GetInt32(3);
                    boleto.Disponible = sdr.IsDBNull(4) ? 0 : sdr.GetInt32(4);
                    listaBoletos.Add(boleto);
                }
                sdr.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error en conexión: " + ex.Message);
            }
            return listaBoletos;
        }    

    }
}
