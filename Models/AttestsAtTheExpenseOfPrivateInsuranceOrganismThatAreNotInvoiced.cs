using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("AttestsAtTheExpenseOfPrivateInsuranceOrganismThatAreNotInvoiced")]
[Index("Id", Name = "AttestsAtTheExpenseOfPrivateInsuranceOrganismThatAreNotInvoiced_Id_uindex", IsUnique = true)]
public partial class AttestsAtTheExpenseOfPrivateInsuranceOrganismThatAreNotInvoiced
{
    [Key]
    public Guid Id { get; set; }
}
