using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace frmFlowTicket_v1.Data_Access_Object
{
    internal class EventoDAO
    {
        public List<string> VerEventos(DateTime f1, DateTime f2) {
            Conexion conexion = new Conexion();
            List<string> lista = new List<string>();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_VerEventosFecha", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fechainicio", f1);
                cmd.Parameters.AddWithValue("@fechafin", f2);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    lista.Add(sdr.GetString(1));
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en conexión: " + ex.Message);
            }
            return lista;
        }

        public Evento ObtenerInformacionEvento(string nombre) { 
            Evento evento = new Evento();
            Conexion conexion = new Conexion();

            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_BuscarEvento", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@lugar", DBNull.Value);
                cmd.Parameters.AddWithValue("@fecha", DBNull.Value);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    evento.EventoID = sdr.GetInt32(0);
                    evento.NombreEvento = sdr.GetString(1);
                    evento.Fecha = sdr.GetDateTime(2);
                    evento.Lugar = sdr.GetString(3);
                    evento.Cantidad = sdr.GetInt32(4);
                    evento.Imagen = sdr.GetString(5);
                }
                sdr.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error en conexión: " + ex.Message);
            }
            return evento;
        }

        public Evento BuscarEvento(string nombreEvento, DateTime? fecha, string lugar)
        {
            Evento evento = null;
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_BuscarEvento", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombreEvento);
                cmd.Parameters.AddWithValue("@Lugar", lugar);

                if (fecha.HasValue)
                {
                    cmd.Parameters.AddWithValue("@fecha", fecha.Value.Date);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@fecha", DBNull.Value);
                }
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    if (sdr.Read())
                    {
                        evento = new Evento();
                        evento.EventoID = sdr.GetInt32(0);
                        evento.NombreEvento = sdr.GetString(1);
                        evento.Fecha = sdr.GetDateTime(2);
                        evento.Lugar = sdr.GetString(3);
                        evento.Cantidad = sdr.GetInt32(4);
                        evento.Imagen = sdr["Poster"].ToString();
                    }
                    sdr.Close();
                }
                conexion.Cerrar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos en BuscarEvento: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                evento = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion en BD (bu): " + ex.Message);
                conexion.Cerrar();
            }
            return evento;
        }

        public List<string> CargarEventosId()
        {
            Conexion conexion = new Conexion();
            List<string> listaE = new List<string>();

            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_ObtenerEventosId", conexion.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();
                
                while (sdr.Read())
                {                    
                    listaE.Add(sdr.GetInt32(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaE;
        }

        public int RegistrarEvento(string nombreEvento, string lugar, DateTime? fecha, int capacidad, string imagen)
        {
            int resp = 0;
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_InsertarEvento", conexion.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombreEvento);
                cmd.Parameters.AddWithValue("@Lugar", lugar);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                cmd.Parameters.AddWithValue("@foto", imagen);

                SqlParameter respuesta = new SqlParameter("@respuesta", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
                };
                cmd.Parameters.Add(respuesta);

                cmd.ExecuteNonQuery();

                if (respuesta.Value != null && respuesta.Value != DBNull.Value)
                {
                    resp = Convert.ToInt32(respuesta.Value);
                }
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion en BD: " + ex.Message);
                conexion.Cerrar();
            }
            return resp;
        }

        public int ActualizarEvento(int eventoId, string nombreEvento, string lugar, DateTime? fecha, int capacidad, string imagen)
        {
            int respuesta = 0;
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_ActualizarEvento", conexion.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EventoId", eventoId);
                cmd.Parameters.AddWithValue("@Nombre", nombreEvento);
                cmd.Parameters.AddWithValue("@Lugar", lugar);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                cmd.Parameters.AddWithValue("@Foto", imagen);
                SqlParameter resp = new SqlParameter("@respuesta", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
                };
                cmd.Parameters.Add(resp);

                cmd.ExecuteNonQuery();

                respuesta = Convert.ToInt32(resp.Value);
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion en BD: " + ex.Message);
                conexion.Cerrar();
                respuesta = 0;
            }
            return respuesta;
        }

        public int EliminarEvento(int eventoId)
        {
            Conexion conexion = new Conexion();
            int respuesta = 0;
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_EliminarEvento", conexion.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eventoId", eventoId);
                SqlParameter resp = new SqlParameter("@respuesta", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
                };
                cmd.Parameters.Add(resp);
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToInt32(resp.Value);
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion en BD: " + ex.Message);
                conexion.Cerrar();
                respuesta = 0;
            }

            return respuesta;
        }
    }
}
