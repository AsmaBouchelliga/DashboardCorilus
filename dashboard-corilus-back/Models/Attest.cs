using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Attest")]
[Index("IsDuplicateOf", Name = "IX_Attest_IsDuplicateOf")]
[Index("IsDuplicateOf", "Canceled", Name = "IX_Attest_IsDuplicateOfAndCanceled")]
[Index("PatientId", "ExternalApplicationId", Name = "IX_Attest_PatientId_ExternalApplicationId")]
public partial class Attest
{
    [Key]
    public Guid AttestId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int AttestModel { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AttestDate { get; set; }

    [StringLength(25)]
    public string AttestNumber { get; set; } = null!;

    public Guid PatientId { get; set; }

    [StringLength(255)]
    public string PatientName { get; set; } = null!;

    [StringLength(100)]
    public string PatientAddressStreet { get; set; } = null!;

    [StringLength(10)]
    public string PatientAddressNumber { get; set; } = null!;

    [StringLength(15)]
    public string? PatientAddressPostBox { get; set; }

    [StringLength(10)]
    public string PatientAddressPostalCode { get; set; } = null!;

    [StringLength(100)]
    public string PatientAddressCity { get; set; } = null!;

    [StringLength(100)]
    public string PatientInsuranceOrganism { get; set; } = null!;

    [StringLength(15)]
    public string PatientInsuranceOrganismCode { get; set; } = null!;

    [StringLength(20)]
    public string PatientNationalNumber { get; set; } = null!;

    [Column("PatientCG1")]
    [StringLength(5)]
    public string PatientCg1 { get; set; } = null!;

    [Column("PatientCG2")]
    [StringLength(5)]
    public string PatientCg2 { get; set; } = null!;

    public bool PatientHasGmd { get; set; }

    [StringLength(25)]
    public string PatientGmdHolder { get; set; } = null!;

    public int AtTheExpenseOf { get; set; }

    public int? SocialThirdPartyPayerReason { get; set; }

    public Guid? ThirdPartyPayerId { get; set; }

    public bool Canceled { get; set; }

    public Guid? IsDuplicateOf { get; set; }

    [StringLength(255)]
    public string? Stamp { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public Guid PatientContributionPayerId { get; set; }

    [StringLength(255)]
    public string? CancelReason { get; set; }

    [Column("InvoicedUsingEFact")]
    public bool InvoicedUsingEfact { get; set; }

    [StringLength(20)]
    public string? PatientCardNr { get; set; }

    public DateTime? PatientCardReadingDate { get; set; }

    [Column("EFactStatus")]
    public int? EfactStatus { get; set; }

    [Column("EFactCorrectionPreviousEFactInvoiceReference")]
    [StringLength(25)]
    public string? EfactCorrectionPreviousEfactInvoiceReference { get; set; }

    [Column("EFactCorrectionPreviousAttestNr")]
    [StringLength(25)]
    public string? EfactCorrectionPreviousAttestNr { get; set; }

    [Column("EFactCorrectionPreviousDispatchNr")]
    [StringLength(25)]
    public string? EfactCorrectionPreviousDispatchNr { get; set; }

    [Column("EFactCorrectionPreviousHealthInsuranceCode")]
    [StringLength(5)]
    public string? EfactCorrectionPreviousHealthInsuranceCode { get; set; }

    [Column("EFactCorrectionPreviousMutualityReferenceNr")]
    [StringLength(25)]
    public string? EfactCorrectionPreviousMutualityReferenceNr { get; set; }

    [Column("EFactCorrectionPreviousInvoicingPeriod")]
    [StringLength(8)]
    public string? EfactCorrectionPreviousInvoicingPeriod { get; set; }

    [Column("EAttestReceiptLastPrintedOn")]
    public DateTime? EattestReceiptLastPrintedOn { get; set; }

    [Column("EAttestTreatmentReason")]
    public int? EattestTreatmentReason { get; set; }

    public bool? PatientHasChronicalDisease { get; set; }

    public bool? PatientHasPalliativeStatus { get; set; }

    [StringLength(50)]
    public string? ExternalAttestId { get; set; }

    public DateTime? AttestLastPrintedOn { get; set; }

    public int AttestNumberType { get; set; }

    public int PatientContributionAtTheExpenseOf { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VatNumber { get; set; }

    public int VatRegulationType { get; set; }

    public int? GmrHolderStatus { get; set; }

    [StringLength(20)]
    public string? PatientGmrHolderNihii { get; set; }

    public DateTimeOffset? CancellationDate { get; set; }

    [InverseProperty("Attest")]
    public virtual ICollection<AttestedSession> AttestedSessions { get; set; } = new List<AttestedSession>();

    [InverseProperty("Attest")]
    public virtual ICollection<Correction> Corrections { get; set; } = new List<Correction>();

    [InverseProperty("Attest")]
    public virtual ICollection<ElectronicAttestResponse> ElectronicAttestResponses { get; set; } = new List<ElectronicAttestResponse>();

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("Attests")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("IsDuplicateOfNavigation")]
    public virtual ICollection<Attest> InverseIsDuplicateOfNavigation { get; set; } = new List<Attest>();

    [InverseProperty("Attest")]
    public virtual ICollection<InvoiceLine> InvoiceLines { get; set; } = new List<InvoiceLine>();

    [ForeignKey("IsDuplicateOf")]
    [InverseProperty("InverseIsDuplicateOfNavigation")]
    public virtual Attest? IsDuplicateOfNavigation { get; set; }

    [InverseProperty("FirstAttest")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [ForeignKey("PatientId")]
    [InverseProperty("Attests")]
    public virtual Patient Patient { get; set; } = null!;

    [InverseProperty("Attest")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [ForeignKey("ThirdPartyPayerId")]
    [InverseProperty("Attests")]
    public virtual ThirdParty? ThirdPartyPayer { get; set; }

    [ForeignKey("AttestId")]
    [InverseProperty("Attests")]
    public virtual ICollection<AttestSummary> AttestSummaries { get; set; } = new List<AttestSummary>();

    [ForeignKey("AttestId")]
    [InverseProperty("Attests")]
    public virtual ICollection<ElectronicInvoice> ElectronicInvoices { get; set; } = new List<ElectronicInvoice>();
}
