using Hranoteka.Data;
using Hranoteka.Utils;

namespace Hranoteka.Views;

public interface IRecipeDetailsForm : IForm
{
    int RecipeId { get; set; }
    string RecipeTitle { get; set; }
    Category Category { get; set; }
    string TotalCalories { get; set; }
    string TotalRating { get; set; }
    string ImagePath { get; set; }
    string Description { get; set; }
    string Ingredients { get; set; }
    string Alergens { get; set; }
    int CurrentUserRating { get; set; }
    string CurrentUserComment { get; set; }

    void DisplayComments(List<Comment> comments);
    void SetEditButtonVisibility(bool isVisible);
    void SetRateTabPageVisibility(bool isVisible);


    event EventHandler<RecipeEventArgs> EditRecipeEvent;
    event EventHandler<RecipeEventArgs> RateRecipeEvent;
}
