using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Models;

[Table("MailerQueueAttachment")]
[Index("MailItemId", Name = "IX_MailerQueueAttachment_MailItemId")]
public partial class MailerQueueAttachment
{
    [Key]
    public Guid AttachmentId { get; set; }

    public Guid MailItemId { get; set; }

    [StringLength(255)]
    public string Filename { get; set; } = null!;

    public byte[] Attachment { get; set; } = null!;

    [ForeignKey("MailItemId")]
    [InverseProperty("MailerQueueAttachments")]
    public virtual MailerQueue MailItem { get; set; } = null!;
}
