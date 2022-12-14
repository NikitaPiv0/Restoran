using Microsoft.EntityFrameworkCore;
using Restoran.Models;

namespace Restoran.Ef
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Ingredient> Ingredients { get; set; } = null!;

        public DbSet<Dish> Dishes { get; set; } = null!;

        public DbSet<DishIngredient> DishIngredients { get; set; } = null!;

        public DbSet<Menu> Menus { get; set; } = null!;

        public DbSet<MenuDish> MenuDishes { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<OrderDish> OrderDishes { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;

        public DbSet<Role> Roles { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(
            //    "Server=(localdb)\\mssqllocaldb;Database=RestoranDb;Trusted_Connection=True;");
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>()
                .HasMany(dish => dish.Ingredients)
                .WithMany(ingredient => ingredient.Dishes)
                .UsingEntity<DishIngredient>(
                    j => j
                        .HasOne(dishIngredient => dishIngredient.Ingredient)
                        .WithMany(ingredient => ingredient.DishIngredients)
                        .HasForeignKey(dishIngredient => dishIngredient.IngredientId),
                    j => j
                        .HasOne(dishIngredient => dishIngredient.Dish)
                        .WithMany(dish => dish.DishIngredients)
                        .HasForeignKey(dishIngredient => dishIngredient.DishId),
                    j =>
                    {
                        j.HasKey(dishIngredient => new { dishIngredient.DishId, dishIngredient.IngredientId });
                    });

            modelBuilder.Entity<Dish>()
                .HasMany(dish => dish.Orders)
                .WithMany(order => order.Dishes)
                .UsingEntity<OrderDish>(
                    j => j
                        .HasOne(orderDish => orderDish.Order)
                        .WithMany(order => order.OrderDishes)
                        .HasForeignKey(orderDish => orderDish.OrderId),
                    j => j
                        .HasOne(orderDish => orderDish.Dish)
                        .WithMany(dish => dish.OrderDishes)
                        .HasForeignKey(orderDish => orderDish.DishId),
                    j =>
                    {
                        j.HasKey(orderDish => new { orderDish.OrderId, orderDish.DishId });
                    });

            modelBuilder.Entity<Dish>()
                .HasMany(dish => dish.Menus)
                .WithMany(menu => menu.Dishes)
                .UsingEntity<MenuDish>(
                    j => j
                        .HasOne(menuDish => menuDish.Menu)
                        .WithMany(menu => menu.MenuDishes)
                        .HasForeignKey(menuDish => menuDish.MenuId),
                    j => j
                        .HasOne(menuDish => menuDish.Dish)
                        .WithMany(menu => menu.MenuDishes)
                        .HasForeignKey(menuDish => menuDish.DishId),
                    j =>
                    {
                        j.HasKey(menuDish => new { menuDish.MenuId, menuDish.DishId });
                    });

            var roles = new List<Role>
            {
                new Role { Id = Guid.NewGuid(), Name = "Кассир" },
                new Role { Id = Guid.NewGuid(), Name = "Повар" },
                new Role { Id = Guid.NewGuid(), Name = "Администратор" }
            };

            modelBuilder.Entity<Role>().HasData(roles);
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.NewGuid(),
                UserName = "admin",
                Password = "admin",
                FIO = "Иванов Иван Иванович",
                BirthDay = DateTime.Now,
                RoleId = roles[2].Id
            });
        }
    }
}
