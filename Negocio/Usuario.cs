using Montenegro.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Montenegro.Negocio
{
    public class Usuario
    {
        public Usuario()
        {
        }
        public static  List<Entidades.Usuario> RecuperarTodos()
        {
            UsuarioBase UsuarioBase = new UsuarioBase();



            return UsuarioBase.RecuperarTodos();

        }
        public static void Agregar(Entidades.Usuario usuario)
        {
            UsuarioBase UsuarioBase = new UsuarioBase();
            UsuarioBase.Agregar(usuario);



        }
        public static Entidades.Usuario RecuperarUno(string NombreUsuario)
        {
            UsuarioBase UsuarioBase = new UsuarioBase();
            if (String.IsNullOrWhiteSpace(NombreUsuario))
            {
                throw new Exception("El nombre de usuario es nulo");
            }
            return UsuarioBase.RecuperarUno(NombreUsuario);
            ;
        }
    }
}
