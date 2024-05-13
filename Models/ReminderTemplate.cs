using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ReminderTemplate")]
[Index("ExternalApplicationId", Name = "IX_ReminderTemplate_ExternalApplicationId")]
public partial class ReminderTemplate
{
    [Key]
    public Guid ReminderTemplateId { get; set; }

    [StringLength(50)]
    public string? ReminderTemplateName { get; set; }

    public short BeneficiaryType { get; set; }

    public Guid? BeneficiaryId { get; set; }

    public bool InfoBoxVisible { get; set; }

    public short InfoBoxX { get; set; }

    public short InfoBoxY { get; set; }

    public short SenderBoxVisibilityType { get; set; }

    public short SenderBoxX { get; set; }

    public short SenderBoxY { get; set; }

    public bool SenderBoxTenantNameVisible { get; set; }

    public bool SenderBoxTelephoneVisible { get; set; }

    public bool SenderBoxEmailVisible { get; set; }

    public bool SenderBoxWebsiteVisible { get; set; }

    [Column("SenderBoxCBENumberVisible")]
    public bool SenderBoxCbenumberVisible { get; set; }

    public bool SenderBoxNihiiNumberVisible { get; set; }

    public short AddresseeBoxVisibilityType { get; set; }

    public short AddresseeBoxX { get; set; }

    public short AddresseeBoxY { get; set; }

    [Column("ContentBoxYAuto")]
    public bool ContentBoxYauto { get; set; }

    public short ContentBoxY { get; set; }

    [Column(TypeName = "text")]
    public string? Level1ContentBoxMessage1 { get; set; }

    [Column(TypeName = "text")]
    public string? Level1ContentBoxMessage2 { get; set; }

    [Column(TypeName = "text")]
    public string? Level2ContentBoxMessage1 { get; set; }

    [Column(TypeName = "text")]
    public string? Level2ContentBoxMessage2 { get; set; }

    [Column(TypeName = "text")]
    public string? Level3ContentBoxMessage1 { get; set; }

    [Column(TypeName = "text")]
    public string? Level3ContentBoxMessage2 { get; set; }

    [Column(TypeName = "text")]
    public string? Level4ContentBoxMessage1 { get; set; }

    [Column(TypeName = "text")]
    public string? Level4ContentBoxMessage2 { get; set; }

    public short TransferBoxVisibilityType { get; set; }

    public short TransferBoxX { get; set; }

    public short TransferBoxY { get; set; }

    public bool TransferBoxAmountVisible { get; set; }

    public bool TransferBoxAddresseeVisible { get; set; }

    public bool TransferBoxBeneficiaryVisible { get; set; }

    public bool TransferBoxBeneficiaryBankAccountNumberVisible { get; set; }

    public bool TransferBoxReferenceVisible { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int Version { get; set; }

    public bool PrePrinted { get; set; }

    [ForeignKey("BeneficiaryId")]
    [InverseProperty("ReminderTemplates")]
    public virtual Beneficiary? Beneficiary { get; set; }

    [InverseProperty("ReminderTemplate")]
    public virtual ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();
}
