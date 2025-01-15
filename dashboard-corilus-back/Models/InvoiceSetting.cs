using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Keyless]
[Index("ExternalApplicationId", Name = "IX_InvoiceSettings_ExternalApplicationId")]
public partial class InvoiceSetting
{
    public Guid InvoiceSettingsId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [StringLength(255)]
    public string CoverTitle { get; set; } = null!;

    public string CoverFooter { get; set; } = null!;

    public int DueDaysPatient { get; set; }

    public int DueDaysOrganisation { get; set; }

    public bool HasCoverPage { get; set; }

    [StringLength(255)]
    public string PaymentBeneficiaryLine1 { get; set; } = null!;

    [StringLength(255)]
    public string PaymentBeneficiaryLine2 { get; set; } = null!;

    [StringLength(255)]
    public string PaymentBeneficiaryLine3 { get; set; } = null!;

    [StringLength(255)]
    public string PaymentBeneficiaryLine4 { get; set; } = null!;

    [StringLength(50)]
    public string PaymentBankAccountNr { get; set; } = null!;

    [StringLength(50)]
    public string PaymentBicNr { get; set; } = null!;

    [StringLength(50)]
    public string JournalNumber { get; set; } = null!;

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public Guid? UserId { get; set; }

    [StringLength(25)]
    public string? PaymentBeneficiaryCbeNumber { get; set; }

    [StringLength(25)]
    public string? PaymentBeneficiaryPhoneNumber { get; set; }

    [Column(TypeName = "text")]
    public string? Message1 { get; set; }

    [Column(TypeName = "text")]
    public string? Message2 { get; set; }

    public Guid? DefaultInvoiceTemplateId { get; set; }

    public Guid? DefaultReminderTemplateId { get; set; }

    public short ReminderDueDateTresholdLevel1 { get; set; }

    public short ReminderDueDateTresholdLevel2 { get; set; }

    public short ReminderDueDateTresholdLevel3 { get; set; }

    public short ReminderDueDateTresholdLevel4 { get; set; }

    public bool CoverTransferBox { get; set; }

    [ForeignKey("DefaultInvoiceTemplateId")]
    public virtual InvoiceTemplate? DefaultInvoiceTemplate { get; set; }

    [ForeignKey("DefaultReminderTemplateId")]
    public virtual ReminderTemplate? DefaultReminderTemplate { get; set; }
}
