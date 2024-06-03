using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cwiczenia10.Models;

public class Categories
{
    [Key]
    public int CategoryId { get; set; }
    [Column("name")]
    [MaxLength(100)]
    public string Name { get; set; }
}