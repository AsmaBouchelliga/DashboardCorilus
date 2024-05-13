using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ElectronicAttestResponse")]
public partial class ElectronicAttestResponse
{
    [Key]
    public Guid ElectronicAttestResponseId { get; set; }

    public Guid AttestId { get; set; }

    public string Message { get; set; } = null!;

    public string Xades { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    [ForeignKey("AttestId")]
    [InverseProperty("ElectronicAttestResponses")]
    public virtual Attest Attest { get; set; } = null!;
}
