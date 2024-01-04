using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using THANG_TEST.BLL;
using THANG_TEST.Models.User;
using VRMS_3layers.Models.ResultObj;

namespace THANG_TEST.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserBLL userBll = new UserBLL();
        [HttpGet]
        [Route("/getListUser")]
        public ResultObject getListUser()
        {
            return userBll.getListUser();
        }
        [HttpPost]
        [Route("/getUserByID")]
        public ResultObject getUserById([FromBody]int id)
        {
            return userBll.getUserById(id);
        }

        [HttpPost]
        [Route("/insertNewUser")]
        public ResultObject insertNewUser([FromBody] User insertUser)
        {
            return userBll.insertNewUser(insertUser);
        }

        [HttpPost]
        [Route("/updateUser")]
        public ResultObject updateUser([FromBody] User updateUser)
        {
            return userBll.updateUser(updateUser);
        }


        [HttpPost]
        [Route("/deleteUser")]
        public ResultObject deleteUser([FromBody] User deleteUser)
        {
            return userBll.deleteUser(deleteUser);
        }

        [HttpPost]
        [Route("/Login")]
        public ResultObject login([FromBody] UserLogin userLogin)
        {
            return userBll.Login(userLogin.inputLogin, userLogin.password);
        }

    }
}
