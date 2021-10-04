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
        public List<Modelos.SUELDO_EMPLEADO> getEmpleadoSueldos(SqlConnection cnn, string DPI);

        public Modelos.SUELDO_EMPLEADO getEmpleadoSueldoById(SqlConnection cnn, string ID,string DPI);

        public bool addEmpleadoSueldo(SqlConnection cnn, Modelos.SUELDO_EMPLEADO sueldoEmpleado);

        public bool putEmpleadoSueldo(SqlConnection cnn, Modelos.SUELDO_EMPLEADO sueldoEmpleado);

        public bool deleteEmpleadoSueldo(SqlConnection cnn, int ID, string DPI);
    }
}
