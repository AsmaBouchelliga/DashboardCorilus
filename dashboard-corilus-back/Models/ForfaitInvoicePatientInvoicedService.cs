using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ForfaitInvoicePatientInvoicedService")]
[Index("ForfaitInvoiceDetailId", Name = "IX_ForfaitInvoicePatientInvoicedService")]
public partial class ForfaitInvoicePatientInvoicedService
{
    [Key]
    public Guid ForfaitInvoicePatientInvoicedServiceId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    public Guid ForfaitInvoiceDetailId { get; set; }

    [StringLength(10)]
    public string NomenclatureCode { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Amount { get; set; }

    public int Deleted { get; set; }

    [ForeignKey("ForfaitInvoiceDetailId")]
    [InverseProperty("ForfaitInvoicePatientInvoicedServices")]
    public virtual ForfaitInvoiceDetail ForfaitInvoiceDetail { get; set; } = null!;
}
