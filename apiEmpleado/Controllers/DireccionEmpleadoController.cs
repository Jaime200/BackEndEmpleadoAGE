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
    public class DireccionEmpleadoController : ControllerBase
    {

        private readonly Servicios.Interfaz.IDIRECCION_EMPLEADO direccionEmpleadoService;
        private readonly Servicios.Interfaz.IConexion conexionSQL;
        public DireccionEmpleadoController(
            Servicios.Interfaz.IConexion conexionSQL,
            Servicios.Interfaz.IDIRECCION_EMPLEADO direccionEmpleadoService
            )
        {
            this.conexionSQL = conexionSQL;
            this.direccionEmpleadoService = direccionEmpleadoService;
        }

        // GET api/<DireccionEmpleadoController>/5
        [HttpGet("{dpi}")]
        public ActionResult<List<Modelos.DIRECCION_EMPLEADO>> Get(string dpi)
        {
            try
            {
                var result = this.direccionEmpleadoService.getDireccionEmpleado(this.conexionSQL.getConexion(), dpi);
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        // POST api/<DireccionEmpleadoController>
        [HttpPost]
        public ActionResult<bool> Post( Modelos.DIRECCION_EMPLEADO newDireccion)
        {
            try
            {
                var result = this.direccionEmpleadoService.addDireccionEmpleado(this.conexionSQL.getConexion(), newDireccion);
                return StatusCode(201, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        // DELETE api/<DireccionEmpleadoController>/5
        [HttpDelete("{id}/{DPI}")]
        public ActionResult<bool> Delete(int id, string DPI)
        {
            try
            {
                var result = this.direccionEmpleadoService.deleteDireccionEmpleado(this.conexionSQL.getConexion(), id, DPI);
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }
}
