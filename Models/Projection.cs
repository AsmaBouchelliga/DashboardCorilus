using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Index("Name", Name = "IX_Projections_Name")]
[Index("Id", Name = "Projections_Id_uindex", IsUnique = true)]
public partial class Projection
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(256)]
    public string Name { get; set; } = null!;

    public bool NeedsToBeRebuilt { get; set; }

    public DateTimeOffset? LastRebuilt { get; set; }

    public int? LastRebuiltStatus { get; set; }
}
