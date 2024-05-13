using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Index("TarificationProfileId", Name = "IX_UserPrintOptions_TarificationProfileId", IsUnique = true)]
public partial class UserPrintOption
{
    [Key]
    public Guid UserPrintOptionsId { get; set; }

    public Guid TarificationProfileId { get; set; }

    public int AttestModelCode { get; set; }

    public int? HonorariumPrintMode { get; set; }

    [StringLength(200)]
    public string? AdditionalFreeText { get; set; }

    [StringLength(50)]
    public string? AdditionalFreeTextOnReceipt { get; set; }

    [StringLength(255)]
    public string? CollectingInstituteInfoLine1 { get; set; }

    [StringLength(255)]
    public string? CollectingInstituteInfoLine2 { get; set; }

    [StringLength(255)]
    public string? CollectingInstituteInfoLine3 { get; set; }

    [StringLength(255)]
    public string? CollectingInstituteInfoLine4 { get; set; }

    public bool? PrintHonorariaOnModelD { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public bool StrikeOutUnusedPrestations { get; set; }

    public int? AmountOnReceiptPrintMode { get; set; }

    public int? PrintOrderOfAttestsAndInvoices { get; set; }

    [ForeignKey("TarificationProfileId")]
    [InverseProperty("UserPrintOption")]
    public virtual TarificationProfile TarificationProfile { get; set; } = null!;
}
