using UseDapper.BissnesLogic.Interface;
using UseDapper.DAL.Interface;
using UseDapper.DAL.Model;

namespace UseDapper.BissnesLogic.Implemeytation
{
    public class UserBl : IUserBL

    {
        private readonly IUserDal userDal;

        public UserBl(IUserDal userDal) 
        { 
            this.userDal = userDal; 
        

        }
        public int? Authenticate(string email, string password)
        {
            string encpassword =Encrypt(password);
            foreach (User user in userDal.FindByEmail(email))
            {
                if (user.Password == encpassword)
                {
                    return user.UserId;
                }
            }
            return null;

        }

        public User GetUserById(int userid)
        {
             return userDal.FindById(userid);
        }


        public string Encrypt(string password)
        {
            return password;
        }
    }
}
