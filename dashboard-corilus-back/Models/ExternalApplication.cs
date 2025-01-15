using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ExternalApplication")]
public partial class ExternalApplication
{
    [Key]
    public Guid ExternalApplicationId { get; set; }

    [StringLength(250)]
    public string ApplicationName { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public Guid? PassportTenantId { get; set; }

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<AttestSummary> AttestSummaries { get; set; } = new List<AttestSummary>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<Attest> Attests { get; set; } = new List<Attest>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<BackgroundTask> BackgroundTasks { get; set; } = new List<BackgroundTask>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<EfactRejectionReason> EfactRejectionReasons { get; set; } = new List<EfactRejectionReason>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<ElectronicInvoiceDispatchNumberCounter> ElectronicInvoiceDispatchNumberCounters { get; set; } = new List<ElectronicInvoiceDispatchNumberCounter>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<ElectronicInvoice> ElectronicInvoices { get; set; } = new List<ElectronicInvoice>();

    [InverseProperty("ExternalApplicationSettings")]
    public virtual ExternalApplicationSetting? ExternalApplicationSetting { get; set; }

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<FileJob> FileJobs { get; set; } = new List<FileJob>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<ForfaitMedicalCareServiceFee> ForfaitMedicalCareServiceFees { get; set; } = new List<ForfaitMedicalCareServiceFee>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<ForfaitPatientHistory> ForfaitPatientHistories { get; set; } = new List<ForfaitPatientHistory>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<MailerQueue> MailerQueues { get; set; } = new List<MailerQueue>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<MemberDataHistory> MemberDataHistories { get; set; } = new List<MemberDataHistory>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<MemberDataRequest> MemberDataRequests { get; set; } = new List<MemberDataRequest>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<PatientCarePlan> PatientCarePlans { get; set; } = new List<PatientCarePlan>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<Physician> Physicians { get; set; } = new List<Physician>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<PrestationGroup> PrestationGroups { get; set; } = new List<PrestationGroup>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<RetrocessionSetting> RetrocessionSettings { get; set; } = new List<RetrocessionSetting>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<Site> Sites { get; set; } = new List<Site>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<TarificationSession> TarificationSessions { get; set; } = new List<TarificationSession>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<ThirdParty> ThirdParties { get; set; } = new List<ThirdParty>();

    [InverseProperty("ExternalApplication")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
