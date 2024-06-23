using Hranoteka.Data;

namespace Hranoteka.Repositories;

public class IngredientRepository
{
    private readonly AppDbContext _dbContext;

    public IngredientRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Ingredient> GetIngredientsForRecipe(int recipeId)
    {
        return _dbContext.Ingredients
            .Where(i => i.RecipeId == recipeId)
            .ToList();
    }
}
