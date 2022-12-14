using Restoran.Models.Base;

namespace Restoran.Models
{
    public class User : ModelBase
    {
        public string FIO { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public DateTime BirthDay { get; set; }

        public Guid RoleId { get; set; }
        public Role Role { get; set; }

        public List<Dish> Dishes { get; set; } = new List<Dish>();


        public static User CurrentUser { get; set; }
    }
}
