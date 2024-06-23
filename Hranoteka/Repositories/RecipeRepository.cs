using Hranoteka.Data;
using Microsoft.EntityFrameworkCore;

namespace Hranoteka.Repositories;

public class RecipeRepository
{
    private readonly AppDbContext _dbContext;

    public RecipeRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Recipe> GetMyRecipes(int userId)
    {
        return _dbContext.Recipes.Where(r => r.UserId == userId)
            .OrderByDescending(r => r.RecipeId)
            .ToList();
    }

    public List<Recipe> SearchRecipes(string searchText, int? userId)
    {
        var query = _dbContext.Recipes.AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            query = query.Where(r => r.Name.ToLower().Contains(searchText.ToLower()));
        }        
        if (userId.HasValue)
        {
            query = query.Where(r =>r.UserId == userId);
        }

        return query
            .Include(r => r.Author)
            .Include(r => r.Category)
            .Include(r => r.Ingredients)
            .Include(r => r.Comments)
            .OrderByDescending(r => r.RecipeId)
            .ToList();
    }

    public bool AddRecipe(Recipe recipe)
    {
        _dbContext.Recipes.Add(recipe);
        _dbContext.SaveChanges();

        return true;
    }

    public Recipe GetRecipeById(int id)
    {
        return _dbContext.Recipes
            .Include(r => r.Category)
            .Include(r => r.Author)
            .Include(r => r.Ingredients)
            .Include(r => r.Comments)
            .FirstOrDefault(r => r.RecipeId == id);
    }

    public bool UpdateRecipe(int recipeId, Recipe recipe)
    {
        var existingRecipe = _dbContext.Recipes
            .Include(r => r.Ingredients)
            .FirstOrDefault(r => r.RecipeId == recipeId);
        //var existingRecipe = _dbContext.Recipes.FirstOrDefault(r => r.RecipeId == recipeId);
        if (existingRecipe != null)
        {
            _dbContext.Entry(existingRecipe).State = EntityState.Detached;

            // Re-attach the recipe entity
            recipe.RecipeId = recipeId;
            recipe.Rating = existingRecipe.Rating;
            recipe.UserId = existingRecipe.UserId;
            recipe.Author = existingRecipe.Author;
            _dbContext.Entry(recipe).State = EntityState.Modified;

            // Update ingredients
            foreach (var ingredient in existingRecipe.Ingredients.ToList())
            {
                _dbContext.Entry(ingredient).State = EntityState.Deleted;
            }

            foreach (var ingredient in recipe.Ingredients)
            {
                ingredient.RecipeId = recipeId; // Ensure the foreign key is set
                _dbContext.Entry(ingredient).State = EntityState.Added;
            }

            ////////_dbContext.Entry(existingRecipe).State = EntityState.Modified;
            ////////existingRecipe.Name = recipe.Name;
            ////////existingRecipe.CategoryId = recipe.CategoryId;
            ////////existingRecipe.Category = recipe.Category;
            ////////existingRecipe.Alergens = recipe.Alergens;
            ////////existingRecipe.Kcal = recipe.Kcal;
            ////////existingRecipe.Description = recipe.Description;
            ////////existingRecipe.RecipeImagePath = recipe.RecipeImagePath;
            //////////existingRecipe.Rating = recipe.Rating;
            //////////existingRecipe.UserId = recipe.UserId;
            //////////existingRecipe.Author = recipe.Author;

            ////////// Update ingredients
            ////////if (existingRecipe.Ingredients != null)
            ////////{
            ////////    _dbContext.Ingredients.RemoveRange(existingRecipe.Ingredients);
            ////////}

            ////////foreach (var ingredient in recipe.Ingredients)
            ////////{
            ////////    ingredient.RecipeId = recipeId; // Ensure the foreign key is set
            ////////    _dbContext.Ingredients.Add(ingredient);
            ////////}

            _dbContext.SaveChanges();

            return true;
        }

        return false;
    }

    public decimal RecalculateRatingForRecipe(int recipeId)
    {
        var ratings = _dbContext.Comments
            .Where(c => c.RecipeId == recipeId)
            .Select(c => (decimal?)c.Rating) // koristimo decimal? kako bi omogućili Null handling
            .ToList();

        // Ako nema komentara, vraćamo 0
        decimal rating = 0m;
        if (!ratings.Any() || !ratings.Sum().HasValue)
        {
            return rating;
        }

        var recipe = _dbContext.Recipes.FirstOrDefault(r => r.RecipeId == recipeId);
        if (recipe != null)
        {
            rating = ratings.Average().Value;
            recipe.Rating = rating;
            _dbContext.SaveChanges();
        }

        return rating;
    }
}

