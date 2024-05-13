using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("AttestedSession")]
[Index("AttestId", "SequenceNumber", Name = "IX_AttestedSession_AttestId_SequenceNumber", IsUnique = true)]
[Index("EagreementId", Name = "IX_AttestedSession_EAgreementId_index")]
[Index("PatientCarePlanId", Name = "IX_AttestedSession_PatientCarePlanId")]
[Index("TarificationSessionId", Name = "IX_AttestedSession_TarificationSessionId")]
public partial class AttestedSession
{
    [Key]
    public Guid AttestedSessionId { get; set; }

    public Guid AttestId { get; set; }

    public short SequenceNumber { get; set; }

    public Guid PhysicianId { get; set; }

    [StringLength(20)]
    public string PhysicianSocialSecurityNumber { get; set; } = null!;

    [StringLength(255)]
    public string PhysicianName { get; set; } = null!;

    public int ConsultationTypeCode { get; set; }

    public int SuppliedAidType { get; set; }

    public int OnCallType { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal TotalReimbursed { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal TravelCost { get; set; }

    public DateTime? PrescriptionDate { get; set; }

    [StringLength(255)]
    public string? PrescribingPhysician { get; set; }

    [StringLength(255)]
    public string? PrescribingPhysicianSocialSecurityNumber { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public Guid TarificationSessionId { get; set; }

    public int? RoundingStrategy { get; set; }

    public int? RoundingBoundary { get; set; }

    public bool IsInOrganizedOnCallService { get; set; }

    public bool PhysicianAccreditated { get; set; }

    public bool PhysicianConventionnedWithRiziv { get; set; }

    public int? TravelDistance { get; set; }

    [StringLength(25)]
    public string? HospitalNumber { get; set; }

    public Guid ResponsiblePhysicianId { get; set; }

    [StringLength(255)]
    public string ResponsiblePhysicianRizivNumber { get; set; } = null!;

    [StringLength(25)]
    public string? CustomTarifCodeToApply { get; set; }

    public Guid? PatientCarePlanId { get; set; }

    public int? TreatmentId { get; set; }

    public Guid? OrderId { get; set; }

    public DateTime? SessionDate { get; set; }

    public int? CounterPhysio { get; set; }

    public int PhysicianConventionStatus { get; set; }

    public Guid? OriginalTarificationSessionId { get; set; }

    [StringLength(50)]
    public string? ExternalSessionId { get; set; }

    public Guid? SiteId { get; set; }

    public int? PercentageCoPayment { get; set; }

    public Guid? WorkAccidentId { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? TotalVat { get; set; }

    [Column("EAgreementId")]
    public Guid? EagreementId { get; set; }

    [StringLength(50)]
    public string? DecisionReference { get; set; }

    public bool PatientHasSpecialStatus { get; set; }

    [Column("CareProviderNotInTheSameGMDGroup")]
    public bool CareProviderNotInTheSameGmdgroup { get; set; }

    [ForeignKey("AttestId")]
    [InverseProperty("AttestedSessions")]
    public virtual Attest Attest { get; set; } = null!;

    [InverseProperty("AttestedSession")]
    public virtual ICollection<AttestLineItem> AttestLineItems { get; set; } = new List<AttestLineItem>();

    [ForeignKey("OrderId")]
    [InverseProperty("AttestedSessions")]
    public virtual Order? Order { get; set; }

    [ForeignKey("PatientCarePlanId")]
    [InverseProperty("AttestedSessions")]
    public virtual PatientCarePlan? PatientCarePlan { get; set; }

    [ForeignKey("PhysicianId")]
    [InverseProperty("AttestedSessionPhysicians")]
    public virtual Physician Physician { get; set; } = null!;

    [ForeignKey("ResponsiblePhysicianId")]
    [InverseProperty("AttestedSessionResponsiblePhysicians")]
    public virtual Physician ResponsiblePhysician { get; set; } = null!;

    [ForeignKey("SiteId")]
    [InverseProperty("AttestedSessions")]
    public virtual Site? Site { get; set; }

    [ForeignKey("SuppliedAidType")]
    [InverseProperty("AttestedSessions")]
    public virtual UsageType SuppliedAidTypeNavigation { get; set; } = null!;

    [ForeignKey("WorkAccidentId")]
    [InverseProperty("AttestedSessions")]
    public virtual WorkAccident? WorkAccident { get; set; }
}
