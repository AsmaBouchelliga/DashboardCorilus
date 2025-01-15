using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("MemoCode")]
[Index("ExternalApplicationId", Name = "IX_MemoCode_ExternalApplicationId")]
public partial class MemoCode
{
    [Key]
    public Guid MemoCodeId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [Column("MemoCode")]
    [StringLength(48)]
    public string MemoCode1 { get; set; } = null!;

    [StringLength(256)]
    public string? DutchDescription { get; set; }

    [StringLength(256)]
    public string? FrenchDescription { get; set; }

    public bool IsGrouping { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? ServiceFee { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime LastUpdatedOn { get; set; }

    public int Version { get; set; }

    public bool? SystemCode { get; set; }

    public Guid? PhysicianId { get; set; }

    [InverseProperty("MemoCode")]
    public virtual ICollection<DefaultMemoCodesForPatientCarePlan> DefaultMemoCodesForPatientCarePlans { get; set; } = new List<DefaultMemoCodesForPatientCarePlan>();

    [InverseProperty("MemoCode")]
    public virtual ICollection<MemoCodeMedicalCareService> MemoCodeMedicalCareServices { get; set; } = new List<MemoCodeMedicalCareService>();
}
