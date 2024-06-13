using Hranoteka.Data;
using Hranoteka.Utils;

namespace Hranoteka.Views;

public interface IMainForm : IForm
{
    string SearchText { get; }
    bool CurrentRecipesOnly { get; }

    event EventHandler AddNewRecipeEvent;
    //event EventHandler MyRecipesEvent;
    event EventHandler SearchRecipesEvent;
    event EventHandler LoadProfileEvent;
    event EventHandler<RecipeEventArgs> RecipeLoadDetailsEvent;

    void PopulateUserData(User user);
    void DisplayRecipes(List<Recipe> recipes);
}
