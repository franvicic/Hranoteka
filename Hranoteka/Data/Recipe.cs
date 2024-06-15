using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hranoteka.Data;

public class Recipe
{
    [Key]
    public int RecipeId { get; set; }

    [StringLength(150)]
    public string Name { get; set; }

    [StringLength(1500)]
    public string Description { get; set; }

    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User Author { get; set; }

    [StringLength(500)]
    public string RecipeImagePath { get; set; }

    public int CategoryId { get; set; }

    [ForeignKey(nameof(CategoryId))]
    public virtual Category Category { get; set; }

    public string Alergens { get; set; }

    public decimal Kcal { get; set; }

    [InverseProperty("Recipe")]
    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    public decimal Rating { get; set; }

    [InverseProperty("Recipe")]
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
