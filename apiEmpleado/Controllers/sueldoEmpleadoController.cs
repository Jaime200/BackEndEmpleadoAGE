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
    public class sueldoEmpleadoController : ControllerBase
    {
        private readonly Servicios.Interfaz.ISUELDO_EMPLEADO sueldoEmpleadoService;
        private readonly Servicios.Interfaz.IConexion conexionSQL;
        public sueldoEmpleadoController(
            Servicios.Interfaz.IConexion conexionSQL,
            Servicios.Interfaz.ISUELDO_EMPLEADO sueldoEmpleadoService
            )
        {
            this.conexionSQL = conexionSQL;
            this.sueldoEmpleadoService = sueldoEmpleadoService;
        }
        // GET: api/<sueldoEmpleadoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<sueldoEmpleadoController>/5
        [HttpGet("{dpi}")]
        public ActionResult<bool> Get(string  dpi)
        {
            try
            {
                var result = this.sueldoEmpleadoService.getEmpleadoSueldos(this.conexionSQL.getConexion(), dpi);
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        // POST api/<sueldoEmpleadoController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Modelos.SUELDO_EMPLEADO sueldoEmpleado)
        {
            try
            {
                var result = this.sueldoEmpleadoService.addEmpleadoSueldo(this.conexionSQL.getConexion(), sueldoEmpleado);
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        // PUT api/<sueldoEmpleadoController>/5
        [HttpPut]
        public ActionResult<bool> Put([FromBody] Modelos.SUELDO_EMPLEADO sueldoEmpleado)
        {
            try
            {
                var result = this.sueldoEmpleadoService.putEmpleadoSueldo(this.conexionSQL.getConexion(), sueldoEmpleado);
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        // DELETE api/<sueldoEmpleadoController>/5
        [HttpDelete("{id}/{DPI}")]
        public ActionResult<bool> Delete(int id, string DPI)
        {
            try
            {
                var result = this.sueldoEmpleadoService.deleteEmpleadoSueldo(this.conexionSQL.getConexion(), id,DPI);
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }
    }
}
