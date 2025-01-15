using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("RelativePrestationCode")]
[Index("PrestationId", "RelativePrestationCode1", Name = "IX_RelativePrestationCode_PrestationId", IsUnique = true)]
public partial class RelativePrestationCode
{
    [Key]
    public Guid RelativePrestationCodeId { get; set; }

    public Guid PrestationId { get; set; }

    [Column("RelativePrestationCode")]
    [StringLength(10)]
    public string RelativePrestationCode1 { get; set; } = null!;

    public bool IsDefault { get; set; }

    [Column("DescriptionNL")]
    [StringLength(250)]
    public string DescriptionNl { get; set; } = null!;

    [Column("DescriptionFR")]
    [StringLength(250)]
    public string DescriptionFr { get; set; } = null!;

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [ForeignKey("PrestationId")]
    [InverseProperty("RelativePrestationCodes")]
    public virtual Prestation Prestation { get; set; } = null!;
}
