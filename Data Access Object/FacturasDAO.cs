using frmFlowTicket_v1.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmFlowTicket_v1.Data_Access_Object
{
    internal class FacturasDAO
    {
        public List<string> BuscarFacturas (string usuario)
        {
            List<string> facturas = new List<string>();
            string facturaid = "";
            string estado = "";
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_BuscarFactura", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Facturaid", facturaid);
                cmd.Parameters.AddWithValue("@Usuarioid", usuario);
                cmd.Parameters.AddWithValue("@Estado", estado);

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    { 
                        facturas.Add(sdr.GetString(0));
                    }
                    sdr.Close();
                }
                conexion.Cerrar();
                if (facturas.Count == 0)
                {
                    MessageBox.Show("No se encontraron facturas para este usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion en BD: " + ex.Message);
                conexion.Cerrar();
            }
            return facturas;
        }

        public List<DetalleFacturaVista> ObtenerDetalleFactura(string factura)
        {
            List<DetalleFacturaVista> ldfv = new List<DetalleFacturaVista>();
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_ObtenerDetalleFactura", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Facturaid", factura);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {

                        DetalleFacturaVista df = new DetalleFacturaVista();
                        df.FacturaID = sdr.GetString(0);
                        df.Correlativo = sdr.GetInt32(1);
                        df.Estado = sdr.GetString(2);
                        df.NombreCompleto = sdr.GetString(3);
                        df.Evento = sdr.GetString(4);
                        df.FechaEmision = sdr.GetDateTime(5);
                        df.TipoEntrada = sdr.GetString(6);
                        df.Cantidad = sdr.GetInt16(7);
                        df.PrecioUnitario = sdr.IsDBNull(8) ? 0 : Convert.ToDecimal(sdr[8]);
                        df.CargoPorServicio = sdr.IsDBNull(9) ? 0 : Convert.ToDecimal(sdr[9]);
                        df.Impuesto = sdr.IsDBNull(10) ? 0 : Convert.ToDecimal(sdr[10]);
                        df.Subtotal = sdr.IsDBNull(11) ? 0 : Convert.ToDecimal(sdr[11]);

                        ldfv.Add(df);
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
            return ldfv;
        }

        public List<string> BuscarFacturas(string estado,DateTime fecha1,DateTime fecha2)
        {
            List<string> facturas = new List<string>();
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_BuscarFacturaxFechas", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fechainicio", fecha1);
                cmd.Parameters.AddWithValue("@fechafin", fecha2);
                cmd.Parameters.AddWithValue("@estado", estado);

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        facturas.Add(sdr.GetString(0));
                    }
                    sdr.Close();
                }
                conexion.Cerrar();
                if (facturas.Count == 0)
                {
                    MessageBox.Show("No se encontraron facturas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion en BD: " + ex.Message);
                conexion.Cerrar();
            }
            return facturas;
        }

        public List<string> BuscarFacturas(string estado,string usuario)
        {
            List<string> facturas = new List<string>();
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                MessageBox.Show("Usuario=" + usuario + ", Estado Factura"+estado);
                SqlCommand cmd = new SqlCommand("SP_BuscarFacturaxEstado", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@user", usuario);

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        facturas.Add(sdr.GetString(0));
                    }
                    sdr.Close();
                }
                conexion.Cerrar();
                if (facturas.Count == 0)
                {
                    MessageBox.Show("No se encontraron facturas para este usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion en BD: " + ex.Message);
                conexion.Cerrar();
            }
            return facturas;
        }

        public Factura VerFactura(string facturaid)
        {
            Factura facturas = new Factura();
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_VerFactura", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@facturaid", facturaid);

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        Factura f = new Factura();
                        f.FacturaID=sdr.GetString(0);
                        f.Correlativo=sdr.GetInt32(1);
                        f.UsuarioID = sdr.GetString(2);
                        f.FechaEmision = sdr.GetDateTime(3);
                        f.TotalPago = Convert.ToDouble(sdr.GetDecimal(4));
                        f.Estado = sdr.GetString(5);
                        facturas = f;
                    }
                    sdr.Close();
                }
                conexion.Cerrar();
                if (facturas == null)
                {
                    MessageBox.Show("No se encontraron registros de factura.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion en BD: " + ex.Message);
                conexion.Cerrar();
            }
            return facturas;
        }

        public Factura ObtenerDatosFactura(string usuarioID)
        {
            Factura factura = new Factura();
            Conexion conexion = new Conexion();
            try
            {
                conexion.Abrir();
                SqlCommand cmd = new SqlCommand("SP_CrearFactura", conexion.ObtenerConexion());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuarioID", usuarioID);
                SqlParameter respuestaParam = new SqlParameter("@RESPUESTA", SqlDbType.Int);
                respuestaParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(respuestaParam);
                SqlParameter facturaIDParam = new SqlParameter("@FACTURAID", SqlDbType.Char, 10);
                facturaIDParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(facturaIDParam);
                cmd.ExecuteNonQuery();
                int respuesta = (int)respuestaParam.Value;
                string facturaIDGenerado = facturaIDParam.Value.ToString().Trim();

                if (respuesta == 1)
                {
                    factura = new Factura
                    {
                        FacturaID = facturaIDGenerado,
                        UsuarioID = usuarioID,
                        Estado = "GEN",
                        FechaEmision = DateTime.Now,
                        TotalPago = 0.00,
                        Correlativo = 0
                    };
                    MessageBox.Show($"Factura generada exitosamente. ID: {facturaIDGenerado}");
                }
                else
                {
                    // Si la respuesta es 0 (fallo)
                    MessageBox.Show("Error al generar la factura. Verifique los logs del servidor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en conexión o ejecución del SP: " + ex.Message);
                factura = null; // Aseguramos que sea null en caso de excepción
            }
            return factura;
        }

    }
}
