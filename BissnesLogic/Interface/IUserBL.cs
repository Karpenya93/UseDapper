using UseDapper.DAL.Model;

namespace UseDapper.BissnesLogic.Interface
{
    public interface IUserBL
    {
        int? Authenticate(string email, string password);
        User GetUserById(int id);

    }
}
