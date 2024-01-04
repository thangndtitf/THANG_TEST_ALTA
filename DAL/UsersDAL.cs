using System.Linq;
using THANG_TEST.Models.User;

namespace THANG_TEST.DAL
{
    public class UsersDAL
    {


        public List<User> getListUser() {
            List<User> users = new List<User>();    
            using(var _userDbContext = new UserDbContextcs())
            {
                users = _userDbContext.Users.Where<User>( u => u.CreatedAt != null).ToList();
            }

            return users;
        }

        public User getUserById(int id)
        {
            User? user = null;
            using(var _userDbContext = new UserDbContextcs())
            {
                user = _userDbContext.Users.FirstOrDefault( u => u.Id == id);
            }

            return user;
        }

        public bool insertNewUser( User user)
        {
            bool result = false;

            using (var _userDbContext = new UserDbContextcs())
            {
                _userDbContext.Users.Add(user);
                _userDbContext.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool updateUser ( User user )
        {
            bool result = false;
            User updateUser = null;
            using (var _userDbContext = new UserDbContextcs())
            {
                updateUser = _userDbContext.Users.FirstOrDefault(u => u.Id == user.Id);
                updateUser.Name = user.Name;
                updateUser.Email = user.Email;
                updateUser.Phone = user.Phone;  
                updateUser.Birdday = user.Birdday;
                updateUser.Avata = user.Avata;
                updateUser.Gender = user.Gender;
                _userDbContext.SaveChanges();
                result = true;
            }

                return result;
        }


        public bool deleteUser ( User user )
        {
            bool result = false;
            using (var _userDbContext = new UserDbContextcs())
            {
                _userDbContext.Users.Remove(user);
                result = true;
            }

                return result;
        }

        public User findUserByInput(String inputLogin)
        {
            User user = null;

            using (var _userDbContext = new UserDbContextcs())
            {
                user = _userDbContext.Users.FirstOrDefault(u => u.Name == inputLogin);
                if (user == null)
                {
                    user = _userDbContext.Users.FirstOrDefault(u => u.Email == inputLogin);
                }
            }

            return user;

        }

        public User login ( String inputLogin, String password)
        {
            User user = null;
            using (var _userDbContext = new UserDbContextcs())
            {
                user = findUserByInput (inputLogin);
                if(user != null)
                {
                    if(user.Password != password)
                    {
                        user = null;
                    }
                }
                else
                {
                    user = null;
                }
                return user;
            }
        }


    }
}
