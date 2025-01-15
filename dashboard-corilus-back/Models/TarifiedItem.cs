using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("TarifiedItem")]
[Index("TarificationSessionId", "SequenceNr", Name = "IX_TarifiedItem_TarificationSessionId_SequenceNr")]
public partial class TarifiedItem
{
    [Key]
    public Guid TarifiedItemId { get; set; }

    public Guid TarificationSessionId { get; set; }

    public short SequenceNr { get; set; }

    public DateTime PrestationDate { get; set; }

    public int RegistrationMode { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Honorarium { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal Reimbursement { get; set; }

    public bool IsHonorariumManuallySpecified { get; set; }

    public bool CouldNotExactlyDetermineHonorarium { get; set; }

    public bool CouldNotExactlyDetermineReimbursement { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    public bool IsAdditionalRequirementsPrescriberNeeded { get; set; }

    [StringLength(255)]
    public string? PrescribingPhysician { get; set; }

    [StringLength(20)]
    public string? PrescribingPhysicianSocialSecurityNumber { get; set; }

    public DateTime? PrescriptionDate { get; set; }

    public bool IsAdditionalRequirementsLeftRightDesignationNeeded { get; set; }

    [StringLength(1)]
    public string? LeftRightDesignation { get; set; }

    public bool IsAdditionalRequirementsTravelDistanceNeeded { get; set; }

    [Column(TypeName = "decimal(19, 2)")]
    public decimal? TravelDistance { get; set; }

    public bool IsAdditionalRequirementsHospitalVisitNeeded { get; set; }

    [StringLength(16)]
    public string? HospitalNihii { get; set; }

    [StringLength(3)]
    public string? HospitalServiceCode { get; set; }

    public bool IsAdditionalRequirementsLaboratoryNeeded { get; set; }

    [StringLength(16)]
    public string? LaboratoryNihii { get; set; }

    public int? TreatmentId { get; set; }

    [ForeignKey("RegistrationMode")]
    [InverseProperty("TarifiedItems")]
    public virtual TarifiedPrestationRegistrationMode RegistrationModeNavigation { get; set; } = null!;

    [ForeignKey("TarificationSessionId")]
    [InverseProperty("TarifiedItems")]
    public virtual TarificationSession TarificationSession { get; set; } = null!;

    [InverseProperty("TarifiedPrestationGroupItemNavigation")]
    public virtual TarifiedPrestationGroupItem? TarifiedPrestationGroupItem { get; set; }

    [InverseProperty("TarifiedPrestationItemNavigation")]
    public virtual TarifiedPrestationItem? TarifiedPrestationItem { get; set; }
}
