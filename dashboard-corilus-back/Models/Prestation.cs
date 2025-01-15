using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Prestation")]
[Index("ChapterId", Name = "IX_Prestation_ChapterId")]
public partial class Prestation
{
    [Key]
    public Guid PrestationId { get; set; }

    [StringLength(20)]
    public string NomenclatureNr { get; set; } = null!;

    public DateTime PublicationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IsNoLongerTarifableSince { get; set; }

    [StringLength(255)]
    public string? IsReplacedBy { get; set; }

    public Guid ChapterId { get; set; }

    public int PrestationTypeCode { get; set; }

    public int UsageCode { get; set; }

    public bool IsConsultationPrestation { get; set; }

    public bool OnCallTariffIsNotAllowed { get; set; }

    public bool CanOnlyBeUsedByAccreditatedPhysicians { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [InverseProperty("AdditionalEveningPrestation")]
    public virtual ICollection<AdditionalOnCallPrestationRegistry> AdditionalOnCallPrestationRegistryAdditionalEveningPrestations { get; set; } = new List<AdditionalOnCallPrestationRegistry>();

    [InverseProperty("AdditionalNightPrestation")]
    public virtual ICollection<AdditionalOnCallPrestationRegistry> AdditionalOnCallPrestationRegistryAdditionalNightPrestations { get; set; } = new List<AdditionalOnCallPrestationRegistry>();

    [InverseProperty("AdditionalWeekendPrestation")]
    public virtual ICollection<AdditionalOnCallPrestationRegistry> AdditionalOnCallPrestationRegistryAdditionalWeekendPrestations { get; set; } = new List<AdditionalOnCallPrestationRegistry>();

    [ForeignKey("ChapterId")]
    [InverseProperty("Prestations")]
    public virtual Chapter Chapter { get; set; } = null!;

    [InverseProperty("PrestationX")]
    public virtual ICollection<MedicalCareServiceRelation> MedicalCareServiceRelationPrestationXes { get; set; } = new List<MedicalCareServiceRelation>();

    [InverseProperty("PrestationY")]
    public virtual ICollection<MedicalCareServiceRelation> MedicalCareServiceRelationPrestationies { get; set; } = new List<MedicalCareServiceRelation>();

    [InverseProperty("Prestation")]
    public virtual ICollection<PrestationCoefficientValue> PrestationCoefficientValues { get; set; } = new List<PrestationCoefficientValue>();

    [InverseProperty("Prestation")]
    public virtual ICollection<PrestationGroupItem> PrestationGroupItems { get; set; } = new List<PrestationGroupItem>();

    [InverseProperty("Prestation")]
    public virtual ICollection<PrestationName> PrestationNames { get; set; } = new List<PrestationName>();

    [InverseProperty("Prestation")]
    public virtual ICollection<PrestationPrice> PrestationPrices { get; set; } = new List<PrestationPrice>();

    [ForeignKey("PrestationTypeCode")]
    [InverseProperty("Prestations")]
    public virtual PrestationType PrestationTypeCodeNavigation { get; set; } = null!;

    [InverseProperty("Prestation")]
    public virtual ICollection<RelativePrestationCode> RelativePrestationCodes { get; set; } = new List<RelativePrestationCode>();

    [InverseProperty("Prestation")]
    public virtual ICollection<TarifiedPrestationGroupPrestationLine> TarifiedPrestationGroupPrestationLines { get; set; } = new List<TarifiedPrestationGroupPrestationLine>();

    [InverseProperty("Prestation")]
    public virtual ICollection<TarifiedPrestationItem> TarifiedPrestationItems { get; set; } = new List<TarifiedPrestationItem>();

    [ForeignKey("UsageCode")]
    [InverseProperty("Prestations")]
    public virtual UsageType UsageCodeNavigation { get; set; } = null!;
}
