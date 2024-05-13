using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("InvoiceLine")]
[Index("AttestId", Name = "IX_InvoiceLine_AttestId")]
[Index("AttestLineItemId", Name = "IX_InvoiceLine_AttestLineItemId")]
public partial class InvoiceLine
{
    [Key]
    public Guid InvoiceLineId { get; set; }

    public Guid InvoiceId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PrestationDate { get; set; }

    public Guid PhysicianId { get; set; }

    [StringLength(255)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Amount { get; set; }

    public Guid PatientId { get; set; }

    [StringLength(255)]
    public string PatientName { get; set; } = null!;

    [StringLength(25)]
    public string PatientNationalNumber { get; set; } = null!;

    public int SequenceNr { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public Guid? AttestLineItemId { get; set; }

    [Column(TypeName = "decimal(19, 5)")]
    public decimal? Honorarium { get; set; }

    [Column(TypeName = "decimal(19, 5)")]
    public decimal? Reimbursement { get; set; }

    public Guid AttestId { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? Vat { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? VatPercentage { get; set; }

    [ForeignKey("AttestId")]
    [InverseProperty("InvoiceLines")]
    public virtual Attest Attest { get; set; } = null!;

    [ForeignKey("InvoiceId")]
    [InverseProperty("InvoiceLines")]
    public virtual Invoice Invoice { get; set; } = null!;
}
