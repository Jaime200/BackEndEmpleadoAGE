using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaz
{
    public interface IEMPLEADO
    {
        public List<Modelos.EMPLEADO> getEmpleados(SqlConnection cnn);

        public Modelos.EMPLEADO getEmpleado(SqlConnection cnn, string DPI);

        public bool addEmpleado(SqlConnection cnn,Modelos.EMPLEADO empleado);

        public bool putEmpleado(SqlConnection cnn,Modelos.EMPLEADO empleado);

        public bool deleteEmpleado(SqlConnection cnn,string DPI);
        
    }
}
