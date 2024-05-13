using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PrestationType")]
public partial class PrestationType
{
    [Key]
    public int PrestationTypeCode { get; set; }

    [StringLength(255)]
    public string Description { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [InverseProperty("PrestationTypeCodeNavigation")]
    public virtual ICollection<Prestation> Prestations { get; set; } = new List<Prestation>();
}
