using ForoULAtina.Entidades;
using ForoULAtina.Entidades.Request;
using ForoULAtina.Entidades.Response;
using ForoULAtina.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        [Route("~/api/Productos/obtener")]
        public ResponseProductos VerProductos(RequestProductos req)
        {
            LogicProductos logicaBackend = new LogicProductos();
            return logicaBackend.ValidateProduct(null);
        }
    }
}