using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Physician")]
public partial class Physician
{
    [Key]
    public Guid PhysicianId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [StringLength(50)]
    public string ExternalPhysicianId { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [StringLength(50)]
    public string? Lastname { get; set; }

    [StringLength(50)]
    public string? Firstname { get; set; }

    public bool? Accredited { get; set; }

    [StringLength(15)]
    public string? Nihii { get; set; }

    [StringLength(15)]
    public string? Inss { get; set; }

    public int? ConventionStatus { get; set; }

    [StringLength(15)]
    public string? ResponsiblePhysicianNihii { get; set; }

    [StringLength(50)]
    public string? ResponsablePhysicianName { get; set; }

    [StringLength(50)]
    public string? ResponsablePhysicianExternalId { get; set; }

    [StringLength(50)]
    public string? ExternalReference { get; set; }

    public bool? Archived { get; set; }

    public bool? InscriptionsOnSeperateAttest { get; set; }

    public int? InscriptionsViaThirdPartyPayer { get; set; }

    [Column("EFactContactPersonFirstName")]
    [StringLength(50)]
    public string? EfactContactPersonFirstName { get; set; }

    [Column("EFactContactPersonLastName")]
    [StringLength(50)]
    public string? EfactContactPersonLastName { get; set; }

    [Column("EFactContactPersonNihii")]
    [StringLength(25)]
    public string? EfactContactPersonNihii { get; set; }

    [Column("EFactContactPhoneNumber")]
    [StringLength(25)]
    public string? EfactContactPhoneNumber { get; set; }

    [Column("EFactBankAccountNr")]
    [StringLength(50)]
    public string? EfactBankAccountNr { get; set; }

    [Column("EFactBicNr")]
    [StringLength(50)]
    public string? EfactBicNr { get; set; }

    [Column("EFactCbeNumber")]
    [StringLength(50)]
    public string? EfactCbeNumber { get; set; }

    public bool UseTimeBasedOnCallDetermination { get; set; }

    public long EveningStartsAt { get; set; }

    public long NightStartsAt { get; set; }

    public long NightEndsAt { get; set; }

    public int WeekendStartDay { get; set; }

    public long WeekendStartTime { get; set; }

    public int WeekendEndDay { get; set; }

    public long WeekendEndTime { get; set; }

    [Column("UseETar")]
    public bool UseEtar { get; set; }

    [Column("AutoSendEFact")]
    public bool AutoSendEfact { get; set; }

    public bool AutoPayInvoices { get; set; }

    public int DefaultRoundingStrategy { get; set; }

    public int DefaultRoundingBoundary { get; set; }

    [StringLength(25)]
    public string DefaultPriceTypeCode { get; set; } = null!;

    public int DefaultAtTheExpenseOf { get; set; }

    public int? InitialElectronicInvoiceDispatchNumber { get; set; }

    public bool IsTechnicalPrestationPaidByThirdParty { get; set; }

    [Column("UseEAttest")]
    public bool UseEattest { get; set; }

    public bool IncludeSupplements { get; set; }

    [Column("UseEFact")]
    public bool UseEfact { get; set; }

    [StringLength(50)]
    public string? DefaultPrescriberName { get; set; }

    [StringLength(25)]
    public string? DefaultPrescriberNihii { get; set; }

    public Guid? BeneficiaryId { get; set; }

    public int? DefaultPercentageCoPayment { get; set; }

    public bool DefaultTechnicalActsAtepMut { get; set; }

    [Column("EFactPucCode")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EfactPucCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VatNumber { get; set; }

    public int VatRegulationType { get; set; }

    public bool ThirdPartyPayerByDefault { get; set; }

    public int SupplementAdditionSetting { get; set; }

    public TimeOnly SupplementFrom { get; set; }

    public TimeOnly SupplementStill { get; set; }

    public DateTimeOffset? NewDealStartDate { get; set; }

    public DateTimeOffset? NewDealEndDate { get; set; }

    [InverseProperty("Physician")]
    public virtual ICollection<AttestedSession> AttestedSessionPhysicians { get; set; } = new List<AttestedSession>();

    [InverseProperty("ResponsiblePhysician")]
    public virtual ICollection<AttestedSession> AttestedSessionResponsiblePhysicians { get; set; } = new List<AttestedSession>();

    [ForeignKey("BeneficiaryId")]
    [InverseProperty("Physicians")]
    public virtual Beneficiary? Beneficiary { get; set; }

    [InverseProperty("CareProvider")]
    public virtual ICollection<DefaultMemoCodesForPatientCarePlan> DefaultMemoCodesForPatientCarePlans { get; set; } = new List<DefaultMemoCodesForPatientCarePlan>();

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("Physicians")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("CareProvider")]
    public virtual ICollection<OverriddenOfficialFeesForConventionedCareProvider> OverriddenOfficialFeesForConventionedCareProviders { get; set; } = new List<OverriddenOfficialFeesForConventionedCareProvider>();

    [InverseProperty("Physician")]
    public virtual PhysicianSettingsOb? PhysicianSettingsOb { get; set; }

    [InverseProperty("Physician")]
    public virtual ICollection<RetrocessionSetting> RetrocessionSettings { get; set; } = new List<RetrocessionSetting>();

    [InverseProperty("Physician")]
    public virtual ICollection<TarificationSession> TarificationSessionPhysicians { get; set; } = new List<TarificationSession>();

    [InverseProperty("ResponsiblePhysician")]
    public virtual ICollection<TarificationSession> TarificationSessionResponsiblePhysicians { get; set; } = new List<TarificationSession>();
}
