using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("AttestPrintLayout")]
public partial class AttestPrintLayout
{
    [Key]
    public Guid AttestPrintLayoutId { get; set; }

    public int AttestModelCode { get; set; }

    public bool? MultiLaneEnabled { get; set; }

    public int? LaneTwoPosition { get; set; }

    public int? LaneThreePosition { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [InverseProperty("AttestPrintLayout")]
    public virtual ICollection<AttestPrintLayoutItemPosition> AttestPrintLayoutItemPositions { get; set; } = new List<AttestPrintLayoutItemPosition>();

    [InverseProperty("AttestPrintLayout")]
    public virtual ICollection<PrinterSetting> PrinterSettings { get; set; } = new List<PrinterSetting>();
}
