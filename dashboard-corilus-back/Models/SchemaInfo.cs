using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("SchemaInfo")]
public partial class SchemaInfo
{
    [Key]
    public long Version { get; set; }
}
