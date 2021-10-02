using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class PARAMETROS_CONEXION
    {
        private string dB;
        private string sERVER;
        private string uSER;
        private string pSW;

        public string DB { get => dB; set => dB = value; }
        public string SERVER { get => sERVER; set => sERVER = value; }
        public string USER { get => uSER; set => uSER = value; }
        public string PSW { get => pSW; set => pSW = value; }
    }
}
