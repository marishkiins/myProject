using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TaskType
{
    public int TaskTypeId { get; set; }

    public string? TaskTypeName { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
