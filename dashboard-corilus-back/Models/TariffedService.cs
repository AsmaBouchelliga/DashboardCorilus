using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("TariffedService")]
[Index("TarificationSessionId", Name = "IX_TariffedService_TarificationSessionId")]
public partial class TariffedService
{
    [Key]
    public Guid TariffedServiceId { get; set; }

    public Guid TarificationSessionId { get; set; }

    public int RegistrationMode { get; set; }

    public DateTime ServicedAt { get; set; }

    [StringLength(24)]
    public string ServiceCode { get; set; } = null!;

    public int ServiceType { get; set; }

    public int ServiceCategory { get; set; }

    public Guid? TariffedOnCallServiceId { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal HonorariumFee { get; set; }

    public bool IsReimbursementFeeAffectedByGmd { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal ReimbursementFee { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Copayment { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Supplement { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal FeePercentage { get; set; }

    public bool? IsAccreditedPhysicianOnlyService { get; set; }

    public bool IsAdditionalRequirementsPrescriberNeeded { get; set; }

    [StringLength(255)]
    public string? PrescribingPhysician { get; set; }

    [StringLength(20)]
    public string? PrescribingPhysicianSocialSecurityNumber { get; set; }

    public DateTime? PrescriptionDate { get; set; }

    public bool IsAdditionalRequirementsLeftRightDesignationNeeded { get; set; }

    [StringLength(1)]
    public string? LeftRightDesignation { get; set; }

    public bool IsAdditionalRequirementsTravelDistanceNeeded { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? TravelDistance { get; set; }

    public bool IsAdditionalRequirementsHospitalVisitNeeded { get; set; }

    [StringLength(16)]
    public string? HospitalNihii { get; set; }

    [StringLength(3)]
    public string? HospitalServiceCode { get; set; }

    public bool IsAdditionalRequirementsLaboratoryNeeded { get; set; }

    [StringLength(16)]
    public string? LaboratoryNihii { get; set; }

    [Column("EFactFinancialContractNr")]
    [StringLength(55)]
    public string? EfactFinancialContractNr { get; set; }

    [Column("EFactConsultationDate")]
    public DateTime? EfactConsultationDate { get; set; }

    [Column("EFactRelativeNomenclatureCode")]
    [StringLength(10)]
    public string? EfactRelativeNomenclatureCode { get; set; }

    [Column("EFactClaimAuthorInss")]
    [StringLength(15)]
    public string? EfactClaimAuthorInss { get; set; }

    [Column("EFactClaimAuthorNihii")]
    [StringLength(20)]
    public string? EfactClaimAuthorNihii { get; set; }

    public bool IsUmc { get; set; }

    [StringLength(16)]
    public string? CbeNumberPswc { get; set; }

    [StringLength(16)]
    public string? MediPrimaCardNumber { get; set; }

    [StringLength(8)]
    public string? MediPrimaCardVersion { get; set; }

    public DateTime CreatedOn { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime LastUpdatedOn { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    [StringLength(10)]
    public string? Letter { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Factor { get; set; }

    [StringLength(15)]
    public string? Article { get; set; }

    public int? AtTheExpenseOf { get; set; }

    [Column("EFactMaxCountException")]
    [StringLength(2)]
    public string? EfactMaxCountException { get; set; }

    public bool ReferredSpecialistConsultation { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? RizivHonorarium { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? RizivReimbursement { get; set; }

    [Column("RizivPricingOverriddenByETar")]
    public bool? RizivPricingOverriddenByEtar { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? Vat { get; set; }

    public bool? Nontherapeutic { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? VatPercentage { get; set; }

    public bool CopaymentChargedToInsuranceOrganism { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? UnofficialRounding { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? VatDifferenceDueToUnofficialRounding { get; set; }

    [InverseProperty("TariffedOnCallService")]
    public virtual ICollection<TariffedService> InverseTariffedOnCallService { get; set; } = new List<TariffedService>();

    [ForeignKey("TariffedOnCallServiceId")]
    [InverseProperty("InverseTariffedOnCallService")]
    public virtual TariffedService? TariffedOnCallService { get; set; }
}
