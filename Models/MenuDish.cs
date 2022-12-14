﻿namespace Restoran.Models
{
    public class MenuDish
    {
        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }

        public Guid DishId { get; set; }
        public Dish Dish { get; set; }

        public int Count { get; set; }
    }
}
