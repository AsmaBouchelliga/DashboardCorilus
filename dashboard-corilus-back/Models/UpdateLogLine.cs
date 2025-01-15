using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("UpdateLogLine")]
public partial class UpdateLogLine
{
    [Key]
    public Guid UpdateLogLineId { get; set; }

    public Guid UpdateLogId { get; set; }

    [StringLength(20)]
    public string NomenclatureNr { get; set; } = null!;

    public int UpdateState { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [ForeignKey("UpdateLogId")]
    [InverseProperty("UpdateLogLines")]
    public virtual UpdateLog UpdateLog { get; set; } = null!;
}
