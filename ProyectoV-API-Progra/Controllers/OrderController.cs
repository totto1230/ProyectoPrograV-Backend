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
    public class OrderController : ControllerBase
    {
        [HttpPost]
        [Route("~/api/Order/validate")]
        public ResponseOrder ValidateOrder(RequestOrden req)
        {
            LogicOrder logicaBackend = new LogicOrder();
            return logicaBackend.ValidateOrder(req);
        }
    }
}