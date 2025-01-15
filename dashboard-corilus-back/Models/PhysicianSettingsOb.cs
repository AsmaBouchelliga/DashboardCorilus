using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PhysicianSettings_Obs")]
[Index("PhysicianId", Name = "IX_PhysicianSettings_PhysicianId", IsUnique = true)]
public partial class PhysicianSettingsOb
{
    [Key]
    public Guid PhysicianSettingsId { get; set; }

    public Guid PhysicianId { get; set; }

    public int InitialElectronicInvoiceDispatchNumber { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [ForeignKey("PhysicianId")]
    [InverseProperty("PhysicianSettingsOb")]
    public virtual Physician Physician { get; set; } = null!;
}
