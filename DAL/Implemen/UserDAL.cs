using UseDapper.DAL.Interface;
using UseDapper.DAL.Model;
using Dapper;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace UseDapper.DAL.Implemen
{
    public class UserDAl : IUserDal
    {
        public IEnumerable<User> FindByEmail(string email)
        {
            using (var connection = DBcon.CreateConnection())
            {
                return connection.Query<User>("select * from [User] where Email = @e",
                    new { e = email });
            }
        }

        public User FindById(int id)

        {
            using (var connection = DBcon.CreateConnection())
            {
                return connection.Query<User>("select * from [User] where UserId = @id",
                    new { id = id }).FirstOrDefault();
             }
        }
    }
}
