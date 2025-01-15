using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("Reminder")]
[Index("ExternalApplicationId", Name = "IX_Reminder_ExternalApplicationId")]
public partial class Reminder
{
    [Key]
    public Guid ReminderId { get; set; }

    public DateTime ReminderDate { get; set; }

    public short? ReminderLevel { get; set; }

    public Guid? ReminderTemplateId { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? LastUpdatedBy { get; set; }

    public Guid ExternalApplicationId { get; set; }

    public int Version { get; set; }

    [ForeignKey("CreatedByUserId")]
    [InverseProperty("Reminders")]
    public virtual User? CreatedByUser { get; set; }

    [ForeignKey("ReminderTemplateId")]
    [InverseProperty("Reminders")]
    public virtual ReminderTemplate? ReminderTemplate { get; set; }

    [ForeignKey("ReminderId")]
    [InverseProperty("Reminders")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
