using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaz
{
    public interface IESTADO_CIVIL
    {
        public List<Modelos.ESTADO_CIVIL> getEstadoCivil(SqlConnection cnn);
    }
}
