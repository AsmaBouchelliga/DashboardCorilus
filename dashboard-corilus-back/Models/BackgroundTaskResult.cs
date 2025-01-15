using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("BackgroundTaskResult")]
[Index("BackgroundTaskId", Name = "IX_BackgroundTaskResult_BackgroundTaskId")]
public partial class BackgroundTaskResult
{
    [Key]
    public Guid BackgroundTaskResultId { get; set; }

    public Guid BackgroundTaskId { get; set; }

    [StringLength(256)]
    public string Title { get; set; } = null!;

    [StringLength(1024)]
    public string Description { get; set; } = null!;

    public string? Result { get; set; }

    public DateTime CreatedOn { get; set; }

    [ForeignKey("BackgroundTaskId")]
    [InverseProperty("BackgroundTaskResults")]
    public virtual BackgroundTask BackgroundTask { get; set; } = null!;
}
