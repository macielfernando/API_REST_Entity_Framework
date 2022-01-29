﻿using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; } 
     
     
    //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}


     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Product>()
            .Property(p=> p.Description).HasMaxLength(500).IsRequired(false);

        builder.Entity<Product>()
            .Property(p => p.Name).HasMaxLength(120).IsRequired();

        builder.Entity<Product>()
           .Property(p => p.Code).HasMaxLength(20).IsRequired();

        builder.Entity<Category>()
            .ToTable("Categories");
    }

   
}







//==========================================================================================

//return product.Name + (" - ") + product.Code;



//api.app.com/user?getproduct={date}&dataend={date}
//app.MapGet("/getproductoutro", ([FromQuery] string dateStart, [FromQuery] string dateEnd) => {
// return dateStart + " - " + dateEnd;
//});

//api.app.com/user/{code}
//app.MapGet("/getproduct/{code}", ([FromRoute] string code) => {
//var product = ProductRepository.GetBy(code);
//});