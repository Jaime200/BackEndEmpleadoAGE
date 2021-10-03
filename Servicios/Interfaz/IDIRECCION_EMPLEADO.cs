using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaz
{
    public interface IDIRECCION_EMPLEADO
    {
        public List<Modelos.DIRECCION_EMPLEADO> getDireccionEmpleado(SqlConnection cnn);

        //public Modelos.EMPLEADO getEmpleado(SqlConnection cnn, string DPI);

        public bool addDireccionEmpleado(SqlConnection cnn, Modelos.DIRECCION_EMPLEADO direccionEmpleado);

        public bool putDireccionEmpleado(SqlConnection cnn, Modelos.DIRECCION_EMPLEADO direccionEmpleado);

        public bool deleteDireccionEmpleado(SqlConnection cnn, int ID, string DPI);
    }
}
