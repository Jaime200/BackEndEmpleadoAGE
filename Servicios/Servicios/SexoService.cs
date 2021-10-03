using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
    public class SexoService : Interfaz.ISEXO
    {
        public List<SEXO> getSexo(SqlConnection cnn)
        {
            SqlDataReader reader = null;
            List<Modelos.SEXO> sexos = new List<Modelos.SEXO>();
            try
            {
                string sQUery = @"SELECT [ID]
                                          ,[DESCRIPCION]
                                      FROM [dbo].[SEXO]";
                SqlCommand command = new SqlCommand(sQUery, cnn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Modelos.SEXO sexo = new Modelos.SEXO();
                    sexo.ID = reader.GetInt32(0);
                    sexo.DESCRIPCION = reader.GetString(1);
                    sexos.Add(sexo);
                }
                return sexos;
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
