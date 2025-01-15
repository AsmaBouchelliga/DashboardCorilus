using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("AttestLineItem")]
[Index("AttestedSessionId", "SequenceNumber", Name = "IX_AttestLineItem_AttestedSessionId_SequenceNumber", IsUnique = true)]
[Index("NomenclatureCode", Name = "IX_AttestLineItem_NomenclatureCode")]
[Index("PrestationDate", Name = "IX_AttestLineItem_PrestationDate")]
public partial class AttestLineItem
{
    [Key]
    public Guid AttestLineItemId { get; set; }

    public Guid AttestedSessionId { get; set; }

    public short SequenceNumber { get; set; }

    [StringLength(20)]
    public string NomenclatureCode { get; set; } = null!;

    public DateTime PrestationDate { get; set; }

    public bool IsConsultationPrestation { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Honorarium { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Reimbursement { get; set; }

    public bool PrintLine { get; set; }

    [StringLength(8)]
    public string? Remark { get; set; }

    [StringLength(255)]
    public string UsedMemoCode { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [Column("EFactConsultationDate")]
    public DateTime? EfactConsultationDate { get; set; }

    [Column("EFactRelativePrestationCode")]
    [StringLength(10)]
    public string? EfactRelativePrestationCode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal OfficialHonorarium { get; set; }

    [StringLength(55)]
    public string? FinancialContractNr { get; set; }

    public bool GmdInfluencesReimbursement { get; set; }

    [Column("EFactClaimAuthorInss")]
    [StringLength(15)]
    public string? EfactClaimAuthorInss { get; set; }

    [Column("EFactClaimAuthorNihii")]
    [StringLength(20)]
    public string? EfactClaimAuthorNihii { get; set; }

    public bool TarifiedFor50Percent { get; set; }

    public bool IsAdditionalRequirementsPrescriberNeeded { get; set; }

    [StringLength(255)]
    public string? PrescribingPhysician { get; set; }

    [StringLength(20)]
    public string? PrescribingPhysicianSocialSecurityNumber { get; set; }

    public DateTime? PrescriptionDate { get; set; }

    public bool IsAdditionalRequirementsLeftRightDesignationNeeded { get; set; }

    [StringLength(255)]
    public string? LeftRightDesignation { get; set; }

    public bool IsAdditionalRequirementsTravelDistanceNeeded { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? TravelDistance { get; set; }

    public bool IsAdditionalRequirementsHospitalVisitNeeded { get; set; }

    [StringLength(16)]
    public string? HospitalNihii { get; set; }

    [StringLength(3)]
    public string? HospitalServiceCode { get; set; }

    public bool IsUmc { get; set; }

    [StringLength(16)]
    public string? CbeNumberPswc { get; set; }

    [StringLength(16)]
    public string? MediPrimaCardNumber { get; set; }

    [StringLength(8)]
    public string? MediPrimaCardVersion { get; set; }

    [Column("EAttestOfficialHonorariumAcknowledgedOn")]
    public DateTime? EattestOfficialHonorariumAcknowledgedOn { get; set; }

    public bool IsAdditionalRequirementsLaboratoryNeeded { get; set; }

    [StringLength(16)]
    public string? LaboratoryNihii { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? InitialOfficialHonorarium { get; set; }

    public int? TreatmentId { get; set; }

    public int? ToothNumber { get; set; }

    public int? Quantity { get; set; }

    [StringLength(15)]
    public string? Article { get; set; }

    [StringLength(10)]
    public string? Letter { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Factor { get; set; }

    [Column("EFactMaxCountException")]
    [StringLength(2)]
    public string? EfactMaxCountException { get; set; }

    public bool ReferredSpecialistConsultation { get; set; }

    [StringLength(50)]
    public string? ExternalAttestLineItemId { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? RizivHonorarium { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? RizivReimbursement { get; set; }

    [Column("RizivPricingOverriddenByETar")]
    public bool? RizivPricingOverriddenByEtar { get; set; }

    public int? ServiceNorm { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Vat { get; set; }

    public bool? Nontherapeutic { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? VatPercentage { get; set; }

    public bool CopaymentChargedToInsuranceOrganism { get; set; }

    public int? DentalCategory { get; set; }

    public DateTimeOffset? DentalDateOfFirstDevicePlacement { get; set; }

    [Column(TypeName = "decimal(20, 4)")]
    public decimal Supplement { get; set; }

    [Column(TypeName = "decimal(22, 4)")]
    public decimal Discount { get; set; }

    [Column(TypeName = "decimal(21, 4)")]
    public decimal Copayment { get; set; }

    [Column("RequestInfo_RequestorNihii")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RequestInfoRequestorNihii { get; set; }

    [Column("RequestInfo_PrescriberStandardType")]
    public int? RequestInfoPrescriberStandardType { get; set; }

    [Column("RequestInfo_RequestDate")]
    public DateTimeOffset? RequestInfoRequestDate { get; set; }

    [Column("Claim_NormNihii")]
    public int? ClaimNormNihii { get; set; }

    [Column("Claim_ExceptionType")]
    public int? ClaimExceptionType { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? UnofficialRounding { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? VatDifferenceDueToUnofficialRounding { get; set; }

    [ForeignKey("AttestedSessionId")]
    [InverseProperty("AttestLineItems")]
    public virtual AttestedSession AttestedSession { get; set; } = null!;

    [InverseProperty("AttestedTariffedService")]
    public virtual ICollection<EfactRejectionReason> EfactRejectionReasons { get; set; } = new List<EfactRejectionReason>();
}
