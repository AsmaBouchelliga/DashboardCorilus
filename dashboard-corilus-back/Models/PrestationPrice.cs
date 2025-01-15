using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PrestationPrice")]
[Index("ExternalApplicationId", "PrestationId", Name = "IX_PrestationPrice_ExternalApplicationId")]
public partial class PrestationPrice
{
    [Key]
    public Guid PrestationPriceId { get; set; }

    public Guid PrestationId { get; set; }

    public DateTime ValidationDate { get; set; }

    public int PriceTypeId { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Price { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public Guid? ExternalApplicationId { get; set; }

    [ForeignKey("PrestationId")]
    [InverseProperty("PrestationPrices")]
    public virtual Prestation Prestation { get; set; } = null!;

    [ForeignKey("PriceTypeId")]
    [InverseProperty("PrestationPrices")]
    public virtual PriceType PriceType { get; set; } = null!;
}
