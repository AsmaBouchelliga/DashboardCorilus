using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("MedicalCareServiceRelation")]
public partial class MedicalCareServiceRelation
{
    [Key]
    public Guid PrestationRelationId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public int PrestationRelationCode { get; set; }

    [Column("PrestationX_Id")]
    public Guid PrestationXId { get; set; }

    [Column("PrestationY_Id")]
    public Guid PrestationYId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int? FromMedicalCareServiceCode { get; set; }

    public int? ToMedicalCareServiceCode { get; set; }

    [ForeignKey("PrestationRelationCode")]
    [InverseProperty("MedicalCareServiceRelations")]
    public virtual PrestationRelationCodeType PrestationRelationCodeNavigation { get; set; } = null!;

    [ForeignKey("PrestationXId")]
    [InverseProperty("MedicalCareServiceRelationPrestationXes")]
    public virtual Prestation PrestationX { get; set; } = null!;

    [ForeignKey("PrestationYId")]
    [InverseProperty("MedicalCareServiceRelationPrestationies")]
    public virtual Prestation PrestationY { get; set; } = null!;
}
