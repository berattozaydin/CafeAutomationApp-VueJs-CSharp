using CafeAutomationBLL.Managers;
using CafeAutomationDAL.BaseModel;
using CafeAutomationDAL.Models;
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
        [HttpPost]
        public ResponseReturn Login(int userId)
        {
            return authManager.Login(userId);
        }
    }
}
