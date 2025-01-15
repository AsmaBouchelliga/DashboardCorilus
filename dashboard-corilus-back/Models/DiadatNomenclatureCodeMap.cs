using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[PrimaryKey("DiadatCode", "NomenclatureCode")]
[Table("DiadatNomenclatureCodeMap")]
public partial class DiadatNomenclatureCodeMap
{
    [Key]
    [StringLength(10)]
    public string DiadatCode { get; set; } = null!;

    [Key]
    [StringLength(10)]
    public string NomenclatureCode { get; set; } = null!;
}
