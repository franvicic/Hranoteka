namespace Hranoteka.Utils;

public class RecipeEventArgs : EventArgs
{
    public int RecipeId { get; set; }

    public RecipeEventArgs(int recipeId)
    {
        RecipeId = recipeId;
    }
}
