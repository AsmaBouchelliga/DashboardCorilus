using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PrestationGroupItem")]
public partial class PrestationGroupItem
{
    [Key]
    public Guid PrestationGroupItemId { get; set; }

    public Guid PrestationGroupId { get; set; }

    public Guid PrestationId { get; set; }

    public short SequenceNr { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [ForeignKey("PrestationId")]
    [InverseProperty("PrestationGroupItems")]
    public virtual Prestation Prestation { get; set; } = null!;

    [ForeignKey("PrestationGroupId")]
    [InverseProperty("PrestationGroupItems")]
    public virtual PrestationGroup PrestationGroup { get; set; } = null!;
}
