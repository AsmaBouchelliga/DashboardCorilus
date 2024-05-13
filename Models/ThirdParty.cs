using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ThirdParty")]
[Index("ExternalApplicationId", "ThirdPartyType", Name = "IX_ThirdParty_ExternalApplicationId_ThirdPartyType")]
public partial class ThirdParty
{
    [Key]
    public Guid ThirdPartyId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [StringLength(255)]
    public string ExternalThirdPartyId { get; set; } = null!;

    public int ThirdPartyType { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? ContactPerson { get; set; }

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
    public string? Code { get; set; }

    [StringLength(50)]
    public string? ExternalReference { get; set; }

    [StringLength(15)]
    public string? PostBox { get; set; }

    [InverseProperty("ThirdParty")]
    public virtual ICollection<AttestSummary> AttestSummaries { get; set; } = new List<AttestSummary>();

    [InverseProperty("ThirdPartyPayer")]
    public virtual ICollection<Attest> Attests { get; set; } = new List<Attest>();

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("ThirdParties")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("ThirdParty")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("PatientInsuranceInstitute")]
    public virtual ICollection<TarificationSession> TarificationSessions { get; set; } = new List<TarificationSession>();
}
