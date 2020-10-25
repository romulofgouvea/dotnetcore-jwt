using jwt.Data.Infra.Context;
using jwt.Data.Infra.Repository;
using jwt.Domain.Entities;
using jwt.Domain.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace jwt.Services.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {

        }

        public async Task<bool> ExistsEmailOrUsername(User user)
        {
            var allUsers = await Select();

            return allUsers.Any(e => e.Email == user.Email || e.Username == user.Username);
        }

        public Task<User> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByUserName(string username)
        {
            User data = Select().Result.FirstOrDefault(c => c.Username == username);

            return await Task.FromResult(data);
        }
    }
}
