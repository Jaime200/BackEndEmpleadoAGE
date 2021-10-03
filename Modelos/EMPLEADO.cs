using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class EMPLEADO
    {

        private int dPI;
        private string pRIMER_NOMBRE;
        private string sEGUNDO_NOMBRE;
        private string pRIMER_APELLIDO;
        private string sEGUNDO_APELLIDO;
        private string? aPELLIDO_CASADA;
        private int eSTADO_CIVIL;
        private int sEXO;
        private string nIT;
        private string aFILIACION_IGSS;
        private string iRTRA;
        private string pASAPORTE;

        public int DPI { get => dPI; set => dPI = value; }
        public string PRIMER_NOMBRE { get => pRIMER_NOMBRE; set => pRIMER_NOMBRE = value; }
        public string SEGUNDO_NOMBRE { get => sEGUNDO_NOMBRE; set => sEGUNDO_NOMBRE = value; }
        public string PRIMER_APELLIDO { get => pRIMER_APELLIDO; set => pRIMER_APELLIDO = value; }
        public string SEGUNDO_APELLIDO { get => sEGUNDO_APELLIDO; set => sEGUNDO_APELLIDO = value; }
        
        public int  ESTADO_CIVIL { get => eSTADO_CIVIL; set => eSTADO_CIVIL = value; }
        public int SEXO { get => sEXO; set => sEXO = value; }
        public string NIT { get => nIT; set => nIT = value; }
        public string AFILIACION_IGSS { get => aFILIACION_IGSS; set => aFILIACION_IGSS = value; }
        public string IRTRA { get => iRTRA; set => iRTRA = value; }
        public string PASAPORTE { get => pASAPORTE; set => pASAPORTE = value; }
        public string APELLIDO_CASADA { get => aPELLIDO_CASADA; set => aPELLIDO_CASADA = value; }
    }
}
