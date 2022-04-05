using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
namespace CapaDatos
{
   public class CD_Conexion
    {
        private OracleConnection conexion = new OracleConnection("Data source=orcl; PASSWORD=123;USER ID=proy;");
        public OracleConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        public OracleConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open) 
            {
                conexion.Close();
                
            }
            return conexion;
        }
    }
}
