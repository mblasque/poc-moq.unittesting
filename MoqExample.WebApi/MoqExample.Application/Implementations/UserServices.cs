using System.Threading.Tasks;
using MoqExample.Domain.Entities;
using MoqExample.Infra.Interfaces;
using MoqExample.Application.Interfaces;

namespace MoqExample.Application.Implementations
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Create(User user)
        {
            // Business here
            await _userRepository.Save(user);
        }

        public async Task Delete(int id)
        {
            // Business here
            await _userRepository.Delete(id);
        }

        public async Task<User> Get(int id)
        {
            // Business here
            var user = await _userRepository.Get(id);
            return user;
        }

        public async Task Update(User user)
        {
            // Business here
            await _userRepository.Save(user);
        }
    }
}
