using frmFlowTicket_v1.Data_Access_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmFlowTicket_v1
{
    public partial class frmMantenimientoEventos : Form
    {
        string imagenSelecc = "";
        public frmMantenimientoEventos()
        {
            InitializeComponent();
            TxtNombreEvento.Focus();
            EventoDAO eDAO = new EventoDAO();
            List<string> lista = eDAO.CargarEventosId();
            CmbCodigoEvento.DataSource = eDAO.CargarEventosId();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            EventoDAO eDAO = new EventoDAO();
            string nombreEvento = TxtNombreEvento.Text.Trim();
            string lugar = TxtLugar.Text.Trim();
            Conexion conexion = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_BuscarEvento", conexion.ObtenerConexion());
            DateTime? fechaEvento = null;
            if (DtpFechaEvento.Checked)
            {
                cmd.Parameters.AddWithValue("@fecha", DtpFechaEvento);
            }
            else
            {
                cmd.Parameters.AddWithValue("@fecha", DBNull.Value);
            }
            Evento eventoEncontrado = eDAO.BuscarEvento(nombreEvento, fechaEvento, lugar);
            if (eventoEncontrado != null)
            {
                PtbImagen.Visible = true;
                TxtNombreEvento.Text = eventoEncontrado.NombreEvento;
                TxtLugar.Text = eventoEncontrado.Lugar;
                TxtCapacidad.Text = eventoEncontrado.Cantidad.ToString();
                DtpFechaEvento.Value = (DateTime) eventoEncontrado.Fecha;
                CmbCodigoEvento.SelectedItem = eventoEncontrado.EventoID;
                if (!string.IsNullOrEmpty(eventoEncontrado.Imagen))
                {
                    string rutaImagen = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, eventoEncontrado.Imagen);
                    if (System.IO.File.Exists(rutaImagen))
                    {
                        PtbImagen.Image = System.Drawing.Image.FromFile(rutaImagen);
                        PtbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        PtbImagen.Image = null;
                        MessageBox.Show("La imagen del evento no se encontró en: " + rutaImagen, "Imagen no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    PtbImagen.Image = null;
                }

            }
            else
            {
                MessageBox.Show("No se encontró ningún evento con los criterios de búsqueda especificados.", "Evento No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNombreEvento.Text = "";
                TxtLugar.Text = "";
                TxtCapacidad.Text = "";
                PtbImagen.Image = null;
                DtpFechaEvento.Value.ToString();
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string imagen = "";
            int capacidad = 0;
            int eventoIdSelec;
            int.TryParse(CmbCodigoEvento.Text, out eventoIdSelec);
            if (!string.IsNullOrEmpty(imagenSelecc))
            {
                string carpetaDestino = Path.Combine(System.Windows.Forms.Application.StartupPath, "Conciertos");
                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }
                string rutaDestinoCompleta = Path.Combine(carpetaDestino, Path.GetFileName(imagenSelecc));
                File.Copy(imagenSelecc, rutaDestinoCompleta, true);
                imagen = Path.GetFileName(imagenSelecc);
            }
            string nombre = TxtNombreEvento.Text;
            string lugar = TxtLugar.Text;
            DateTime fecha = DtpFechaEvento.Value.Date;
            if (!int.TryParse(TxtCapacidad.Text, out capacidad))
            {
                MessageBox.Show("No se pudo registrar el evento", "Complete todos los campos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(lugar) || capacidad == 0)
            {
                MessageBox.Show("No se pudo registrar el evento", "Complete todos los campos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EventoDAO eDAO = new EventoDAO();
            int actualizacion = eDAO.ActualizarEvento(eventoIdSelec, nombre, lugar, fecha, capacidad, imagen);
            if (actualizacion == 1)
            {
                MessageBox.Show("Evento actualizado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNombreEvento.Clear();
                TxtLugar.Clear();
                TxtCapacidad.Clear();
                DtpFechaEvento.Value = DateTime.Now;
                PtbImagen.Image = null;
                imagenSelecc = "";
            }
            else
            {
                MessageBox.Show("No se pudo registrar el evento.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int eventoIdSelec;
            int.TryParse(CmbCodigoEvento.Text, out eventoIdSelec);
            EventoDAO eDAO = new EventoDAO();
            int eliminacion = eDAO.EliminarEvento(eventoIdSelec);
            if (eliminacion == 1)
            {
                MessageBox.Show("Evento eliminado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNombreEvento.Clear();
                TxtLugar.Clear();
                TxtCapacidad.Clear();
                DtpFechaEvento.Value = DateTime.Now;
                PtbImagen.Image = null;
                imagenSelecc = "";
            }

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string imagen = "";
            int capacidad = 0;
            if (!string.IsNullOrEmpty(imagenSelecc))
            {
                string carpetaDestino = Path.Combine(System.Windows.Forms.Application.StartupPath, "Conciertos");
                if (!Directory.Exists(carpetaDestino))
                {
                    Directory.CreateDirectory(carpetaDestino);
                }
                string rutaDestinoCompleta = Path.Combine(carpetaDestino, Path.GetFileName(imagenSelecc));
                File.Copy(imagenSelecc, rutaDestinoCompleta, true);
                imagen = Path.GetFileName(imagenSelecc);
            }
            string nombre = TxtNombreEvento.Text;
            string lugar = TxtLugar.Text;
            DateTime fecha = DtpFechaEvento.Value.Date;
            int.TryParse(TxtCapacidad.Text, out capacidad);
            if (!int.TryParse(TxtCapacidad.Text, out capacidad))
            {
                MessageBox.Show("No se pudo registrar el evento", "Complete todos los campos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(lugar) || capacidad == 0)
            {
                MessageBox.Show("No se pudo registrar el evento", "Complete todos los campos correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EventoDAO eDAO = new EventoDAO();
            int registro = eDAO.RegistrarEvento(nombre, lugar, fecha, capacidad, imagen);
            if (registro == 1)
            {
                MessageBox.Show("Evento registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNombreEvento.Clear();
                TxtLugar.Clear();
                TxtCapacidad.Clear();
                DtpFechaEvento.Value = DateTime.Now;
                PtbImagen.Image = null;
                imagenSelecc = "";
                CmbCodigoEvento.Visible = false;
                PtbImagen.Visible = true;
            }
            else
            {
                MessageBox.Show("No se pudo registrar el evento.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "archivos de imagenes (.png; *.jpg)|.png;*jpg";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                imagenSelecc = archivo.FileName;
                PtbImagen.Image = System.Drawing.Image.FromFile(imagenSelecc);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtLugar.Clear();
            TxtNombreEvento.Clear();
            TxtCapacidad.Clear();
            TxtCapacidad.Visible = true;
            TxtLugar.Visible = true;
            PtbImagen.Visible = false;
            TxtNombreEvento.Visible = true;
            CmbCodigoEvento.Visible = true;
            CmbCodigoEvento.SelectedIndex = 0;
            DtpFechaEvento.Visible = true;
            DtpFechaEvento.Value = DateTime.Now;
        }
    }
}
