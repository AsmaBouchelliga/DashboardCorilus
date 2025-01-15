using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("FileJobItemFile")]
public partial class FileJobItemFile
{
    [Key]
    public Guid FileJobItemFileId { get; set; }

    public Guid FileJobItemId { get; set; }

    public Guid FileId { get; set; }

    [ForeignKey("FileJobItemId")]
    [InverseProperty("FileJobItemFiles")]
    public virtual FileJobItem FileJobItem { get; set; } = null!;
}
