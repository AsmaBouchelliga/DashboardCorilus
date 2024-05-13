using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PriceTypeRelation")]
public partial class PriceTypeRelation
{
    [Key]
    public Guid PriceTypeRelationId { get; set; }

    [Column("PriceTypeX_Id")]
    public int PriceTypeXId { get; set; }

    [Column("PriceTypeY_Id")]
    public int PriceTypeYId { get; set; }

    public int PriceTypeRelationCode { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [ForeignKey("PriceTypeRelationCode")]
    [InverseProperty("PriceTypeRelations")]
    public virtual PriceTypeRelationCodeType PriceTypeRelationCodeNavigation { get; set; } = null!;

    [ForeignKey("PriceTypeXId")]
    [InverseProperty("PriceTypeRelationPriceTypeXes")]
    public virtual PriceType PriceTypeX { get; set; } = null!;

    [ForeignKey("PriceTypeYId")]
    [InverseProperty("PriceTypeRelationPriceTypeYs")]
    public virtual PriceType PriceTypeY { get; set; } = null!;
}
