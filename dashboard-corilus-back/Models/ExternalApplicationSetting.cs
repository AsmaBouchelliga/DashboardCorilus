using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

public partial class ExternalApplicationSetting
{
    [Key]
    public Guid ExternalApplicationSettingsId { get; set; }

    public int NextAttestReferenceNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastReferenceNumberRetrievalDate { get; set; }

    public long NextInvoiceNumber { get; set; }

    public DateTime LastInvoiceNumberRetrievalDate { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int NextPaymentInvitationReferenceNumber { get; set; }

    public DateTime LastPaymentInvitationRefNumberRetrievalDate { get; set; }

    public int NextElectronicInvoiceNumber { get; set; }

    public DateTime LastElectronicInvoiceNumberRetrievalDate { get; set; }

    [Column("ModelDGroupNumber")]
    [StringLength(15)]
    public string? ModelDgroupNumber { get; set; }

    public bool UseEfactOnOrganizationLevel { get; set; }

    public bool UseReceptionDeskWorkflow { get; set; }

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
    [StringLength(25)]
    public string? EfactCbeNumber { get; set; }

    [Column("UseEFact")]
    public bool UseEfact { get; set; }

    [Column("UseETar")]
    public bool UseEtar { get; set; }

    [Column("AutoPayEFactInvoices")]
    public bool AutoPayEfactInvoices { get; set; }

    [Column("AutoSendEFactInvoices")]
    public bool AutoSendEfactInvoices { get; set; }

    public int LegalForm { get; set; }

    [Column("IsEAttestEnabled")]
    public bool IsEattestEnabled { get; set; }

    [Column("AllowUsersToSetEFact")]
    public bool AllowUsersToSetEfact { get; set; }

    public bool? UseElectronicInvoiceForfait { get; set; }

    public Guid? BeneficiaryId { get; set; }

    public bool UseCorrespondenceTemplates { get; set; }

    public int UseSites { get; set; }

    public Guid? DefaultSiteId { get; set; }

    [Column("EFactPucCode")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EfactPucCode { get; set; }

    public bool ThirdPartyPayerByDefault { get; set; }

    public bool DisableNomenclatureFilteringOnCompetence { get; set; }

    public bool EnableNewPrescriptionFlow { get; set; }

    public bool UseHelenaByDefault { get; set; }

    public bool VatOnTenantLevel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VatNumber { get; set; }

    public int VatRegulationType { get; set; }

    public bool DisableBalanceDuePopup { get; set; }

    [Column("UseEBoxByDefault")]
    public bool UseEboxByDefault { get; set; }

    [ForeignKey("BeneficiaryId")]
    [InverseProperty("ExternalApplicationSettings")]
    public virtual Beneficiary? Beneficiary { get; set; }

    [ForeignKey("DefaultSiteId")]
    [InverseProperty("ExternalApplicationSettings")]
    public virtual Site? DefaultSite { get; set; }

    [ForeignKey("ExternalApplicationSettingsId")]
    [InverseProperty("ExternalApplicationSetting")]
    public virtual ExternalApplication ExternalApplicationSettings { get; set; } = null!;
}
