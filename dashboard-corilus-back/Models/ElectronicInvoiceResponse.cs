using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ElectronicInvoiceResponse")]
[Index("ElectronicInvoiceId", "ResponseType", Name = "IX_ElectronicInvoiceResponse_ElectronicInvoiceId_ResponseType")]
public partial class ElectronicInvoiceResponse
{
    [Key]
    public Guid ElectronicInvoiceResponseId { get; set; }

    public Guid ElectronicInvoiceId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int ResponseType { get; set; }

    public string Message { get; set; } = null!;

    public DateTime ReceivedOn { get; set; }

    public string Xades { get; set; } = null!;

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public bool? ActionRequired { get; set; }

    [ForeignKey("ElectronicInvoiceId")]
    [InverseProperty("ElectronicInvoiceResponses")]
    public virtual ElectronicInvoice ElectronicInvoice { get; set; } = null!;
}
