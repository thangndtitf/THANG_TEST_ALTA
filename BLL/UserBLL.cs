using THANG_TEST.DAL;
using THANG_TEST.Models.User;
using VRMS_3layers.Models.ResultObj;

namespace THANG_TEST.BLL
{
    public class UserBLL
    {
        private UsersDAL userDAL = new UsersDAL();

        public ResultObject getListUser()
        {
            ResultObject result = new ResultObject();
            List<User> users = userDAL.getListUser();
            if(users != null)
            {
                result.isError = false;
                result.message = "Get List User Success";
                result.messageDetail = string.Empty;
                result.dataObject = users;
                return result;
            }
            else 
            {
                result.isError = true;
                result.message = "Get List Fail";
                result.messageDetail = string.Empty;
                result.dataObject = users;
                return result;
            }
            
        }

        public ResultObject getUserById(int id)
        {
            ResultObject result = new ResultObject();
            if(id<0)
            {
                result.isError = true;
                result.message = "Get User Fail";
                result.messageDetail = "User Id is <0 ";
                result.dataObject = null;
                return result;
            }
            else
            {
                User user = userDAL.getUserById(id);
                if(user != null)
                {
                    result.isError = false;
                    result.message = "Get  User Success";
                    result.messageDetail = string.Empty;
                    result.dataObject = user;
                    return result;
                }
                else
                {
                    result.isError = true;
                    result.message = "Get User Fail";
                    result.messageDetail = "Cannot find your user with id =" + id.ToString();
                    result.dataObject = null;
                    return result;
                }
            }
        }

        public ResultObject insertNewUser(User user)
        {
            ResultObject result = new ResultObject();
            if(user == null)
            {
                result.isError = true;
                result.message = "Insert User Fail";
                result.messageDetail = "Yout new User is null";
                result.dataObject = null;
                return result;
            }
            else
            {
                bool isInsertSucces = userDAL.insertNewUser(user);
                if(isInsertSucces)
                {
                    result.isError = false;
                    result.message = "Insert  User Success";
                    result.messageDetail = string.Empty;
                    result.dataObject = user;
                    return result;
                }
                else
                {
                    result.isError = true;
                    result.message = "Insert User Fail";
                    result.messageDetail =String.Empty;
                    result.dataObject = null;
                    return result;
                }
            }
        }

        public ResultObject updateUser(User user)
        {
            ResultObject result = new ResultObject();
            if(user == null)
            {
                result.isError = true;
                result.message = "Insert User Fail";
                result.messageDetail = "Yout Update User is null";
                result.dataObject = null;
                return result;
            }
            else
            {
                bool isInsertSucces = userDAL.updateUser(user);
                if (isInsertSucces)
                {
                    result.isError = false;
                    result.message = "Update  User Success";
                    result.messageDetail = string.Empty;
                    result.dataObject = user;
                    return result;
                }
                else
                {
                    result.isError = true;
                    result.message = "Update User Fail";
                    result.messageDetail = String.Empty;
                    result.dataObject = null;
                    return result;
                }
            }
        }

        public ResultObject deleteUser(User user)
        {
            ResultObject result = new ResultObject();
            if(user == null)
            {
                result.isError = true;
                result.message = "Delete User Fail";
                result.messageDetail = "Yout Delete User is null";
                result.dataObject = null;
                return result;
            }
            else
            {
                bool isInsertSucces = userDAL.deleteUser(user);
                if (isInsertSucces)
                {
                    result.isError = false;
                    result.message = "Delete  User Success";
                    result.messageDetail = string.Empty;
                    result.dataObject = user;
                    return result;
                }
                else
                {
                    result.isError = true;
                    result.message = "Delete User Fail";
                    result.messageDetail = String.Empty;
                    result.dataObject = null;
                    return result;
                }
            }
        }
        public ResultObject Login(String loginInput, String password)
        {
            ResultObject result = new ResultObject();
            if(loginInput == null || password == null) {
                result.isError = true;
                result.message = "Login Fail";
                result.messageDetail = "Your userName or password is Null";
                result.dataObject = null;
                return result;
            }else
            {
                User user = userDAL.login(loginInput, password);
                if(user == null)
                {
                    result.isError = true;
                    result.message = "Login Fail";
                    result.messageDetail = "Your user is Null";
                    result.dataObject = null;
                    return result;
                }
                else
                {
                    result.isError = false;
                    result.message = "Login Success";
                    result.messageDetail = String.Empty;
                    result.dataObject = null;
                    return result;
                }
            }
        }

    }
}

