﻿using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TaskType
{
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
