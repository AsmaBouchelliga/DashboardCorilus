using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Beneficiary")]
[Index("ExternalApplicationId", Name = "IX_Beneficiary_ExternalApplicationId")]
public partial class Beneficiary
{
    [Key]
    public Guid BeneficiaryId { get; set; }

    [StringLength(50)]
    public string? TenantName { get; set; }

    [StringLength(50)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    public string? LastName { get; set; }

    [StringLength(60)]
    public string? StreetName { get; set; }

    [StringLength(10)]
    public string? HouseNumber { get; set; }

    public short? PostalCode { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(25)]
    public string? TelephoneNumber { get; set; }

    [StringLength(50)]
    public string? Email { get; set; }

    [StringLength(70)]
    public string? Website { get; set; }

    [Column("CBENumber")]
    [StringLength(50)]
    public string? Cbenumber { get; set; }

    [StringLength(25)]
    public string? NihiiNumber { get; set; }

    [StringLength(50)]
    public string? BankAccountNumber { get; set; }

    [Column("BICNumber")]
    [StringLength(50)]
    public string? Bicnumber { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int Version { get; set; }

    [InverseProperty("Beneficiary")]
    public virtual ICollection<ExternalApplicationSetting> ExternalApplicationSettings { get; set; } = new List<ExternalApplicationSetting>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<InvoiceTemplate> InvoiceTemplates { get; set; } = new List<InvoiceTemplate>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<Physician> Physicians { get; set; } = new List<Physician>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<ReminderTemplate> ReminderTemplates { get; set; } = new List<ReminderTemplate>();
}
