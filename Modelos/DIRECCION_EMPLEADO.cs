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
        private int dPI;
        private string dIRECCION;

        public int ID { get => iD; set => iD = value; }
        public int DPI { get => dPI; set => dPI = value; }
        public string DIRECCION { get => dIRECCION; set => dIRECCION = value; }
    }
}
