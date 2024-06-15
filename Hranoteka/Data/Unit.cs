using System.ComponentModel.DataAnnotations;

namespace Hranoteka.Data;

public class Unit
{
    [Key]
    public int UnitId { get; set; }

    [StringLength(150)]
    public string Name { get; set; }
}
