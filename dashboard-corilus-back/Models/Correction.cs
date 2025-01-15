using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Correction")]
[Index("ExternalApplicationId", Name = "IX_Correction_ExternalApplicationId")]
public partial class Correction
{
    [Key]
    public Guid CorrectionId { get; set; }

    public Guid AttestId { get; set; }

    public Guid? AttestLineItemId { get; set; }

    public Guid? InvoiceId { get; set; }

    public Guid? CreditNoteId { get; set; }

    public Guid? PhysicianId { get; set; }

    public int CorrectionType { get; set; }

    [StringLength(255)]
    public string ChangeInfo { get; set; } = null!;

    public DateTime? PrestationDate { get; set; }

    [Column(TypeName = "decimal(19, 5)")]
    public decimal? Honorarium { get; set; }

    [Column(TypeName = "decimal(19, 5)")]
    public decimal? Reimbursement { get; set; }

    public Guid CorrectedBy { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [ForeignKey("AttestId")]
    [InverseProperty("Corrections")]
    public virtual Attest Attest { get; set; } = null!;
}
