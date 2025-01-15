using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ChapterName")]
public partial class ChapterName
{
    [Key]
    public Guid ChapterNameId { get; set; }

    public Guid ChapterId { get; set; }

    [StringLength(255)]
    public string Name { get; set; } = null!;

    public int LanguageCode { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [ForeignKey("ChapterId")]
    [InverseProperty("ChapterNames")]
    public virtual Chapter Chapter { get; set; } = null!;

    [ForeignKey("LanguageCode")]
    [InverseProperty("ChapterNames")]
    public virtual Language LanguageCodeNavigation { get; set; } = null!;
}
