using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PatientCarePlanAgreement")]
[Index("ExternalApplicationId", Name = "IX_ExternalApplication")]
[Index("PatientCarePlanId", Name = "IX_PatientCarePlanId")]
public partial class PatientCarePlanAgreement
{
    [Key]
    public Guid PatientCarePlanAgreementId { get; set; }

    public Guid PatientCarePlanId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidTill { get; set; }

    [StringLength(50)]
    public string? ExternalAgreementId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    public int? AgreementStatus { get; set; }

    public Guid? ExternalApplicationId { get; set; }

    public int? PatientCarePlanAgreementType { get; set; }

    [StringLength(50)]
    public string? DecisionReference { get; set; }

    [ForeignKey("PatientCarePlanId")]
    [InverseProperty("PatientCarePlanAgreements")]
    public virtual PatientCarePlan PatientCarePlan { get; set; } = null!;

    [InverseProperty("PatientCarePlanAgreement")]
    public virtual ICollection<PatientCarePlanAgreementProperty> PatientCarePlanAgreementProperties { get; set; } = new List<PatientCarePlanAgreementProperty>();
}
