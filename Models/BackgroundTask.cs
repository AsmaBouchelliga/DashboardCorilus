using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("BackgroundTask")]
[Index("ExternalApplicationId", Name = "IX_BackgroundTask_ExternalApplicationId")]
public partial class BackgroundTask
{
    [Key]
    public Guid BackgroundTaskId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int BackgroundTaskTypeId { get; set; }

    public int BackgroundTaskStatus { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public Guid? UserId { get; set; }

    public int? RunCounter { get; set; }

    public string? Arguments { get; set; }

    [InverseProperty("BackgroundTask")]
    public virtual ICollection<BackgroundTaskResult> BackgroundTaskResults { get; set; } = new List<BackgroundTaskResult>();

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("BackgroundTasks")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("BackgroundTasks")]
    public virtual User? User { get; set; }
}
