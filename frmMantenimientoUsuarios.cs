using frmFlowTicket_v1.Data_Access_Object;
using frmFlowTicket_v1.Modelos;
using Microsoft.Win32;
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
    public partial class frmMantenimientoUsuarios : Form
    {
        bool registro = false;
        public frmMantenimientoUsuarios()
        {
            InitializeComponent();
            registro = true;
            TxtPasword.PasswordChar = '*';
            UsuarioDAO ud = new UsuarioDAO();
            List<string> codigoUsuario = ud.BuscarCodigoUsuario();
            CmbCodigo.DataSource = codigoUsuario;
            CmbEstado.Items.Clear();
            CmbEstado.Items.Add("ESTADO");
            CmbEstado.Items.Add("ACTIVO");
            CmbEstado.Items.Add("INACTIVO");
            CmbEstado.SelectedItem = "ESTADO";
            CmbTipoUser.Items.Clear();
            CmbTipoUser.Items.Add("TIPO USUARIO");
            CmbTipoUser.Items.Add("ADMINISTRADOR");
            CmbTipoUser.Items.Add("USUARIO FINAL");
            CmbTipoUser.SelectedItem = "TIPO USUARIO";
            CmbSexo.Items.Clear();
            CmbSexo.Items.Add("SEXO");
            CmbSexo.Items.Add("MASCULINO");
            CmbSexo.Items.Add("FEMENINO");
            CmbSexo.SelectedItem = "SEXO";
            CmbTipoDocumento.Items.Clear();
            CmbTipoDocumento.Items.Add("TIPO DOCUMENTO");
            CmbTipoDocumento.Items.Add("DUI");
            CmbTipoDocumento.Items.Add("LICENCIA DE CONDUCIR");
            CmbTipoDocumento.Items.Add("PASAPORTE");
            CmbTipoDocumento.SelectedItem = "TIPO DOCUMENTO";
        }

        public frmMantenimientoUsuarios(bool registrado)
        {
            InitializeComponent();
            registro = registrado;
            TxtPasword.PasswordChar = '*';
            UsuarioDAO ud = new UsuarioDAO();
            CmbCodigo.Enabled = false;
            CmbEstado.Items.Clear();
            CmbEstado.Items.Add("ESTADO");
            CmbEstado.Items.Add("ACTIVO");
            CmbEstado.Items.Add("INACTIVO");
            CmbEstado.SelectedItem = "ACTIVO";
            CmbTipoUser.Items.Clear();
            CmbTipoUser.Items.Add("TIPO USUARIO");
            CmbTipoUser.Items.Add("ADMINISTRADOR");
            CmbTipoUser.Items.Add("USUARIO FINAL");
            CmbTipoUser.SelectedItem = "USUARIO FINAL";
            CmbSexo.Items.Clear();
            CmbSexo.Items.Add("SEXO");
            CmbSexo.Items.Add("MASCULINO");
            CmbSexo.Items.Add("FEMENINO");
            CmbSexo.SelectedItem = "SEXO";
            CmbTipoDocumento.Items.Clear();
            CmbTipoDocumento.Items.Add("TIPO DOCUMENTO");
            CmbTipoDocumento.Items.Add("DUI");
            CmbTipoDocumento.Items.Add("LICENCIA DE CONDUCIR");
            CmbTipoDocumento.Items.Add("PASAPORTE");
            CmbTipoDocumento.SelectedItem = "TIPO DOCUMENTO";
            CmbEstado.Enabled = false;
            CmbTipoUser.Enabled = false;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnBuscar.Enabled = false;
        }

        public List<string> CargarComboBox()
        {
            UsuarioDAO uDAO = new UsuarioDAO();
            List<string> codigoUsuario = uDAO.BuscarCodigoUsuario();
            return codigoUsuario;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            UsuarioDAO ud = new UsuarioDAO();
            Usuario u = new Usuario();

            List<string> codigos = new List<string>();
            if (BtnRegistrar.Text.Equals("Registrar Usuario"))
            {
                TxtNombre.Text = "";
                TxtDocumento.Text = "";
                TxtTelefono.Text = "";
                TxtUsuario.Text = "";
                TxtPasword.Text = "";
                TxtCorreo.Text = "";
                CmbCodigo.DataSource = CargarComboBox();
                CmbEstado.SelectedItem = "ESTADO";
                CmbSexo.SelectedItem = "SEXO";
                CmbTipoDocumento.SelectedItem = "TIPO DOCUMENTO";
                CmbTipoUser.SelectedItem = "TIPO USUARIO";
                BtnBuscar.Enabled = false;
                BtnActualizar.Enabled = false;
                BtnEliminar.Enabled = false;
                CmbCodigo.Enabled = false;
                BtnLimpiar.Text = "Regresar";
                BtnRegistrar.Text = "Confirmar";
            }
            else if (BtnRegistrar.Text.Equals("Confirmar"))
            {
                u.Nombre = TxtNombre.Text;
                u.TipoDocumento = (string)CmbTipoDocumento.SelectedItem;
                u.Documento = TxtDocumento.Text;
                u.Telefono = TxtTelefono.Text;
                u.Username = TxtUsuario.Text;
                u.Password = TxtPasword.Text;
                u.Email = TxtCorreo.Text;
                u.Sexo = (string)CmbSexo.SelectedItem;
                if (CmbEstado.SelectedItem.Equals("ACTIVO"))
                    u.Estado = 1;
                else if (CmbEstado.SelectedItem.Equals("INACTIVO"))
                    u.Estado = 0;
                if (CmbTipoUser.SelectedItem.Equals("ADMINISTRADOR"))
                    u.TipoUsuario = true;
                else if (CmbTipoUser.SelectedItem.Equals("USUARIO FINAL"))
                    u.TipoUsuario = false;
                DateTime fecha = DtpFechaNacimiento.Value;
                int edad = (DateTime.Now.Year - fecha.Year);

                if (u.Nombre.Equals(""))
                {
                    MessageBox.Show("Debes ingresar el nombre");
                    TxtNombre.Focus();
                }
                else if (u.TipoDocumento.Equals("TIPO DOCUMENTO"))
                {
                    MessageBox.Show("Debes elegir un tipo de documento");
                    CmbTipoDocumento.Focus();
                }
                else if (u.Documento.Equals(""))
                {
                    MessageBox.Show("Debes ingresar el numero de documento");
                    TxtDocumento.Focus();
                }
                else if (u.Telefono.Equals(""))
                {
                    MessageBox.Show("Debes ingresar un telefono");
                    TxtTelefono.Focus();
                }
                else if (u.Username.Equals(""))
                {
                    MessageBox.Show("Debes ingresar un nombre de usuario");
                    TxtUsuario.Focus();
                }
                else if (u.Password.Equals(""))
                {
                    MessageBox.Show("Debes ingresar una contraseña");
                    TxtPasword.Focus();
                }
                else if (u.Email.Equals(""))
                {
                    MessageBox.Show("Debes ingresar un correo");
                    TxtCorreo.Focus();
                }
                else if (u.Sexo.Equals("SEXO"))
                {
                    MessageBox.Show("Debes elegir el sexo de la persona");
                    CmbSexo.Focus();
                }
                else if (u.Estado.Equals("ESTADO"))
                {
                    MessageBox.Show("Debes elegir el estado del usuario");
                    CmbEstado.Focus();
                }
                else if (u.TipoUsuario.Equals("TIPO USUARIO"))
                {
                    MessageBox.Show("Debes elegir el tipo de usuario");
                    CmbTipoUser.Focus();
                }
                else if (edad < 18)
                {
                    MessageBox.Show("Debes ser mayor de edad");
                    DtpFechaNacimiento.Focus();
                }
                else
                {   
                    u.UsuarioID = ud.InsertarUsuario(u.Nombre, u.Sexo, u.TipoDocumento, u.Documento, fecha, u.Telefono, u.Email, u.Username, u.Password, "Fl0wTick3t", u.Estado, u.TipoUsuario);

                    if (u.UsuarioID.Length > 0)
                    {
                        CmbCodigo.Text = u.UsuarioID;
                        MessageBox.Show("Usuario insertado exitosamente!!");
                        TxtNombre.Text = "";
                        TxtDocumento.Text = "";
                        TxtTelefono.Text = "";
                        TxtUsuario.Text = "";
                        TxtPasword.Text = "";
                        TxtCorreo.Text = "";
                        CmbCodigo.DataSource = CargarComboBox(); ;
                        CmbEstado.SelectedItem = "ESTADO";
                        CmbSexo.SelectedItem = "SEXO";
                        CmbTipoDocumento.SelectedItem = "TIPO DOCUMENTO";
                        CmbTipoUser.SelectedItem = "TIPO USUARIO";
                        BtnRegistrar.Text = "Registrar Usuario";
                        if (registro)
                        {
                            BtnActualizar.Enabled = true;
                            BtnEliminar.Enabled = true;
                            BtnBuscar.Enabled = true;
                            BtnLimpiar.Text = "Limpiar";
                        }
                        else
                        {
                            BtnLimpiar.Text = "Limpiar";
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Algo no salio bien!!");
                    }
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (BtnBuscar.Text.Equals("Buscar Usuario"))
            {
                TxtPasword.Enabled = false;
                TxtTelefono.Enabled = false;
                CmbSexo.Enabled = false;
                DtpFechaNacimiento.Enabled = false;
                CmbEstado.Enabled = false;
                CmbTipoDocumento.Enabled = false;
                CmbTipoUser.Enabled = false;
                BtnRegistrar.Enabled = false;
                BtnLimpiar.Text = "Regresar";
                BtnBuscar.Text = "Ver Usuario";
                TxtNombre.Focus();
            }
            else if (BtnBuscar.Text.Equals("Ver Usuario"))
            {
                Usuario u = new Usuario();
                UsuarioDAO uDao = new UsuarioDAO();

                u.Nombre = TxtNombre.Text;
                u.Documento = TxtDocumento.Text;
                u.Email = TxtCorreo.Text;
                u.Username = TxtUsuario.Text;
                u.UsuarioID = (string)CmbCodigo.SelectedItem;

                u = uDao.BuscarUsuario(u.UsuarioID, u.Nombre, u.Username, u.Documento, u.Email);

                if (u != null)
                {
                    if (!string.IsNullOrEmpty(u.UsuarioID))
                    {
                        MessageBox.Show("Usuario encontrado!");
                        TxtNombre.Text = u.Nombre;
                        TxtDocumento.Text = u.Documento;
                        TxtTelefono.Text = u.Telefono;
                        TxtUsuario.Text = u.Username;
                        TxtPasword.Text = u.Password;
                        TxtCorreo.Text = u.Email;
                        CmbCodigo.Text = u.UsuarioID;
                        CmbTipoDocumento.Text = u.TipoDocumento;
                        if (DateTime.TryParse(u.FechaNacimiento, out DateTime fecha))
                        {
                            DtpFechaNacimiento.Value = fecha;
                        }
                        if (u.Estado == 1)
                            CmbEstado.Text = "ACTIVO";
                        else
                            CmbEstado.Text = "INACTIVO";
                        if (u.TipoUsuario == true)
                            CmbTipoUser.Text = "ADMINISTRADOR";
                        else
                            CmbTipoUser.Text = "USUARIO FINAL";
                        CmbSexo.Text = u.Sexo;
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado!");
                    }
                    TxtNombre.Enabled = true;
                    TxtCorreo.Enabled = true;
                    TxtUsuario.Enabled = true;
                    TxtPasword.Enabled = true;
                    TxtTelefono.Enabled = true;
                    CmbSexo.Enabled = true;
                    DtpFechaNacimiento.Enabled = true;
                    CmbEstado.Enabled = true;
                    CmbTipoDocumento.Enabled = true;
                    CmbTipoUser.Enabled = true;
                    BtnRegistrar.Enabled = true;
                    BtnLimpiar.Text = "Limpiar";
                    BtnBuscar.Text = "Buscar Usuario";
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado!");
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (BtnLimpiar.Text.Equals("Limpiar"))
            {
                TxtNombre.Text = "";
                TxtDocumento.Text = "";
                TxtTelefono.Text = "";
                TxtUsuario.Text = "";
                TxtPasword.Text = "";
                TxtCorreo.Text = "";
                CmbCodigo.DataSource = CargarComboBox();
                CmbEstado.SelectedItem = "ESTADO";
                CmbSexo.SelectedItem = "SEXO";
                CmbTipoDocumento.SelectedItem = "TIPO DOCUMENTO";
                CmbTipoUser.SelectedItem = "TIPO USUARIO";
            }
            else if (BtnLimpiar.Text.Equals("Regresar"))
            {
                TxtNombre.Text = "";
                TxtDocumento.Text = "";
                TxtTelefono.Text = "";
                TxtUsuario.Text = "";
                TxtPasword.Text = "";
                TxtCorreo.Text = "";
                CmbCodigo.DataSource = CargarComboBox();
                CmbEstado.SelectedItem = "ESTADO";
                CmbSexo.SelectedItem = "SEXO";
                CmbTipoDocumento.SelectedItem = "TIPO DOCUMENTO";
                CmbTipoUser.SelectedItem = "TIPO USUARIO";
                BtnBuscar.Enabled = true;
                BtnRegistrar.Text = "Registrar Usuario";
                BtnActualizar.Text = "Actualizar Usuario";
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            UsuarioDAO ud = new UsuarioDAO();
            Usuario u = new Usuario();
            List<string> codigos = new List<string>();

            if (BtnActualizar.Text.Equals("Actualizar Usuario"))
            {
                CmbCodigo.Focus();
                BtnRegistrar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnBuscar.Text = "Ver Usuario";
                BtnLimpiar.Text = "Regresar";
                BtnActualizar.Text = "Confirmar";
            }
            else if (BtnActualizar.Text.Equals("Confirmar"))
            {
                u.UsuarioID = (string)CmbCodigo.SelectedItem;
                u.Nombre = TxtNombre.Text;
                u.TipoDocumento = (string)CmbTipoDocumento.SelectedItem;
                u.Documento = TxtDocumento.Text;
                u.Telefono = TxtTelefono.Text;
                u.Username = TxtUsuario.Text;
                if (TxtPasword.Text.Equals(""))
                    u.Password = "0";
                else
                    u.Password = TxtPasword.Text;
                u.Email = TxtCorreo.Text;
                u.Sexo = (string)CmbSexo.SelectedItem;
                if (CmbEstado.SelectedItem.Equals("ACTIVO"))
                    u.Estado = 1;
                else if (CmbEstado.SelectedItem.Equals("INACTIVO"))
                    u.Estado = 0;
                if (CmbTipoUser.SelectedItem.Equals("ADMINISTRADOR"))
                    u.TipoUsuario = true;
                else if (CmbTipoUser.SelectedItem.Equals("USUARIO FINAL"))
                    u.TipoUsuario = false;
                DateTime fecha = DtpFechaNacimiento.Value;
                int edad = (DateTime.Now.Year - fecha.Year);
                u.FechaNacimiento = fecha.ToString();    


                if (u.Nombre.Equals(""))
                {
                    MessageBox.Show("Debes ingresar el nombre");
                    TxtNombre.Focus();
                }
                else if (u.TipoDocumento.Equals("TIPO DOCUMENTO"))
                {
                    MessageBox.Show("Debes elegir un tipo de documento");
                    CmbTipoDocumento.Focus();
                }
                else if (u.Documento.Equals(""))
                {
                    MessageBox.Show("Debes ingresar el numero de documento");
                    TxtDocumento.Focus();
                }
                else if (edad < 18)
                {
                    MessageBox.Show("Debe ser mayor de edad");
                    DtpFechaNacimiento.Focus();
                }
                else if (u.Telefono.Equals(""))
                {
                    MessageBox.Show("Debes ingresar un telefono");
                    TxtTelefono.Focus();
                }
                else if (u.Username.Equals(""))
                {
                    MessageBox.Show("Debes ingresar un nombre de usuario");
                    TxtUsuario.Focus();
                }
                else if (u.Email.Equals(""))
                {
                    MessageBox.Show("Debes ingresar un correo");
                    TxtCorreo.Focus();
                }
                else if (u.Sexo.Equals("SEXO"))
                {
                    MessageBox.Show("Debes elegir el sexo de la persona");
                    CmbSexo.Focus();
                }
                else if (u.Estado.Equals("ESTADO"))
                {
                    MessageBox.Show("Debes elegir el estado del usuario");
                    CmbEstado.Focus();
                }
                else if (u.TipoUsuario.Equals("TIPO USUARIO"))
                {
                    MessageBox.Show("Debes elegir el tipo de usuario");
                    CmbTipoUser.Focus();
                }
                else if (edad < 18)
                {
                    MessageBox.Show("Debes ser mayor de edad");
                    DtpFechaNacimiento.Focus();
                }
                else
                {
                    int respuesta = ud.ActualizarUsuario(u);

                    if (respuesta > 0)
                    {
                        CmbCodigo.Text = u.UsuarioID;
                        MessageBox.Show("Usuario actualizado exitosamente!!");
                        TxtNombre.Text = "";
                        TxtDocumento.Text = "";
                        TxtTelefono.Text = "";
                        TxtUsuario.Text = "";
                        TxtPasword.Text = "";
                        TxtCorreo.Text = "";
                        CmbCodigo.DataSource = CargarComboBox(); ;
                        CmbEstado.SelectedItem = "ESTADO";
                        CmbSexo.SelectedItem = "SEXO";
                        CmbTipoDocumento.SelectedItem = "TIPO DOCUMENTO";
                        CmbTipoUser.SelectedItem = "TIPO USUARIO";
                        BtnActualizar.Text = "Actualizar Usuario";
                        BtnRegistrar.Enabled = true;
                        BtnEliminar.Enabled = true;
                        BtnBuscar.Enabled = true;
                        BtnLimpiar.Text = "Limpiar";
                    }
                    else
                    {
                        MessageBox.Show("Algo no salio bien!!");
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (BtnEliminar.Text.Equals("Eliminar Usuario")){
                CmbCodigo.Focus();
                BtnRegistrar.Enabled = false;
                BtnActualizar.Enabled = false;
                BtnBuscar.Text = "Ver Usuario";
                BtnLimpiar.Text = "Regresar";
                BtnEliminar.Text = "Confirmar";
                TxtNombre.Enabled = false;
                TxtDocumento.Enabled = false;
                TxtTelefono.Enabled = false;
                TxtUsuario.Enabled = false;
                TxtPasword.Enabled = false;
                TxtCorreo.Enabled = false;
                CmbEstado.Enabled = false;
                CmbSexo.Enabled = false;
                CmbTipoDocumento.Enabled = false;
                CmbTipoUser.Enabled = false;
                DtpFechaNacimiento.Enabled = false;
            } else if (BtnEliminar.Text.Equals("Confirmar")) {
                Usuario u = new Usuario();
                UsuarioDAO uDao = new UsuarioDAO();
                int respuesta;

                u.UsuarioID = CmbCodigo.SelectedItem.ToString();
                respuesta = uDao.EliminarUsuario(u.UsuarioID);
                if (respuesta > 0)
                    MessageBox.Show("Usuario Eliminado correctamente!!");
                else
                    MessageBox.Show("Error. No se pudo eliminar usuario.");
                TxtNombre.Text = "";
                TxtDocumento.Text = "";
                TxtTelefono.Text = "";
                TxtUsuario.Text = "";
                TxtPasword.Text = "";
                TxtCorreo.Text = "";
                CmbCodigo.DataSource = CargarComboBox(); ;
                CmbEstado.SelectedItem = "ESTADO";
                CmbSexo.SelectedItem = "SEXO";
                CmbTipoDocumento.SelectedItem = "TIPO DOCUMENTO";
                CmbTipoUser.SelectedItem = "TIPO USUARIO";
                BtnEliminar.Text = "Eliminar Usuario";
                BtnBuscar.Text = "Buscar";
                BtnRegistrar.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnBuscar.Enabled = true;
                BtnLimpiar.Text = "Limpiar";
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (registro)
            {
                SesionUsuario.NombreUsuario = null;
                SesionUsuario.Tipo = false;
                frmMenuAdm mu = new frmMenuAdm();
                mu.Show();

            }
            else
            {
                IniciarSesion login = new IniciarSesion();
                login.Show();
                this.Close();
            }
        }
    }
}
