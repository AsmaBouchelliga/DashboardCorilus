using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("AttestsAtTheExpenseOfPublicInsuranceOrganismWithReimbursementNotPaidThatAreNotInvoiced")]
[Index("Id", Name = "AttestsAtTheExpenseOfPublicInsuranceOrganismWithReimbursementNotPaidThatAreNotInvoiced_Id_uindex", IsUnique = true)]
public partial class AttestsAtTheExpenseOfPublicInsuranceOrganismWithReimbursementNotPaidThatAreNotInvoiced
{
    [Key]
    public Guid Id { get; set; }
}
