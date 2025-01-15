using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("LatestEFactReferenceNumberForAttests")]
[Index("AttestId", Name = "LatestEFactReferenceNumberForAttests_AttestId_uindex", IsUnique = true)]
public partial class LatestEfactReferenceNumberForAttest
{
    [Key]
    public Guid AttestId { get; set; }

    [Column("LatestEFactReferenceNumber")]
    [StringLength(256)]
    public string LatestEfactReferenceNumber { get; set; } = null!;

    [Column("EFactId")]
    public Guid EfactId { get; set; }

    [Column("EFactCreationDate")]
    public DateTime EfactCreationDate { get; set; }
}
