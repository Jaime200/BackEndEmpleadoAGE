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
    public class EmpleadoController : ControllerBase
    {
        private readonly Servicios.Interfaz.IEMPLEADO empleadoService;
        private readonly Servicios.Interfaz.IConexion conexionSql;
        public EmpleadoController(
            Servicios.Interfaz.IConexion conexionSql,
            Servicios.Interfaz.IEMPLEADO empleadoService
            )
        {
            this.conexionSql = conexionSql;
            this.empleadoService = empleadoService;
        }
        // GET: api/<EmpleadoController>
        [HttpGet]
        public ActionResult<List<Modelos.EMPLEADO>> Get()
        {
            try
            {
                var result =this.empleadoService.getEmpleados(this.conexionSql.getConexion());
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
                
            }
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{dpi}")]
        public ActionResult<Modelos.EMPLEADO> Get(string dpi)
        {
            try
            {
                var result = this.empleadoService.getEmpleado(this.conexionSql.getConexion(), dpi);
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Modelos.EMPLEADO newEmpleado)
        {
            try
            {
                var result = this.empleadoService.addEmpleado(this.conexionSql.getConexion(), newEmpleado);
                return StatusCode(201, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut()]
        public ActionResult<bool> Put([FromBody] Modelos.EMPLEADO empleado)
        {
            try
            {
                var result = this.empleadoService.putEmpleado(this.conexionSql.getConexion(), empleado);
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        // DELETE api/<EmpleadoController>/5
        [HttpDelete("{DPI}")]
        public ActionResult<bool> Delete(string DPI)
        {
            try
            {
                var result = this.empleadoService.deleteEmpleado(this.conexionSql.getConexion(), DPI);
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }
    }
}
