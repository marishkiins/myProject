﻿using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TaskPriority
{
    public int Id { get; set; }

    public string PriorityName { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
