using frmFlowTicket_v1.Data_Access_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmFlowTicket_v1
{
    public partial class frmVerEventos : Form
    {
        public frmVerEventos()
        {
            InitializeComponent();
            DtpFechaInicio.Value = DateTime.Now;
            DtpFechaInicio.Enabled = false;
            CmbEventos.Items.Clear();
            CmbEventos.Items.Add("Eventos disponibles..");
            CmbEventos.SelectedItem = "Eventos disponibles..";        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechainicio = DtpFechaInicio.Value.Date;
            DateTime fechafin = DtpFechaFin.Value.Date;

            if (fechainicio >= fechafin)
            {
                MessageBox.Show("La fecha de inicio debe ser menor que la fecha fin");
            }
            else {
                EventoDAO eDAO = new EventoDAO();
                List<string> NombreEventos = eDAO.VerEventos(fechainicio, fechafin);
                CmbEventos.DataSource = NombreEventos;
            }       
        }

        private void BtnVerEvento_Click(object sender, EventArgs e)
        {
            if(CmbEventos.SelectedItem.Equals("Eventos disponibles..")){
                MessageBox.Show("Debes buscar los eventos con el rango de fecha de tu preferencia");
            }
            else
            {
                Evento eve = new Evento();
                eve.NombreEvento = CmbEventos.SelectedItem.ToString();
                EventoDAO eDAO = new EventoDAO();
                eve = eDAO.ObtenerInformacionEvento(eve.NombreEvento);
                Boletos bol = new Boletos();
                BoletoDAO bDAO = new BoletoDAO();
                List<Boletos> lista = bDAO.VerLocalidades(eve.EventoID);


                if (eve != null)
                {
                    LblNombreEvento.Text = eve.NombreEvento;
                    LblFechaEvento.Text = eve.Fecha.ToString();
                    LblLugarEvento.Text = eve.Lugar;
                    string rutaimagen = Path.Combine(Application.StartupPath, eve.Imagen);
                    if (File.Exists(rutaimagen))
                    {
                        PtbEvento.Image = Image.FromFile(rutaimagen);
                        PtbEvento.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        PtbEvento.Image = null;
                    }
                }

                DgvLocalidades.DataSource = lista;
                DgvLocalidades.Columns["BoletoID"].Visible = false;
                DgvLocalidades.Columns["Capacidad"].Visible = false;
                DgvLocalidades.Columns["Disponible"].Visible = false;
                DgvLocalidades.Columns["EventoID"].Visible = false;
                DgvLocalidades.Columns["TipoEntrada"].DisplayIndex = 0;
                DgvLocalidades.Columns["Precio"].DisplayIndex = 1;
                DgvLocalidades.Columns["TipoEntrada"].HeaderText = "Localidad";
                DgvLocalidades.Columns["Precio"].HeaderText = "Precio";
                DgvLocalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            frmMenuUf fmu = new frmMenuUf();
            fmu.Show();
            this.Close();
        }
    }
}
