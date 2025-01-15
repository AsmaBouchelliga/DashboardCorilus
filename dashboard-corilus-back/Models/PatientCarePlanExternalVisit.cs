using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PatientCarePlanExternalVisit")]
[Index("ExternalApplicationId", Name = "IX_ExternalApplicationId")]
[Index("PatientCarePlanId", Name = "IX_PatientCarePlanId")]
public partial class PatientCarePlanExternalVisit
{
    [Key]
    public Guid PatientCarePlanExternalVisitId { get; set; }

    public Guid PatientCarePlanId { get; set; }

    public DateTime Date { get; set; }

    public int? Quantity { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    public int? TotalSessions { get; set; }

    public Guid? OrderId { get; set; }

    public int? CounterPhysio { get; set; }

    public Guid? ExternalApplicationId { get; set; }

    [Column("EAgreementId")]
    public Guid? EagreementId { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("PatientCarePlanExternalVisits")]
    public virtual Order? Order { get; set; }

    [ForeignKey("PatientCarePlanId")]
    [InverseProperty("PatientCarePlanExternalVisits")]
    public virtual PatientCarePlan PatientCarePlan { get; set; } = null!;
}
