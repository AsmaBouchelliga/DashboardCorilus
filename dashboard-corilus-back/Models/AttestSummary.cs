using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("AttestSummary")]
[Index("ExternalApplicationId", "ThirdPartyId", "AttestSummaryDate", Name = "IX_AttestSummary_ExtAppId_ThirdPartyId_AttestSummaryDate")]
public partial class AttestSummary
{
    [Key]
    public Guid AttestSummaryId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public Guid ThirdPartyId { get; set; }

    public int AtTheExpenseOf { get; set; }

    public DateTime AttestSummaryDate { get; set; }

    [StringLength(255)]
    public string BeneficiaryLine1 { get; set; } = null!;

    [StringLength(255)]
    public string BeneficiaryLine2 { get; set; } = null!;

    [StringLength(255)]
    public string BeneficiaryLine3 { get; set; } = null!;

    [StringLength(255)]
    public string BeneficiaryLine4 { get; set; } = null!;

    [StringLength(50)]
    public string BankAccountNr { get; set; } = null!;

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("AttestSummaries")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [ForeignKey("ThirdPartyId")]
    [InverseProperty("AttestSummaries")]
    public virtual ThirdParty ThirdParty { get; set; } = null!;

    [ForeignKey("AttestSummaryId")]
    [InverseProperty("AttestSummaries")]
    public virtual ICollection<Attest> Attests { get; set; } = new List<Attest>();
}
