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
    public class ProductoController : ApiController
    {
		[System.Web.Http.HttpGet]
		[System.Web.Http.Route("api/Productos/obtener")]
		public ResponseProductos VerProductos()
		{
            LogicProductos logicaBackend = new LogicProductos();
			return logicaBackend.ValidateProduct();
		}
    }
}