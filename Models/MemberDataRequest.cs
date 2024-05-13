using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("MemberDataRequest")]
[Index("ExternalApplicationId", Name = "IX_MemberDataRequest_ExternalApplicationId")]
public partial class MemberDataRequest
{
    [Key]
    public Guid MemberDataRequestId { get; set; }

    public DateTime? CreationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int Status { get; set; }

    [StringLength(255)]
    public string InputReference { get; set; } = null!;

    [Column(TypeName = "text")]
    public string ListOfPatients { get; set; } = null!;

    public int TotalPatients { get; set; }

    [StringLength(50)]
    public string? ErrorMessage { get; set; }

    public int? ErrorType { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("MemberDataRequests")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("MemberDataRequest")]
    public virtual ICollection<MemberDataHistory> MemberDataHistories { get; set; } = new List<MemberDataHistory>();
}
