using Hranoteka.Data;

namespace Hranoteka.Repositories;

public class UserRepository
{
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public User ValidateUser(string username, string password)
    {
        return _dbContext.Users
            .FirstOrDefault(u => u.Username == username && u.Password == password);
    }

    public bool AddUser(User user)
    {
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();

        return true;
    }

    public bool UpdateUser(int userId, User user)
    {
        var existingUser = _dbContext.Users.FirstOrDefault(u => u.UserId == userId);
        if (existingUser != null)
        {
            existingUser.Username = user.Username;
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            existingUser.Country = user.Country;
            existingUser.Password = user.Password;
            existingUser.ProfileImagePath = user.ProfileImagePath;

            _dbContext.SaveChanges();

            return true;
        }

        return false;
    }

    public User GetUserByUsername(string username)
    {
        return _dbContext.Users
            .FirstOrDefault(u => u.Username == username);
    }
}


