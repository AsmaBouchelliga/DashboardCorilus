using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("TarifiedPrestationGroupPrestationLine")]
[Index("PrestationId", Name = "IX_TarifiedPrestationGroupPrestationLine_PrestationId")]
public partial class TarifiedPrestationGroupPrestationLine
{
    [Key]
    public Guid TarifiedPrestationGroupPrestationLineId { get; set; }

    public Guid TarifiedPrestationGroupItemId { get; set; }

    public Guid PrestationId { get; set; }

    public short SequenceNr { get; set; }

    public DateTime PrestationDate { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Honorarium { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Reimbursement { get; set; }

    public bool IsHonorariumManuallySpecified { get; set; }

    public bool CouldNotExactlyDetermineHonorarium { get; set; }

    public bool CouldNotExactlyDetermineReimbursement { get; set; }

    public int? HonorariumPriceTypeId { get; set; }

    public int? ReimbursementPriceTypeId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public bool? IsReimbursementManuallySpecified { get; set; }

    [StringLength(55)]
    public string? FinancialContractNr { get; set; }

    [Column("EFactConsultationDate", TypeName = "datetime")]
    public DateTime? EfactConsultationDate { get; set; }

    [Column("EFactRelativePrestationCode")]
    [StringLength(10)]
    public string? EfactRelativePrestationCode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal OfficialHonorarium { get; set; }

    [ForeignKey("PrestationId")]
    [InverseProperty("TarifiedPrestationGroupPrestationLines")]
    public virtual Prestation Prestation { get; set; } = null!;

    [ForeignKey("TarifiedPrestationGroupItemId")]
    [InverseProperty("TarifiedPrestationGroupPrestationLines")]
    public virtual TarifiedPrestationGroupItem TarifiedPrestationGroupItem { get; set; } = null!;
}
