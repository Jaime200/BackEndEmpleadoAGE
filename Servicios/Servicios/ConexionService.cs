using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Servicios.Servicios
{
    public class ConexionService : Interfaz.IConexion
    {
        SqlConnection cnn = null;
        public ConexionService(Modelos.PARAMETROS_CONEXION parametrosConexion)
        {
            try
            {
               this.cnn =this.singleConn(parametrosConexion);
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message, ex.InnerException);
            }
            
        }
        public SqlConnection getConexion()
        {
            return this.cnn;
        }



        private SqlConnection singleConn(Modelos.PARAMETROS_CONEXION parametrosConexion)
        {
            try
            {
                SqlConnection cnn = new SqlConnection($"Data Source={parametrosConexion.SERVER};Initial Catalog={parametrosConexion.DB};User ID={parametrosConexion.USER};Password={parametrosConexion.PSW}");
                cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
