using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Keyless]
[Table("EForfaitAgreement")]
public partial class EforfaitAgreement
{
    [Column("EForfaitAgreementId")]
    public Guid EforfaitAgreementId { get; set; }

    public DateTime RequestDate { get; set; }

    [StringLength(50)]
    public string? RequestType { get; set; }

    [StringLength(50)]
    public string PatientExternalId { get; set; } = null!;

    [StringLength(50)]
    public string? PatientInss { get; set; }

    [StringLength(255)]
    public string? InsuranceId { get; set; }

    [StringLength(255)]
    public string? InsuranceMembership { get; set; }

    [StringLength(50)]
    public string? StatusCode { get; set; }

    public DateTime? StartOrEndDate { get; set; }

    public DateTime? AgreementDate { get; set; }

    [StringLength(255)]
    public string? AgreementNumber { get; set; }

    [StringLength(50)]
    public string? ClosureStatus { get; set; }

    [StringLength(50)]
    public string? MedicalHouseNihii { get; set; }

    public string? ErrorMsgDetails { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int? Version { get; set; }

    [StringLength(255)]
    public string? PatientName { get; set; }
}
