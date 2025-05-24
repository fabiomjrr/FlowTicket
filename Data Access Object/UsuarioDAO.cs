using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using frmFlowTicket_v1;
using System.Runtime.Remoting.Messaging;

namespace frmFlowTicket_v1.Data_Access_Object
{
    internal class UsuarioDAO
    {

        public int BuscarLogin(string username,string password){
            Conexion conexion = new Conexion();
            Usuario u = new Usuario();
            int respuesta=0;
            string patron = "Fl0wTick3t";
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_ValidarLogin", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@patron", patron);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    u.Username = sdr[0].ToString();
                    u.Password = sdr[1].ToString();
                }
                sdr.Close();

                if (username == u.Username)
                {
                    conexion.Cerrar();
                    respuesta = 1;
                }
                else 
                {
                    conexion.Cerrar();
                    respuesta = 0;
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login no es correcto: " + ex.Message);
                respuesta = 0;
                return respuesta;
            }
        }

        public Usuario BuscarUsuario(string codigo,string nombre,string username,string documento,string email)
        {
            Usuario user = new Usuario();
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_BuscarUsuario", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoUsuario", codigo);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Documento", documento);
                cmd.Parameters.AddWithValue("@Email", email);

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        user.UsuarioID = sdr.GetString(0);
                        user.Nombre = sdr.GetString(1);
                        user.Sexo = sdr.GetString(2);
                        user.TipoDocumento = sdr.GetString(3);
                        user.Documento = sdr.GetString(4);
                        DateTime fecha = sdr.GetDateTime(5);
                        user.FechaNacimiento = fecha.ToString("yyyy-MM-dd");
                        user.Telefono = sdr.GetString(6);
                        user.Email = sdr.GetString(7);
                        user.Username = sdr.GetString(8);
                        user.Password = "********";
                        //user.FechaRegistro = sdr.GetString(10);
                        bool estadobool = sdr.GetBoolean(10);
                        user.Estado = (byte)(estadobool ? 1 : 0);
                        bool tipouser = sdr.GetBoolean(11);
                        user.TipoUsuario = (bool)(tipouser ? true : false);
                    }
                    sdr.Close();
                }
                conexion.Cerrar();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error de conexion en BD (bu): " + ex.Message);
                conexion.Cerrar();
            }
            return user;
        }

        public List<string> BuscarCodigoUsuario()
        {
            List<string> codigos = new List<string>();
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_VerCodigoUsuario", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        codigos.Add(sdr.GetString(0));
                    }
                    sdr.Close();
                }
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion en BD: " + ex.Message);
                conexion.Cerrar();
            }

            return codigos;
        }
        public string InsertarUsuario(string nombre,string sexo,string tipodocumento,string documento,DateTime fechanacimento,string telefonomovil,string email, string username,string password,string patron,byte estado, bool tipo){
            string code="";
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_InsertarUsuario", conexion.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Sexo", sexo);
                cmd.Parameters.AddWithValue("@TipoDocumento", tipodocumento);
                cmd.Parameters.AddWithValue("@Documento", documento);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechanacimento);
                cmd.Parameters.AddWithValue("@TelefonoMovil", telefonomovil);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Patron", patron);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@Tipo", tipo);

                SqlParameter codigo = new SqlParameter("@codigoUsuario", System.Data.SqlDbType.VarChar, 10)
                {
                    Direction = System.Data.ParameterDirection.Output
                };
                cmd.Parameters.Add(codigo);

                cmd.ExecuteNonQuery();

                code = codigo.Value.ToString();
                conexion.Cerrar();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error de conexion en BD: " + ex.Message);
                conexion.Cerrar();
            }
            return code;
        }

        public int ActualizarUsuario(Usuario user)
        {
            int respuesta = 0;
            Conexion conexion = new Conexion();
            DateTime fecha = DateTime.Parse(user.FechaNacimiento);
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_ActualizarUsuario", conexion.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", user.UsuarioID);
                cmd.Parameters.AddWithValue("@Nombre", user.Nombre);
                cmd.Parameters.AddWithValue("@Sexo", user.Sexo);
                cmd.Parameters.AddWithValue("@TipoDocumento", user.TipoDocumento);
                cmd.Parameters.AddWithValue("@Documento", user.Documento);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fecha);
                cmd.Parameters.AddWithValue("@TelefonoMovil", user.Telefono);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Patron", "Fl0wTick3t");
                cmd.Parameters.AddWithValue("@Estado", user.Estado);
                cmd.Parameters.AddWithValue("@Tipo", user.TipoUsuario);
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

        public int EliminarUsuario(string codigoUsuario)
        {
            Conexion conexion = new Conexion();
            int respuesta=0;
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", conexion.ObtenerConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", codigoUsuario);
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

        public List<string> BuscarCodigoNombre()
        {
            List<string> lista = new List<string>();
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_VerUsuariosConFactura", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        lista.Add(sdr.GetString(0) + "-" + sdr.GetString(1));
                    }
                    sdr.Close();
                }
                conexion.Cerrar();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error de conexion en BD: " + ex.Message);
                conexion.Cerrar();
            }
            return lista;
        }

        public bool ValidarTipoUsu(string username)
        {
            Conexion conexion = new Conexion();
            Usuario u = new Usuario();
            bool resultado=false;
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("sp_VerificarTipoUsuario", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", username);
                SqlParameter TipoUsu = new SqlParameter("@tipo", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(TipoUsu);

                cmd.ExecuteNonQuery();
                
                resultado = (bool)TipoUsu.Value;
                conexion.Cerrar();
                return resultado;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion en BD: " + e.Message);
                return resultado;
            }
        }

       

    }
}


