using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("MedicalHouseBankAccountInfo")]
[Index("MedicalHouseSettingsId", "MutualityCode", Name = "IX_MedicalHouseBankAccountInfo_IdCode", IsUnique = true)]
public partial class MedicalHouseBankAccountInfo
{
    [Key]
    public Guid MedicalHouseBankAccountInfoId { get; set; }

    public Guid MedicalHouseSettingsId { get; set; }

    [StringLength(255)]
    public string MutualityCode { get; set; } = null!;

    [StringLength(255)]
    public string? Iban { get; set; }

    [StringLength(255)]
    public string? Bic { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [ForeignKey("MedicalHouseSettingsId")]
    [InverseProperty("MedicalHouseBankAccountInfos")]
    public virtual MedicalHouseSetting MedicalHouseSettings { get; set; } = null!;
}
