using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[PrimaryKey("AttestPrintLayoutId", "ItemName")]
[Table("AttestPrintLayoutItemPosition")]
public partial class AttestPrintLayoutItemPosition
{
    [Key]
    public Guid AttestPrintLayoutId { get; set; }

    [Key]
    [StringLength(100)]
    public string ItemName { get; set; } = null!;

    public int ItemPositionX { get; set; }

    public int ItemPositionY { get; set; }

    [ForeignKey("AttestPrintLayoutId")]
    [InverseProperty("AttestPrintLayoutItemPositions")]
    public virtual AttestPrintLayout AttestPrintLayout { get; set; } = null!;
}
