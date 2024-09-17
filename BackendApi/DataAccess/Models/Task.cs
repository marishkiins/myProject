using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public int? UserId { get; set; }

    public int? TaskTypeId { get; set; }

    public string? Title { get; set; }

    public string? DescriptionTask { get; set; }

    public byte? PriorityTask { get; set; }

    public DateTime? Deadline { get; set; }

    public string? StatusTask { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Notification? Notification { get; set; }

    public virtual ICollection<TaskAttachment> TaskAttachments { get; set; } = new List<TaskAttachment>();

    public virtual TaskType? TaskType { get; set; }

    public virtual UsersInfo? User { get; set; }
}
