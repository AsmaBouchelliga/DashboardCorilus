using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("AttestsWithPatientContributionAtTheExpenseOfPatientThatAreNotInvoiced")]
[Index("Id", Name = "AttestsWithPatientContributionAtTheExpenseOfPatientThatAreNotInvoiced_Id_uindex", IsUnique = true)]
public partial class AttestsWithPatientContributionAtTheExpenseOfPatientThatAreNotInvoiced
{
    [Key]
    public Guid Id { get; set; }
}
