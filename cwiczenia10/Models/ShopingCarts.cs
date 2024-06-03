using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cwiczenia10.Models;

public class ShopingCarts
{
    [Key]
    [ForeignKey("Account")]
    [Column("FK_account")]
    public int Accounts { get; set; }
    [Key]
    [ForeignKey("Product")]
    [Column("FK_product")]
    public int Products { get; set; }
    [Column("amount")]
    public int amount { get; set; }
    public Accounts Account { get; set; }
    public Products Product { get; set; }
}