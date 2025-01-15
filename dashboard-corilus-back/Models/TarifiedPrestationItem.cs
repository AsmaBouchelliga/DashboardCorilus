using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("TarifiedPrestationItem")]
[Index("PrestationId", Name = "IX_TarifiedPrestationProperties_PrestationId")]
public partial class TarifiedPrestationItem
{
    [Key]
    public Guid TarifiedPrestationItemId { get; set; }

    public Guid PrestationId { get; set; }

    public int? HonorariumPriceTypeId { get; set; }

    public int? ReimbursementPriceTypeId { get; set; }

    public bool? IsReimbursementManuallySpecified { get; set; }

    [StringLength(55)]
    public string? FinancialContractNr { get; set; }

    [Column("EFactConsultationDate")]
    public DateTime? EfactConsultationDate { get; set; }

    [Column("EFactRelativePrestationCode")]
    [StringLength(10)]
    public string? EfactRelativePrestationCode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal OfficialHonorarium { get; set; }

    public bool GmdInfluencesReimbursement { get; set; }

    [Column("EFactClaimAuthorInss")]
    [StringLength(15)]
    public string? EfactClaimAuthorInss { get; set; }

    [Column("EFactClaimAuthorNihii")]
    [StringLength(20)]
    public string? EfactClaimAuthorNihii { get; set; }

    public bool TarifiedFor50Percent { get; set; }

    public bool IsUmc { get; set; }

    [StringLength(16)]
    public string? CbeNumberPswc { get; set; }

    [StringLength(16)]
    public string? MediPrimaCardNumber { get; set; }

    [StringLength(8)]
    public string? MediPrimaCardVersion { get; set; }

    [ForeignKey("PrestationId")]
    [InverseProperty("TarifiedPrestationItems")]
    public virtual Prestation Prestation { get; set; } = null!;

    [ForeignKey("TarifiedPrestationItemId")]
    [InverseProperty("TarifiedPrestationItem")]
    public virtual TarifiedItem TarifiedPrestationItemNavigation { get; set; } = null!;
}
