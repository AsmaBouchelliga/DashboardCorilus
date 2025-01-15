using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ForfaitInvoice")]
[Index("ExternalApplicationId", Name = "IX_ForfaitInvoice_ExternalApplicationId")]
[Index("ExternalApplicationId", "FacturationPeriod", "InvoiceType", Name = "IX_ForfaitInvoice_FactPeriodInvoiceType")]
public partial class ForfaitInvoice
{
    [Key]
    public Guid ForfaitInvoiceId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [StringLength(5)]
    public string TargetMutuality { get; set; } = null!;

    public DateTime FacturationPeriod { get; set; }

    public int InvoiceType { get; set; }

    [Column(TypeName = "decimal(19, 5)")]
    public decimal TotalAmount { get; set; }

    [StringLength(25)]
    public string ReferenceNumber { get; set; } = null!;

    public bool Validated { get; set; }

    public Guid? ElectronicInvoiceId { get; set; }

    [InverseProperty("ForfaitInvoice")]
    public virtual ICollection<ForfaitInvoiceDetail> ForfaitInvoiceDetails { get; set; } = new List<ForfaitInvoiceDetail>();

    [InverseProperty("ForfaitInvoice")]
    public virtual ICollection<ForfaitInvoiceElectronicMessage> ForfaitInvoiceElectronicMessages { get; set; } = new List<ForfaitInvoiceElectronicMessage>();

    [InverseProperty("ForfaitInvoice")]
    public virtual ICollection<ForfaitInvoiceReInvoiceablePeriod> ForfaitInvoiceReInvoiceablePeriods { get; set; } = new List<ForfaitInvoiceReInvoiceablePeriod>();

    [InverseProperty("ForfaitInvoice")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
