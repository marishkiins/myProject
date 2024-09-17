using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Notification
{
    public int TaskId { get; set; }

    public DateTime? NotificationTime { get; set; }

    public string? Status { get; set; }

    public virtual Task Task { get; set; } = null!;
}
