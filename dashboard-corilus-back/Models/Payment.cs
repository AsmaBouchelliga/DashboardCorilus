using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Payment")]
[Index("AttestId", Name = "IX_Payment_AttestId")]
[Index("ExternalApplicationId", Name = "IX_Payment_ExternalApplicationId")]
[Index("ForfaitInvoiceId", Name = "IX_Payment_ForfaitInvoiceId")]
[Index("InvoiceId", Name = "IX_Payment_InvoiceId")]
[Index("Payer", Name = "IX_Payment_Payer")]
[Index("TarificationSessionId", Name = "IX_Payment_TarificationSessionId")]
public partial class Payment
{
    [Key]
    public Guid PaymentId { get; set; }

    public DateTime PaymentDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Amount { get; set; }

    public int PaymentMode { get; set; }

    public int Payer { get; set; }

    [StringLength(100)]
    public string? Remark { get; set; }

    public Guid? CollectingUserId { get; set; }

    public Guid? AttestId { get; set; }

    public Guid? TarificationSessionId { get; set; }

    public Guid? InvoiceId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public Guid? ForfaitInvoiceId { get; set; }

    public Guid? ExternalApplicationId { get; set; }

    [StringLength(50)]
    public string? PaymentReference { get; set; }

    public Guid? ExternalPaymentTransactionId { get; set; }

    public Guid? GroupId { get; set; }

    public int PaymentType { get; set; }

    [ForeignKey("AttestId")]
    [InverseProperty("Payments")]
    public virtual Attest? Attest { get; set; }

    [ForeignKey("CollectingUserId")]
    [InverseProperty("Payments")]
    public virtual User? CollectingUser { get; set; }

    [ForeignKey("ForfaitInvoiceId")]
    [InverseProperty("Payments")]
    public virtual ForfaitInvoice? ForfaitInvoice { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("Payments")]
    public virtual Invoice? Invoice { get; set; }

    [ForeignKey("TarificationSessionId")]
    [InverseProperty("Payments")]
    public virtual TarificationSession? TarificationSession { get; set; }
}
