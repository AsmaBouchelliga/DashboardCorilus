using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PatientCarePlan")]
[Index("ExternalApplicationId", Name = "IX_PatientCarePlan_ExternalApplicationId")]
[Index("PatientId", Name = "IX_PatientId")]
public partial class PatientCarePlan
{
    [Key]
    public Guid PatientCarePlanId { get; set; }

    public Guid PatientId { get; set; }

    public int? ExternalPatientCarePlanId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(255)]
    public string? Description { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public bool HasMaxAllowedFee { get; set; }

    public bool HasTransportAllowance { get; set; }

    public bool HasOtherSurcharges { get; set; }

    public bool HasCopayment { get; set; }

    public int? ThirdPartyId { get; set; }

    public int AtTheExpenseOf { get; set; }

    public int PatientCarePlanStatus { get; set; }

    public int? PercentageCoPayment { get; set; }

    public Guid? CoPaymentPaidBy { get; set; }

    public int CarePlanType { get; set; }

    public bool IsBeingReworked { get; set; }

    public byte FlowType { get; set; }

    public int? PathologySituation { get; set; }

    public bool SendToAssurmed { get; set; }

    [StringLength(50)]
    public string? DigitalFlowPathologySituation { get; set; }

    [InverseProperty("PatientCarePlan")]
    public virtual ICollection<AttestedSession> AttestedSessions { get; set; } = new List<AttestedSession>();

    [InverseProperty("PatientCarePlan")]
    public virtual ICollection<DefaultMemoCodesForPatientCarePlan> DefaultMemoCodesForPatientCarePlans { get; set; } = new List<DefaultMemoCodesForPatientCarePlan>();

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("PatientCarePlans")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("PatientCarePlan")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [ForeignKey("PatientId")]
    [InverseProperty("PatientCarePlans")]
    public virtual Patient Patient { get; set; } = null!;

    [InverseProperty("PatientCarePlan")]
    public virtual ICollection<PatientCarePlanAgreement> PatientCarePlanAgreements { get; set; } = new List<PatientCarePlanAgreement>();

    [InverseProperty("PatientCarePlan")]
    public virtual ICollection<PatientCarePlanExternalVisit> PatientCarePlanExternalVisits { get; set; } = new List<PatientCarePlanExternalVisit>();

    [InverseProperty("PatientCarePlan")]
    public virtual ICollection<TarificationSession> TarificationSessions { get; set; } = new List<TarificationSession>();

    [InverseProperty("PatientCarePlan")]
    public virtual ICollection<WorkAccident> WorkAccidents { get; set; } = new List<WorkAccident>();
}
