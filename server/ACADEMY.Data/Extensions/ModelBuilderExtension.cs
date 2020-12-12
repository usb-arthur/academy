using ACADEMY.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ACADEMY.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, CategoryName = "Development"});
        }
    }
}