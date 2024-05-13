using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PriceTypeRelationCodeType")]
public partial class PriceTypeRelationCodeType
{
    [Key]
    public int PriceTypeRelationCode { get; set; }

    [StringLength(255)]
    public string Description { get; set; } = null!;

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [InverseProperty("PriceTypeRelationCodeNavigation")]
    public virtual ICollection<PriceTypeRelation> PriceTypeRelations { get; set; } = new List<PriceTypeRelation>();
}
