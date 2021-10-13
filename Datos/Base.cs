using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;

namespace Montenegro.Datos
{
    public class Base
    {
        protected string NetGenerica { get; set; }
        public SqlConnection SqlConnection { get; set; }
        public Base()
        {
            this.NetGenerica = ConfigurationManager.ConnectionStrings["UsuarioDb"].ConnectionString;
            this.SqlConnection = new SqlConnection(this.NetGenerica);

        }
    }
}
