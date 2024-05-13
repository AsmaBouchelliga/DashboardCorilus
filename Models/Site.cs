using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Site")]
[Index("ExternalApplicationId", Name = "IX_Site_ExternalApplicationId")]
public partial class Site
{
    [Key]
    public Guid SiteId { get; set; }

    [StringLength(50)]
    public string? ExternalSiteId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public Guid ExternalApplicationId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public int? Version { get; set; }

    [StringLength(50)]
    public string? Street { get; set; }

    [StringLength(50)]
    public string? HouseNr { get; set; }

    [StringLength(50)]
    public string? ZipCode { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(2)]
    public string? Country { get; set; }

    [StringLength(15)]
    public string? PostBox { get; set; }

    [InverseProperty("Site")]
    public virtual ICollection<AttestedSession> AttestedSessions { get; set; } = new List<AttestedSession>();

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("Sites")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("DefaultSite")]
    public virtual ICollection<ExternalApplicationSetting> ExternalApplicationSettings { get; set; } = new List<ExternalApplicationSetting>();

    [InverseProperty("Site")]
    public virtual ICollection<TarificationSession> TarificationSessions { get; set; } = new List<TarificationSession>();
}
