using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Index("ExternalApplicationId", Name = "IX_MedicalHouseSettings", IsUnique = true)]
public partial class MedicalHouseSetting
{
    [Key]
    public Guid MedicalHouseSettingsId { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string? Nihii { get; set; }

    [StringLength(255)]
    public string? CbeNumber { get; set; }

    [StringLength(255)]
    public string? TelephoneNumber { get; set; }

    [StringLength(255)]
    public string? Email { get; set; }

    [StringLength(255)]
    public string? WebsiteUri { get; set; }

    [StringLength(255)]
    public string? IdentificationNumber { get; set; }

    [StringLength(255)]
    public string? Street { get; set; }

    [StringLength(255)]
    public string? City { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    public bool IsServiceGp { get; set; }

    public bool IsServiceKine { get; set; }

    public bool IsServiceNurse { get; set; }

    [InverseProperty("MedicalHouseSettings")]
    public virtual ICollection<MedicalHouseBankAccountInfo> MedicalHouseBankAccountInfos { get; set; } = new List<MedicalHouseBankAccountInfo>();
}
