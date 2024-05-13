using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[PrimaryKey("PatientCarePlanAgreementId", "ContextKey")]
public partial class PatientCarePlanAgreementProperty
{
    [Key]
    public Guid PatientCarePlanAgreementId { get; set; }

    [Key]
    [StringLength(50)]
    public string ContextKey { get; set; } = null!;

    [StringLength(255)]
    public string ContextValue { get; set; } = null!;

    public Guid? PatientCarePlanAgreementPropertiesId { get; set; }

    [ForeignKey("PatientCarePlanAgreementId")]
    [InverseProperty("PatientCarePlanAgreementProperties")]
    public virtual PatientCarePlanAgreement PatientCarePlanAgreement { get; set; } = null!;
}
