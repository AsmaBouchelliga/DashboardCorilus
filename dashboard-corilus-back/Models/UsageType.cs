using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("UsageType")]
public partial class UsageType
{
    [Key]
    public int UsageTypeCode { get; set; }

    [StringLength(255)]
    public string Description { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [InverseProperty("UsageCodeNavigation")]
    public virtual ICollection<AdditionalOnCallPrestationRegistry> AdditionalOnCallPrestationRegistries { get; set; } = new List<AdditionalOnCallPrestationRegistry>();

    [InverseProperty("SuppliedAidTypeNavigation")]
    public virtual ICollection<AttestedSession> AttestedSessions { get; set; } = new List<AttestedSession>();

    [InverseProperty("UsageCodeNavigation")]
    public virtual ICollection<Prestation> Prestations { get; set; } = new List<Prestation>();

    [InverseProperty("SuppliedAidTypeNavigation")]
    public virtual ICollection<TarificationSession> TarificationSessions { get; set; } = new List<TarificationSession>();
}
