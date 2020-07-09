using System.Threading.Tasks;
using MoqExample.Domain.Entities;
using MoqExample.Infra.Interfaces;

namespace MoqExample.Infra.Repositories
{
    public class SqlUserRepository : IUserRepository
    {
        public Task Save(User user)
        {
            // Implement access data here
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            // Implement access data here
            throw new System.NotImplementedException();
        }

        public Task<User> Get(int id)
        {
            // Implement access data here
            throw new System.NotImplementedException();
        }
    }
}
