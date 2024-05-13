using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PrestationCoefficientValue")]
public partial class PrestationCoefficientValue
{
    [Key]
    public Guid PrestationCoefficientValueId { get; set; }

    public Guid PrestationId { get; set; }

    public DateTime ValidationDate { get; set; }

    [StringLength(3)]
    public string LetterKey { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Coefficient { get; set; }

    [Column(TypeName = "decimal(19, 6)")]
    public decimal Value { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [ForeignKey("PrestationId")]
    [InverseProperty("PrestationCoefficientValues")]
    public virtual Prestation Prestation { get; set; } = null!;
}
