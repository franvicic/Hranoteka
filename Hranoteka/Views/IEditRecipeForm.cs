using Hranoteka.Data;
using Hranoteka.Utils;

namespace Hranoteka.Views;

public interface IEditRecipeForm : IForm
{
    int RecipeId { get; set; }
    string Title { get; set; }
    string RecipeName { get; set; }
    int CategoryId { get; set; }
    Category Category { get; set; }
    string Alergens { get; set; }
    decimal Kcal { get; set; }
    string Description { get; set; }
    List<Ingredient> Ingredients { get; set; }
    string ImagePath { get; set; }
    List<Category> Categories { set; }
    List<Unit> Units { set; }

    void SetDetailsPageForEditing();
    void SetDetailsPageForAdding();

    event EventHandler SaveRecipeEvent;
    event EventHandler<RecipeEventArgs> LoadImageEvent;

}
