using Restoran.Models;
using Restoran.ViewModels;

namespace Restoran.Mappings
{
    public class UserMapper : MapperBase
    {
        public UserMapper()
        {
            CreateMap<User, UserViewModel>(user => new UserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Password = user.Password,
                RoleName = user.Role.Name,
                FIO = user.FIO,
                BirthDay = user.BirthDay
            });
        }
    }
}
