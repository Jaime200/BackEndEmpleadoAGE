using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
    public class EmpleadoSueldoService : Interfaz.ISUELDO_EMPLEADO
    {
        public bool addEmpleadoSueldo(SqlConnection cnn, SUELDO_EMPLEADO sueldoEmpleado)
        {
            try
            {
                string sQUery = @"INSERT INTO [dbo].[SUELDO_EMPLEADO]([DPI] ,[SUELDO_BASE],[BONIFICACION]) VALUES (@DPI,@SUELDO_BASE,@BONIFICACION)";
                SqlCommand command = new SqlCommand(sQUery, cnn);

                command.Parameters.AddWithValue("@DPI", sueldoEmpleado.DPI);
                command.Parameters.AddWithValue("@SUELDO_BASE", sueldoEmpleado.SUELDO_BASE);
                command.Parameters.AddWithValue("@BONIFICACION", sueldoEmpleado.BONIFICACION);
                int resp = command.ExecuteNonQuery();

                if (resp == 0) throw new Exception($"No se pudo realizar el registro de sueldo para el empleado {sueldoEmpleado.DPI}");
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

        public bool deleteEmpleadoSueldo(SqlConnection cnn, int ID, string DPI)
        {
            try
            {
                string sQUery = @"UPDATE [dbo].[SUELDO_EMPLEADO]  SET   [ELIMINADO] = 1 WHERE [ID] = @ID [DPI] = @DPI";
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

        public List<SUELDO_EMPLEADO> getEmpleadoSueldos(SqlConnection cnn)
        {
            SqlDataReader reader = null;
            List<Modelos.SUELDO_EMPLEADO> empleadoSueldos = new List<Modelos.SUELDO_EMPLEADO>();
            try
            {
                string sQUery = @"SELECT [ID]
                                  ,[DPI]
                                  ,[SUELDO_BASE]
                                  ,[BONIFICACION]
                              FROM [dbo].[SUELDO_EMPLEADO]
                              where DPI = @DPI";
                SqlCommand command = new SqlCommand(sQUery, cnn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Modelos.SUELDO_EMPLEADO empleadoSueldo = new Modelos.SUELDO_EMPLEADO();
                    empleadoSueldo.ID = reader.GetInt32(0);
                    empleadoSueldo.DPI = reader.GetInt32(1);
                    empleadoSueldo.SUELDO_BASE = reader.GetDecimal(2);
                    empleadoSueldo.BONIFICACION = reader.GetDecimal(3);
                    empleadoSueldos.Add(empleadoSueldo);
                }
                return empleadoSueldos;
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

        public bool putEmpleadoSueldo(SqlConnection cnn, SUELDO_EMPLEADO sueldoEmpleado)
        {
            try
            {
                string sQUery = @"UPDATE [dbo].[SUELDO_EMPLEADO]
                                   SET [DPI] = @DPI
                                      ,[SUELDO_BASE] = @SUELDO_BASE
                                      ,[BONIFICACION] = @BONIFICACION
                                WHERE [DPI] = @DPI AND [ID] = @ID";
                SqlCommand command = new SqlCommand(sQUery, cnn);

                command.Parameters.AddWithValue("@ID", sueldoEmpleado.ID);
                command.Parameters.AddWithValue("@DPI", sueldoEmpleado.DPI);
                command.Parameters.AddWithValue("@SUELDO_BASE", sueldoEmpleado.SUELDO_BASE);
                command.Parameters.AddWithValue("@BONIFICACION", sueldoEmpleado.BONIFICACION);

                int resp = command.ExecuteNonQuery();
                if (resp == 0) throw new Exception($"No se pudo realizar la accion para el registro del empleado {sueldoEmpleado.DPI}");
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
