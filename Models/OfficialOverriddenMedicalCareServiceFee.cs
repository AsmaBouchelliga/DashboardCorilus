using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("OfficialOverriddenMedicalCareServiceFee")]
[Index("ExternalApplicationId", "MedicalCareServiceCode", "PhysicianId", Name = "UC_ExternalApplicationId_MedicalCareServiceCode", IsUnique = true)]
public partial class OfficialOverriddenMedicalCareServiceFee
{
    [Key]
    public Guid OfficialOverriddenMedicalCareServiceFeeId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int MedicalCareServiceCode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal MedicalCareServiceFee { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime LastUpdatedOn { get; set; }

    public int Version { get; set; }

    public Guid? PhysicianId { get; set; }
}
