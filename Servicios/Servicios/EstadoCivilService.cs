using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
    public class EstadoCivilService : Interfaz.IESTADO_CIVIL
    {
        public List<ESTADO_CIVIL> getEstadoCivil(SqlConnection cnn)
        {
            SqlDataReader reader = null;
            List<Modelos.ESTADO_CIVIL> estados_civiles = new List<Modelos.ESTADO_CIVIL>();
            try
            {
                string sQUery = @"SELECT [ID]
                                        ,[DESCRIPCION]
                                      FROM [dbo].[ESTADO_CIVIL]";
                SqlCommand command = new SqlCommand(sQUery, cnn);
                reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    Modelos.ESTADO_CIVIL estado_civil = new Modelos.ESTADO_CIVIL();
                    estado_civil.ID = reader.GetInt32(0);
                    estado_civil.DESCRIPCION = reader.GetString(1);
                    estados_civiles.Add(estado_civil);
                }
                return estados_civiles;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex.InnerException);
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }
    }
}
