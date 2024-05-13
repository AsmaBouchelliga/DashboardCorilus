using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Patient")]
public partial class Patient
{
    [Key]
    public Guid PatientId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [StringLength(50)]
    public string ExternalPatientId { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public bool ShouldCollectPatientContribution { get; set; }

    public int? PaymentInfoReceiptMode { get; set; }

    [StringLength(50)]
    public string? Lastname { get; set; }

    [StringLength(50)]
    public string? Firstname { get; set; }

    public int? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    [StringLength(15)]
    public string? Inss { get; set; }

    [StringLength(320)]
    public string? Email { get; set; }

    [StringLength(50)]
    public string? Street { get; set; }

    [StringLength(50)]
    public string? HouseNr { get; set; }

    [StringLength(50)]
    public string? ZipCode { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(2)]
    public string? Country { get; set; }

    public bool? Chronic { get; set; }

    public bool? Palliative { get; set; }

    public bool? PreCarePath { get; set; }

    [StringLength(15)]
    public string? GmdHolderNihii { get; set; }

    public bool? GmdHolderNotInPractice { get; set; }

    [StringLength(20)]
    public string? EidCardNumber { get; set; }

    [StringLength(20)]
    public string? IsiPlusCardNumber { get; set; }

    public DateTime? EidCardLastReadDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfDecease { get; set; }

    public byte[]? ProfilePicture { get; set; }

    [StringLength(50)]
    public string? ExternalReference { get; set; }

    public bool? Archived { get; set; }

    public DateTime? AcquisitionDate { get; set; }

    public DateTime? AgreementDateForfait { get; set; }

    [StringLength(50)]
    public string? ReferenceNumberForfait { get; set; }

    [StringLength(15)]
    public string? PostBox { get; set; }

    public Guid? ResourceId { get; set; }

    [InverseProperty("Patient")]
    public virtual ICollection<Attest> Attests { get; set; } = new List<Attest>();

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("Patients")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("Patient")]
    public virtual ICollection<ForfaitInvoiceDetail> ForfaitInvoiceDetails { get; set; } = new List<ForfaitInvoiceDetail>();

    [InverseProperty("Patient")]
    public virtual ICollection<ForfaitInvoiceReInvoiceablePeriod> ForfaitInvoiceReInvoiceablePeriods { get; set; } = new List<ForfaitInvoiceReInvoiceablePeriod>();

    [InverseProperty("Patient")]
    public virtual ICollection<ForfaitPatientHistory> ForfaitPatientHistories { get; set; } = new List<ForfaitPatientHistory>();

    [InverseProperty("Patient")]
    public virtual ICollection<ForfaitPendingInvoicingItem> ForfaitPendingInvoicingItems { get; set; } = new List<ForfaitPendingInvoicingItem>();

    [InverseProperty("Patient")]
    public virtual ICollection<MemberDataHistory> MemberDataHistories { get; set; } = new List<MemberDataHistory>();

    [InverseProperty("Patient")]
    public virtual ICollection<PatientCarePlan> PatientCarePlans { get; set; } = new List<PatientCarePlan>();

    [InverseProperty("Patient")]
    public virtual ICollection<TarificationSession> TarificationSessions { get; set; } = new List<TarificationSession>();
}
