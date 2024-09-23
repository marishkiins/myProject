using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class NotificationStatus
{
    public int Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
