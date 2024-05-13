using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[PrimaryKey("PatientCarePlanId", "MemoCodeId", "CareProviderId")]
public partial class DefaultMemoCodesForPatientCarePlan
{
    [Key]
    public Guid PatientCarePlanId { get; set; }

    [Key]
    public Guid MemoCodeId { get; set; }

    [Key]
    public Guid CareProviderId { get; set; }

    [ForeignKey("CareProviderId")]
    [InverseProperty("DefaultMemoCodesForPatientCarePlans")]
    public virtual Physician CareProvider { get; set; } = null!;

    [ForeignKey("MemoCodeId")]
    [InverseProperty("DefaultMemoCodesForPatientCarePlans")]
    public virtual MemoCode MemoCode { get; set; } = null!;

    [ForeignKey("PatientCarePlanId")]
    [InverseProperty("DefaultMemoCodesForPatientCarePlans")]
    public virtual PatientCarePlan PatientCarePlan { get; set; } = null!;
}
