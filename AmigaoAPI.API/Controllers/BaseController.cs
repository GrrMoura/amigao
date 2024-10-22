using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AmigaoAPI.API.Controllers
{
    [Authorize]
    [ApiController]
    public class BaseController : ControllerBase
    {
        [NonAction]
        public bool ValidatePermission(List<string> permissionUser, List<string> permissionNeed)
        {
            //perssionUser = são as permissoes que o usuario tem
            // permissionNeed = são as que o usuário precisa
            return permissionNeed.Any(x => permissionUser.Contains(x));
        }
        [NonAction]
        public IActionResult Forbidden()
        {

            var obj = new
            {
                code = "Permissão negada",
                message = "Usuário não tem permissão para acessar o recurso"
            };

            return new ObjectResult(obj) { StatusCode = 401 };
        }
    }
}
