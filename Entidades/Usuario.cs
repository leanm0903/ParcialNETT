using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Montenegro.Entidades
{
    public class Usuario
    {
        public string Clave { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public int TipoUsuario { get; set; }
        public DateTime UltimoIngreso { get; }
        public Usuario()
        {

        }
        public Usuario(string clave,string email,string nombreUsuario,int tipoUsuario)
        {
            this.Clave = clave;
            this.Email = email;
            this.NombreUsuario = nombreUsuario;
            this.TipoUsuario = tipoUsuario;
        }
    }
}
