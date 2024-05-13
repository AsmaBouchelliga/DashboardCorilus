using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("User")]
public partial class User
{
    [Key]
    public Guid UserId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [StringLength(50)]
    public string ExternalUserId { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [StringLength(50)]
    public string? Lastname { get; set; }

    [StringLength(50)]
    public string? Firstname { get; set; }

    public Guid? PhysicianId { get; set; }

    [StringLength(50)]
    public string? ExternalReference { get; set; }

    public bool? Archived { get; set; }

    [StringLength(250)]
    public string? CorilusPersonId { get; set; }

    public int? MedicalRole { get; set; }

    public bool? IsAdministrator { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<BackgroundTask> BackgroundTasks { get; set; } = new List<BackgroundTask>();

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("Users")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("CollectingUser")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [InverseProperty("User")]
    public virtual ICollection<PrestationGroup> PrestationGroups { get; set; } = new List<PrestationGroup>();

    [InverseProperty("User")]
    public virtual ICollection<PrinterSetting> PrinterSettings { get; set; } = new List<PrinterSetting>();

    [InverseProperty("CreatedByUser")]
    public virtual ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();

    [InverseProperty("User")]
    public virtual ICollection<TarificationProfile> TarificationProfiles { get; set; } = new List<TarificationProfile>();

    [InverseProperty("User")]
    public virtual ICollection<UserSetting> UserSettings { get; set; } = new List<UserSetting>();
}
