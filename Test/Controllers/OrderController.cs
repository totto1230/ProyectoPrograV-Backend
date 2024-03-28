using ForoULAtina.Entidades;
using ForoULAtina.Entidades.Request;
using ForoULAtina.Entidades.Response;
using ForoULAtina.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace API.Controllers
{
    public class OrderController : ApiController
    {
		[System.Web.Http.HttpPost]
		[System.Web.Http.Route("api/Order/validate")]
		public ResponseOrder ValidateOrder(RequestOrden req)
		{
			LogicOrder logicaBackend = new LogicOrder();
			return logicaBackend.ValidateOrder(req);
		}
    }
}