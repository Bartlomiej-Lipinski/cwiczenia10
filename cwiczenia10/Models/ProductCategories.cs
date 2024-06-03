using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cwiczenia10.Models;

public class ProductCategories
{
    [Key]
    [ForeignKey("Product")]
    [Column("FK_product")]
    public int ProductId { get; set; }
    [Key]
    [ForeignKey("Category")]
    [Column("FK_category")]
    public int CategoryId { get; set; }
    public Products Product { get; set; }
    public Categories Category { get; set; }
}