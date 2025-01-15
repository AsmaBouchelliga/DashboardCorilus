using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[PrimaryKey("ExternalApplicationId", "Nihii", "InsuranceOrganismCode", "InvoicingYear")]
[Table("ElectronicInvoiceDispatchNumberCounter")]
[Index("ExternalApplicationId", Name = "IX_ElectronicInvoiceDispatchNumberCounter_ExternalApplicationId")]
public partial class ElectronicInvoiceDispatchNumberCounter
{
    [Key]
    public Guid ExternalApplicationId { get; set; }

    [Key]
    [StringLength(5)]
    public string InsuranceOrganismCode { get; set; } = null!;

    [Key]
    [StringLength(15)]
    public string Nihii { get; set; } = null!;

    [Key]
    public int InvoicingYear { get; set; }

    public int NextDispatchNumber { get; set; }

    public DateTime LastDispatchNumberRetrievalDate { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("ElectronicInvoiceDispatchNumberCounters")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;
}
