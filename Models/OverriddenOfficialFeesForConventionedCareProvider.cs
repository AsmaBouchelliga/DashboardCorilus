using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Index("ExternalApplicationId", "CareProviderId", "NomenclatureCode", Name = "IX_ExternalApplicationId_CareProviderId_NomenclatureCode", IsUnique = true)]
public partial class OverriddenOfficialFeesForConventionedCareProvider
{
    [Key]
    public Guid OverriddenOfficialFeesForConventionedCareProvidersId { get; set; }

    public Guid CareProviderId { get; set; }

    [StringLength(10)]
    public string NomenclatureCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Fee { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    [ForeignKey("CareProviderId")]
    [InverseProperty("OverriddenOfficialFeesForConventionedCareProviders")]
    public virtual Physician CareProvider { get; set; } = null!;
}
