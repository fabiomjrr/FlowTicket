using frmFlowTicket_v1.Data_Access_Object;
using frmFlowTicket_v1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmFlowTicket_v1
{
    public partial class IniciarSesion : Form
    {
        SesionUsuario s = new SesionUsuario();
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioDAO uDAO = new UsuarioDAO();
            usuario.Username = TxtUsuario.Text;
            usuario.Password = TxtPassword.Text;
            int respuesta=0;

            if (usuario.Username.Equals("")){ 
                
            }else if (usuario.Password.Equals("")){

            }
            else
            {
                respuesta = uDAO.BuscarLogin(usuario.Username, usuario.Password);
            }

            if (respuesta == 0 || usuario.Username == "" || usuario.Password == "")
            {
                MessageBox.Show("Inicio de sesión incorrecto, complete correctamente los campos", "Intente nuevamente", MessageBoxButtons.OK);
            }
            else
            {   
                MessageBox.Show("Bienvenido "+ usuario.Username);
                bool tipo = uDAO.ValidarTipoUsu(usuario.Username);
                SesionUsuario.NombreUsuario = usuario.Username;
                if (tipo)
                {
                    SesionUsuario.Tipo = tipo;
                    frmMenuAdm frma = new frmMenuAdm();
                    frma.Show();
                    Hide();
                }
                else
                {
                    SesionUsuario.Tipo = tipo;
                    frmMenuUf frmu = new frmMenuUf();
                    frmu.Show();
                    Hide();

                }
            }
        }

        private void LblRegistroUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool registrado = false;
            frmMantenimientoUsuarios mu = new frmMantenimientoUsuarios(registrado);
            mu.Show();
            Hide();
        }
    }
}
