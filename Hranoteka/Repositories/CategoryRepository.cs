using Hranoteka.Data;

namespace Hranoteka.Repositories;

public class CategoryRepository
{
    private readonly AppDbContext _dbContext;

    public CategoryRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Category> GetAllCategories()
    {
        return _dbContext.Categories.ToList();
    }

}
