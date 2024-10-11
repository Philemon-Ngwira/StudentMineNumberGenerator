﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared.Models;

[Table("Status")]
public partial class Status
{
    [Key]
    public int StatusId { get; set; }

    [Column("Status")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status1 { get; set; }

    [InverseProperty("StatusNavigation")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}