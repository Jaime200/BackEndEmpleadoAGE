using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DIRECCION_EMPLEADO
    {
        private int iD;
        private Int64 dPI;
        private string dIRECCION;

        public int ID { get => iD; set => iD = value; }
        public Int64 DPI { get => dPI; set => dPI = value; }
        public string DIRECCION { get => dIRECCION; set => dIRECCION = value; }
    }
}
