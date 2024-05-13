using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("PaymentInvitation")]
[Index("PaymentInvitationDate", Name = "IX_PaymentInvitation_Date")]
[Index("ExternalApplicationId", Name = "IX_PaymentInvitation_ExternalApplicationId")]
[Index("Patient", Name = "IX_PaymentInvitation_Patient")]
[Index("PatientId", Name = "IX_PaymentInvitation_PatientId")]
[Index("ReferenceNumber", Name = "IX_PaymentInvitation_ReferenceNumber", IsUnique = true)]
public partial class PaymentInvitation
{
    [Key]
    public Guid PaymentInvitationId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [StringLength(255)]
    public string Patient { get; set; } = null!;

    public Guid PatientId { get; set; }

    [StringLength(25)]
    public string ReferenceNumber { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Amount { get; set; }

    public DateTime PaymentInvitationDate { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [InverseProperty("PaymentInvitation")]
    public virtual ICollection<PaymentInvitationPayable> PaymentInvitationPayables { get; set; } = new List<PaymentInvitationPayable>();
}
