using API_Login.Models.ModelResponse;
using API_Login.IServices;
using Microsoft.AspNetCore.Mvc;

namespace API_Login.Controllers
{
    [Route("api_login/[controller]/[action]")]
    [ApiController]
    public class LoginController : Controller
    {
         private readonly ILoginServices _loginServices;
         public LoginController(ILoginServices loginServices)
        {
            _loginServices = loginServices;
        }

        [HttpGet]
        public async Task<Response> GetUserKey(string userlogin)
        {
            return  await _loginServices.GetUserKey(userlogin);
        }
    }
}
