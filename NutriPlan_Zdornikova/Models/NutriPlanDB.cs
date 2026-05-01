using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NutriPlan_Zdornikova.Models
{
    public partial class NutriPlanDB : DbContext
    {
        public NutriPlanDB()
            : base("name=NutriPlanDB")
        {
        }

        public virtual DbSet<ActivityLevel> ActivityLevel { get; set; }
        public virtual DbSet<dishes> dishes { get; set; }
        public virtual DbSet<FoodLogs> FoodLogs { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Goal> Goal { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypesMeal> TypesMeal { get; set; }
        public virtual DbSet<UserProfiles> UserProfiles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ViewDishes> ViewDishes { get; set; }
        public virtual DbSet<WeightHistory> WeightHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityLevel>()
                .HasMany(e => e.UserProfiles)
                .WithRequired(e => e.ActivityLevel)
                .HasForeignKey(e => e.IdActivityLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dishes>()
                .HasMany(e => e.FoodLogs)
                .WithRequired(e => e.dishes)
                .HasForeignKey(e => e.DishId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.UserProfiles)
                .WithRequired(e => e.Gender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Goal>()
                .HasMany(e => e.UserProfiles)
                .WithRequired(e => e.Goal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypesMeal>()
                .HasMany(e => e.FoodLogs)
                .WithRequired(e => e.TypesMeal)
                .HasForeignKey(e => e.IdMealType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserProfiles>()
                .HasMany(e => e.FoodLogs)
                .WithRequired(e => e.UserProfiles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserProfiles>()
                .HasMany(e => e.WeightHistory)
                .WithRequired(e => e.UserProfiles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.dishes)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.Created_by)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasOptional(e => e.UserProfiles)
                .WithRequired(e => e.Users);

            modelBuilder.Entity<ViewDishes>()
                .HasMany(e => e.dishes)
                .WithOptional(e => e.ViewDishes1)
                .HasForeignKey(e => e.ViewDishes);
        }
    }
}
