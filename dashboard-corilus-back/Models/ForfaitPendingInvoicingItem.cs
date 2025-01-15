using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("ForfaitPendingInvoicingItem")]
[Index("PatientInsuranceOrganismCode", "FacturationYearMonth", Name = "IX_ForfaitPendingInvoicingItem_InsOrg_Date")]
public partial class ForfaitPendingInvoicingItem
{
    [Key]
    public Guid PendingInvoiceItemId { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public DateTime ModificationDate { get; set; }

    public int Version { get; set; }

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

    [Column("PatientCG1")]
    [StringLength(5)]
    public string PatientCg1 { get; set; } = null!;

    [Column("PatientCG2")]
    [StringLength(5)]
    public string PatientCg2 { get; set; } = null!;

    public DateTime FacturationYearMonth { get; set; }

    [StringLength(10)]
    public string NomenclatureGp { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal AmountGp { get; set; }

    [StringLength(10)]
    public string NomenclatureNurse { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal AmountNurse { get; set; }

    [StringLength(10)]
    public string NomenclatureKine { get; set; } = null!;

    [Column(TypeName = "decimal(19, 4)")]
    public decimal AmountKine { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("ForfaitPendingInvoicingItems")]
    public virtual Patient Patient { get; set; } = null!;
}
