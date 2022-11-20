using UseDapper.DAL.Model;

namespace UseDapper.DAL.Interface
{
    public interface IUserDal
    {
        IEnumerable<User> FindByEmail(string email);
        User FindById(int id);
    }
}
