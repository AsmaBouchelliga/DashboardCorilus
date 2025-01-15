using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Index("UserId", Name = "IX_UserSettings")]
public partial class UserSetting
{
    [Key]
    public Guid UserSettingsId { get; set; }

    public Guid UserId { get; set; }

    [StringLength(255)]
    public string? BeneficiaryLine1 { get; set; }

    [StringLength(255)]
    public string? BeneficiaryLine2 { get; set; }

    [StringLength(255)]
    public string? BeneficiaryLine3 { get; set; }

    [StringLength(255)]
    public string? BeneficiaryLine4 { get; set; }

    [StringLength(50)]
    public string? BankAccountNr { get; set; }

    [StringLength(255)]
    public string? BeneficiaryLine1InscriptionsSummary { get; set; }

    [StringLength(255)]
    public string? BeneficiaryLine2InscriptionsSummary { get; set; }

    [StringLength(255)]
    public string? BeneficiaryLine3InscriptionsSummary { get; set; }

    [StringLength(255)]
    public string? BeneficiaryLine4InscriptionsSummary { get; set; }

    [StringLength(50)]
    public string? BankAccountNrInscriptionsSummary { get; set; }

    public bool? InscriptionsOnSeperateAttest { get; set; }

    public int? InscriptionsViaThirdPartyPayer { get; set; }

    [StringLength(50)]
    public string? BicNr { get; set; }

    [Column("EFactContactPersonFirstName")]
    [StringLength(50)]
    public string? EfactContactPersonFirstName { get; set; }

    [Column("EFactContactPersonLastName")]
    [StringLength(50)]
    public string? EfactContactPersonLastName { get; set; }

    [Column("EFactContactPersonNihii")]
    [StringLength(25)]
    public string? EfactContactPersonNihii { get; set; }

    [Column("EFactContactPhoneNumber")]
    [StringLength(25)]
    public string? EfactContactPhoneNumber { get; set; }

    [Column("EFactBankAccountNr")]
    [StringLength(50)]
    public string? EfactBankAccountNr { get; set; }

    [Column("EFactBicNr")]
    [StringLength(50)]
    public string? EfactBicNr { get; set; }

    [Column("EFactCbeNumber")]
    [StringLength(50)]
    public string? EfactCbeNumber { get; set; }

    [StringLength(50)]
    public string? BicNrInscriptionsSummary { get; set; }

    public int PatientContactCloseBehavior { get; set; }

    [StringLength(255)]
    public string? PaymentInfoReceiptPrinter { get; set; }

    public bool? UseTimeBasedOnCallDetermination { get; set; }

    public long? EveningStartsAt { get; set; }

    public long? NightStartsAt { get; set; }

    public long? NightEndsAt { get; set; }

    public int? WeekendStartDay { get; set; }

    public long? WeekendStartTime { get; set; }

    public int? WeekendEndDay { get; set; }

    public long? WeekendEndTime { get; set; }

    [Column("ConsultETarif")]
    public bool? ConsultEtarif { get; set; }

    public bool? AutoPayInvoices { get; set; }

    public int? DefaultRoundingStrategy { get; set; }

    public int? DefaultRoundingBoundary { get; set; }

    [StringLength(25)]
    public string? DefaultPriceTypeCode { get; set; }

    [Column("AutoConsultEFact")]
    public bool? AutoConsultEfact { get; set; }

    public bool? DefaultAtTheExpenseOf { get; set; }

    public int? InitialElectronicInvoiceDispatchNumber { get; set; }

    public bool? IsTechnicalPrestationPaidByThirdParty { get; set; }

    [Column("UseEAttest")]
    public bool? UseEattest { get; set; }

    public bool? IncludeSupplements { get; set; }

    [Column("UseEFact")]
    public bool? UseEfact { get; set; }

    public Guid? DefaultSiteId { get; set; }

    public Guid? PayconiqPointOfSalesId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserSettings")]
    public virtual User User { get; set; } = null!;
}
