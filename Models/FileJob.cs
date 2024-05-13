using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("FileJob")]
[Index("ExternalApplicationId", Name = "IX_FileJob_ExternalApplicationId")]
public partial class FileJob
{
    [Key]
    public Guid FileJobId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public string? FollowupUrl { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("FileJobs")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("FileJob")]
    public virtual ICollection<FileJobItem> FileJobItems { get; set; } = new List<FileJobItem>();
}
