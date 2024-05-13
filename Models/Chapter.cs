using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Chapter")]
public partial class Chapter
{
    [Key]
    public Guid ChapterId { get; set; }

    [StringLength(25)]
    public string ChapterCode { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [InverseProperty("Chapter")]
    public virtual ICollection<ChapterName> ChapterNames { get; set; } = new List<ChapterName>();

    [InverseProperty("Chapter")]
    public virtual ICollection<Prestation> Prestations { get; set; } = new List<Prestation>();
}
