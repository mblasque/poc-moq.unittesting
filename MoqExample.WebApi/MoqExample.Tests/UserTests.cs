using Moq;
using Xunit;
using FluentAssertions;
using System.Threading.Tasks;
using MoqExample.Domain.Entities;
using MoqExample.Infra.Interfaces;
using MoqExample.Application.Implementations;

namespace MoqExample.Tests
{
    public class UserTests
    {
        private UserServices _userServices;
        private Mock<IUserRepository> _userRepositoryMock;

        public UserTests()
        {
            GenerateMock();
        }

        private void GenerateMock()
        {
            _userRepositoryMock = new Mock<IUserRepository>();

            _userServices = new UserServices(_userRepositoryMock.Object);
        }

        [Fact]
        public async Task CreateTest()
        {
            await _userServices.Create(new User());

            _userRepositoryMock.Verify(v => v.Save(It.IsAny<User>()), Times.Once);
        }

        [Fact]
        public async Task UpdateTest()
        {
            await _userServices.Update(new User());

            _userRepositoryMock.Verify(v => v.Save(It.IsAny<User>()), Times.Once);
        }

        [Fact]
        public async Task DeleteTest()
        {
            await _userServices.Delete(1);

            _userRepositoryMock.Verify(v => v.Delete(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public async Task GetTest()
        {
            var user = new User { Id = 1, Name = "Test" };

            _userRepositoryMock.Setup(s => s.Get(It.IsAny<int>()))
                .ReturnsAsync(user);

            var result = await _userServices.Get(0);

            result.Should().Be(user);
        }
    }
}
