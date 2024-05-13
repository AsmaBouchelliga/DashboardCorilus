using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[PrimaryKey("TarificationSessionId", "ContextKey")]
[Table("TarificationSessionContext")]
public partial class TarificationSessionContext
{
    [Key]
    public Guid TarificationSessionId { get; set; }

    [Key]
    [StringLength(50)]
    public string ContextKey { get; set; } = null!;

    [StringLength(255)]
    public string ContextValue { get; set; } = null!;

    [ForeignKey("TarificationSessionId")]
    [InverseProperty("TarificationSessionContexts")]
    public virtual TarificationSession TarificationSession { get; set; } = null!;
}
