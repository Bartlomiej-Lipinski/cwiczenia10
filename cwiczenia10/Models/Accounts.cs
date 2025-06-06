﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cwiczenia10.Models;
[Table("Accounts")]
public class Accounts
{
    [Key]
    [Column("PK_account")]
    public int AccountId { get; set; }
    [Column("FK_role")]
    [ForeignKey("Role")]
    public int Roles { get; set; }
    [Column("first_name")]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Column("last_name")]
    [MaxLength(50)]
    public string LastName { get; set; }
    [Column("email")]
    [MaxLength(80)]
    public string Email { get; set; }
    [Column("phone")]
    [MaxLength(9)]
    public string? Phone { get; set; }
    public Roles Role { get; set; }
}