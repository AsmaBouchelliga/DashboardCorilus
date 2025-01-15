using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("TarifiedPrestationGroupItem")]
[Index("PrestationGroupId", Name = "IX_TarifiedPrestationGroupItem_PrestationGroupId")]
public partial class TarifiedPrestationGroupItem
{
    [Key]
    public Guid TarifiedPrestationGroupItemId { get; set; }

    public Guid PrestationGroupId { get; set; }

    public int TarificationPolicy { get; set; }

    [ForeignKey("PrestationGroupId")]
    [InverseProperty("TarifiedPrestationGroupItems")]
    public virtual PrestationGroup PrestationGroup { get; set; } = null!;

    [ForeignKey("TarifiedPrestationGroupItemId")]
    [InverseProperty("TarifiedPrestationGroupItem")]
    public virtual TarifiedItem TarifiedPrestationGroupItemNavigation { get; set; } = null!;

    [InverseProperty("TarifiedPrestationGroupItem")]
    public virtual ICollection<TarifiedPrestationGroupPrestationLine> TarifiedPrestationGroupPrestationLines { get; set; } = new List<TarifiedPrestationGroupPrestationLine>();
}
