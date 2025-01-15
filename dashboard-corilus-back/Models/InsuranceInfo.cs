using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Keyless]
[Table("InsuranceInfo")]
[Index("ExternalApplicationId", Name = "IX_InsuranceInfo_ExternalApplicationId")]
public partial class InsuranceInfo
{
    public Guid? InsuranceInfoId { get; set; }

    public DateTime? InsuredFrom { get; set; }

    public DateTime? InsuredTo { get; set; }

    public Guid? PatientId { get; set; }

    public Guid? ThirdpartyId { get; set; }

    [StringLength(50)]
    public string? InscriptionNr { get; set; }

    [StringLength(5)]
    public string? Code1 { get; set; }

    [StringLength(5)]
    public string? Code2 { get; set; }

    public bool? Chronic { get; set; }

    public bool? ThirdpartyAutorized { get; set; }

    public bool? HospitalService { get; set; }

    public DateTime? HospitalAdmissionDate { get; set; }

    [StringLength(15)]
    public string? HospitalNihii { get; set; }

    [StringLength(15)]
    public string? MedicalHouseNihii { get; set; }

    public bool? MedicalHouseNurse { get; set; }

    public bool? MedicalHouseKine { get; set; }

    public bool? MedicalHouseGp { get; set; }

    public DateTime? MedicalHouseStart { get; set; }

    public DateTime? MedicalHouseEnd { get; set; }

    public bool? PaymentApproval { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public Guid? ExternalApplicationId { get; set; }

    public int? Version { get; set; }

    public bool? Archived { get; set; }

    [ForeignKey("PatientId")]
    public virtual Patient? Patient { get; set; }

    [ForeignKey("ThirdpartyId")]
    public virtual ThirdParty? Thirdparty { get; set; }
}
