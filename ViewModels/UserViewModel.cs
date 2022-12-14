using Restoran.Models.Base;

namespace Restoran.ViewModels
{
    public class UserViewModel : ModelBase
    {
        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string RoleName { get; set; } = null!;

        public string FIO { get; set; } = null!;

        public DateTime BirthDay { get; set; }
    }
}
