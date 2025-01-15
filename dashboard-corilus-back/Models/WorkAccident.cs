using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("WorkAccident")]
[Index("ExternalApplicationId", Name = "IX_ExternalApplicationId")]
[Index("PatientCarePlanId", Name = "IX_PatientCarePlanId")]
[Index("PatientId", Name = "IX_PatientId")]
public partial class WorkAccident
{
    [Key]
    public Guid WorkAccidentId { get; set; }

    [StringLength(255)]
    public string? EmployerName { get; set; }

    [StringLength(255)]
    public string? Reference { get; set; }

    [StringLength(255)]
    public string? FirstNameContacPersonInsurance { get; set; }

    [StringLength(255)]
    public string? LastNameContacPersonInsurance { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public bool NihiiRulesApply { get; set; }

    public Guid? PatientId { get; set; }

    public Guid? PatientCarePlanId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int Version { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ContactPersonPhoneNumber { get; set; }

    [InverseProperty("WorkAccident")]
    public virtual ICollection<AttestedSession> AttestedSessions { get; set; } = new List<AttestedSession>();

    [ForeignKey("PatientCarePlanId")]
    [InverseProperty("WorkAccidents")]
    public virtual PatientCarePlan? PatientCarePlan { get; set; }

    [InverseProperty("WorkAccident")]
    public virtual ICollection<TarificationSession> TarificationSessions { get; set; } = new List<TarificationSession>();
}
