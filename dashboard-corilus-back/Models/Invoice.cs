using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Invoice")]
[Index("ExternalApplicationId", "ThirdPartyId", Name = "IX_Invoice_ExtAppId_ThirdPartyId")]
public partial class Invoice
{
    [Key]
    public Guid InvoiceId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [StringLength(255)]
    public string BeneficiaryLine1 { get; set; } = null!;

    [StringLength(255)]
    public string BeneficiaryLine2 { get; set; } = null!;

    [StringLength(255)]
    public string BeneficiaryLine3 { get; set; } = null!;

    [StringLength(255)]
    public string BeneficiaryLine4 { get; set; } = null!;

    [StringLength(50)]
    public string BankAccountNr { get; set; } = null!;

    public DateTime InvoiceDate { get; set; }

    public DateTime DueDate { get; set; }

    [StringLength(25)]
    public string InvoiceNumber { get; set; } = null!;

    [Column(TypeName = "decimal(19, 5)")]
    public decimal Amount { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public bool CreditNote { get; set; }

    public Guid? LinkedInvoiceId { get; set; }

    public Guid? PatientId { get; set; }

    [StringLength(255)]
    public string? InvoiceTitle { get; set; }

    [StringLength(50)]
    public string? ReferenceNumber { get; set; }

    [StringLength(50)]
    public string? BicNr { get; set; }

    [StringLength(255)]
    public string? PaymentBeneficiaryLine1 { get; set; }

    [StringLength(255)]
    public string? PaymentBeneficiaryLine2 { get; set; }

    [StringLength(255)]
    public string? PaymentBeneficiaryLine3 { get; set; }

    [StringLength(255)]
    public string? PaymentBeneficiaryLine4 { get; set; }

    [StringLength(50)]
    public string? PaymentBankAccountNr { get; set; }

    [StringLength(50)]
    public string? PaymentBicNr { get; set; }

    public Guid? ThirdPartyId { get; set; }

    public int? AtTheExpenseOf { get; set; }

    public bool InvoicePaid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VatNumber { get; set; }

    public int VatRegulationType { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal TotalVat { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("Invoices")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("Invoice")]
    public virtual ICollection<InvoiceLine> InvoiceLines { get; set; } = new List<InvoiceLine>();

    [InverseProperty("Invoice")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [ForeignKey("ThirdPartyId")]
    [InverseProperty("Invoices")]
    public virtual ThirdParty? ThirdParty { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("Invoices")]
    public virtual ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();
}
