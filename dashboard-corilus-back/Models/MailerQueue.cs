using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("MailerQueue")]
[Index("ExternalApplicationId", Name = "IX_MailerQueue_ExternalApplicationId")]
public partial class MailerQueue
{
    [Key]
    public Guid ItemId { get; set; }

    public Guid ExternalApplicationId { get; set; }

    [StringLength(255)]
    public string From { get; set; } = null!;

    public string To { get; set; } = null!;

    public string? Cc { get; set; }

    public string? Bcc { get; set; }

    [StringLength(255)]
    public string? Subject { get; set; }

    public string Body { get; set; } = null!;

    public bool BodyIsHtml { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(50)]
    public string LastUpdatedBy { get; set; } = null!;

    public int Version { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime ModificationDate { get; set; }

    [ForeignKey("ExternalApplicationId")]
    [InverseProperty("MailerQueues")]
    public virtual ExternalApplication ExternalApplication { get; set; } = null!;

    [InverseProperty("MailItem")]
    public virtual ICollection<MailerQueueAttachment> MailerQueueAttachments { get; set; } = new List<MailerQueueAttachment>();
}
