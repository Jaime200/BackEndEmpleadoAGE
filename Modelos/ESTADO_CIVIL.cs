using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ESTADO_CIVIL
    {
        private int iD;
        private string dESCRIPCION;

        public int ID { get => iD; set => iD = value; }
        public string DESCRIPCION { get => dESCRIPCION; set => dESCRIPCION = value; }
    }
}
