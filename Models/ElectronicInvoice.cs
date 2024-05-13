using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ElectronicInvoice")]
[Index("ExternalApplicationId", Name = "IX_ElectronicInvoice_ExternalApplicationId")]
[Index("ReferenceNumber", "ExternalApplicationId", Name = "IX_ElectronicInvoice_ReferenceNumber", IsUnique = true)]
public partial class ElectronicInvoice
{
    [Key]
    public Guid ElectronicInvoiceId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public Guid? SentByUserId { get; set; }

    public DateTime? SentOn { get; set; }

    public Guid? PhysicianId { get; set; }

    [StringLength(50)]
    public string ContactPersonFirstName { get; set; } = null!;

    [StringLength(50)]
    public string ContactPersonLastName { get; set; } = null!;

    [StringLength(25)]
    public string ContactPersonNihii { get; set; } = null!;

    [StringLength(25)]
    public string ContactPhoneNumber { get; set; } = null!;

    [StringLength(25)]
    public string CbeNumber { get; set; } = null!;

    [Column("BankAccountIBAN")]
    [StringLength(25)]
    public string BankAccountIban { get; set; } = null!;

    [Column("BankAccountBIC")]
    [StringLength(15)]
    public string BankAccountBic { get; set; } = null!;

    [StringLength(25)]
    public string DispatchNumber { get; set; } = null!;

    [StringLength(25)]
    public string ReferenceNumber { get; set; } = null!;

    public DateTime InvoicingPeriod { get; set; }

    [StringLength(5)]
    public string TargetMutuality { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal TotalHonorarium { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal TotalReimbursed { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal TotalAmountPaid { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal TotalAmountRefused { get; set; }

    public string InvoiceMessage { get; set; } = null!;

    public int Status { get; set; }

    public bool HasPendingCorrections { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Type { get; set; }

    [StringLength(50)]
    public string? PaymentReference { get; set; }

    [InverseProperty("Efact")]
    public virtual ICollection<EfactRejectionReason> EfactRejectionReasons { get; set; } = new List<EfactRejectionReason>();

    [InverseProperty("ElectronicInvoice")]
    public virtual ICollection<ElectronicInvoiceResponse> ElectronicInvoiceResponses { get; set; } = new List<ElectronicInvoiceResponse>();

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("ElectronicInvoices")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [ForeignKey("ElectronicInvoiceId")]
    [InverseProperty("ElectronicInvoices")]
    public virtual ICollection<Attest> Attests { get; set; } = new List<Attest>();
}
