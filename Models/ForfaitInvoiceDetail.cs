using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ForfaitInvoiceDetail")]
[Index("ForfaitInvoiceId", "ForfaitInvoicePatientType", Name = "IX_ForfaitInvoiceDetail_Invoice")]
[Index("PatientId", "FacturationYearMonth", "ForfaitInvoicePatientType", Name = "IX_ForfaitInvoiceDetail_Patient")]
public partial class ForfaitInvoiceDetail
{
    [Key]
    public Guid ForfaitInvoiceDetailId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

    public Guid ForfaitInvoiceId { get; set; }

    public int ForfaitInvoicePatientType { get; set; }

    public Guid PatientId { get; set; }

    [StringLength(255)]
    public string PatientName { get; set; } = null!;

    public DateTime PatientDob { get; set; }

    [StringLength(20)]
    public string PatientInss { get; set; } = null!;

    public DateTime PatientForfaitInscriptionDate { get; set; }

    [StringLength(5)]
    public string PatientInsuranceOrganismCode { get; set; } = null!;

    public Guid ThirdPartyId { get; set; }

    [Column("PatientCG1")]
    [StringLength(5)]
    public string PatientCg1 { get; set; } = null!;

    [Column("PatientCG2")]
    [StringLength(5)]
    public string PatientCg2 { get; set; } = null!;

    public DateTime FacturationYearMonth { get; set; }

    public bool Deleted { get; set; }

    [StringLength(128)]
    public string? InsuranceInstituteInscriptionNumber { get; set; }

    [StringLength(25)]
    public string? ReferenceNumber { get; set; }

    [ForeignKey("ForfaitInvoiceId")]
    [InverseProperty("ForfaitInvoiceDetails")]
    public virtual ForfaitInvoice ForfaitInvoice { get; set; } = null!;

    [InverseProperty("ForfaitInvoiceDetail")]
    public virtual ICollection<ForfaitInvoicePatientInvoicedService> ForfaitInvoicePatientInvoicedServices { get; set; } = new List<ForfaitInvoicePatientInvoicedService>();

    [ForeignKey("PatientId")]
    [InverseProperty("ForfaitInvoiceDetails")]
    public virtual Patient Patient { get; set; } = null!;
}
