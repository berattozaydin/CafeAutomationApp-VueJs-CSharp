using CafeAutomationBLL.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CafeAutomationServer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        AuthManager authManager;
        public AuthController(AuthManager authManager)
        {
            this.authManager = authManager; 
        }
    }
}
