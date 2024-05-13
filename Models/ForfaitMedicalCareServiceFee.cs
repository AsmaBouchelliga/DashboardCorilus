using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ForfaitMedicalCareServiceFee")]
[Index("ExternalApplicationId", Name = "IX_ForfaitMedicalCareServiceFee_ExternalApplicationId")]
public partial class ForfaitMedicalCareServiceFee
{
    [Key]
    public Guid ForfaitMedicalCareServiceFeeId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int ServiceCode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal ServiceFee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ValidOn { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime LastUpdatedOn { get; set; }

    public int Version { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("ForfaitMedicalCareServiceFees")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;
}
