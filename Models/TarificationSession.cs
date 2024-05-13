using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("TarificationSession")]
[Index("ExternalApplicationId", Name = "IX_ExternalApplicationId")]
[Index("PatientCarePlanId", Name = "IX_PatientCarePlanId")]
[Index("EagreementId", Name = "IX_TarificationSession_EAgreementId")]
[Index("ExternalApplicationId", "AtTheExpenseOf", Name = "IX_TarificationSession_ExternalApplicationId_AtTheExpenseOf")]
[Index("ExternalApplicationId", "PatientId", Name = "IX_TarificationSession_ExternalApplicationId_PatientId")]
[Index("PatientContributionAtTheExpenseOf", Name = "IX_TarificationSession_PatientContributionAtTheExpenseOf")]
public partial class TarificationSession
{
    [Key]
    public Guid TarificationSessionId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public Guid PatientId { get; set; }

    public DateTime PatientDateOfBirth { get; set; }

    public bool PatientHasGmd { get; set; }

    [StringLength(25)]
    public string PatientGmdHolder { get; set; } = null!;

    public bool PatientHasChronicalDisease { get; set; }

    public bool PatientHasPalliativeStatus { get; set; }

    [Column("PatientCG1")]
    [StringLength(5)]
    public string PatientCg1 { get; set; } = null!;

    [Column("PatientCG2")]
    [StringLength(5)]
    public string PatientCg2 { get; set; } = null!;

    [StringLength(20)]
    public string PatientNationalNumber { get; set; } = null!;

    public Guid? PatientInsuranceInstituteId { get; set; }

    public Guid PhysicianId { get; set; }

    [StringLength(20)]
    public string PhysicianSocialSecurityNumber { get; set; } = null!;

    public bool PhysicianIsAccreditated { get; set; }

    public bool PhysicianHasAgreementWithRiziv { get; set; }

    public DateTime SessionDate { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal TravelCost { get; set; }

    public int ConsultationTypeCode { get; set; }

    public int OnCallType { get; set; }

    public bool IsInOrganizedOnCallService { get; set; }

    public int SuppliedAidType { get; set; }

    public int AtTheExpenseOf { get; set; }

    public int? SocialThirdPartyPayerReason { get; set; }

    public bool CollectPatientContribution { get; set; }

    public int RoundingStrategy { get; set; }

    public int RoundingBoundary { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal TotalAmount { get; set; }

    [StringLength(255)]
    public string? PrescribingPhysician { get; set; }

    [StringLength(20)]
    public string? PrescribingPhysicianSocialSecurityNumber { get; set; }

    public DateTime? PrescriptionDate { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public bool PatientHasCarePath { get; set; }

    public bool IsReviewed { get; set; }

    public int? TravelDistance { get; set; }

    [StringLength(20)]
    public string? PatientCardNr { get; set; }

    public DateTime? PatientCardReadingDate { get; set; }

    public Guid? IsCorrectionSessionForElectronicInvoiceId { get; set; }

    [Column("EFactStatus")]
    public int? EfactStatus { get; set; }

    [Column("EFactCorrectionPreviousAttestNr")]
    [StringLength(25)]
    public string? EfactCorrectionPreviousAttestNr { get; set; }

    [Column("EFactCorrectionPreviousEFactInvoiceReference")]
    [StringLength(25)]
    public string? EfactCorrectionPreviousEfactInvoiceReference { get; set; }

    [Column("EFactCorrectionPreviousDispatchNr")]
    [StringLength(25)]
    public string? EfactCorrectionPreviousDispatchNr { get; set; }

    [Column("EFactCorrectionPreviousHealthInsuranceCode")]
    [StringLength(5)]
    public string? EfactCorrectionPreviousHealthInsuranceCode { get; set; }

    [Column("EFactCorrectionPreviousMutualityReferenceNr")]
    [StringLength(25)]
    public string? EfactCorrectionPreviousMutualityReferenceNr { get; set; }

    [Column("EFactCorrectionPreviousInvoicingPeriod")]
    [StringLength(8)]
    public string? EfactCorrectionPreviousInvoicingPeriod { get; set; }

    [StringLength(25)]
    public string? HospitalNumber { get; set; }

    public bool PhysicianUsesElectronicGmdManagement { get; set; }

    public Guid ResponsiblePhysicianId { get; set; }

    [StringLength(255)]
    public string ResponsiblePhysicianRizivNumber { get; set; } = null!;

    [StringLength(25)]
    public string? CustomTarifCodeToApply { get; set; }

    public Guid? PatientCarePlanId { get; set; }

    public int? TreatmentId { get; set; }

    public Guid? OrderId { get; set; }

    public int? CounterPhysio { get; set; }

    public bool HasMaxAllowedFee { get; set; }

    public int PhysicianConventionStatus { get; set; }

    public Guid? OriginalTarificationSessionId { get; set; }

    [StringLength(50)]
    public string? ExternalSessionId { get; set; }

    public Guid? SiteId { get; set; }

    public int? PercentageCoPayment { get; set; }

    public Guid PatientContributionPayerId { get; set; }

    public Guid? ThirdPartyPayerId { get; set; }

    public Guid? WorkAccidentId { get; set; }

    [Column("ETarValidated")]
    public bool? EtarValidated { get; set; }

    public int PatientContributionAtTheExpenseOf { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? TotalVat { get; set; }

    [Column("EAgreementId")]
    public Guid? EagreementId { get; set; }

    [StringLength(50)]
    public string? DecisionReference { get; set; }

    public bool PatientHasSpecialStatus { get; set; }

    [Column("CareProviderNotInTheSameGMDGroup")]
    public bool CareProviderNotInTheSameGmdgroup { get; set; }

    public bool IsAttested { get; set; }

    public int? GmrHolderStatus { get; set; }

    [StringLength(20)]
    public string? PatientGmrHolderNihii { get; set; }

    public int NewDealStatusOfCareProviders { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("TarificationSessions")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [ForeignKey("OrderId")]
    [InverseProperty("TarificationSessions")]
    public virtual Order? Order { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("TarificationSessions")]
    public virtual Patient Patient { get; set; } = null!;

    [ForeignKey("PatientCarePlanId")]
    [InverseProperty("TarificationSessions")]
    public virtual PatientCarePlan? PatientCarePlan { get; set; }

    [ForeignKey("PatientInsuranceInstituteId")]
    [InverseProperty("TarificationSessions")]
    public virtual ThirdParty? PatientInsuranceInstitute { get; set; }

    [InverseProperty("TarificationSession")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [ForeignKey("PhysicianId")]
    [InverseProperty("TarificationSessionPhysicians")]
    public virtual Physician Physician { get; set; } = null!;

    [ForeignKey("ResponsiblePhysicianId")]
    [InverseProperty("TarificationSessionResponsiblePhysicians")]
    public virtual Physician ResponsiblePhysician { get; set; } = null!;

    [ForeignKey("SiteId")]
    [InverseProperty("TarificationSessions")]
    public virtual Site? Site { get; set; }

    [ForeignKey("SuppliedAidType")]
    [InverseProperty("TarificationSessions")]
    public virtual UsageType SuppliedAidTypeNavigation { get; set; } = null!;

    [InverseProperty("TarificationSession")]
    public virtual ICollection<TarificationSessionContext> TarificationSessionContexts { get; set; } = new List<TarificationSessionContext>();

    [InverseProperty("TarificationSession")]
    public virtual ICollection<TarifiedItem> TarifiedItems { get; set; } = new List<TarifiedItem>();

    [ForeignKey("WorkAccidentId")]
    [InverseProperty("TarificationSessions")]
    public virtual WorkAccident? WorkAccident { get; set; }
}
