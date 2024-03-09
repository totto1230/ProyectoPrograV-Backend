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
    public class UserController : ApiController
    {
		[System.Web.Http.HttpPost]
		[System.Web.Http.Route("api/Users/create")]
		public ResponseRegistration CreateUser(RequestRegistation req)
		{
			LogicRegistrationUser logicaBackend = new LogicRegistrationUser();
			return logicaBackend.CreateUser(req);
		}

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Users/validate")]
        public ResponseLogin ValidateUser(RequestLogin req)
        {
            LogicLogin  logicaBackend = new LogicLogin();
            return logicaBackend.ValidateUser(req);
        }
    }
}