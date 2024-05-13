using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("MemoCodeMedicalCareService")]
public partial class MemoCodeMedicalCareService
{
    [Key]
    public Guid MemoCodeMedicalCareServiceId { get; set; }

    public Guid MemoCodeId { get; set; }

    public int MedicalCareServiceCode { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime LastUpdatedOn { get; set; }

    public int Version { get; set; }

    [ForeignKey("MemoCodeId")]
    [InverseProperty("MemoCodeMedicalCareServices")]
    public virtual MemoCode MemoCode { get; set; } = null!;
}
