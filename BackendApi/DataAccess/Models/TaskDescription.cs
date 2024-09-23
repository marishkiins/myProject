﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TaskDescription
{
    public int Id { get; set; }

    public int TaskId { get; set; }

    public string Description { get; set; } = null!;

    public virtual Task Task { get; set; } = null!;
}
