using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[PrimaryKey("LetterKey", "MinCoefficient", "MaxCoefficient", "UsageCode")]
[Table("AdditionalOnCallPrestationRegistry")]
[Index("LetterKey", "MinCoefficient", "MaxCoefficient", "UsageCode", Name = "IX_AdditionalOnCallPrestationRegistry", IsUnique = true)]
public partial class AdditionalOnCallPrestationRegistry
{
    [Key]
    [StringLength(1)]
    public string LetterKey { get; set; } = null!;

    [Key]
    [Column(TypeName = "decimal(19, 4)")]
    public decimal MinCoefficient { get; set; }

    [Key]
    [Column(TypeName = "decimal(19, 4)")]
    public decimal MaxCoefficient { get; set; }

    [Key]
    public int UsageCode { get; set; }

    public Guid? AdditionalEveningPrestationId { get; set; }

    public Guid? AdditionalNightPrestationId { get; set; }

    public Guid? AdditionalWeekendPrestationId { get; set; }

    [ForeignKey("AdditionalEveningPrestationId")]
    [InverseProperty("AdditionalOnCallPrestationRegistryAdditionalEveningPrestations")]
    public virtual Prestation? AdditionalEveningPrestation { get; set; }

    [ForeignKey("AdditionalNightPrestationId")]
    [InverseProperty("AdditionalOnCallPrestationRegistryAdditionalNightPrestations")]
    public virtual Prestation? AdditionalNightPrestation { get; set; }

    [ForeignKey("AdditionalWeekendPrestationId")]
    [InverseProperty("AdditionalOnCallPrestationRegistryAdditionalWeekendPrestations")]
    public virtual Prestation? AdditionalWeekendPrestation { get; set; }

    [ForeignKey("UsageCode")]
    [InverseProperty("AdditionalOnCallPrestationRegistries")]
    public virtual UsageType UsageCodeNavigation { get; set; } = null!;
}
