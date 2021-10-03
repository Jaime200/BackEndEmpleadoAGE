using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
    public class DireccionEmpleado : Interfaz.IDIRECCION_EMPLEADO
    {
        public bool addDireccionEmpleado(SqlConnection cnn, DIRECCION_EMPLEADO direccionEmpleado)
        {
            
            try
            {
                string sQUery = @"INSERT INTO [dbo].[DIRECCION_EMPLEADO] ([DPI] ,[DIRECCION])  VALUES(@DPI, @DIRECCION)";
                SqlCommand command = new SqlCommand(sQUery, cnn);

                command.Parameters.AddWithValue("@DPI", direccionEmpleado.DPI);
                command.Parameters.AddWithValue("@DIRECCION", direccionEmpleado.DIRECCION);

                int resp = command.ExecuteNonQuery();
                if (resp == 0) throw new Exception($"No se pudo realizar el registro del empleado {direccionEmpleado.DPI}");
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex.InnerException);
            }
            finally
            {
            }
        }

        public bool deleteDireccionEmpleado(SqlConnection cnn, int ID, string DPI)
        {
            try
            {
                string sQUery = @"UPDATE [dbo].[DIRECCION_EMPLEADO]  SET   [ELIMINADO] = 1 WHERE [ID] = @ID [DPI] = @DPI";
                SqlCommand command = new SqlCommand(sQUery, cnn);

                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@DPI", DPI);


                int resp = command.ExecuteNonQuery();
                if (resp == 0) throw new Exception($"No se pudo realizar la accion para el registro del empleado {DPI}");
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex.InnerException);
            }
            finally
            {
            }
        }

        public List<DIRECCION_EMPLEADO> getDireccionEmpleado(SqlConnection cnn)
        {
            SqlDataReader reader = null;
            List<Modelos.DIRECCION_EMPLEADO> direccionesEmpleado = new List<Modelos.DIRECCION_EMPLEADO>();
            try
            {
                string sQUery = @"SELECT [ID]
                                      ,[DPI]
                                      ,[DIRECCION]
                                      ,[ELIMINADO]
                                    FROM [dbo].[DIRECCION_EMPLEADO]
                                    where DPI = @DPI";
                SqlCommand command = new SqlCommand(sQUery, cnn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Modelos.DIRECCION_EMPLEADO empleadoSueldo = new Modelos.DIRECCION_EMPLEADO();
                    empleadoSueldo.ID = reader.GetInt32(0);
                    empleadoSueldo.DPI = reader.GetInt32(1);
                    empleadoSueldo.DIRECCION = reader.GetString(3);
                    direccionesEmpleado.Add(empleadoSueldo);
                }
                return direccionesEmpleado;
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

        public bool putDireccionEmpleado(SqlConnection cnn, DIRECCION_EMPLEADO direccionEmpleado)
        {
            try
            {
                string sQUery = @"UPDATE [dbo].[SUELDO_EMPLEADO]
                                   SET [DIRECCION] = @DIRECCION
                                        ,[ELIMINADO] = 0
                                WHERE [DPI] = @DPI AND [ID] = @ID";
                SqlCommand command = new SqlCommand(sQUery, cnn);

                command.Parameters.AddWithValue("@ID", direccionEmpleado.ID);
                command.Parameters.AddWithValue("@DPI", direccionEmpleado.DPI);
                command.Parameters.AddWithValue("@DIRECCION", direccionEmpleado.DIRECCION);

                int resp = command.ExecuteNonQuery();
                if (resp == 0) throw new Exception($"No se pudo realizar la accion para el registro del empleado {direccionEmpleado.DPI}");
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex.InnerException);
            }
            finally
            {
            }
        }
    }
}
