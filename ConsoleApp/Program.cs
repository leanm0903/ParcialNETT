using Montenegro.Datos;
using Montenegro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var UsuDatos = new UsuarioBase();
            UsuDatos.Agregar(new Usuario
            {
                NombreUsuario = "nombre",
                Clave = "1234",
                Email = "esteEmailFalso@gmail.com",
                TipoUsuario = 1

            });
            var usu = UsuDatos.RecuperarUno("nombre");
            var ListUsuarios=UsuDatos.RecuperarTodos();
        }
    }
}
