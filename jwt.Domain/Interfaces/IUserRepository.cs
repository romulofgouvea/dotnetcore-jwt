using jwt.Domain.Entities;
using System.Threading.Tasks;

namespace jwt.Domain.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetByUserName(string username);
        Task<User> GetByEmail(string email);
        Task<bool> ExistsEmailOrUsername(User user);
    }
}
