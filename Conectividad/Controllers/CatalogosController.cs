using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conectividad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCatalogDBPJ()
        {
            using (var dbpjContext = new Conectividad.Models.DBPJ.DBPJContext())
            {
                var products = (from dbpj in dbpjContext._002materias
                                select dbpj).ToList();
                return Ok(products);
            }
        }
        [HttpGet("newtable")]
        public IActionResult GetCatalogTable()
        {
            using (var dbtContext = new Conectividad.Models.DBServer.testdbContext())
            {
                var products = (from dbt in dbtContext.Tabla1s
                                select dbt).ToList();
                return Ok(products);
            }
        }
    }
}
