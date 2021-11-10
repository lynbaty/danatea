
using Core.Entities.Identity;
using Core.Entities.Store;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() {Id=1,Name="English Breakfast",Description="Trà Anh Quốc",Price=1000,Frame="Image/1.jpg",DateCreated=System.DateTime.Now,IsHome=true,CategoryId=1},
                new Product() {Id=2,Name="EarlGrey",Description="Trà Bá Tước",Price=1000,Frame="Image/1.jpg",DateCreated=System.DateTime.Now,IsHome=true,CategoryId=1},
                new Product() {Id=3,Name="Mint",Description="Trà Bạc Hà",Price=1000,Frame="Image/1.jpg",DateCreated=System.DateTime.Now,IsHome=true,CategoryId=2}
            );
            modelBuilder.Entity<Category>().HasData(
                new Category() {Id=1,Name="Ahmad",SortOrder=1,IsHome=true},
                new Category() {Id=2,Name="Dilmah",SortOrder=1,IsHome=true}
            );
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() {Name="Admin"}
            );
        }
    }
}