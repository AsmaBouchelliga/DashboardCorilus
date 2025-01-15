using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("MemberDataHistory")]
[Index("ExternalApplicationId", Name = "IX_MemberDataHistory_ExternalApplicationId")]
public partial class MemberDataHistory
{
    [Key]
    public Guid MemberDataHistoryId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public Guid MemberDataRequestId { get; set; }

    public Guid PatientId { get; set; }

    public int Status { get; set; }

    public DateTime ValidationDate { get; set; }

    [StringLength(500)]
    public string? ValidationErrors { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("MemberDataHistories")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [ForeignKey("MemberDataRequestId")]
    [InverseProperty("MemberDataHistories")]
    public virtual MemberDataRequest MemberDataRequest { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("MemberDataHistories")]
    public virtual Patient Patient { get; set; } = null!;
}
