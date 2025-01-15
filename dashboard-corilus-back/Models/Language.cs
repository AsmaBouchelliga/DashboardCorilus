using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Language")]
[Index("IsoCode", Name = "IX_Language_IsoCode", IsUnique = true)]
public partial class Language
{
    [Key]
    public int LanguageCode { get; set; }

    [StringLength(3)]
    public string IsoCode { get; set; } = null!;

    [StringLength(255)]
    public string Description { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<ChapterName> ChapterNames { get; set; } = new List<ChapterName>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<PrestationName> PrestationNames { get; set; } = new List<PrestationName>();

    [InverseProperty("LanguageCodeNavigation")]
    public virtual ICollection<PriceTypeDescription> PriceTypeDescriptions { get; set; } = new List<PriceTypeDescription>();
}
