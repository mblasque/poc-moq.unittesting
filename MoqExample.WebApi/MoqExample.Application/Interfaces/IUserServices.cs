using MoqExample.Domain.Entities;
using System.Threading.Tasks;

namespace MoqExample.Application.Interfaces
{
    public interface IUserServices
    {
        Task Create(User user);
        Task<User> Get(int id);
        Task Update(User user);
        Task Delete(int id);
    }
}
