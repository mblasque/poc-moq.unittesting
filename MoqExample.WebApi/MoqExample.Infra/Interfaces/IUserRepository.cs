using System.Threading.Tasks;
using MoqExample.Domain.Entities;

namespace MoqExample.Infra.Interfaces
{
    public interface IUserRepository
    {
        Task Save(User user);
        Task<User> Get(int id);
        Task Delete(int id);
    }
}
