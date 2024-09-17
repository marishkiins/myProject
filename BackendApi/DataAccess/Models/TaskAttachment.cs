using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TaskAttachment
{
    public int AttachmentId { get; set; }

    public int? TaskId { get; set; }

    public string? FilePath { get; set; }

    public DateTime? UploadedAt { get; set; }

    public virtual Task? Task { get; set; }
}
