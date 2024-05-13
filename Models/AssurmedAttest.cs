using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Index("OriginalUnattestedSessionId", Name = "IX_AssurmedAttests_OriginalUnattestedSessionId")]
[Index("OriginalUnattestedSessionId", "ExternalApplicationId", Name = "IX_OriginalUnattestedSessionId_ExternalApplicationId", IsUnique = true)]
public partial class AssurmedAttest
{
    [Key]
    public Guid AssurmedAttestId { get; set; }

    [StringLength(23)]
    [Unicode(false)]
    public string Reference { get; set; } = null!;

    public Guid OriginalUnattestedSessionId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public Guid ExternalApplicationId { get; set; }
}
