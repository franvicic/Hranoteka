using System.ComponentModel.DataAnnotations;

namespace Hranoteka.Data;

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [StringLength(150)]
    public string Name { get; set; }
}
