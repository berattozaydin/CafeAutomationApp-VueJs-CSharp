using CafeAutomationDAL.BaseModel;
using CafeAutomationDAL.Dto;
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
        public ResponseReturn Login(int userId)
        {
            var res = cafeautomationappContext
                .Users
                .Where(x=>x.UserId == userId)
                .Select(x => new UserDto
                {
                    UserName = x.Name
                }).FirstOrDefault();
            return new ResponseReturn { };
        }
    }
}
