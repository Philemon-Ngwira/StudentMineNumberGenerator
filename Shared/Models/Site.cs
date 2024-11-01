﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared.Models;

public partial class Site
{
    [Key]
    public int SiteId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SiteName { get; set; }

    [InverseProperty("SiteNavigation")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}