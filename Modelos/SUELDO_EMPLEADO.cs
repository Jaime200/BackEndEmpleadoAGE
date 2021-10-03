using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class SUELDO_EMPLEADO
    {
        private int iD;
        private int dPI;
        private decimal sUELDO_BASE;
        private decimal bONIFICACION;

        public int ID { get => iD; set => iD = value; }
        public int DPI { get => dPI; set => dPI = value; }
        public decimal SUELDO_BASE { get => sUELDO_BASE; set => sUELDO_BASE = value; }
        public decimal BONIFICACION { get => bONIFICACION; set => bONIFICACION = value; }
    }
}
