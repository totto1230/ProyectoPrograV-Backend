using ForoULAtina.Entidades.Request;
using ForoULAtina.Entidades.Response;
using ForoULAtina.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIs_ProyectoV.Controllers
{
    
    //[Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("api/Users/create")]
        public ResponseRegistration CreateUser(RequestRegistation req)
        {
            LogicRegistrationUser logicaBackend = new LogicRegistrationUser();
            return logicaBackend.CreateUser(req);
        }

        [HttpPost]
        [Route("api/Users/validate")]
        public ResponseLogin ValidateUser(RequestLogin req)
        {
            LogicLogin logicaBackend = new LogicLogin();
            return logicaBackend.ValidateUser(req);
        }
    }
}
