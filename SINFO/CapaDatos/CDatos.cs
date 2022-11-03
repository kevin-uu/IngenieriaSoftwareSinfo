
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINFO.Models
{
    public class CDatos
    {
        #region Metodos para acceder a la conexion
        static private string CadenConexion = "Data Source=.;Initial Catalog=sinfo;Integrated Security=True";
        private SqlConnection Conexx = new SqlConnection(CadenConexion);
        public SqlConnection AbrirConexion()
        {
            if (Conexx.State == ConnectionState.Closed)
                Conexx.Open();
            return Conexx;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexx.State == ConnectionState.Open)
                Conexx.Close();
            return Conexx;
        }
        #endregion

        
    }

    public abstract class connectiontosql
    {
        private readonly string connectionString;
        public connectiontosql()
        {
            connectionString = "Data Source=.;Initial Catalog=sinfo;Integrated Security=True";
        }
        protected SqlConnection getconnection()
        {
            return new SqlConnection(connectionString);
        }
    }




}

