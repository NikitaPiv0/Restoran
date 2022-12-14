﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restoran.Ef;

#nullable disable

namespace Restoran.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221008094834_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("DishUser", b =>
                {
                    b.Property<Guid>("AuthorsId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DishesId")
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorsId", "DishesId");

                    b.HasIndex("DishesId");

                    b.ToTable("DishUser");
                });

            modelBuilder.Entity("Restoran.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Restoran.Models.Dish", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Restoran.Models.DishIngredient", b =>
                {
                    b.Property<Guid>("DishId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quntity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DishId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("DishIngredients");
                });

            modelBuilder.Entity("Restoran.Models.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Carbohydrate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Protein")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Сalories")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Restoran.Models.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CopmanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Restoran.Models.MenuDish", b =>
                {
                    b.Property<Guid>("MenuId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DishId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.HasKey("MenuId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("MenuDishes");
                });

            modelBuilder.Entity("Restoran.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MenuId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Restoran.Models.OrderDish", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DishId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("OrderDishes");
                });

            modelBuilder.Entity("Restoran.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fbadc424-0e28-4ed1-af49-ee11c43fb957"),
                            Name = "Кассир"
                        },
                        new
                        {
                            Id = new Guid("c021e800-8cc7-4d71-925d-219120e7d67a"),
                            Name = "Повар"
                        },
                        new
                        {
                            Id = new Guid("2690036f-03ab-4483-a5b0-4b9be18dc499"),
                            Name = "Администратор"
                        });
                });

            modelBuilder.Entity("Restoran.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("TEXT");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eab6a7f2-1d25-40dc-afd7-d050899e105e"),
                            BirthDay = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FIO = "Иванов Иван Иванович",
                            Password = "admin",
                            RoleId = new Guid("2690036f-03ab-4483-a5b0-4b9be18dc499"),
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("DishUser", b =>
                {
                    b.HasOne("Restoran.Models.User", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Models.Dish", null)
                        .WithMany()
                        .HasForeignKey("DishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.Models.Dish", b =>
                {
                    b.HasOne("Restoran.Models.Category", "Category")
                        .WithMany("Dishes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Restoran.Models.DishIngredient", b =>
                {
                    b.HasOne("Restoran.Models.Dish", "Dish")
                        .WithMany("DishIngredients")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Models.Ingredient", "Ingredient")
                        .WithMany("DishIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("Restoran.Models.MenuDish", b =>
                {
                    b.HasOne("Restoran.Models.Dish", "Dish")
                        .WithMany("MenuDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Models.Menu", "Menu")
                        .WithMany("MenuDishes")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("Restoran.Models.Order", b =>
                {
                    b.HasOne("Restoran.Models.Menu", "Menu")
                        .WithMany("Orders")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("Restoran.Models.OrderDish", b =>
                {
                    b.HasOne("Restoran.Models.Dish", "Dish")
                        .WithMany("OrderDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Models.Order", "Order")
                        .WithMany("OrderDishes")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Restoran.Models.User", b =>
                {
                    b.HasOne("Restoran.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Restoran.Models.Category", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("Restoran.Models.Dish", b =>
                {
                    b.Navigation("DishIngredients");

                    b.Navigation("MenuDishes");

                    b.Navigation("OrderDishes");
                });

            modelBuilder.Entity("Restoran.Models.Ingredient", b =>
                {
                    b.Navigation("DishIngredients");
                });

            modelBuilder.Entity("Restoran.Models.Menu", b =>
                {
                    b.Navigation("MenuDishes");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Restoran.Models.Order", b =>
                {
                    b.Navigation("OrderDishes");
                });

            modelBuilder.Entity("Restoran.Models.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
