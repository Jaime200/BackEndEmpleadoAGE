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
    public class SexoController : ControllerBase
    {
        private readonly Servicios.Interfaz.IConexion conexionSQL;
        private readonly Servicios.Interfaz.ISEXO sexo;
        public SexoController(
            Servicios.Interfaz.IConexion conexionSQL,
            Servicios.Interfaz.ISEXO sexo
            )
        {
            this.conexionSQL = conexionSQL;
            this.sexo = sexo;
        }
        // GET: api/<SexoController>
        [HttpGet]
        public ActionResult<List<Modelos.SEXO>> Get()
        {
            try
            {
                var result = this.sexo.getSexo(this.conexionSQL.getConexion());
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

    }
}
