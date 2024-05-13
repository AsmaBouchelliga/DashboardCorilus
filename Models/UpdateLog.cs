using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("UpdateLog")]
public partial class UpdateLog
{
    [Key]
    public Guid UpdateLogId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExecutionDate { get; set; }

    public bool FinishedSuccessfully { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [InverseProperty("UpdateLog")]
    public virtual ICollection<UpdateLogLine> UpdateLogLines { get; set; } = new List<UpdateLogLine>();
}
