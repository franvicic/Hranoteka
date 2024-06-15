using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hranoteka.Data;

public class Comment
{
    [Key]
    public int CommentId { get; set; }

    public int RecipeId { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public virtual Recipe Recipe { get; set; }

    [StringLength(1500)]
    public string Text { get; set; }

    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User Author { get; set; }

    public int Rating { get; set; }
}
