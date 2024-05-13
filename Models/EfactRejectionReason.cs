using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("EFactRejectionReason")]
[Index("AttestId", Name = "IX_EFactRejectionReason_Attest")]
[Index("ExternalApplicationId", Name = "IX_EFactRejectionReason_ExternalApplicationId")]
[Index("TarificationSessionId", Name = "IX_EFactRejectionReason_TarificationSession")]
public partial class EfactRejectionReason
{
    [Key]
    public Guid RejectionReasonId { get; set; }

    public Guid? AttestId { get; set; }

    public Guid? TarificationSessionId { get; set; }

    [StringLength(50)]
    public string RejectionErrorCode { get; set; } = null!;

    [StringLength(10)]
    public string RejectedNomenclatureCode { get; set; } = null!;

    [StringLength(100)]
    public string RejectedValue { get; set; } = null!;

    [Column("EFactId")]
    public Guid? EfactId { get; set; }

    public Guid? AttestedTariffedServiceId { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? CommentByInsuranceOrganisation { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public int Version { get; set; }

    public bool Processed { get; set; }

    [ForeignKey("AttestedTariffedServiceId")]
    [InverseProperty("EfactRejectionReasons")]
    public virtual AttestLineItem? AttestedTariffedService { get; set; }

    [ForeignKey("EfactId")]
    [InverseProperty("EfactRejectionReasons")]
    public virtual ElectronicInvoice? Efact { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("EfactRejectionReasons")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;
}
