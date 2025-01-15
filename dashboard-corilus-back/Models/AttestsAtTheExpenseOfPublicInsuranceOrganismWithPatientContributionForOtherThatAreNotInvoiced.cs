using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("AttestsAtTheExpenseOfPublicInsuranceOrganismWithPatientContributionForOtherThatAreNotInvoiced")]
[Index("Id", Name = "AttestsAtTheExpenseOfPublicInsuranceOrganismWithPatientContributionForOtherThatAreNotInvoiced_Id_uindex", IsUnique = true)]
public partial class AttestsAtTheExpenseOfPublicInsuranceOrganismWithPatientContributionForOtherThatAreNotInvoiced
{
    [Key]
    public Guid Id { get; set; }
}
