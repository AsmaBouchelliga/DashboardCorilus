using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Index("ExternalApplicationId", Name = "IX_Orders_ExternalApplicationId")]
public partial class Order
{
    [Key]
    public Guid OrderId { get; set; }

    public Guid PatientCarePlanId { get; set; }

    public DateTime DateWritten { get; set; }

    public int NrOfSessions { get; set; }

    [StringLength(100)]
    public string? OrderNumber { get; set; }

    [StringLength(100)]
    public string? PrescribedBy { get; set; }

    [StringLength(11)]
    public string? PrescribedByNihii { get; set; }

    [StringLength(100)]
    public string? Owner { get; set; }

    [StringLength(11)]
    public string? OwnerNihii { get; set; }

    public int? OrderStatus { get; set; }

    public int? ExternalOrderId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    public Guid? ExternalApplicationId { get; set; }

    public DateTime? FirstAttestDate { get; set; }

    public bool? IsAttested { get; set; }

    [StringLength(255)]
    public string? Reference { get; set; }

    public DateTime? ClosingDate { get; set; }

    public Guid? FirstAttestId { get; set; }

    public bool TwoSessionsPerDayAllowedForPatientCarePlanTypeNormalAndFaAndFb { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<AttestedSession> AttestedSessions { get; set; } = new List<AttestedSession>();

    [ForeignKey("FirstAttestId")]
    [InverseProperty("Orders")]
    public virtual Attest? FirstAttest { get; set; }

    [ForeignKey("PatientCarePlanId")]
    [InverseProperty("Orders")]
    public virtual PatientCarePlan PatientCarePlan { get; set; } = null!;

    [InverseProperty("Order")]
    public virtual ICollection<PatientCarePlanExternalVisit> PatientCarePlanExternalVisits { get; set; } = new List<PatientCarePlanExternalVisit>();

    [InverseProperty("Order")]
    public virtual ICollection<TarificationSession> TarificationSessions { get; set; } = new List<TarificationSession>();
}
