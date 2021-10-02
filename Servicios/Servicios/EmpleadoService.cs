using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
    class EmpleadoService : Interfaz.IEMPLEADO
    {
        public bool addEmpleado(SqlConnection cnn, EMPLEADO empleado)
        {
            SqlDataReader reader = null;
            try
            {
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

        public bool deleteEmpleado(SqlConnection cnn, EMPLEADO empleado)
        {
            try
            {
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

        public EMPLEADO getEmpleado(SqlConnection cnn, string DPI)
        {
            SqlDataReader reader = null;
            Modelos.EMPLEADO empleado = new Modelos.EMPLEADO() ;
            try
            {
                string sQUery = @"SELECT
                                    DPI
                                    ,PRIMER_NOMBRE
                                    ,SEGUNDO_NOMBRE
                                    ,PRIMER_APELLIDO
                                    ,SEGUNDO_APELLIDO
                                    ,APELLIDO_CASADA
                                    ,ESTADO_CIVIL
                                    ,SEXO
                                    ,NIT
                                    ,AFILIACION_IGSS
                                    ,IRTRA
                                    ,PASAPORTE 
                                    FROM EMPLEADO WHERE DPI = @DPI";
                SqlCommand command = new SqlCommand(sQUery, cnn);
                reader = command.ExecuteReader();
                if(!reader.HasRows) { throw new Exception($"El empleado con dpi {DPI} no existe"); }
                while (reader.Read())
                {
                    empleado.DPI = reader.GetInt32(0);
                    empleado.PRIMER_NOMBRE = reader.GetString(1);
                    empleado.SEGUNDO_NOMBRE = reader.GetString(2);
                    empleado.PRIMER_APELLIDO = reader.GetString(3);
                    empleado.SEGUNDO_APELLIDO= reader.GetString(4);
                    empleado.APELLIDO_CASADA = reader.GetString(5);
                    empleado.ESTADO_CIVIL = reader.GetInt32(6);
                    empleado.SEXO = reader.GetInt32(7);
                    empleado.NIT= reader.GetString(8);
                    empleado.AFILIACION_IGSS= reader.GetString(0);
                    empleado.IRTRA= reader.GetString(10);
                    empleado.PASAPORTE =reader.GetString(11);
                    break;
                }
                return empleado;
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

        public List<EMPLEADO> getEmpleados(SqlConnection cnn)
        {
            SqlDataReader reader = null;
            List<Modelos.EMPLEADO> empleados = new List<Modelos.EMPLEADO>();
            try
            {
                string sQUery = @"SELECT
                                    DPI
                                    ,PRIMER_NOMBRE
                                    ,SEGUNDO_NOMBRE
                                    ,PRIMER_APELLIDO
                                    ,SEGUNDO_APELLIDO
                                    ,APELLIDO_CASADA
                                    ,ESTADO_CIVIL
                                    ,SEXO
                                    ,NIT
                                    ,AFILIACION_IGSS
                                    ,IRTRA
                                    ,PASAPORTE 
                                    FROM EMPLEADO";
                SqlCommand command = new SqlCommand(sQUery, cnn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Modelos.EMPLEADO empleado = new Modelos.EMPLEADO();
                    empleado.DPI = reader.GetInt32(0);
                    empleado.PRIMER_NOMBRE = reader.GetString(1);
                    empleado.SEGUNDO_NOMBRE = reader.GetString(2);
                    empleado.PRIMER_APELLIDO = reader.GetString(3);
                    empleado.SEGUNDO_APELLIDO = reader.GetString(4);
                    empleado.APELLIDO_CASADA = reader.GetString(5);
                    empleado.ESTADO_CIVIL = reader.GetInt32(6);
                    empleado.SEXO = reader.GetInt32(7);
                    empleado.NIT = reader.GetString(8);
                    empleado.AFILIACION_IGSS = reader.GetString(0);
                    empleado.IRTRA = reader.GetString(10);
                    empleado.PASAPORTE = reader.GetString(11);
                }
                return empleados;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public bool putEmpleado(SqlConnection cnn, EMPLEADO empleado)
        {
            try
            {
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
