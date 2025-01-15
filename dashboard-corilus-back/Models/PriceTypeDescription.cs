using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[PrimaryKey("PriceTypeId", "LanguageCode")]
[Table("PriceTypeDescription")]
public partial class PriceTypeDescription
{
    [Key]
    public int PriceTypeId { get; set; }

    [Key]
    public int LanguageCode { get; set; }

    [StringLength(255)]
    public string Description { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [ForeignKey("LanguageCode")]
    [InverseProperty("PriceTypeDescriptions")]
    public virtual Language LanguageCodeNavigation { get; set; } = null!;

    [ForeignKey("PriceTypeId")]
    [InverseProperty("PriceTypeDescriptions")]
    public virtual PriceType PriceType { get; set; } = null!;
}
