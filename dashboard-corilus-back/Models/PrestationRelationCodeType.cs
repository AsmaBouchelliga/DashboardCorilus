using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PrestationRelationCodeType")]
public partial class PrestationRelationCodeType
{
    [Key]
    public int PrestationRelationCode { get; set; }

    [StringLength(255)]
    public string Description { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [InverseProperty("PrestationRelationCodeNavigation")]
    public virtual ICollection<MedicalCareServiceRelation> MedicalCareServiceRelations { get; set; } = new List<MedicalCareServiceRelation>();
}
