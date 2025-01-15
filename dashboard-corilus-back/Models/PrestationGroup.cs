using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PrestationGroup")]
public partial class PrestationGroup
{
    [Key]
    public Guid PrestationGroupId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public Guid? UserId { get; set; }

    [StringLength(25)]
    public string MemoCode { get; set; } = null!;

    [StringLength(255)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Amount { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("PrestationGroups")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("PrestationGroup")]
    public virtual ICollection<PrestationGroupItem> PrestationGroupItems { get; set; } = new List<PrestationGroupItem>();

    [InverseProperty("PrestationGroup")]
    public virtual ICollection<TarifiedPrestationGroupItem> TarifiedPrestationGroupItems { get; set; } = new List<TarifiedPrestationGroupItem>();

    [ForeignKey("UserId")]
    [InverseProperty("PrestationGroups")]
    public virtual User? User { get; set; }
}
