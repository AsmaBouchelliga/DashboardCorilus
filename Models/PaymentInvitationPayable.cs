using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[PrimaryKey("PaymentInvitationId", "PayableId", "PayableType")]
[Index("PayableId", "PayableType", Name = "IX_PaymentInvitationPayables_Payables")]
public partial class PaymentInvitationPayable
{
    [Key]
    public Guid PaymentInvitationId { get; set; }

    [Key]
    public Guid PayableId { get; set; }

    [Key]
    [StringLength(1)]
    public string PayableType { get; set; } = null!;

    [ForeignKey("PaymentInvitationId")]
    [InverseProperty("PaymentInvitationPayables")]
    public virtual PaymentInvitation PaymentInvitation { get; set; } = null!;
}
