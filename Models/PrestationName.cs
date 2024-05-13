using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PrestationName")]
public partial class PrestationName
{
    [Key]
    public Guid PrestationNameId { get; set; }

    public Guid PrestationId { get; set; }

    public int LanguageCode { get; set; }

    [StringLength(4000)]
    public string Name { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [ForeignKey("LanguageCode")]
    [InverseProperty("PrestationNames")]
    public virtual Language LanguageCodeNavigation { get; set; } = null!;

    [ForeignKey("PrestationId")]
    [InverseProperty("PrestationNames")]
    public virtual Prestation Prestation { get; set; } = null!;
}
