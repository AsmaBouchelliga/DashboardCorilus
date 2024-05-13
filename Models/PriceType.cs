using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PriceType")]
[Index("PhysicianId", Name = "IX_PriceType_PhysicianId")]
[Index("TarifCode", Name = "IX_PriceType_TarifCode")]
[Index("TarifCode", "ExternalApplicationId", "PhysicianId", Name = "IX_PriceType_TarifCode_ExternalApplicationId_PhysicianId", IsUnique = true)]
public partial class PriceType
{
    [Key]
    public int PriceTypeId { get; set; }

    public bool IsOfficialPriceType { get; set; }

    [StringLength(25)]
    public string TarifCode { get; set; } = null!;

    public bool IsHonorarium { get; set; }

    public Guid? ExternalApplicationId { get; set; }

    public Guid? PhysicianId { get; set; }

    public bool? IsOnlyValidForGmdPatients { get; set; }

    public bool? IsOnlyValidForPreferenceRegulationPatients { get; set; }

    public bool? IsOnlyValidForPalliativePatients { get; set; }

    public bool? IsOnlyValidForChronicalPatients { get; set; }

    public bool? IsOnlyValidForPhysiciansWithAgreement { get; set; }

    public bool? IsOnlyValidForApprenticePhysicians { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [InverseProperty("PriceType")]
    public virtual ICollection<PrestationPrice> PrestationPrices { get; set; } = new List<PrestationPrice>();

    [InverseProperty("PriceType")]
    public virtual ICollection<PriceTypeDescription> PriceTypeDescriptions { get; set; } = new List<PriceTypeDescription>();

    [InverseProperty("PriceTypeX")]
    public virtual ICollection<PriceTypeRelation> PriceTypeRelationPriceTypeXes { get; set; } = new List<PriceTypeRelation>();

    [InverseProperty("PriceTypeY")]
    public virtual ICollection<PriceTypeRelation> PriceTypeRelationPriceTypeYs { get; set; } = new List<PriceTypeRelation>();
}
