using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cwiczenia10.Models;

public class Products
{
    [Key]
    [Column("PK_product")]
    public int ProductId { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("weight")]
    public double Weight { get; set; }
    [Column("width")]
    public double Width { get; set; }
    [Column("height")]
    public double Height { get; set; }
    [Column("depth")]
    public double Depth { get; set; }
}