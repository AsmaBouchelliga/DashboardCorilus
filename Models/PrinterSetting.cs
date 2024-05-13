using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Index("AttestPrintLayoutId", Name = "IX_PrinterSettings_PrintLayoutId")]
[Index("UserId", Name = "IX_PrinterSettings_UserId")]
public partial class PrinterSetting
{
    [Key]
    public Guid PrinterSettingsId { get; set; }

    [StringLength(150)]
    public string PrinterName { get; set; } = null!;

    public bool IsManualPrinter { get; set; }

    [StringLength(25)]
    public string? AttestNumber { get; set; }

    public int AttestModelCode { get; set; }

    public int? MarginOffsetX { get; set; }

    public int? MarginOffsetY { get; set; }

    public Guid? AttestPrintLayoutId { get; set; }

    public Guid? UserId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public Guid? ExternalApplicationId { get; set; }

    public bool Extended { get; set; }

    [ForeignKey("AttestPrintLayoutId")]
    [InverseProperty("PrinterSettings")]
    public virtual AttestPrintLayout? AttestPrintLayout { get; set; }

    [InverseProperty("PrinterSettings")]
    public virtual ICollection<TarificationProfile> TarificationProfiles { get; set; } = new List<TarificationProfile>();

    [ForeignKey("UserId")]
    [InverseProperty("PrinterSettings")]
    public virtual User? User { get; set; }
}
