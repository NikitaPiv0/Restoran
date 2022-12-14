using Restoran.Models.Base;

namespace Restoran.Models
{
    public class Role : ModelBase
    {
        public string Name { get; set; } = null!;

        public List<User> Users { get; set; } = new List<User>();


        public static string Admin => "Администратор";
        public static string Cook => "Повар";
        public static string Cashier => "Кассир";

        public static bool IsAdmin(Role role)
        {
            return role.Name == "Администратор";
        }

        public static bool IsCook(Role role)
        {
            return role.Name == "Повар";
        }

        public static bool IsCashier(Role role)
        {
            return role.Name == "Кассир";
        }
    }
}
