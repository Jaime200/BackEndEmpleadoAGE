using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiEmpleado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoCivilController : ControllerBase
    {
        private readonly Servicios.Interfaz.IConexion conexionSQL;
        private readonly Servicios.Interfaz.IESTADO_CIVIL estado_civil;
        public EstadoCivilController(
            Servicios.Interfaz.IConexion conexionSQL,
            Servicios.Interfaz.IESTADO_CIVIL estado_civil
            )
        {
            this.conexionSQL = conexionSQL;
            this.estado_civil = estado_civil;
        }
        // GET: api/<EstadoCivilController>
        public ActionResult<List<Modelos.SEXO>> Get()
        {
            try
            {
                var result = this.estado_civil.getEstadoCivil(this.conexionSQL.getConexion());
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }
    }
}
