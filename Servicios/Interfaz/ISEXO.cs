using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaz
{
    public interface ISEXO
    {
        public List<Modelos.SEXO> getSexo(SqlConnection cnn);
    }
}
