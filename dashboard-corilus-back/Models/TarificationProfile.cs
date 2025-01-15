using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("TarificationProfile")]
[Index("PrinterSettingsId", Name = "IX_TarificationProfile_PrinterSettings")]
[Index("UserId", "ProfileName", Name = "IX_TarificationProfile_UserId_ProfileName", IsUnique = true)]
public partial class TarificationProfile
{
    [Key]
    public Guid TarificationProfileId { get; set; }

    public Guid UserId { get; set; }

    [StringLength(50)]
    public string ProfileName { get; set; } = null!;

    public bool IsDefaultProfile { get; set; }

    public Guid? PrinterSettingsId { get; set; }

    [StringLength(100)]
    public string AttestSummaryPrinterName { get; set; } = null!;

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int PaymentRegistrationMode { get; set; }

    [StringLength(260)]
    public string PaymentInvitationTemplate { get; set; } = null!;

    [StringLength(100)]
    public string PaymentInvitationPrinter { get; set; } = null!;

    public int? DefaultPaymentMode { get; set; }

    [ForeignKey("PrinterSettingsId")]
    [InverseProperty("TarificationProfiles")]
    public virtual PrinterSetting? PrinterSettings { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("TarificationProfiles")]
    public virtual User User { get; set; } = null!;

    [InverseProperty("TarificationProfile")]
    public virtual UserPrintOption? UserPrintOption { get; set; }
}
