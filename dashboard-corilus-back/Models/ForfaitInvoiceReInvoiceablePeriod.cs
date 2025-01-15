using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ForfaitInvoiceReInvoiceablePeriod")]
[Index("ExternalApplicationId", Name = "IX_ForfaitInvoiceReInvoiceablePeriod_ExternalApplicationId")]
public partial class ForfaitInvoiceReInvoiceablePeriod
{
    [Key]
    public Guid ForfaitInvoiceReInvoiceablePeriodId { get; set; }

    public DateTime InvoiceDate { get; set; }

    public bool ServiceGp { get; set; }

    public bool ServiceNurse { get; set; }

    public bool ServiceKine { get; set; }

    public bool Prediabetesplan { get; set; }

    public Guid? ForfaitInvoiceId { get; set; }

    public Guid PatientId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int Version { get; set; }

    [ForeignKey("ForfaitInvoiceId")]
    [InverseProperty("ForfaitInvoiceReInvoiceablePeriods")]
    public virtual ForfaitInvoice? ForfaitInvoice { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("ForfaitInvoiceReInvoiceablePeriods")]
    public virtual Patient Patient { get; set; } = null!;
}
