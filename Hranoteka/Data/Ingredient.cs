using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hranoteka.Data;

public class Ingredient
{
    [Key]
    public int IngredientId { get; set; }

    public int RecipeId { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public virtual Recipe Recipe { get; set; }

    [StringLength(1500)]
    public string Description { get; set; }
}
