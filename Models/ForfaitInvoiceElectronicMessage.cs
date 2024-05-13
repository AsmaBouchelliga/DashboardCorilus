using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ForfaitInvoiceElectronicMessage")]
[Index("ForfaitInvoiceId", "ValidationDate", Name = "IX_ForfaitInvoiceElectronicMessage")]
public partial class ForfaitInvoiceElectronicMessage
{
    [Key]
    public Guid ForfaitInvoiceElectronicMessageId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    public Guid ForfaitInvoiceId { get; set; }

    [StringLength(5)]
    public string DispatchNr { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string InvoiceMessage { get; set; } = null!;

    public DateTime ValidationDate { get; set; }

    [ForeignKey("ForfaitInvoiceId")]
    [InverseProperty("ForfaitInvoiceElectronicMessages")]
    public virtual ForfaitInvoice ForfaitInvoice { get; set; } = null!;
}
