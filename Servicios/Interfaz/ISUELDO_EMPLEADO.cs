using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaz
{
    public interface ISUELDO_EMPLEADO
    {
        public List<Modelos.SUELDO_EMPLEADO> getEmpleadoSueldos(SqlConnection cnn);

        //public Modelos.EMPLEADO getEmpleado(SqlConnection cnn, string DPI);

        public bool addEmpleadoSueldo(SqlConnection cnn, Modelos.SUELDO_EMPLEADO sueldoEmpleado);

        public bool putEmpleadoSueldo(SqlConnection cnn, Modelos.SUELDO_EMPLEADO sueldoEmpleado);

        public bool deleteEmpleadoSueldo(SqlConnection cnn, int ID, string DPI);
    }
}
