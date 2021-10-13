using Montenegro.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Montenegro.Datos
{
   public class UsuarioBase:Base
    {
   
//    Crear clase pública Usuario que contengan los siguientes métodos que se conecten Base de Datos
//utilizando la conexión de la clase Base y recuperen/persistan datos de/en la tabla homónima.
//Considerar que el/los objeto/s retornado/s y argumentos de los métodos tomen el objeto de Entidad
//o colección de este tipo (Ej.List<Entidades.Usuario>)
//i. Método RecuperarTodos que obtenga todos los registros de la tabla.
//ii.Método Agregar que reciba la entidad e inserte un nuevo registro en la tabla.
    public List<Usuario> RecuperarTodos()
       {
            
             string sql = "Select * from Usuarios";

            SqlCommand sqlCommand = new SqlCommand(sql, this.SqlConnection);
            this.SqlConnection.Open();
            SqlDataReader sqlDataReader=sqlCommand.ExecuteReader();
            List<Usuario> usuarios = new List<Usuario>();
            while (sqlDataReader.Read())
            {
                usuarios.Add(new Usuario
                {
                    Clave = sqlDataReader["Clave"].ToString(),
                    Email= sqlDataReader["Email"].ToString(),
                    NombreUsuario = sqlDataReader["NombreUsuario"].ToString(),
                    TipoUsuario=(int) sqlDataReader["TipoUsuario"],

                });
                ;


            }
            this.SqlConnection.Close();
            
            return usuarios;

       }
     public void Agregar(Usuario usuario)
        {
            string sql = "INSERT INTO USUARIOS (Clave,Email,NombreUsuario,TipoUsuario) VALUES(@clave,@email,@nombreUsuario,@tipoUsuario)";

            SqlCommand sqlCommand = new SqlCommand(sql, this.SqlConnection);
            this.SqlConnection.Open();
            sqlCommand.Parameters.Add(new SqlParameter("@clave",usuario.Clave));
            sqlCommand.Parameters.Add(new SqlParameter("@email", usuario.Email));
            sqlCommand.Parameters.Add(new SqlParameter("@nombreUsuario", usuario.NombreUsuario));
            sqlCommand.Parameters.Add(new SqlParameter("@tipoUsuario", usuario.TipoUsuario));
            sqlCommand.ExecuteNonQuery();
            this.SqlConnection.Close();



        }
     public Usuario RecuperarUno(string NombreUsuario)
        {
            List<Usuario> ListUsuarios = this.RecuperarTodos();

            var usuarios = from usu in ListUsuarios where usu.NombreUsuario == NombreUsuario select usu;
            return usuarios.FirstOrDefault();
        }
        public List<Usuario> RecuperarUnocv2()
        {

            string sql = "Select * from Usuarios where NombreUsuario=@nombreUsu";

            SqlCommand sqlCommand = new SqlCommand(sql, this.SqlConnection);
            this.SqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Usuario> usuarios = new List<Usuario>();
            while (sqlDataReader.Read())
            {
                usuarios.Add(new Usuario
                {
                    Clave = sqlDataReader["Clave"].ToString(),
                    Email = sqlDataReader["Email"].ToString(),
                    NombreUsuario = sqlDataReader["NombreUsuario"].ToString(),
                    TipoUsuario = (int)sqlDataReader["TipoUsuario"],

                });
                ;


            }
            this.SqlConnection.Close();

            return usuarios;

        }
    }

}
  
