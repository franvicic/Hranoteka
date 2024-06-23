using Hranoteka.Data;
using Microsoft.EntityFrameworkCore;

namespace Hranoteka.Repositories;

public class CommentRepository
{
    private readonly AppDbContext _dbContext;

    public CommentRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Comment> GetCommentsByRecipeId(int recipeId)
    {
        return _dbContext.Comments
            .Where(c => c.RecipeId == recipeId)
            .Include(c => c.Author)
            .ToList();
    }

    public Comment GetUserCommentForRecipe(int recipeId, int userId)
    {
        return _dbContext.Comments
            .Where(c => c.RecipeId == recipeId)
            .Where(c => c.UserId == userId)
            .Include(c => c.Author)
            .FirstOrDefault();
    }

    public bool AddComment(Comment comment)
    {
        var existingComment = _dbContext.Comments
            .Where(c => c.UserId == comment.UserId)
            .Where(c => c.RecipeId == comment.RecipeId)
            .FirstOrDefault();

        var existingRecipe = _dbContext.Recipes.FirstOrDefault(r => r.RecipeId == comment.RecipeId);
        if (existingRecipe == null)
        {
            return false;
        }

        if (existingComment != null)
        {
            existingComment.Text = comment.Text;
            existingComment.Rating = comment.Rating;
        }
        else
        {
            _dbContext.Comments.Add(comment);
        }
        _dbContext.SaveChanges();

        return true;
    }

}
