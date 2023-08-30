using CafeAutomationDAL.BaseModel;
using CafeAutomationDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CafeAutomationBLL.Managers
{
    public class AuthManager
    {
        CafeautomationappContext cafeautomationappContext;
        public AuthManager(CafeautomationappContext cafeautomationappContext)
        {
           this.cafeautomationappContext= cafeautomationappContext;
        }
        public ResponseReturn Login(User user)
        {
            return new ResponseReturn { };
        }
    }
}
