using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Keyless]
public partial class VwGlobalSessionInfoForAttest
{
    public Guid AttestId { get; set; }

    public Guid? PatientCarePlanId { get; set; }

    public Guid? PrescriptionId { get; set; }

    public Guid PhysicianId { get; set; }

    [StringLength(255)]
    public string PhysicianName { get; set; } = null!;

    [StringLength(20)]
    public string CareProviderNihii { get; set; } = null!;

    public int CareProviderConventionStatus { get; set; }

    public DateTime? PrescriptionDate { get; set; }

    [StringLength(255)]
    public string? PrescriberName { get; set; }

    [StringLength(255)]
    public string? PrescriberNihii { get; set; }

    public long? RowNumber { get; set; }
}
