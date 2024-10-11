﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared.Models;

[Table("MineNumberType")]
public partial class MineNumberType
{
    [Key]
    [Column("MNTypeId")]
    public int MntypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; }

    [InverseProperty("TypeNavigation")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}