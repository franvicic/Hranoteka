using Microsoft.EntityFrameworkCore;

namespace Hranoteka.Data;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Recipe -> Ingredients relationship
        modelBuilder.Entity<Recipe>()
            .HasMany(r => r.Ingredients)
            .WithOne(i => i.Recipe)
            .HasForeignKey(i => i.RecipeId)
            .OnDelete(DeleteBehavior.Cascade);

        // Recipe -> Comments relationship
        modelBuilder.Entity<Recipe>()
            .HasMany(r => r.Comments)
            .WithOne(c => c.Recipe)
            .HasForeignKey(c => c.RecipeId)
            .OnDelete(DeleteBehavior.Cascade);

        // Comment -> User relationship
        modelBuilder.Entity<Comment>()
            .HasOne(c => c.Author)
            .WithMany()
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        // Recipe -> User relationship
        modelBuilder.Entity<Recipe>()
            .HasOne(r => r.Author)
            .WithMany()
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        if (Database.ProviderName == "Microsoft.EntityFrameworkCore.InMemory")
        {
            return;
        }

        // data
        modelBuilder.Entity<Category>().HasData
        (
            new Category { CategoryId = 1, Name = "hrvatska" },
            new Category { CategoryId = 2, Name = "talijanska" },
            new Category { CategoryId = 3, Name = "američka" },
            new Category { CategoryId = 4, Name = "kineska" },
            new Category { CategoryId = 5, Name = "ostalo" }
        );

        modelBuilder.Entity<Unit>().HasData
        (
            new Unit { UnitId = 1, Name = "g" },
            new Unit { UnitId = 2, Name = "dag" },
            new Unit { UnitId = 3, Name = "kg" },
            new Unit { UnitId = 4, Name = "ml" },
            new Unit { UnitId = 5, Name = "dl" },
            new Unit { UnitId = 6, Name = "lit" },
            new Unit { UnitId = 7, Name = "kom" }
        );

        modelBuilder.Entity<User>().HasData
        (
            new User { UserId = 1, Username = "fran", Password = "password", FirstName = "Fran", LastName = "Vicić", Country = "Hrvatska", ProfileImagePath = "fran.jpg" },
            new User { UserId = 2, Username = "tin", Password = "password", FirstName = "Tin", LastName = "Šoprun", Country = "Hrvatska", ProfileImagePath = "tin.jpg" },
            new User { UserId = 3, Username = "bruno", Password = "password", FirstName = "Bruno", LastName = "Bogdan", Country = "Hrvatska", ProfileImagePath = "bruno.jpg" },
            new User { UserId = 4, Username = "dora", Password = "password", FirstName = "Dora", LastName = "Sučić", Country = "Hrvatska", ProfileImagePath = "dora.jpg" }
        );

        modelBuilder.Entity<Recipe>().HasData
        (
            new Recipe { RecipeId = 1, Name = "Štrukli", Description = "Speci", UserId = 1, CategoryId = 1, RecipeImagePath = "strukli.jpg", Alergens = "sir", Kcal = 1500, Rating = 5M },
            new Recipe { RecipeId = 2, Name = "Pizza", Description = "Razvuci", UserId = 2, CategoryId = 2, RecipeImagePath = "pizza.jpg", Alergens = "rajčica", Kcal = 1800, Rating = 4M },
            new Recipe { RecipeId = 3, Name = "Burger", Description = "Složi", UserId = 3, CategoryId = 3, RecipeImagePath = "burger.jpg", Alergens = "sir", Kcal = 1000, Rating = 3M },
            new Recipe { RecipeId = 4, Name = "Pekinška patka", Description = "Ulovi patku", UserId = 4, CategoryId = 4, RecipeImagePath = "pepa.jpg", Alergens = "---", Kcal = 1200, Rating = 2M }
        );


        modelBuilder.Entity<Ingredient>().HasData
        (
            new Ingredient { IngredientId = 1, RecipeId = 1, Description = "tijesto - 500 g" },
            new Ingredient { IngredientId = 2, RecipeId = 1, Description = "sir - 500 g" },
            new Ingredient { IngredientId = 3, RecipeId = 2, Description = "tijesto - 500 g" },
            new Ingredient { IngredientId = 4, RecipeId = 2, Description = "šunka - 150 g" },
            new Ingredient { IngredientId = 5, RecipeId = 3, Description = "pecivo - 100 g" },
            new Ingredient { IngredientId = 6, RecipeId = 3, Description = "pljeskavica - 150 g" },
            new Ingredient { IngredientId = 7, RecipeId = 4, Description = "patka - 2,5 kg" },
            new Ingredient { IngredientId = 8, RecipeId = 4, Description = "krumpir - 1 kg" }
        );

        modelBuilder.Entity<Comment>().HasData
        (
            new Comment { CommentId = 1, UserId = 1, RecipeId = 4, Rating = 2, Text = "jestivo" },
            new Comment { CommentId = 2, UserId = 2, RecipeId = 3, Rating = 3, Text = "dobro" },
            new Comment { CommentId = 3, UserId = 3, RecipeId = 2, Rating = 4, Text = "vrlo dobro" },
            new Comment { CommentId = 4, UserId = 4, RecipeId = 1, Rating = 5, Text = "odlično" }
        );

        base.OnModelCreating(modelBuilder);
    }

}
