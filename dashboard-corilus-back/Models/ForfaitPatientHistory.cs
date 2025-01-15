using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ForfaitPatientHistory")]
[Index("ExternalApplicationId", Name = "IX_ForfaitPatientHistory_ExternalApplicationId")]
[Index("ExternalApplicationId", "ValidationDate", "PatientId", "ForfaitRegistrationType", Name = "IX_PatientForfait_DateStatus")]
public partial class ForfaitPatientHistory
{
    [Key]
    public Guid ForfaitPatientHistoryId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime ValidationDate { get; set; }

    public Guid PatientId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int ForfaitRegistrationType { get; set; }

    public int? UseTrialPeriod { get; set; }

    [StringLength(500)]
    public string? Remark { get; set; }

    public int? ForfaitOutReasonId { get; set; }

    public Guid? MutationTarget { get; set; }

    public bool ServiceGp { get; set; }

    public DateTime? ServiceGpSince { get; set; }

    public bool ServiceNurse { get; set; }

    public DateTime? ServiceNurseSince { get; set; }

    public bool ServiceKine { get; set; }

    public DateTime? ServiceKineSince { get; set; }

    public bool Electronic { get; set; }

    [StringLength(50)]
    public string? ReferenceNumberForfait { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("ForfaitPatientHistories")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("ForfaitPatientHistories")]
    public virtual Patient Patient { get; set; } = null!;
}
