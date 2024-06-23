using Hranoteka.Data;

namespace Hranoteka.Repositories;

public class UnitRepository
{
    private readonly AppDbContext _dbContext;

    public UnitRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Unit> GetAllUnits()
    {
        return _dbContext.Units.ToList();
    }
}
