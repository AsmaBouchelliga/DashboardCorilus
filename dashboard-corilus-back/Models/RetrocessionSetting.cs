using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("RetrocessionSetting")]
[Index("ExternalApplicationId", Name = "IX_RetrocessionSetting_ExternalApplicationId")]
public partial class RetrocessionSetting
{
    [Key]
    public Guid RetrocessionSettingId { get; set; }

    public Guid PhysicianId { get; set; }

    [StringLength(24)]
    public string ServiceCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Amount { get; set; }

    public bool? IsPercentage { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int Version { get; set; }

    public bool PerSessionCalculation { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("RetrocessionSettings")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [ForeignKey("PhysicianId")]
    [InverseProperty("RetrocessionSettings")]
    public virtual Physician Physician { get; set; } = null!;
}
