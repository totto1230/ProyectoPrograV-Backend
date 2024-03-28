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
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("~/api/Users/create")]
        public ResponseRegistration CreateUser(RequestRegistation req)
        {
            LogicRegistrationUser logicaBackend = new LogicRegistrationUser();
            return logicaBackend.CreateUser(req);
        }

        [HttpPost]
        [Route("~/api/Users/validate")]
        public ResponseLogin ValidateUser(RequestLogin req)
        {
            LogicLogin logicaBackend = new LogicLogin();
            return logicaBackend.ValidateUser(req);
        }
    }
}