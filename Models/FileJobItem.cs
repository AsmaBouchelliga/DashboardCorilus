using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("FileJobItem")]
[Index("FileJobId", Name = "IX_FileJobItem_FileJobId")]
public partial class FileJobItem
{
    [Key]
    public Guid FileJobItemId { get; set; }

    public Guid FileJobId { get; set; }

    public int JobType { get; set; }

    public Guid? AttestPrinterProfileId { get; set; }

    [StringLength(128)]
    public string? FilterName { get; set; }

    [StringLength(24)]
    public string? FilterAmount { get; set; }

    public int? FilterAtTheExpenseOf { get; set; }

    public Guid? FilterPhysicianId { get; set; }

    public DateTime? FilterFromDate { get; set; }

    public DateTime? FilterToDate { get; set; }

    public string? FilterTargets { get; set; }

    public int? FilterForfaitType { get; set; }

    [StringLength(255)]
    public string? FileName { get; set; }

    [StringLength(8)]
    public string? FileExtension { get; set; }

    public int? AccountingExportListType { get; set; }

    public int? ExportType { get; set; }

    public int? ExportContent { get; set; }

    [StringLength(50)]
    public string? FilterSelectedSiteId { get; set; }

    [ForeignKey("FileJobId")]
    [InverseProperty("FileJobItems")]
    public virtual FileJob FileJob { get; set; } = null!;

    [InverseProperty("FileJobItem")]
    public virtual ICollection<FileJobItemFile> FileJobItemFiles { get; set; } = new List<FileJobItemFile>();
}
