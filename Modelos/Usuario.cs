using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmFlowTicket_v1
{
    internal class Usuario
    {
        string usuarioID,nombre, sexo, tipoDocumento, documento, telefono, email, username, password, fechaRegistro,fechanac;
        byte estado;
        bool tipoUsuario;

        public string UsuarioID { get { return usuarioID; } set { usuarioID = value; }}
        public string Nombre { get { return nombre; } set { nombre = value; }}
        public string Sexo { get { return sexo; } set { sexo = value; }}
        public string TipoDocumento { get { return tipoDocumento; } set { tipoDocumento = value; }}
        public string Documento { get { return documento; } set { documento = value; }}
        public string FechaNacimiento { get { return fechanac; } set { fechanac = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; }}
        public string Email { get { return email; } set { email = value; }}
        public string Username { get { return username; } set { username = value; }}
        public string Password { get { return password; } set { password = value; }}
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; }}
        public byte Estado { get { return estado; } set { estado = value; } }
        public bool TipoUsuario { get { return tipoUsuario; } set { tipoUsuario = value; } }
    }
}
