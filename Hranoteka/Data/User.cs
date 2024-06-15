using System.ComponentModel.DataAnnotations;

namespace Hranoteka.Data;

public class User
{
    [Key]
    public int UserId { get; set; }

    [StringLength(150)]
    public string Username { get; set; }

    [StringLength(50)]
    public string Password { get; set; }

    [StringLength(150)]
    public string FirstName { get; set; }

    [StringLength(150)]
    public string LastName { get; set; }

    [StringLength(150)]
    public string Country { get; set; }

    [StringLength(500)]
    public string ProfileImagePath { get; set; }
}
